﻿using System;
using System.Text;
using System.Linq;

namespace Extra1
{
    internal struct Student
    {
        public string surName;
        public string firstName;
        public string patronymic;
        public char sex;
        public DateTime dateOfBirth;
        public char mathematicsMark;
        public char physicsMark;
        public char informaticsMark;
        public int scholarship;

        public Student(string lineWithAllData)
        {
            string[] dataSplit = lineWithAllData.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            surName = dataSplit[0];
            firstName = dataSplit[1];
            patronymic = dataSplit[2];
            sex = Convert.ToChar(dataSplit[3]);

            dateOfBirth = DateTime.ParseExact(dataSplit[4], "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            mathematicsMark = Convert.ToChar(dataSplit[5]);
            physicsMark = Convert.ToChar(dataSplit[6]);
            informaticsMark = Convert.ToChar(dataSplit[7]);
            scholarship = Convert.ToInt32(dataSplit[8]);
        }
    }
}
