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
            bool ProstoeChislo = false;

            Console.Write("Введите целое число: ");
            string chislo = Console.ReadLine();
            int N = Convert.ToInt32(chislo);
            int i = 2;

            while (i <= N - 1)
            {
                int ostatok = N % i;

                if (ostatok == 0)
                {
                    ProstoeChislo = true;
                    break;
                }

                i++;
            }
            if (ProstoeChislo)
            {
                Console.WriteLine("Число не является простым");
            }
            else
            {
                Console.WriteLine("Число является простым");
            }
            Console.ReadKey();
        }
    }
    }
