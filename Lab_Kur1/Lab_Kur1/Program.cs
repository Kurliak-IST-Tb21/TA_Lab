using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Kur1
{
    class Program
    {
        static void Main(string[] args)
        {
            double z1, z2, a;
            Console.Write("Введите а=");
            a = Convert.ToDouble(Console.ReadLine());
            z1 = 1 - (1.0 / 4) * Math.Pow(Math.Sin(2 * a), 2) + Math.Cos(2 * a);
            z2 = Math.Pow(Math.Cos(a), 2);
            z2 = z2 + z2 * z2;
            Console.WriteLine("z1=" + z1);
            Console.WriteLine("z2=" + z2);
            Console.ReadKey(true);
        }
    }
}

       