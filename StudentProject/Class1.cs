using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StudentProject
{
    internal class Class1
    {

        static void Main(string[] args)
        {
            // File.Create("Student.txt");
            Console.WriteLine("Enter Details:");
            string s = Console.ReadLine();
            File.AppendAllText("Student.txt","\n"+s);
            List<Student> list = new List<Student>();
            list = ReadFile();
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item.name);
            //}
            var Details = File.ReadLines("Student.txt").OrderBy((line => (line.Split(',')[0])))
                  .ToList();
            foreach (var item in Details)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=======================================================");
            list.Sort((a, b) => a.name[1].CompareTo(b.name[1]));
            foreach (var item in list)
            {
                Console.WriteLine(item.name + " " + item.classRoom);
            }

        }
        public static List<Student> ReadFile()
        {
            List<Student> details;
            string[] data = File.ReadAllLines("Student.txt");
            if (data != null)
            {
                Student s;
                string[] temp;
                details = new List<Student>();
                for (int i = 0; i < data.GetLength(0); i++)
                {
                    temp = Regex.Split(data[i], ",");
                    if (temp != null && temp.GetLength(0) > 1)
                    {
                        s = new Student();
                        s.name = temp[0];
                        int.TryParse(temp[1], out s.classRoom);
                        details.Add(s);
                    }
                }
                return details.ToList();
            }
            return null;
        }
    }
}
