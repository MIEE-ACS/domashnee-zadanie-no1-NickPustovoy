using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = 0;
            double B = 0;
            double C = 0;
            double Sum = 0;
            double AC = 0;
            double BC = 0;
            Console.WriteLine("Пожалуйста введите значения точки A");
            A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Пожалуйста введите значения точки B");
            B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Пожалуйста введите значения точки C");
            C = Convert.ToDouble(Console.ReadLine());
            AC = C - A;
            AC = Math.Abs(AC);
            Console.WriteLine($"Длина отрезка AC: {AC}");
            BC = C - B;
            BC = Math.Abs(BC);
            Console.WriteLine($"Длина отрезка BC: {BC}");
            Sum = AC + BC;
            Console.WriteLine($"Сумма длин отрезков равна {Sum}");
            Console.ReadKey();
        }
    }
}
