using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace PersonalExercises
{
    //Personal exercises. Common tech test questions. No Linq other than problem #2.

    class Program
    {
        public static string Separator = "---------------------------------------------------";

        static void Main(string[] args)
        {
            bool keepGoing = true;
            while (keepGoing)
            {
                Console.Clear();
                Console.WriteLine(Separator);
                Console.WriteLine("Choice 1: Power of Two");
                Console.WriteLine("Choice 2: Remove Duplicates From Array");
                Console.WriteLine("Choice 3: Reverse String");
                Console.WriteLine("Choice 4: Double DDOOUUBBLLEE");
                Console.WriteLine("Choice 5: Average Array Ints");
                Console.WriteLine();
                Console.WriteLine("More to come later.");
                Console.WriteLine(Separator);
                Console.WriteLine("Choice Q:");

                switch (Console.ReadLine().ToUpper())
                {
                    case "1":
                        PowerOfTwo();
                        break;
                    case "2":
                        RemoveDuplicates();
                        break;
                    case "3":
                        ReverseString();
                        break;
                    case "4":
                        Doubles();
                        break;
                    case "5":
                        ArrayAverage();
                        break;
                    case "Q":
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Enter a choice again.");
                        continue;
                }
            }
        }

        public static void PowerOfTwo()
        {
            Console.Clear();
            Console.WriteLine(Separator);
            Console.WriteLine("Two Fast Two POWERful!");
            Console.WriteLine(Separator);

            Console.WriteLine("Enter a number, and I will tell you if it is a power of 2!");

            int powerNumber;
            int.TryParse(Console.ReadLine(), out powerNumber);
            if (powerNumber >= 0)
            {
                if ((powerNumber & (powerNumber - 1)) == 0 && powerNumber != 0)
                {
                    Console.WriteLine("{0} IS a power of 2", powerNumber);
                    Console.WriteLine("Press any key to return to the main screen.");
                }
                else
                {
                    Console.WriteLine("{0} is NOT a power of 2", powerNumber);
                    Console.WriteLine("Press any key to return to the main screen.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid, positive number!");
            }

            Console.ReadKey();
            return;
        }

        public static void RemoveDuplicates()
        {
            Console.Clear();
            Console.WriteLine(Separator);
            Console.WriteLine("Remov[e] Duplicates from an Ar[r][a]y!");
            Console.WriteLine(Separator);

            Console.WriteLine("How big would you like the int array to be? (10 or less!)");

            int n = int.Parse(Console.ReadLine());
            int[] testArray = new int[n];


            if ((n > 0) && (n <= 10))
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("What is the index {0} for your array? (only write numbers!)", i);
                    testArray[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine(Separator);
                Console.WriteLine();
                Console.WriteLine("Here is the values in your array with the duplicates removed: \n");
                
                testArray.Distinct().ToList().ForEach(a => Console.Write(a + " "));
            }
            else
            {
                Console.WriteLine("Only valid numbers greater than 0 and less than 10.");
            }

            Console.ReadKey();
            return;
        }

        public static void ReverseString()
        {
            Console.Clear();
            Console.WriteLine(Separator);
            Console.WriteLine("Reverse String, gnirtS esreveR!");
            Console.WriteLine(Separator);
            Console.WriteLine("Write a string (word(s)) you would like to reverse!");

            string input = Console.ReadLine();
            string reversedStr = string.Empty;

            if (!String.IsNullOrEmpty(input) && !String.IsNullOrWhiteSpace(input))
            {
                for (var i = input.Length - 1; i >= 0; i--)
                {
                    reversedStr += input[i];
                }
                Console.WriteLine("The reverse of {0} is {1}", input, reversedStr);
            }
            else
            {
                Console.WriteLine("If you want me to reverse a string, you gotta give me something..");
            }

            Console.ReadKey();
            return;
        }

        public static void Doubles()
        {
            Console.Clear();
            Console.WriteLine(Separator);
            Console.WriteLine("Double DDOOUUBBLLEE Toil and TTRROOUUBBLLEE.");
            Console.WriteLine(Separator);
            Console.WriteLine("Write a string (word(s)) and I will change it to SSTTRRIINNGG!");

            string input = Console.ReadLine();
            string doubledStr = string.Empty;

            if (!String.IsNullOrEmpty(input) && !String.IsNullOrWhiteSpace(input))
            {
                for (var i = 0; i < input.Length; i++)
                {
                    doubledStr += input[i];
                    doubledStr += input[i];
                }
                Console.WriteLine(doubledStr.ToUpper());
            }
            else
            {
                Console.WriteLine("Well. I can't change nothing if you give me nothing.");
            }

            Console.ReadKey();
            return;
        }

        public static void ArrayAverage()
        {
            Console.Clear();
            Console.WriteLine(Separator);
            Console.WriteLine("Given an array of ints, return the average!");
            Console.WriteLine(Separator);
            Console.WriteLine("How big would you like the int array to be? (10 or less!)");

            int n = int.Parse(Console.ReadLine());
            int[] testArray = new int[n];

            if (n > 0 && n <= 10)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("What is the index {0} for the int array?", i);
                    testArray[i] = int.Parse(Console.ReadLine());
                }

                int size = testArray.Length;
                int sum = 0;
                int average = 0;

                for (int i = 0; i < size; i++)
                {
                    sum += testArray[i];
                }

                average = sum / size;

                Console.WriteLine("The Sum Of Array Elements Is : " + sum);
                Console.WriteLine("The Average Of Array Elements Is : " + average);
            }
            else
            {
                Console.WriteLine("Only numbers greater than 0 and less than 10.");
            }

            Console.ReadKey();
            return;
        }
    }
}