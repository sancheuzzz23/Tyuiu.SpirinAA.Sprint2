﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SpirinAA.Sprint2.Task7.V14.Lib;

namespace Tyuiu.SpirinAA.Sprint2.Task7.V14
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
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Спирин Александр Алексеевич | АСОиУб-23-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, на C# которая запрашивает исходные данные           *");
            Console.WriteLine("* (вещественные значения) и вычисляет, находится ли точка с координатами  *");
            Console.WriteLine("* X,Y в заштрихованной области.                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            bool res;

            double x;
            double y;

            Console.WriteLine("Введите координату X: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координату Y: ");
            y = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            res = ds.CheckDotInShadedArea(x, y);
            if (res)
            {
                Console.WriteLine("Точка находится в зашрихованной области");
            }
            else
            {
                Console.WriteLine("Точка не находится в зашрихованной области");
            }
            Console.ReadKey();
        }
    }
}
