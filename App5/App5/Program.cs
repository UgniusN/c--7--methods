using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5
{
    class Program
    {
        static void Main(string[] args)
        {
            uzdetiRemeli("Trying the text that should fit into the frames.");
        }

        public static void uzdetiRemeli(string a)
        {
            int lettercount = 0;
            foreach (char letter in a)
            {
                lettercount++;
            }
            for (int i = 0; i < lettercount + 4; i++)
            {
                Console.Write("♦");
            }
            Console.WriteLine();
            Console.WriteLine("♦ {0} ♦", a);
            for (int i = 0; i < lettercount + 4; i++)
            {
                Console.Write("♦");
            }
            Console.Read();
        }
    }
}
