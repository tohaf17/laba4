using System;
using System.Collections.Generic;
using System.IO;
using Extra1;

namespace Extra4
{
    internal class SortStudentMarks
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

        public static void ListOfMarks(List<Student> students)
        {
            int propysk = 2;
            foreach (Student student in students)
            {
                foreach (var field in new[] { "informaticsMark", "physicsMark", "mathematicsMark" })
                {
                    if ((char)typeof(Student).GetField(field).GetValue(student) == '-')
                    {
                        typeof(Student).GetField(field).SetValue(student, propysk);
                    }
                }
            }
        }

        public static void Sort(List<Student> list)
        {
            list.Sort((x, y) =>
            {
                if (x.mathematicsMark != y.mathematicsMark)
                {
                    return y.mathematicsMark.CompareTo(x.mathematicsMark);
                }
                if (x.physicsMark != y.physicsMark)
                {
                    return y.physicsMark.CompareTo(x.physicsMark);
                }
                if (x.informaticsMark != y.informaticsMark)
                {
                    return y.informaticsMark.CompareTo(x.informaticsMark);
                }
                return y.surName.CompareTo(x.surName);
            });
        }

        public List<Student> Main()
        {
            var list = ReadData("C:\\Users\\Filip\\OneDrive\\Робочий стіл\\ЧНУ\\ПАЛМ\\Laba4\\input.txt");
            ListOfMarks(list);
            Sort(list);
            return list;
        }
    }
}
