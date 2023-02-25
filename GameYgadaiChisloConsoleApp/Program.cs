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
            Random rand = new Random();

            int Number = rand.Next(1, 100);
            int count = 0;
            int UserNumber;

            do
            {
                Console.Write("Введите предполагаемое число : ");
                count++;
                UserNumber = Convert.ToInt32(Console.ReadLine());

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
