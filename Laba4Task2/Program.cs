using static System.Console;
﻿using System;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace struct_lab_student
{
    partial class Program
    {
        static List<Student> ReadData(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            List<Student> list= new List<Student>();

            string line;
            while((line = sr.ReadLine()) != null)
            {
                Student student = new Student(line);
                list.Add(student);
            }
            return list;
        }

        static List<Student> RunMenu(List<Student> studs)
        {
            List<Student> resultStudents=new List<Student>();

            DateTime currentDay = DateTime.Today;
            DateTime timeTwoWeeksAgo = currentDay.AddDays(-14);
            DateTime timeOneWeekNext = currentDay.AddDays(7);

            foreach(Student  currentStudent in studs)
            {
                if (
                    (currentStudent.dateOfBirth.Month == timeTwoWeeksAgo.Month && currentStudent.dateOfBirth.Day >= timeTwoWeeksAgo.Day) 
                    ||
                    (currentStudent.dateOfBirth.Month == timeOneWeekNext.Month && currentStudent.dateOfBirth.Day <= timeOneWeekNext.Day)
                   )
                {
                    resultStudents.Add(currentStudent);
                }
            }
            return resultStudents;
        }

        static void Main(string[] args)
        {
            List<Student> studs = ReadData(@"C:\\Users\\Filip\\OneDrive\\Робочий стіл\\ЧНУ\\ПАЛМ\\Laba4\\input.txt");
            List<Student> result = RunMenu(studs);
            foreach(Student student in result)
            {
                Console.WriteLine(student.surName+" "+student.firstName+" оцінки: "+student.mathematicsMark+" "+student.physicsMark+" "+student.informaticsMark);
            }
        }
    }
}