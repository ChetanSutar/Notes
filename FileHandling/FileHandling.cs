using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class FileHandling
    {
        public static void Main (string[] args)
        {
            FileInfo f = new FileInfo("C:\\Study Material\\Youtube\\Oops Shiva Gautam\\Test.Text");

            //===  Create and write===
            //FileStream fs = f.Open(FileMode.OpenOrCreate, FileAccess.Write);
            //StreamWriter streamWriter = new StreamWriter(fs);
            //streamWriter.WriteLine("Chetan Sutar");
            //streamWriter.Close();

            //===== Read ====
            // FileStream fs = f.Open(FileMode.OpenOrCreate, FileAccess.Read);
            // StreamReader sr = new StreamReader(fs);
            //string data =sr.ReadToEnd();
            // Console.WriteLine(data);
            // Console.WriteLine("File Created Succssfully");


            //====  Append  ======
            FileStream fs = f.Open(FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter streamWriter = File.AppendText("C:\\Study Material\\Youtube\\Oops Shiva Gautam\\Test.Text");
            streamWriter.WriteLine("Chetan Sutar");
            streamWriter.Close();
        }
    }
}
