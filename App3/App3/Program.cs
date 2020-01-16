using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(arLyginis(6));
            Console.Read();
        }


        public static Boolean arLyginis(int a)
        {
            if (a % 2 == 0)
                return true;
            else
                return false;
        }
    }
}
