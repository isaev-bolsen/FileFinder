using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMO
    {
    class Saver
        {
        private System.IO.FileInfo file;

        public string dir="";
        public string fileName="";
        public string text="";

        public Saver()
            {
            file = new System.IO.FileInfo("settings");
            if (file.Exists)
                {
                var reader = file.OpenText();
                dir = reader.ReadLine();
                fileName = reader.ReadLine();
                text = reader.ReadToEnd();
                reader.Close();
                }
            }
         public void Save()
             {
             //file.Delete();
             var writer = file.CreateText();
             writer.WriteLine(dir);
             writer.WriteLine(fileName);
             writer.WriteLine(text);
             writer.Close();
             }
            }
        }
   
