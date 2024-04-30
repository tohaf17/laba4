
using System;
using Extra1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Extra3;

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
            sr.Close();
            return list;
        }
        static void RunMenu(List<Student> studs)
        {
            Zodiak zod = new Zodiak();
            var list = zod.Main();
            var directory = "C:\\Users\\Filip\\OneDrive\\Робочий стіл\\ЧНУ\\ПАЛМ\\Laba4\\Extra3\\Zodiak";
            DirectoryInfo directoryInfo = new DirectoryInfo(directory);
            if (directoryInfo.Exists)
            {
                foreach(FileInfo file in directoryInfo.GetFiles())
                {
                    file.Delete();
                }
            }
            else
            {
                directoryInfo.Create();
            }
            foreach (Student student in studs)
            {
                foreach (var zodiak in list)
                {
                    if (
                        (student.dateOfBirth.Month == zodiak.Item2[0].Month && student.dateOfBirth.Day >= zodiak.Item2[0].Day)
                        ||
                        (student.dateOfBirth.Month == zodiak.Item2[1].Month && student.dateOfBirth.Day <= zodiak.Item2[1].Day)
                       )
                    {

                        var fileName = $"{zodiak.Item1}.txt";
                        var filePath = Path.Combine(directory, fileName);
                        using (var file = new FileStream(filePath, FileMode.Append))
                        {
                            using (StreamWriter text = new StreamWriter(file))
                            {
                                text.WriteLine($"{student.surName}, {student.firstName}, {student.patronymic}, {student.dateOfBirth.ToShortDateString()}");
                            }
                        }


                    }
                }
            }

            
        }
        static void Main(string[] args)
        { 
                Console.WriteLine("dvsqwdqwqdq");
                List<Student> studs = ReadData(@"C:\\Users\\Filip\\OneDrive\\Робочий стіл\\ЧНУ\\ПАЛМ\\Laba4\\input.txt");
                RunMenu(studs);
        }
    }
}
