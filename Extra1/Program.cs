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
            List<(Student,int)> women=new List<(Student,int)>();
            char[] menChars = new char[3] { 'M', 'Ч', 'М' };
            char[] womenChars = new char[2] { 'F', 'Ж'};

            int averageMen = 0;
            int averageManCount = 0;

            foreach (Student student in studs)
            {
                char propysk = '2';
                foreach(var field in new[] { "informaticsMark", "physicsMark", "mathematicsMark" })
                {
                    if ((char)typeof(Student).GetField(field).GetValue(student) == '-')
                    {
                        typeof(Student).GetField(field).SetValue(student, propysk);
                    }
                }
                if (menChars.Contains(student.sex))
                {
                    
                    averageMen +=(int)student.informaticsMark + (int)student.physicsMark + (int)student.mathematicsMark;
                    averageManCount++;
                    continue;
                }
                if (womenChars.Contains(student.sex))
                {
                    int averageWoman = (int)student.informaticsMark + (int)student.physicsMark + (int)student.mathematicsMark;
                    women.Add((student,averageWoman));
                }
            }
            double averageMenResult = averageMen / (double)averageManCount;
            foreach(var woman in women)
            {
                if ((double)woman.Item2 > averageMenResult)
                {
                    Console.WriteLine(woman.Item1.surName + " " + woman.Item1.firstName + " " + woman.Item1.patronymic);
                }
            }
        }

        static void Main(string[] args)
        {
            List<Student> studs = ReadData(@"C:\\Users\\Filip\\OneDrive\\Робочий стіл\\ЧНУ\\ПАЛМ\\Laba4\\input.txt");
            RunMenu(studs);
        }
    }
}
