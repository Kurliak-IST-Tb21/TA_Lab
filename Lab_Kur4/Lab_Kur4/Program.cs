using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Kur4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Номер минимального элемента массива
                Console.WriteLine("введите количество элементов массива");
                Console.Write("N = ");
                int n = int.Parse(Console.ReadLine());
                float[] array = new float[n];
                int min = 0;
                int a = -1, b = -1;
                Console.WriteLine("введите элементы массива");
                for (int i = 0; i < array.Length; i++)
                {

                    Console.Write("array[{0}] = ", i);
                    array[i] = float.Parse(Console.ReadLine());
                    if (array[min] > array[i])
                        min = i;
                    if (array[i] < 0)
                        if (a == -1)
                            a = i;
                        else if (b == -1)
                            b = i;
                }

                // Сумму элементов массива, расположенных между первым и вторым отрицательны-ми элементами
                Console.WriteLine("Номер минимального элемента = {0}", min);
                if (a == -1 || b == -1)
                    Console.WriteLine("В массиве нет хотя бы двух отрицательных чисел: сумму не посчитать!");
                else
                {
                    float sum = 0;
                    for (int i = a + 1; i < b; i++)
                        sum += array[i];
                    Console.WriteLine("Сумма между двумя отрицательными числами = {0}", sum);
                }

                // Преобразовать массив таким образом, чтобы сначала располагались все эле-менты,
                // модуль которых не превышает 1, а потом все остальные
                for (int i = 0, j = 0; i < array.Length; i++)
                    if (Math.Abs(array[i]) <= 1)
                    {
                        float temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                        j++;
                    }
                Console.WriteLine("Результат преобразования массива:");
                for (int i = 0; i < array.Length; i++)
                    Console.Write("{0} ", array[i]);
                Console.WriteLine();
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Ошибка");
                Console.WriteLine("Приложение будет закрыто после нажатия клавиши Enter");
                Console.ReadLine();

            }
        }
    }
}

        