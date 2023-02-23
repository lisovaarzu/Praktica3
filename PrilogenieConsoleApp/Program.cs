using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrilogenieConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");

            int a;

            a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)

            {
                Console.WriteLine("Введенное число является четным");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Введенное число нечетное");
                Console.ReadLine();
            }
        }
    }
}
