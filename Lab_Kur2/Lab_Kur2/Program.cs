using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Kur2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y = 0;
            // Задание 1
            Console.WriteLine("Задание 1");
            Console.Write("x=");
            x = Convert.ToDouble(Console.ReadLine());
            if (-10 <= x && x < -6)
                y = -Math.Sqrt(4 - Math.Pow(x + 8, 2)) - 2;
            else if (-6 <= x && x <= 2)
                y = 0.5 * x + 1;
            else if (2 < x && x < 6)
                y = 0;
            else if (6 <= x)
                y = Math.Pow(x - 6, 2);
            else
                Console.WriteLine("Неопределена");
            Console.WriteLine("y=" + y);
            Console.ReadKey(true);
            // Задание 2
            Double R;
            Console.WriteLine("\nЗадание 2"); Console.Write("R=");
            R = Convert.ToDouble(Console.ReadLine());
            Console.Write("x=");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y=");
            y = Convert.ToDouble(Console.ReadLine());
            if ((x >= 0 && x <= R && x * x + y * y <= R * R) || (x >= -R && x <= 0 && ((y >= -x && y <= R) || (y <= x && y >= -R))))
                Console.WriteLine("Пара (x,y) принадлежит заданной области");
            else Console.WriteLine("Пара (x,y) не принадлежит заданной области");
            Console.ReadKey(true);
        }
    }
}
