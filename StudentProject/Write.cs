using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace StudentProject
{
    internal class Write
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("StudentDemo.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            try
            {
                string name, classRoom, temp;
                bool status;
                do
                {
                    status = false;
                    Console.WriteLine("Enter Student Name:");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter Class Room Number:");
                    classRoom = Console.ReadLine();
                    sw.WriteLine(name + "," + classRoom);
                    Console.WriteLine("do you want to continue (y/n)");
                    temp = Console.ReadLine();
                    if (temp == "y" || temp == "Y")
                    {
                        status = true;
                    }
                } while (status);
            }
            finally
            {
                sw.Flush();
                sw.Close();
                fs.Close();
            }
        }
    }
}
