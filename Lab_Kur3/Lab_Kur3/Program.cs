using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Kur3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Выборка заданий: \n\tЧасть 1 - 1 \n\tЧасть 2 - 2 \n\tЧасть 3 - 3\nВыберете задание: ");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("\nЧасть-1");
                    double x = -10, y = 8, dx;
                    Console.WriteLine("Таблица значений кусочной функции");
                    Console.WriteLine("     ____________");
                    Console.WriteLine("     |  x |   y |");
                    Console.WriteLine("     |____|_____|");
                    for (dx = 1; x < 9; x = x + dx)
                    {
                        if (-10 <= x && x < -6)
                            y = Math.Sqrt(4 - Math.Pow(x + 8, 2)) - 2;
                        else if (-6 <= x && x <= 2)
                            y = 0.5 * x + 1;
                        else if (2 < x && x < 6)
                            y = 0;
                        else if (6 <= x)
                            y = Math.Pow(x - 6, 2);

                        Console.WriteLine("     |" + String.Format("{0,4:0.#}", x) + "|" + String.Format("{0,5:0.##}", y) + "|");
                        Console.WriteLine("     |____|_____|");
                    }
                    break;
                case "2":
                    Console.WriteLine("\nЧасть-2");
                    Double R;
                    Console.WriteLine("Попадания в мишень");
                    for (int i = 0; i < 10; i++)
                    {
                        while (true)
                        {
                            try
                            {
                                Console.Write("Введите R=");
                                R = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Введите x=");
                                x = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Введите у=");
                                y = Convert.ToDouble(Console.ReadLine());
                            }
                            catch (FormatException) { Console.WriteLine("\nОшибка формата данных данных\n"); continue; }
                            break;
                        }
                        if ((x >= 0 && x <= R && x * x + y * y <= R * R) || (x >= -R && x <= 0 && ((y >= -x && y <= R) || (y <= x && y >= -R))))
                            Console.WriteLine("Есть попадание!");
                        else
                            Console.WriteLine("Мимо!");
                    }
                    break;
                case "3":
                    Console.WriteLine("\nЧасть-3");
                    Double eps;
                    Console.WriteLine("Таблица значений функции");
                    y = 0;
                    eps = 0.0001;
                    Console.WriteLine("");
                    Console.WriteLine(String.Format("{0,5:0.#}", "X") + String.Format("{0,10}", "Y") + String.Format("{0,50}", "Кол-во просуммированных членов ряда"));
                    Console.WriteLine("");
                    for (x = 2; x < 20; x += 1)
                    {
                        int n = 0;
                        double b = 0;
                        do
                        {
                            y = Math.Pow((-1), n + 1) / ((2 * n + 1) * Math.Pow(x, 2 * n + 1));
                            b = y + b;
                            n += 1;
                        } while (Math.Abs(y) > eps);
                        b = Math.PI / 2 + b;
                        Console.WriteLine(String.Format("{0,5:0.#}", x) + String.Format("{0,20:0.###############}", b) + String.Format("{0,10}", n));
                    }
                    Console.WriteLine("\nВыполнение окончено.");
                    Console.ReadKey(true);
                    break;
            }
        }
    }
}

