using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_module_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите целое число");

            int N;
            N = int.Parse(Console.ReadLine());

            if (N%2 == 0)
            {
                Console.WriteLine("Введенное число четное");
            }
            else 
            {
                Console.WriteLine("Введенное число не четное");
            }
        }
    }
}
