using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp49
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int minNumber = 1;
            int maxNumber = 27;
            int maxRange = 999;
            int minRange = 100;
            int numberRandom;
            int counter = 0;
            
            numberRandom = random.Next(minNumber, maxNumber + 1);

            for (int i = 0; i <= maxRange; i += numberRandom)
            {
                if (i >= minRange) 
                {   
                    counter++;
                    Console.WriteLine(i);
                }
              
            }
            Console.WriteLine(" Количество трехзначных чисел " + counter);
        }
    }
}