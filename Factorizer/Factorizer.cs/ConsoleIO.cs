using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizer.cs
{
    public class ConsoleIO
    {
        public static string GetYesNoAnswerFromUser(string prompt)
        {
            while (true)
            {
                Console.Clear();
                Factorize.FactorizingMenu();

                Console.Write(prompt + " (Y/N) ");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
                {
                    Console.Clear();
                    Factorize.FactorizingMenu();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter Y/N! ");
                    Console.ResetColor();
                    Console.WriteLine("Press any key to continue. ");
                    Console.ReadKey();
                }
                else
                {
                    if (input.ToUpper() != "Y" && input.ToUpper() != "N")
                    {
                        Console.Clear();
                        Factorize.FactorizingMenu();

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter Y/N only. ");
                        Console.ResetColor();
                        Console.WriteLine("Press any key to continue. ");
                        Console.ReadKey();
                        continue;
                    }
                    return input;
                }
            }
        }

        public static void Goodbye()
        {
            Console.Clear();
            Console.WriteLine(Separator);
            Console.WriteLine("@ BBBBBBBB    Y       Y  EEEEEEEEEEEE    !!!               @");
            Console.WriteLine("@ B       B    Y     Y   E              !!!!!     00  00   @");
            Console.WriteLine("@ B        B    Y   Y    E             !!!!!!!    00  00   @");
            Console.WriteLine("@ B       B      Y Y     E            !!!!!!!!!            @");
            Console.WriteLine("@ B   BBBBB       Y      E             !!!!!!!   00    00  @");
            Console.WriteLine("@ B         B     Y      E EEEEEE       !!!!!     000000   @");
            Console.WriteLine("@ B         B     Y      E               !!!               @");
            Console.WriteLine("@ B         B     Y      E                !                @");
            Console.WriteLine("@ B         B     Y      E                                 @");
            Console.WriteLine("@ B         B     Y      E                !                @");
            Console.WriteLine("@ BBBBBBBBBBB     Y      EEEEEEEEEEEE     !                @");
            Console.WriteLine(Separator);
            Console.ReadKey();
        }

        public static void WindowSetup()
        {
            Console.SetWindowSize(60, 25);
        }
        public const string Separator = "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@";
        public const string Blanks = "@                                                          @";
    }
}
