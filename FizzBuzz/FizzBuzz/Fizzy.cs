using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Fizzy
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO FIZZBUZZ.");
            Console.WriteLine("Shall we begin? Y / N");
            string userInput = Console.ReadLine();

            while ((userInput.ToUpper() != "N"))
            {
                if (userInput.ToUpper() == "Y")
                {
                    for (int n = 1; n <= 100; n++)
                    {
                        if (n % 15 == 0)
                        {
                            Console.WriteLine("FIZZERBUZZER >:D");
                        }
                        else if (n % 3 == 0)
                        {
                            Console.WriteLine("Fizzy ---> :3");
                        }
                        else if (n % 5 == 0)
                        {
                            Console.WriteLine("Buzzy -----> :)");
                        }
                        else
                        {
                            Console.WriteLine(n);
                        }
                    }
                    Console.WriteLine("\nAgain?");
                    userInput = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Please only press Y or N! Do you want to buzz this fizz?");
                    userInput = Console.ReadLine();
                }
            }
        }
    }
}