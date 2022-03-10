using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
    class Program
    {
        /*Создать метод для вычисления объема и площади поверхности куба по длине его ребра.*/
        static void Main(string[] args)
        {
            // Объявление переменных для длины ребра, площади поверхности и объема куба
            double aCube, sCube, vCube;

            Console.WriteLine("Введите длину ребра куба (см): ");
            aCube = Convert.ToDouble(Console.ReadLine());

            // Вычисляем площадь поверхности куба
            sCube = CalcSq(aCube);

            // Вычисляем объем куба
            vCube = CalcV(aCube);

            // Выводим полученные значения площади поверхности и объема
            Console.WriteLine("\n\nПлощадь поверхности {0} кв. см", sCube);
            Console.WriteLine("\nОбъем {0} куб. см.", vCube);
            Console.ReadKey();
        }

        // Метод для вычисления площади поверхности куба
        static double CalcSq(double a)
        {
            double s = 6 * a * a;
            return s;
        }
        // Метод для вычисления объема куба
        static double CalcV(double a)
        {
            double v = a * a * a;
            return v;
        }

    }
}
