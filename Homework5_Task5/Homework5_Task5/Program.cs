using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Введіть число : ");
            int enterNumber = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            int num = 1;
            do
            {
                fact *= num;
                num++;
            }
            while (num <= enterNumber);
            Console.WriteLine("Факторіал числа: {0} ", fact);
            Console.ReadKey();
        }
    }
}
