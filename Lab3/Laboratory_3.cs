using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Лабораторная работа №3

            //Задание 1
            /*
            int a, b, c;
            Console.WriteLine("Введите числа А и В по-очередно: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = a;
            a = b;
            b = c;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadLine();
            */


            //Задание 2
            /*
            int a, b, c, d;
            Console.WriteLine("Введите числа А, В и С по-очередно: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = a;            a = b;            b = c;            c = d;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.ReadLine();
            */


            //Задание 3
            /*
            int a, b, c, d;
            Console.WriteLine("Введите числа А, В и С по-очередно: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = a;            a = c;            c = b;            b = d;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.ReadLine();
            */


            //Задание 4
            /*
            double x;
            Console.WriteLine("Введите x: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine((3 * Math.Pow(x, 6)) - (6 * x * x) - 7); // y = 3x^6 - 7x^2 - 7
            Console.ReadLine();
            */


            //Задание 5
            //Найти значение функции y = 4(x−3)^6 − 7(x−3)^3 + 2 при данном значении x
            /*
            double x;
            Console.WriteLine("Введите x: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine((4 * Math.Pow((x-3), 6)) - (7*Math.Pow((x-3),3)) + 2);
            Console.ReadLine();
            */


            //Задание 6
            
            double x, Result;
            Console.WriteLine("Введите х: ");
            x = int.Parse(Console.ReadLine());
            Result = ((Math.Pow(x, 2)) * (Math.Pow(x, 2)));
            Result = ((Math.Pow(x, 2)) * (Math.Pow(x, 2))* Result);
            Console.WriteLine("A^8 = " + Result);
            Console.ReadLine();
            

            //Задание 7
            /*
            double x, a, Result;
            Console.WriteLine("Введите х: ");
            x = int.Parse(Console.ReadLine());
            Result = ((Math.Pow(x, 3)) * (Math.Pow(x, 3))* (Math.Pow(x, 3)) * (Math.Pow(x, 3)));
            Result = ((Math.Pow(x, 3)) * Result);
            Console.WriteLine("A^15 = " + Result);
            Console.ReadLine();
            */

        }
    }
}
