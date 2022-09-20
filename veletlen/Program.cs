using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veletlen
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[100];

            Random vel = new Random();


            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = vel.Next(1, 11);
                if (tomb[i] % 2 !=0)
                {
                 Console.Write($"{tomb[i]}, ");
                 
                }
            }
            //foreach (int szam in tomb)
            //{
              // Console.Write($"{szam}, ");
            //}             


            Console.ReadKey();
        }
    }
}
