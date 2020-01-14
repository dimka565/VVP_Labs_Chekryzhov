using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Лабораторная работа №2


            //Задание 1
            /*
            int x1, x2, y1, y2;
            Console.WriteLine("Введите координаты 1 точки (x1;y1) по-очередно: ");
            x1 = int.Parse(Console.ReadLine());
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y координаты 2 точки (x2;y2) по-очередно: ");
            x2 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());
            //по математической формуле считаем расстояние между точками (Расстояние между двумя точками равно квадратному корню от суммы квадратов расстояний вдоль оси x и вдоль оси y.)
            Console.WriteLine("Расстояние между этими точками = " + (Math.Sqrt((Math.Pow((y2 - y1), 2) + Math.Pow((x2-x1),2)))));
            Console.ReadLine();
            */


            //Задание 2
            /*
            int A, B, C;
            Console.WriteLine("Введите значения точек A, B и С по-очередно: ");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            Console.WriteLine("Длина отрезка АС = " + Math.Abs(C - A));
            Console.WriteLine("Длина отрезка BС = " + Math.Abs(C - B));
            Console.WriteLine("Сумма отрезков AC и BC = " + Math.Abs((C - A) + (C - B)));
            Console.ReadLine();
            */


            //Задание 3
            /*
            int A, B, C;
            Console.WriteLine("Введите точки А, В и С так, что бы С было между А и В: ");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            Console.WriteLine("Произведение длин отрезков AC и BC = " + ((C - A) * (B - C)));
            Console.ReadLine();
            */


            //Задание 4
            /*
            int x1, x2, y1, y2;
            Console.WriteLine("Введите координаты противоположных точек прямоугольника: ");
            Console.WriteLine("Введите координаты 1 точки (x1;y1) по-очередно: ");
            x1 = int.Parse(Console.ReadLine());
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y координаты 2 точки (x2;y2) по-очередно: ");
            x2 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());  //
            Console.WriteLine("Периметр прямоугольника = " + (2 * (((Math.Sqrt((Math.Pow((x2 - x1), 2))))) + (Math.Sqrt((Math.Pow((y2 - y1), 2)))))));
            Console.WriteLine("Площадь прямоугольника = " + (((Math.Sqrt((Math.Pow((x2 - x1), 2))))) * (Math.Sqrt((Math.Pow((y2 - y1), 2))))));
            Console.ReadLine();
            */


            //Задание 5  
            /*
            int x1, y1, x2, y2, x3, y3;
            double a, b, c, p, S;
            Console.WriteLine("Введите координаты 1 вершины");
            x1 = int.Parse(Console.ReadLine());
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты 2 вершины");
            x2 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты 3 вершины");
            x3 = int.Parse(Console.ReadLine());
            y3 = int.Parse(Console.ReadLine());
            a = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            b = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
            c = Math.Sqrt(Math.Pow((x1 - x3), 2) + Math.Pow((y1 - y3), 2));
            p = (a + b + c) / 2;                                //формула полупериметра
            S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));     //по формуле герона считаем площадь
            Console.WriteLine("Площадь: " + S);
            Console.WriteLine("Периметр:" + (a + b + c));
            Console.ReadLine();
            */


        }
    }
}
