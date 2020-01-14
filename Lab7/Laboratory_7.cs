using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Лаба 7

            //Задание 1
            /*
            int a, b;
            Console.WriteLine("Введите A и В по-очередно: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Справедливы неравенства А > 2 и B <= 3 \n" + ((a > 2) && (b <= 3)));
            Console.ReadLine();
            */


            //Задание 2
            /*
            int a, b, c;
            Console.WriteLine("Введите A, В и С по-очередно: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Справедливо двойное неравенство A < B < C \n" + ((a < b) && (b < c)));
            Console.ReadLine();
            */


            //Задание 3
            /*
            int a;
            Console.WriteLine("Введите число: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Данное число является четным двузначным \n" + ((a % 2 == 0) && (a / 100 == 0)));
            Console.ReadLine();
            */


            //Задание 4
            /*
            int a;
            Console.WriteLine("Введите трехзначное число: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Цифры данного числа образуют возрастающую или убывающую последовательность \n" + ((a / 100) > (a % 100 / 10) && (a % 100 / 10) > (a % 10) || (a / 100) < (a % 100 / 10) && (a % 100 / 10) < (a % 10)));
            Console.ReadLine();
            */


            //Задание 5
            /*
            int a;
            Console.WriteLine("Введите четырехзначное число: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Данное число читается одинаково слева направо и справа налев \n" + ((a / 1000 == a % 10) && ((a % 1000 / 100) == (a % 100 / 10))));
            Console.ReadLine();
            */


            //Задание 6
            /*
            int a, b, c;
            Console.WriteLine("Введите 3 стороны треугольника по-очередно: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Треугольник со сторонами a, b, c является прямоугольным \n" + ((a * a == b * b + c * c) || (b * b == a * a + c * c) || (c * c == a * a + b * b)));
            Console.ReadLine();
            */


            //Задание 7
            /*
            int a, b, c;
            Console.WriteLine("Введите 3 стороны треугольника по-очередно: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Существует треугольник со сторонами a, b, c \n" + ((a + b > c) && (a + c > b) && (b + c > a)));
            Console.ReadLine();
            */
        }
    }
}
