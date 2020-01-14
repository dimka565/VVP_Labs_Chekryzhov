using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Лабораторная работа 4

            //Задание 1           
            //Quest1_0();


            //Задание 2            
            //Quest2_0();


            //Задание 3
            /*
            int a, b, c;
            Console.WriteLine("Введите сколько кг конфет: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите цену " + a + " кг этих конфет: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("1 кг этих конфет стоит " + (b / a));
            Console.WriteLine("Сколько кг этих конфет вам надо?");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Цена за " + c + " кг этих конфет = " + (c * (b / a)));
            Console.ReadLine();
            */


            //Задание 4
            /*
            int v1, v2, s, t;
            Console.WriteLine("Введите скорость 1 автомобиля: ");
            v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите скорость 2 автомобиля: ");
            v2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Какое расстояние между ними (км): ");
            s = int.Parse(Console.ReadLine());
            Console.WriteLine("Через сколько часов вам нужно знать их расстояние? ");
            t = int.Parse(Console.ReadLine());
            Console.WriteLine("Расстояние между ними через " + t + " часов будет равно " + (s + t * (v1 + v2)));
            Console.ReadLine();
            */


            //Задание 5
            /*
            int a, b, x;
            Console.WriteLine("Введите А: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите B: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (-(b / a)));
            Console.ReadLine();
            */


            //Задание 6
            /*
            int a1, a2, b1, b2, D, c1, c2;

            Console.WriteLine("Введите А1, B1 и C1 по-очередно: ");
            a1 = int.Parse(Console.ReadLine());
            b1 = int.Parse(Console.ReadLine());
            c1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите А2, B2 и C2 по-очередно: ");
            a2 = int.Parse(Console.ReadLine());
            b2 = int.Parse(Console.ReadLine());
            c2 = int.Parse(Console.ReadLine());
            D = a1 * b2 - a2 * b1;
            Console.WriteLine("x = " + (c1 * b2 - c2 * b1) / D);
            Console.WriteLine("y = " + (a1 * c2 - a2 * c1) / D);
            Console.ReadLine();
            */
        }

        static void Quest1_0()
        {
            float x;
            Console.WriteLine("Введие значение угла в градусах: ");
            x = int.Parse(Console.ReadLine());
            if (x > 0 && x < 360)
            {
                Console.WriteLine("Значение угла в радианах = " + ((Math.PI * x) / 180));
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Число должно соответствовать условию 0 > x > 360");
                Quest1_0();
            }

        }
        static void Quest2_0()
        {
            float x;
            Console.WriteLine("Введие значение угла в радианах: ");
            x = int.Parse(Console.ReadLine());
            if (x > 0 && x < 2 * Math.PI)
            {
                Console.WriteLine("Значение угла в градусах = " + (x * (180 / Math.PI)));
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Число должно соответствовать условию 0 > x > 2pi");
                Quest2_0();
            }
        }
    }

}
