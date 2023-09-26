using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SamarAA.Sprint1.Task5.V1.Lib;

namespace Tyuiu.SamarAA.Sprint1.Task5.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Самар А. С. | ИИПб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Самар Андрей Александрович | ИИПб-23-3                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                    *");
            Console.WriteLine("* найти расстояние между двумя точками с заданными координатами (x, y).   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫ:                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите координаты X1:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты Y1:");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты X2:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты Y2:");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.DistanceBetweenDots(x1, y1, x2, y2);
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
