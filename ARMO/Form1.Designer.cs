namespace ARMO
    {
    partial class Form1
        {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
            {
            if (disposing && (components != null))
                {
                components.Dispose();
                }
            base.Dispose(disposing);
            }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
            {
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.StatrtDirectoryPicker = new System.Windows.Forms.FolderBrowserDialog();
            this.StartDirectoryTB = new System.Windows.Forms.TextBox();
            this.StartDirectoryL = new System.Windows.Forms.Label();
            this.BrowseStartDirectoryButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.StartStopButton = new System.Windows.Forms.Button();
            this.TextInFileTB = new System.Windows.Forms.TextBox();
            this.TextInFileL = new System.Windows.Forms.Label();
            this.FileNameTB = new System.Windows.Forms.TextBox();
            this.FileNmeLabel = new System.Windows.Forms.Label();
            this.StartDirectoryExistLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.CurrentProcessingFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.TimeElapsed = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.FilesCounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(888, 407);
            this.treeView1.TabIndex = 0;
            // 
            // StartDirectoryTB
            // 
            this.StartDirectoryTB.Location = new System.Drawing.Point(100, 13);
            this.StartDirectoryTB.Name = "StartDirectoryTB";
            this.StartDirectoryTB.Size = new System.Drawing.Size(264, 20);
            this.StartDirectoryTB.TabIndex = 1;
            this.StartDirectoryTB.TextChanged += new System.EventHandler(this.StartDirectoryTB_TextChanged);
            // 
            // StartDirectoryL
            // 
            this.StartDirectoryL.AutoSize = true;
            this.StartDirectoryL.Location = new System.Drawing.Point(6, 16);
            this.StartDirectoryL.Name = "StartDirectoryL";
            this.StartDirectoryL.Size = new System.Drawing.Size(88, 13);
            this.StartDirectoryL.TabIndex = 2;
            this.StartDirectoryL.Text = "Starting Directory";
            // 
            // BrowseStartDirectoryButton
            // 
            this.BrowseStartDirectoryButton.Location = new System.Drawing.Point(370, 11);
            this.BrowseStartDirectoryButton.Name = "BrowseStartDirectoryButton";
            this.BrowseStartDirectoryButton.Size = new System.Drawing.Size(130, 23);
            this.BrowseStartDirectoryButton.TabIndex = 3;
            this.BrowseStartDirectoryButton.Text = "Browse";
            this.BrowseStartDirectoryButton.UseVisualStyleBackColor = true;
            this.BrowseStartDirectoryButton.Click += new System.EventHandler(this.BrowseStartDirectoryButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClearButton);
            this.groupBox1.Controls.Add(this.StartStopButton);
            this.groupBox1.Controls.Add(this.TextInFileTB);
            this.groupBox1.Controls.Add(this.TextInFileL);
            this.groupBox1.Controls.Add(this.FileNameTB);
            this.groupBox1.Controls.Add(this.FileNmeLabel);
            this.groupBox1.Controls.Add(this.StartDirectoryExistLabel);
            this.groupBox1.Controls.Add(this.BrowseStartDirectoryButton);
            this.groupBox1.Controls.Add(this.StartDirectoryTB);
            this.groupBox1.Controls.Add(this.StartDirectoryL);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(382, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 407);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(9, 194);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(485, 23);
            this.ClearButton.TabIndex = 10;
            this.ClearButton.Text = "CLEAR";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // StartStopButton
            // 
            this.StartStopButton.Location = new System.Drawing.Point(7, 164);
            this.StartStopButton.Name = "StartStopButton";
            this.StartStopButton.Size = new System.Drawing.Size(487, 23);
            this.StartStopButton.TabIndex = 9;
            this.StartStopButton.Text = "START";
            this.StartStopButton.UseVisualStyleBackColor = true;
            this.StartStopButton.Click += new System.EventHandler(this.StartStopButton_Click);
            // 
            // TextInFileTB
            // 
            this.TextInFileTB.Location = new System.Drawing.Point(100, 78);
            this.TextInFileTB.Multiline = true;
            this.TextInFileTB.Name = "TextInFileTB";
            this.TextInFileTB.Size = new System.Drawing.Size(400, 69);
            this.TextInFileTB.TabIndex = 7;
            this.TextInFileTB.TextChanged += new System.EventHandler(this.TextInFileTB_TextChanged);
            // 
            // TextInFileL
            // 
            this.TextInFileL.AutoSize = true;
            this.TextInFileL.Location = new System.Drawing.Point(6, 81);
            this.TextInFileL.Name = "TextInFileL";
            this.TextInFileL.Size = new System.Drawing.Size(59, 13);
            this.TextInFileL.TabIndex = 8;
            this.TextInFileL.Text = "Text In File";
            // 
            // FileNameTB
            // 
            this.FileNameTB.Location = new System.Drawing.Point(100, 52);
            this.FileNameTB.Name = "FileNameTB";
            this.FileNameTB.Size = new System.Drawing.Size(400, 20);
            this.FileNameTB.TabIndex = 5;
            this.FileNameTB.TextChanged += new System.EventHandler(this.FileNameTB_TextChanged);
            // 
            // FileNmeLabel
            // 
            this.FileNmeLabel.AutoSize = true;
            this.FileNmeLabel.Location = new System.Drawing.Point(6, 55);
            this.FileNmeLabel.Name = "FileNmeLabel";
            this.FileNmeLabel.Size = new System.Drawing.Size(54, 13);
            this.FileNmeLabel.TabIndex = 6;
            this.FileNmeLabel.Text = "File Name";
            // 
            // StartDirectoryExistLabel
            // 
            this.StartDirectoryExistLabel.AutoSize = true;
            this.StartDirectoryExistLabel.Location = new System.Drawing.Point(205, 36);
            this.StartDirectoryExistLabel.Name = "StartDirectoryExistLabel";
            this.StartDirectoryExistLabel.Size = new System.Drawing.Size(54, 13);
            this.StartDirectoryExistLabel.TabIndex = 4;
            this.StartDirectoryExistLabel.Text = "Not Exists";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CurrentProcessingFile});
            this.statusStrip1.Location = new System.Drawing.Point(0, 385);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(382, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // CurrentProcessingFile
            // 
            this.CurrentProcessingFile.Name = "CurrentProcessingFile";
            this.CurrentProcessingFile.Size = new System.Drawing.Size(41, 17);
            this.CurrentProcessingFile.Text = "Stoped";
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TimeElapsed,
            this.toolStripStatusLabel1,
            this.FilesCounter});
            this.statusStrip2.Location = new System.Drawing.Point(0, 363);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(382, 22);
            this.statusStrip2.TabIndex = 6;
            this.statusStrip2.Text = "0";
            // 
            // TimeElapsed
            // 
            this.TimeElapsed.Name = "TimeElapsed";
            this.TimeElapsed.Size = new System.Drawing.Size(13, 17);
            this.TimeElapsed.Text = "0";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(112, 17);
            this.toolStripStatusLabel1.Text = "Файлов обработано:";
            // 
            // FilesCounter
            // 
            this.FilesCounter.Name = "FilesCounter";
            this.FilesCounter.Size = new System.Drawing.Size(13, 17);
            this.FilesCounter.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 407);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "FileSearcher";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.FolderBrowserDialog StatrtDirectoryPicker;
        private System.Windows.Forms.TextBox StartDirectoryTB;
        private System.Windows.Forms.Label StartDirectoryL;
        private System.Windows.Forms.Button BrowseStartDirectoryButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label StartDirectoryExistLabel;
        private System.Windows.Forms.TextBox FileNameTB;
        private System.Windows.Forms.Label FileNmeLabel;
        private System.Windows.Forms.TextBox TextInFileTB;
        private System.Windows.Forms.Label TextInFileL;
        private System.Windows.Forms.Button StartStopButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel CurrentProcessingFile;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel TimeElapsed;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel FilesCounter;
        }
    }

