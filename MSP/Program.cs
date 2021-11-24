using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисление суммы геометрической прогрессии: ");
            Console.Write("Введите первый член: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите знаменатель: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите количество членов: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Сумма геометрической прогрессии равна: " + GetGeometricSeries(a, r, n));
        }
        static public double GetGeometricSeries(double a, double r, int n)
        {
            return a * (1 - Math.Pow(r, n)) / (1 - r);
        }
    }
}
