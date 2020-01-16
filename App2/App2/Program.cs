using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Suma(9, 5));
            Console.Read();
        }


        public static int Suma(int a, int b)
        {
            return a + b;
        }
    }
}
