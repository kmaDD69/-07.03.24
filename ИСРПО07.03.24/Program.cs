using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ИСРПО07._03._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            double number = Convert.ToDouble(Console.ReadLine());

            double result = CalculateFunction(number);

            Console.WriteLine($"Результат вычисления функции: {result}");

            Console.ReadKey();
        }

        static double CalculateFunction(double x)
        {
            return 3 * Math.Sin(x + 2);
        }
    }
}
