using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_module_3_part__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длинну строки");
            int lenght = int.Parse(Console.ReadLine());
            int value;
            int minValue = int.MaxValue;

            for (int i = 0; i < lenght; i++) 
            {
                Console.WriteLine("Введите число: ");
                value = int.Parse(Console.ReadLine());
                if (value < minValue) 
                {
                    minValue = value;
                }

            }
            Console.WriteLine($"Минимальное число в последовательности: {minValue}");
            Console.ReadLine();
            
        }
    }
}