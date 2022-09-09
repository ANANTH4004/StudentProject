using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentProject
{
    internal class Searching
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a student name: ");
            string name = Console.ReadLine();
            var Details = File.ReadLines("StudentDemo.txt").OrderBy((line => (line.Split(',')[1])))
                 .ToList();
            bool found = false;
            foreach (var item in Details)
            {
                //Console.WriteLine("searching in the list of student.......... :");
                if (item.Contains(name))
                {
                    Console.WriteLine($"Name: {item.Split(',')[0]} \nClass Room Number : {item.Split(',')[1]} ");
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Student Not found or student not in the list please enter a valid Student Name");
            }
        }
        
}
}
