using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App7
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] skaiciai = { 3.5575474m,3.5432537m,5.4325322m,4.677432m};
            Console.WriteLine(apvalinimasIrSumavimas(skaiciai));
            Console.Read();
        }


        public static decimal apvalinimasIrSumavimas(decimal [] a)
        {
            decimal suma = 0 ;
            foreach(decimal skaicius in a)
            {
                suma += skaicius;
            }
            return Math.Round(suma, 2);
        }
    }
}
