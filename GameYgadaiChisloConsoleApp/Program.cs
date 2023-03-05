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

            Console.Write("Введите предполагаемое число или Enter для выхода: ");

            do
            {
                var userInput = Console.ReadLine();
                if (userInput == "")
                {
                    Console.Write ($"Загаданное число: {Number}.");
                    Console.ReadKey();
                    break;
                }

                count++;
                UserNumber = Convert.ToInt32 (userInput);
                
                if (UserNumber < Number)
                {
                    Console.Write ("Введённое число меньше загаданного. Попробуйте снова: ");
                }

                else if (UserNumber > Number)
                {
                    Console.Write ("Введённое число больше загаданного. Попробуйте снова: ");
                }

                else
                {
                    Console.WriteLine ($"Введённое число угаданно. Попыток ввода {count}. ");
                    Console.ReadKey();
                    break;
                }
                
            }
            while (true);
        }
    }
    
}


