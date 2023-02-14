using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace task2
{
    internal class Student
    {
        public Student(string fullName, string groupNo, int age)
        {
            FullName = fullName;
            GrupNo = groupNo;
            Age= age;
        }


        private string _fullname;
        private string _groupNo;
        public int Age { get; set; }
        public string FullName
        {
            get
            {
                return _fullname;
            }
            set
            {
                if (CheckFullName(value))
                    _fullname = value;
            }
        }

        public bool CheckFullName(string str)
        {
            if (str==null)
            {
                var word = str.Split(' ');

                if (word.Length == 2 && char.IsUpper(word[0][0]) && char.IsUpper(word[1][0]))
                {
                    return true;
                }
            }
            return false;
        }
        public string GrupNo
        {
            get
            {
                return _groupNo;
            }
            set
            {
                if (CheckGroupNo(value))
                    _groupNo = value;
            }
        }

        private bool CheckGroupNo(string groupno)
        {
            if (groupno==null && groupno.Length == 4 && char.IsUpper(groupno[0]))
            {
                for (int i = 1; i < groupno.Length; i++)
                {
                    if (!char.IsDigit(groupno[i]))
                        return false;
                }
                return true;
            }
            return false;
        }
        
    }
}







       
