using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameYgadaiChisloConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите конец интервала: ");
            int y = int.Parse (Console.ReadLine());

            Random rand = new Random();

            int Number = rand.Next(0, y);
            int count = 0;
            int UserNumber;
            int Enter = 0;

            Console.Write("Введите предполагаемое число или Enter для выхода: ");

            do
            {
                var userInput = Console.ReadLine();
                if (userInput == "")
                {
                    System.Environment.Exit(Enter);
                }

                count++;
                UserNumber = Convert.ToInt32 (Console.ReadLine());
                
                if (UserNumber < Number)
                {
                    Console.WriteLine("Введённое число меньше загаданного. Попробуйте снова");
                }

                else if (UserNumber > Number)
                {
                    Console.WriteLine("Введённое число больше загаданного. Попробуйте снова");
                }

                else
                {
                    Console.WriteLine($"Введённое число угаданно. Попыток ввода {count}. ");
                    Console.ReadKey();
                    break;
                }
                
            }
            while (true);
        }
    }
    
}


