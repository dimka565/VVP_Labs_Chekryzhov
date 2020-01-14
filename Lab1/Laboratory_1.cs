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
            //Лабораторная работа №1 
            //Задание 1

            /* 
            int a, b;
            Console.WriteLine("Введите первую сторону");
            a = int.Parse(Console.ReadLine());  //оформляем ввод с клавиатуры
            Console.WriteLine("Введите вторую сторону");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Площадь = "+(a*b)); //считаем и выводим на экран площадь а затем периметр
            Console.WriteLine("Периметр = " + 2 * (a + b));
            Console.ReadLine();
            */

            //Задание 2

            /* 
            int d;
            Console.WriteLine("Введите диаметр окружности");
            d = int.Parse(Console.ReadLine()); //оформляем ввод с клавиатуры
            Console.WriteLine("Длина окружности =  " + (Math.PI * d)); //считаем и выводим на экран длину окружности
            Console.ReadLine();
            */

            //Задание 3

            /*
            int a, b;
            Console.WriteLine("Введите первое число");
            a = int.Parse(Console.ReadLine()); //оформляем ввод с клавиатуры
            Console.WriteLine("Введите второе число");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Среднее арефметическое = " + (a + b) / 2); //считаем и выводим на экран среднее арефметическое
            Console.ReadLine();
            */

            //Задание 4

            /*
            int a, b;
            Console.WriteLine("Введите первое ненулевое число, иначе ничего не получится");
            a = int.Parse(Console.ReadLine()); //оформляем ввод с клавиатуры
            Console.WriteLine("Введите второе ненулевое число, иначе ничего не получится");    
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Сумма их квадратов = " + (a * a + b * b)); //все считаем и выводим на экран
            Console.WriteLine("Разность их квадратов = " + (a * a - b * b));
            Console.WriteLine("Произведение их квадратов = " + ((a * a) * (b * b)));
            Console.WriteLine("Частное их квадратов = " + ((a * a) / (b * b)));
            Console.ReadLine();
            */

            //Задание 5

            /*
            int a, b;
            Console.WriteLine("Введите первое ненулевое число, иначе ничего не получится");
            a = int.Parse(Console.ReadLine()); //оформляем ввод с клавиатуры
            Console.WriteLine("Введите второе ненулевое число, иначе ничего не получится");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Сумма их модулей = " + (Math.Abs(a) + Math.Abs(b))); //считаем модули и выводим на экран результаты
            Console.WriteLine("Разность их модулей = " + (Math.Abs(a) - Math.Abs(b)));
            Console.WriteLine("Произведение их модулей = " + (Math.Abs(a) * Math.Abs(b)));
            Console.WriteLine("Частное их модулей = " + (Math.Abs(a) / Math.Abs(b)));
            Console.ReadLine();
            */


        }
    }
}
