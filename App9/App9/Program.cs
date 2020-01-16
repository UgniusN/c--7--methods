using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App9
{
    class Program
    {
        static void Main(string[] args)
        {
            printLine(20);
        }


        public static void printLine(int a)
        {
            char[] raides = new char[a];
            int max;
            String text;
            string simboliai = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            max = simboliai.Length;
            Random rnd = new Random();
            for (int i=0; i<a; i++)
            {
                raides[i] = simboliai[rnd.Next(0, max)];
            }
            text = new string(raides);
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
