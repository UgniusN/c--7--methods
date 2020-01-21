using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App10
{
    class Program
    {
        static void Main(string[] args)
        {
            string zodis = "Grazus vakaras";
            string result = "";
            string result2 = "";
            for (int i = 0; i < zodis.Length - 1; i++)
            {
                int simbolis = (int)zodis[i];
                simbolis += 2;
                result = result + (char)simbolis;
            }

            for (int i = 0; i < result.Length - 1; i++)
            {
                int simbolis = (int)result[i];
                simbolis -= 2;
                result2 = result2 + (char)simbolis;
            }

            Console.WriteLine("Pradine fraze: {0}, sifruota fraze: {1}, po dekodavimo: {2}", zodis, result, result2);

            //char c = 'a';
            //int i = (int)c;
            //Console.WriteLine("c: {0}, (int)c:{1}", c, i);
            //i++;
            //c = (char)i;
            //Console.WriteLine("c: {0}, (int)c:{1}", c, i);
            Console.ReadLine();
        }
    }
}
