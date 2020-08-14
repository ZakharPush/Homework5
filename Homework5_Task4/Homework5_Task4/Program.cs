using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homewrok5_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть висоту : ");
            int enterHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть ширину : ");
            int enterWidth = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < enterHeight; i++)
            {
                for (int j = 0; j < enterWidth; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
