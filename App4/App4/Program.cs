using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(stringCount("Labas as esu ugnius"));
            Console.Read();
        }

        public static String stringCount(String a)
        {
            int count = 0;
            foreach(char letter in a)
            {
                count++;
            }
            String countString = count.ToString();
            return countString;
        }
    }
}
