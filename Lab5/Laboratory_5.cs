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
            //Лабораторная работа 5

            //Задание 1
            
            int a;
            Console.WriteLine("Введите размер файла в байтах: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Размер файла в килобайтах = " + (a/1024));
            Console.ReadLine();
            


            //Задание 2
            /*
            int a, b, i;
            i = 0;
            Console.WriteLine("Введите А и В по-очередно (А > В): ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            while (a - b >= 0)
               i++;
            Console.WriteLine("Количество отрезков В на отрезке А = " + i);
            Console.ReadLine();
            */


            //Задание 3
            /*
            int a, b, i;
            i = 0;
            Console.WriteLine("Введите А и В по-очередно (А > В): ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            while (a - b >= 0)
                i++;
            Console.WriteLine("Длина незанятой части на отрезке А = " + (a - (i*b)));
            Console.ReadLine();
            */


            //Задание 4
            /*
            int a, b, c;
            Console.WriteLine("Введите 2х значное число: ");
            a = int.Parse(Console.ReadLine());
            b = (a / 10);
            c = (a % 10);
            Console.Write(c);
            Console.Write(b);
            Console.ReadLine();
            */


            //Задание 5
            /*
            int a, b, c;
            Console.WriteLine("Введите 3х значное число: ");
            a = int.Parse(Console.ReadLine());
            b = (a % 100);
            c = (a / 100);
            Console.Write(b);
            Console.Write(c);
            Console.ReadLine();
            */
        }
    }
}
