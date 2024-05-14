using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_module_3_part__5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Игра \"Угадай число»\"");
            Random random = new Random();
            int randomNumber = random.Next(0, 101);
            Console.WriteLine("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine()); 

            while (true)
            {
                string f;
                f = Console.ReadLine();
                if (f == string.Empty) 
                {
                    Console.WriteLine($"Загаданное число: {randomNumber} ");
                    break;
                }
                if (n > randomNumber)
                {
                    Console.WriteLine("Загаданное число меньше, попробуй еще раз");
                }
                else if (n < randomNumber)
                {
                    Console.WriteLine("Загаданное число больше, попробуй еще раз");
                }
                else
                {
                    Console.WriteLine("Поздравляю, Вы угадали число!!!");
                    Console.ReadKey();  
                    break;
                }
            }
        }
    }
}
