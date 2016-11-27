using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers of the fibonacci sequence would you like to go?");

            double n = int.Parse(Console.ReadLine());

            double a = 0;
            double b = 1;

            for (double i = 0; i < n; i++)
            {
                double temp = a;
                a = b;
                b = temp + b;
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
}
