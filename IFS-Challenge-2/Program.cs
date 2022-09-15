using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFS_Challenge_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Z = 5;
            int Y = 6;
            int X = Z + Y * Z - Y;

            int sum = 0;
            int count = 0;

            while (count < X)
            {
                if (findPrime(count))
                {
                    sum += count;
                }
                count++;
            }

            Console.Write("Sum of Prime numbers below " + X + " is: " + sum);
            Console.ReadLine();
        }

        // Find the number is Prime number
        static bool findPrime(int num)
        {
            bool isPrime = true;

            if (num <= 1)
            {
                isPrime = false;
            }

            for (int count = 2; count <= num / 2; count++)
            {
                if (num % count == 0)
                {
                    isPrime = false;
                }
            }

            return isPrime;
        }
    }
}
