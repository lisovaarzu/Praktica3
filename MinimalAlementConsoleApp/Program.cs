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
            int i = Int32.Parse(Console.ReadLine()), min = int.MaxValue, N = -1;

            for (; i > 0; i--)
            {
                N = Int32.Parse(Console.ReadLine());
                min = min > N ? N : min;
            }
            Console.WriteLine("Наименьшее число последовательности: " + min);
            Console.ReadKey(true);
        }
    }
}
