using System;
using System.Text.RegularExpressions;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tek eded daxil et:");
            string numOdd=Console.ReadLine();
            int numodd=Convert.ToInt32(numOdd);

            Console.WriteLine(numodd.IsOdd());

            Console.Write("Cut eded daxil et:");
            string numEven = Console.ReadLine();
            int numeven = Convert.ToInt32(numEven);

            Console.WriteLine(numeven.IsEven());

            Console.Write("Yazi daxil et:");
            string name = Console.ReadLine();

            Console.WriteLine(name.IsContainsDigit());

            Console.Write("Kicik herifle baslayan birsey daxil et:");
            string str = Console.ReadLine();

            Console.WriteLine(str.ToCapitalize());


        }
    }
}
