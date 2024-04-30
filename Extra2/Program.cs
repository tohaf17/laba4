using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra1
{
    public class Extra1
    {
        static List<Student> ReadData(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            List<Student> list = new List<Student>();

            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Student student = new Student(line);
                list.Add(student);
            }
            return list;
        }

        static void RunMenu(List<Student> studs)
        {
            Console.WriteLine("First Part");
            var first = studs.GroupBy(student => new{ Day=student.dateOfBirth.Day,Year=student.dateOfBirth.Year});

            foreach (var group in first)
            {
                if (group.Count() > 1)
                {
                    foreach(var student in group)
                    {
                        Console.WriteLine(student.surName + " " + student.firstName + " " + student.dateOfBirth.ToShortDateString());
                    }
                }
            }
            Console.WriteLine("\nSecond Part");
            var second = studs.GroupBy(student => new { Day = student.dateOfBirth.Day });
            foreach (var group in second)
            {
                if (group.Count() > 1)
                {
                    foreach(var student in group)
                    {
                        Console.WriteLine(student.surName + " " + student.firstName + " " + student.dateOfBirth.ToShortDateString());
                    }
                    Console.WriteLine();
                }
                
            }
           
        }

        static void Main(string[] args)
        {
            Console.WriteLine("dvs");
            List<Student> studs = ReadData(@"C:\\Users\\Filip\\OneDrive\\Робочий стіл\\ЧНУ\\ПАЛМ\\Laba4\\input.txt");
            RunMenu(studs);
        }
    }
}
