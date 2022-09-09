using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace StudentProject
{
    internal class Read
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("StudentDemo.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            Console.WriteLine(sr.ReadToEnd());
        }
    }
}
