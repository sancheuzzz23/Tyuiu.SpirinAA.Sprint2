using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SpirinAA.Sprint2.Task5.V8.Lib
{
    public class DataService : ISprint2Task5V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            {
                switch (m)
                {
                    case 1: // Январь
                        if (n == 1)
                        {
                            m = 12;
                            n = 31;
                        }
                        else
                        {
                            n--;
                        }
                        break;

                    case 2: // Февраль
                        if (n == 1)
                        {
                            m = 1;
                            n = 31;
                        }
                        else
                        {
                            n--;
                        }
                        break;

                    case 3: // Март
                        if (n == 1)
                        {
                            m = 2;
                            n = 28;
                        }
                        else
                        {
                            n--;
                        }
                        break;

                    case 4: // Апрель
                        if (n == 1)
                        {
                            m = 3;
                            n = 31;
                        }
                        else
                        {
                            n--;
                        }
                        break;

                    case 5: // Май
                        if (n == 1)
                        {
                            m = 4;
                            n = 30;
                        }
                        else
                        {
                            n--;
                        }
                        break;

                    case 6: // Июнь
                        if (n == 1)
                        {
                            m = 5;
                            n = 31;
                        }
                        else
                        {
                            n--;
                        }
                        break;

                    case 7: // Июль
                        if (n == 1)
                        {
                            m = 6;
                            n = 30;
                        }
                        else
                        {
                            n--;
                        }
                        break;

                    case 8: // Август
                        if (n == 1)
                        {
                            m = 7;
                            n = 31;
                        }
                        else
                        {
                            n--;
                        }
                        break;

                    case 9: // Сентябрь
                        if (n == 1)
                        {
                            m = 8;
                            n = 31;
                        }
                        else
                        {
                            n--;
                        }
                        break;

                    case 10: // Октябрь
                        if (n == 1)
                        {
                            m = 9;
                            n = 30;
                        }
                        else
                        {
                            n--;
                        }
                        break;

                    case 11: // Ноябрь
                        if (n == 1)
                        {
                            m = 10;
                            n = 31;
                        }
                        else
                        {
                            n--;
                        }
                        break;

                    case 12: // Декабрь
                        if (n == 1)
                        {
                            m = 11;
                            n = 30;
                        }
                        else
                        {
                            n--;
                        }
                        break;
                    default:
                        return "Ошибка: недопустимый месяц";
                }

                return $"Предыдущий день: {n}.{m}";
            }
        }
    }
}
