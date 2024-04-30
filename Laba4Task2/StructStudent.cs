using System;
using System.Text;
using System.Linq;

namespace struct_lab_student
{
    public struct Student
    {
        public string surName;
        public string firstName;
        public string patronymic;
        public string sex;
        public DateTime dateOfBirth;
        public char mathematicsMark;
        public char physicsMark;
        public char informaticsMark;
        public int scholarship;

        public Student(string lineWithAllData)
        {
            string[] dataSplit= lineWithAllData.Split(new char[] { ' ', '\t' },StringSplitOptions.RemoveEmptyEntries);
            surName= dataSplit[0];
            firstName= dataSplit[1];
            patronymic= dataSplit[2];
            sex = dataSplit[3];

            dateOfBirth = DateTime.Parse(dataSplit[4]);
            mathematicsMark = Convert.ToChar(dataSplit[5]);
            physicsMark = Convert.ToChar(dataSplit[6]);
            informaticsMark = Convert.ToChar(dataSplit[7]);
            scholarship = Convert.ToInt32(dataSplit[8]);
        }
    }
}