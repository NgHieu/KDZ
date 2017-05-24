using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace KDZ
{
    // Class to create and read seats for each match
    class FileText
    {
        private String filename;
        public String Filename
        {
            set
            {
                filename = value;
            }
            get
            {
                return filename;
            }
        }
        private System.IO.FileStream fs;

        public void WriteData(int n, int [][]A)
        {
            fs = new System.IO.FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None);
            StreamWriter sw = new StreamWriter(fs);
            for (int i =0; i<n;i++)
            {
                string st="";
                for (int j=0;j<3840; j++)
                {
                    st = st + Convert.ToString(A[i][j]);
                }
                sw.WriteLine(st);
            }

            sw.Flush();
            sw.Close();
            fs.Close();

        }
        public void ReadData()
        {
            fs = new System.IO.FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.None);
            StreamReader sr = new StreamReader(fs);
            String str = sr.ReadLine();
            int i = 0;
            while (str != null)
            {

                i = i + 1;
                Global.B[i] = str;
                str = sr.ReadLine();
            }

            sr.Close();
            fs.Close();

        }

        
    }
}