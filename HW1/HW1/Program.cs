// Написать программу, которая выводит таблицу значений функции
// f(x)={    x*x  при x<0
//      {    x    при x≥0
// на заданном интервале. Границы интервала и шаг задаются пользователем.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            double lb;
            double ub;
            double step = 0;
            do
            {
                Console.Clear();
                lb = InputDouble("нижнюю границу интервала", "lb = ");
                ub = InputDouble("верхнюю границу интервала", "ub = ");
                if (lb > ub)
                {
                    check = false;
                    Console.WriteLine("\nВы неправильно ввели границы интервала.");
                    Console.WriteLine("Значение нижней границы должно быть меньше значения верхней границы.");
                    if (CheckExit())
                        continue;
                    else
                        break;
                }
                else
                {
                    step = InputDouble("шаг", "step = ");
                    if (step <= 0)
                    {
                        check = false;
                        Console.WriteLine("\nВы неправильно ввели шаг. Значение шага должно быть больше 0");
                        if (CheckExit())
                            continue;
                        else
                            break;
                    }
                    else
                        check = true;
                }
            } while (!check);
            if (check)
            {
                Console.WriteLine("╔════════╦══════════╗");
                Console.WriteLine("║   x    ║   f(x)   ║");
                Console.WriteLine("╠════════╬══════════╣");
                double f;
                for (double x = lb; x <= ub; x += step)
                {
                    if (x < 0)
                    {
                        f = x * x;
                    }
                    else
                    {
                        f = x;
                    }
                    Console.WriteLine($"║{x,8:f2}║{f,10:f3}║");
                }
                Console.WriteLine("╚════════╩══════════╝");
            }
            Console.ReadKey();
        }
        static double InputDouble(string query, string value = " ")
        {
            Console.Write("Введите " + query + ":\n" + value);
            return Convert.ToDouble(Console.ReadLine());
        }
        static bool CheckExit()
        {
            Console.Write("\nЖелаете ввести новые данные?\n1 - да\n0 - нет\nВаш выбор: ");
            return Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));
        }
    }
}
