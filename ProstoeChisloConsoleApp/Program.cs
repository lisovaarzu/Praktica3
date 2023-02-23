using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProstoeChisloConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            int N = int.Parse(Console.ReadLine());
            int i = 2;

            bool ProstoeChislo = false;
            while (i <= N - 1);
            {
                if (N % i == 0)
                ProstoeChislo = true;

                i++;
            }
            if (ProstoeChislo)
            {
                Console.WriteLine("Число является простым");
            }
            else
            {
                Console.WriteLine("Число не является простым");
            }
            Console.ReadKey();
        }
    }
    }
