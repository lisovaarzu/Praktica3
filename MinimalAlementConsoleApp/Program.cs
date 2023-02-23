using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimalAlementConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длинну последовательности: ");
            int i = Int32.Parse(Console.ReadLine()), min = int.MaxValue;

            for (; i > 0; i--);
            {
                i = Int32.Parse(Console.ReadLine());
                min = min > i ? i : min;
            }
            Console.WriteLine("Наименьшее число последовательности: " + min);
            Console.ReadKey();
        }
    }
}
