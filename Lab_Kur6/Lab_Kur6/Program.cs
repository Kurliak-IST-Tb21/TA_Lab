using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Kur6
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "123 \"мир\" 234\"труд\" 777 \"май\"";   //строка из которой будем брать цитаты
            Console.WriteLine(s);
            bool citata = false; // логическое значение, определяет читаются символы из цитаты 
                                 // или из обычного текста

            for (int i = 1; i < s.Length; i++)  // перебираем последовательно все символы в строке
            {
                if (s[i] == '"' && (!citata))  // если встретилась кавычка, значит началась цитата
                {
                    citata = true;
                    continue;                  // завершает текущую итерацию цикла 
                                               // (чтобы не выводилась на экран кавычка в начале цитаты)
                }
                else if (s[i] == '"' && (citata))   // если встретилась кавычка и значение citata было true, 
                                                    // то это конец цитаты
                {
                    citata = false;
                    Console.WriteLine();
                }
                if (citata) Console.Write(s[i]);  // выводить на экран символы, если они относятся к цитате
            }
            Console.ReadLine();

        }
    }
}
