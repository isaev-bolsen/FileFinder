using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARMO
    {
    public partial class Form1 : Form
        {
        private System.IO.DirectoryInfo StartDirectory;
        private System.Threading.Thread SearchThread;
        private bool isSearchInProgress;

        private delegate void ProcessFileDelegate(System.IO.FileInfo file);
        private Timer timer = new Timer();
        private DateTime SearchStartTime;
        private int FilesProcessed;
        Saver saver = new Saver();

        public Form1()
            {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick +=timer_Tick;
            //Извлечение сохраненных данных
            this.StartDirectoryTB.Text = saver.dir;
            this.FileNameTB.Text = saver.fileName;
            this.TextInFileTB.Text = saver.text.Trim();
            }

        private void timer_Tick(object sender, EventArgs e)
            {
            TimeSpan timeSpan = DateTime.Now-SearchStartTime;
            this.TimeElapsed.Text = timeSpan.ToString();
            this.FilesCounter.Text = FilesProcessed.ToString();
            }

        //Добавить поддерево узлов для файла
        private void AddNode(System.IO.FileInfo file)
            {
            //CurrentProcessingFile.Text = file.FullName;
            string[] path = file.FullName.Split(System.IO.Path.DirectorySeparatorChar);
            //lock (treeView1.Nodes)
            //    {
            // Для каждой части имени проверить существование соответствующего узла.
            // Создать, если не существует
            // Для следующей части имени повторить среди дочерних узлов найденного или созданного.
            var currentNodeCollection = treeView1.Nodes;

                for (int i = 0; i < path.Length; ++i)
                    {
                    var Existed = currentNodeCollection.Find(path[i], false);
                    
                    if (Existed.Length == 0)
                        {
                        var newNode = new TreeNode(path[i]);
                        newNode.Name = path[i];
                        currentNodeCollection.Add(newNode);
                        currentNodeCollection = newNode.Nodes;
                        }
                    else
                        {
                        currentNodeCollection = Existed[0].Nodes;
                        }
                    }
                //}
            CurrentProcessingFile.Text = file.DirectoryName;
            }

        private void BrowseStartDirectoryButton_Click(object sender, EventArgs e)
            {// Открыть стартовое ДО выбора папки
            this.StatrtDirectoryPicker.ShowDialog(this);
            StartDirectoryTB.Text = this.StatrtDirectoryPicker.SelectedPath;
            }

        private void StartDirectoryTB_TextChanged(object sender, EventArgs e)
            {//Создать объект, представляющий начальный каталог
            try
                {
                this.StartDirectory = new System.IO.DirectoryInfo(StartDirectoryTB.Text);
                if (this.StartDirectory.Exists)
                    {
                    this.StartDirectoryExistLabel.Text = "Exists";
                    saver.dir = StartDirectoryTB.Text;
                    saver.Save();
                    }
                else
                    this.StartDirectoryExistLabel.Text = "Not Exists";
                }
            catch (Exception exc)
                {
                this.StartDirectoryExistLabel.Text = "Not Exists";
                }
             }

        private static void BeginSearch(System.IO.DirectoryInfo Directory, string fileName, string TextInFile, Form1 form)
            {//Запуск поиска
            Search(Directory, fileName, TextInFile, form);
            //Оповещение о завершении
            Action setStatusDone = () => form.CurrentProcessingFile.Text = "Stoped";
            form.BeginInvoke(setStatusDone);
            form.timer.Stop();
            Action updateStatus=()=>form.timer_Tick(form.timer,new EventArgs());
            form.BeginInvoke(updateStatus);
            }

        private static void Search(System.IO.DirectoryInfo Directory, string fileName, string TextInFile, Form1 form)
            {//Поиск подходящих файлов в каталоге. Затем рекурсивная обработка в подкаталогах.
            try
                {
                System.IO.FileInfo[] Files = Directory.GetFiles(fileName);
                foreach (System.IO.FileInfo file in Files)
                    {
                    Action setStatus = () => form.CurrentProcessingFile.Text = file.FullName;
                    form.BeginInvoke(setStatus);
                    if (TextInFile.Length > 0)//Для случая, когда нужно искать по файлу
                        {
                        var reader = file.OpenText();
                        try
                            {
                            string content = reader.ReadToEnd();
                            if (content.Contains(TextInFile)) form.BeginInvoke(new ProcessFileDelegate(form.AddNode), new object[] { file });
                            }
                        catch (Exception e)
                            {
                            setStatus = () => form.CurrentProcessingFile.Text += " - не удалось произвести поиск по файлу";
                            form.BeginInvoke(setStatus);
                            }
                        finally
                            { 
                            reader.Close(); 
                            }
                       }
                    else
                        {
                        form.BeginInvoke(new ProcessFileDelegate(form.AddNode), new object[] { file });
                        }
                    ++form.FilesProcessed;
                  }
            System.IO.DirectoryInfo[] Directories = Directory.GetDirectories();
            foreach (System.IO.DirectoryInfo directory in Directories)
                {
                Search(directory, fileName, TextInFile, form);
                }
                
                }
            catch (UnauthorizedAccessException exc)
                {
                //Доступа нет к чужим и некоторым системным папкам
                }
            }


        private void StartStopButton_Click(object sender, EventArgs e)
            {// Запуск/остановка поиска
            if (this.isSearchInProgress)
                {
                SearchThread.Abort();
                timer.Stop();
                isSearchInProgress = false;
                this.StartDirectoryTB.Enabled = true;
                this.BrowseStartDirectoryButton.Enabled = true;
                this.FileNameTB.Enabled = true;
                this.TextInFileTB.Enabled = true;
                this.CurrentProcessingFile.Text = "Stoped";
                this.StartStopButton.Text = "START";
                }
            else 
                {
                if (StartDirectory == null) return;
                this.StartDirectoryTB.Enabled = false;
                this.BrowseStartDirectoryButton.Enabled = false;
                this.FileNameTB.Enabled = false;
                this.TextInFileTB.Enabled = false;

                TimeElapsed.Text = TimeSpan.Zero.ToString();
                SearchStartTime = DateTime.Now;
                FilesProcessed = 0;
                timer.Start();
                SearchThread = new System.Threading.Thread(()=>BeginSearch(this.StartDirectory, this.FileNameTB.Text, this.TextInFileTB.Text, this));
                SearchThread.IsBackground = true;
                SearchThread.Start();
                this.isSearchInProgress = true;
                this.StartStopButton.Text = "STOP";
                }
            }

        private void ClearButton_Click(object sender, EventArgs e)
            {//Очистка дерева
            treeView1.Nodes.Clear();
            }

        private void FileNameTB_TextChanged(object sender, EventArgs e)
            {
            saver.fileName = FileNameTB.Text;
            saver.Save();
            }

        private void TextInFileTB_TextChanged(object sender, EventArgs e)
            {
            saver.text = TextInFileTB.Text;
            saver.Save();
            }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
            {//открытие требуемого файла
            System.IO.FileInfo file = new System.IO.FileInfo(e.Node.FullPath);
            System.Diagnostics.Process.Start(file.FullName);
            }
        }
    }
