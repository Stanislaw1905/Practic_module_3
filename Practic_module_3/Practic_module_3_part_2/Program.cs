using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_module_3_part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Привет, напиши сколько карт у тебя в руке: ");
            int handCards = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= handCards; i++) 
            {
                Console.Write("Введите номинал карты: ");
                string handValue = Console.ReadLine();

                switch (handValue)
                {
                    case "2":
                        sum += 2; 
                        break;
                    case "3":
                        sum += 3; 
                        break;
                    case "4":
                        sum += 4; 
                        break;
                    case "5":
                        sum += 5; 
                        break;
                    case "6":
                        sum += 6; 
                        break;
                    case "7":
                        sum += 7; 
                        break;
                    case "8":   
                        sum += 8; 
                        break;
                    case "9":   
                        sum += 9; 
                        break;
                    case "10":
                        sum += 10; 
                        break;
                    case "J":
                        sum += 10; 
                        break;
                    case "Q":
                        sum += 10; 
                        break;
                    case "K":
                        sum += 10; 
                        break;
                    case "T":
                        sum += 10; 
                        break;
                    default:
                        Console.WriteLine("Можно выбрать карты номиналом от 2 до 10, J, Q, K, T");
                        break;
                }
                Console.WriteLine("Сумма карт : " + sum);
                Console.ReadLine();

            }
            







        }
    }
}
