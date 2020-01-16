using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(apverstiSkaiciu(543));
            Console.Read();
        }


        public static int apverstiSkaiciu(int a)
        {
            String skaiciusString = a.ToString();
            char[] charArray = skaiciusString.ToCharArray();
            Array.Reverse(charArray);
            String skaicius = new string(charArray);
            return Convert.ToInt32(skaicius);
        }
    }
}
