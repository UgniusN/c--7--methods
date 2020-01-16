using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masyvas = { 1, 5, 4, 5, 6, 7, 8 };
            masyvoIsvedimas(masyvas);

        }


        public static void masyvoIsvedimas(int [] arr)
        {
            for(int i=0; i<arr.Length; i++)
            {
                if(i == arr.Length-1)
                {
                    Console.Write(arr[i]);
                }
                else
                Console.Write("{0},", arr[i]);
            }
            Console.Read();
        }
    }
}
