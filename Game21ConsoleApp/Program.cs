using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game21ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write ("Привет. Сколько у вас карт на руках?: ");
            int Cards = int.Parse(Console.ReadLine());
            Console.WriteLine ("Введите номинал каждой карты: ");
            int ValueCards = 0;

            for (int i = 0; i <= Cards; i++)
            {
                string nominal = Console.ReadLine();

                switch (nominal)
                {
                    case "2":
                        ValueCards += 2;
                        break;
                    case "3":
                        ValueCards += 3;
                        break;
                    case "4":
                        ValueCards += 4;
                        break;
                    case "5":
                        ValueCards += 5;
                        break;
                    case "6":
                        ValueCards += 6;
                        break;
                    case "7":
                        ValueCards += 7;
                        break;
                    case "8":
                        ValueCards += 8;
                        break;
                    case "9":
                        ValueCards += 9;
                        break;
                    case "J":
                        ValueCards += 10;
                        break;
                    case "Q":
                        ValueCards += 10;
                        break;
                    case "K":
                        ValueCards += 10;
                        break;
                    case "T":
                        ValueCards += 10;
                        break;
                }

            }
            Console.WriteLine("Сумма карт на руках: " + ValueCards);
            Console.ReadKey();
        }
    }
}
