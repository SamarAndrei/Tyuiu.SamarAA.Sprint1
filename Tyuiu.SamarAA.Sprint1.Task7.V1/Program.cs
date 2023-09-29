using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SamarAA.Sprint1.Task7.V1.Lib;

namespace Tyuiu.SamarAA.Sprint1.Task7.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Самар А. С. | ИИПб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Самар Андрей Александрович | ИИПб-23-3                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
            Console.WriteLine("* исходным значениям данных, вводимых пользователем.                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫ:                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("b + Sqrt(b^2 + 4 * a * c ");
            Console.WriteLine("--------------------------    - a^3 * c - b^-2");
            Console.WriteLine("           2 * a         ");

            Console.WriteLine("Введите координаты A:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты B:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты C:");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(a, b, c));
            Console.ReadKey();
        }
    }
}
