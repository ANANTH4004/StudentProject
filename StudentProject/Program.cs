using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;

namespace StudentProject
{
   public class Student
    {
        public string name;
        public int classRoom;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Write 2.Read 3.Sort 4.Searching");
            int choice = Convert.ToInt32(Console.ReadLine());
            var Details = File.ReadLines("StudentDemo.txt").OrderBy((line => (line.Split(',')[1])))
                .ToList();
            switch (choice)
            {
                case 1:
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
                    break;
                case 2:
                    FileStream f = new FileStream("StudentDemo.txt", FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(f);
                    Console.WriteLine(sr.ReadToEnd());
                    break;
                case 3:
                   
                    foreach (var item in Details)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                case 4:
                    bool found = false;
                    Console.WriteLine("Enter a Name of the student you want to search :");
                    string Sname = Console.ReadLine();
                    foreach (var item in Details)
                    {
                        if (item.Split(',')[0].Equals(Sname))
                        {
                            Console.WriteLine($"Student Name : {item.Split(',')[0]}\nClass Room : {item.Split(',')[1]}");
                            found = true;
                            break;
                        }
                        
                    }
                    if (!found)
                    {
                        Console.WriteLine("Student not found in the list..........");
                    }
                    break;

                default:
                    break;
            }
        }
        
    }
}
