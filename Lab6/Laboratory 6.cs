using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Лаба 6
            //Задание 1
            /*
            int a;
            Console.WriteLine("Введите количество секунд: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Количество секунд, прошедших с начала последней минуты: " + (a - ((a/60)*60)));
            Console.ReadLine();
            */


            //Задание 2
            /*
            int a;
            Console.WriteLine("Введите номер дня: ");
            a = int.Parse(Console.ReadLine());
            a %= 7;
            switch (a)
            {
                case 0:
                    Console.WriteLine("Воскресенье");
                    break;
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
            }
            Console.ReadLine();
            */


            //Задание 3
            /*
            int a, b, i;
            Console.WriteLine("Введите номер дня (1 - 365): ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("1 января было днем (1 -7): ");
            b = int.Parse(Console.ReadLine());
            i = ((a + b - 2) % 7 + 1);
            switch (i)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
            }
            Console.ReadLine();
            */


            //Задание 4
            /*
            int a, b, c, s1, s2;
            Console.WriteLine("Введите стороны прямоугольника по-очередно: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону квадрата: ");
            c = int.Parse(Console.ReadLine());
            s1 = a * b;
            s2 = c * c;
            Console.WriteLine("Количество квадратов в прямоугольнике = " + (s1 / s2));
            Console.WriteLine("Оставшаяся площядь =  " + (s1 - s2 * (s1 / s2)));
            Console.ReadLine();
            */


            //Задание 5
            /*
            int a;
            Console.WriteLine("Введите год: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine(a + " год - " + ((a / 100) + 1) + " столетие.");
            Console.ReadLine();
            */
        }
    }
}
