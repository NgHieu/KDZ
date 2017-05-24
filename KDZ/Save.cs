using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KDZ
{
    //Class to save user's input
    class Save
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

        public void WriteData(int i,int _seat,string FullName, string PhoneNumber,string Email,string CCNumber,string Expire,string CVV)
        {
            if (Global.Check == 0)
            {
                fs = new System.IO.FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None);
            }
            else
            {
                fs = new System.IO.FileStream(filename, FileMode.Append, FileAccess.Write, FileShare.None);
            }

            StreamWriter sw = new StreamWriter(fs);
            string st;
            st = Convert.ToString(i)+"_"+Convert.ToString(_seat)+ "_"+FullName+ "_"+PhoneNumber+ "_"+Email+ "_"+CCNumber+ "_"+Expire+"_"+CVV;
                sw.WriteLine(st);
            
            sw.Flush();
            sw.Close();
            fs.Close();
        }
    }
}
