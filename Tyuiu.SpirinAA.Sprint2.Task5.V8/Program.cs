using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SpirinAA.Sprint2.Task5.V8.Lib;

namespace Tyuiu.SpirinAA.Sprint2.Task5.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Спирин А. А. | АСОиУб-23-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Спирин Александр Алексеевич | АСОиУб-23-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
            Console.WriteLine("* требуемое значение и возвращает результат. Условие: Дата некоторого дня *");
            Console.WriteLine("* характеризуется двумя натуральными числами: m (порядковый номер месяца) *");
            Console.WriteLine("* и n (число). По заданным n и m определить дату предыдущего дня          *");
            Console.WriteLine("* (принять, что n и m не характеризуют 1 января).                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string res;

            int n;
            int m;

            Console.WriteLine("Введите значение переменной M: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение переменной N: ");
            m = Convert.ToInt32(Console.ReadLine());

            if (((n < 1) && (n > 31)) || ((m < 1) && (m > 12)))
            {
                res = "Введены неверные значения";
            }
            else
            {
                res = "Дата предыдущего дня: " + ds.FindDateOfPreviousDay(n, m);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
