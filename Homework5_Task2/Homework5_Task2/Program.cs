using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введіть перше число : ");
            string A1 = Console.ReadLine();
            int A = Convert.ToInt32(A1);
            Console.WriteLine("введіть друге число : ");
            string B1 = Console.ReadLine();
            int B = Convert.ToInt32(B1);
            int sum = 0;
            for (int i = A; i < B; i++)
            {
                sum = (A + B) * (B - A - 1) / 2;
            }
            Console.WriteLine("Сума елементів " + sum);

            for (int i = A; i < B; i++)
            {
                if ((i % 2) != 0)
                {
                    Console.WriteLine("Непарні числа {0}", i);
                }
            }
            Console.ReadKey();
        }
    }
}
