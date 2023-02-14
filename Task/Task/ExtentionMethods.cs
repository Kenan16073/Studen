using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    internal static class ExtentionMethods
    {
        

        public static bool IsOdd(this int numodd)
        {
            if (numodd % 2 != 0)
            {
                return true;
             }
            else return false;
        }
        public static bool IsEven(this int numeven)
        {
            if (numeven % 2 == 0) return true;

            else return false;
        }
        public static bool IsContainsDigit(this string str)
        {
            foreach (var n in str)
            {
                if(char.IsDigit(n)) 
                    return true;
            }
            return false;
        }
        public static string ToCapitalize(this string str)
        {
            string newStr = Char.ToUpper(str[0]) + str.Substring(1).ToLower();
            return newStr;
        }
        public static int[] GetValueIndexes(this string str2, char cr)
        {
            int[] index = new int[0];

            for (int i = 0; i < str2.Length; i++)
            {
                if (str2[i] == cr)
                {
                    Array.Resize(ref index, index.Length + 1);
                    index[index.Length - 1] = i;
                }

            }
            return index;

        }

    }
}
