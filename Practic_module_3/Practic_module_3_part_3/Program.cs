using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_module_3_part_3
{

    internal class Program
    {

        static void Main(string[] args)
        {
            bool number = false;
            Console.WriteLine("Введите целое число: ");
            int n =int.Parse(Console.ReadLine());
            int i = 2;
            while (i <= n - 1)
            {
                if (n % i == 0 )
                {
                    number = true;
                    break;
                }
                i++;
                
            }
            if (number)
            {
                Console.WriteLine("Число не простое");
            }
            else
            {
                Console.WriteLine("Число простое");
            }
            Console.ReadKey();
        }

    }  
}