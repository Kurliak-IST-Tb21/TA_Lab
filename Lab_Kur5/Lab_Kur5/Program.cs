using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Kur5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] c = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    c[i, j] = rand.Next(-100, 100);
                    Console.Write(c[i, j] + "\t");
                }
                Console.WriteLine();
            }


            int[] index = new int[n];
            int[] num = new int[n];
            for (int i = 0; i < n; i++)
            {
                int temp = 0;
                for (int j = 0; j < n; j++)
                {
                    if (c[i, j] < 0) temp += Math.Abs(c[i, j]);
                }
                num[i] = temp;
                index[i] = i;
            }
            Array.Sort(num, index);
            int[,] d = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    d[i, j] = c[index[i], j];
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(d[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

        