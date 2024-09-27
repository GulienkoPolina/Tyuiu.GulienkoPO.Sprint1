using System.Transactions;
using Tyuiu.GulienkoPO.Sprint1.Task3.V5.Lib;

namespace Tyuiu.GulienkoPO.Sprint1.Task3.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Гулиенко П. О. | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнила: Гулиенко Полина Олеговна | ИСТНб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ                                                                 *");
            Console.WriteLine("* Написать программу вычисления расстояния между населёнными пунктами,    *");
            Console.WriteLine("* изображенными на карте.                                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double a = 120;
            double b = 3.5;
            Console.WriteLine("Масштаб карты = " + a);
            Console.WriteLine("Расстояние между точками, изображающими населенные пункты = " + b);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Расстояние между населенными пунктами = " + ds.DistanceLength(a, b));

            Console.ReadKey();

        }
    }
}