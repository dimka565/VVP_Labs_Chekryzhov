using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Лабораторная 12
            //Задание 1
            
            double b, a, i = 1;
            while (i <= 5)
            {
                Console.WriteLine("Введите число a: ");
                a = double.Parse(Console.ReadLine());
                PowerA3(a, out b);
                Console.WriteLine(b);
                i++;
            }
            Console.ReadLine();
            

            //Задание 2
            /*
            double A, B;
            Console.WriteLine("Введите А и Б по-очередно: ");
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            Console.WriteLine("Значение выражения Sign(A) + Sign(B) = " + (Sign(A) + Sign(B)));
            Console.ReadLine();
            */


            //Задание 3
            /*
            double R1, R2;
            int i = 0;
            while (i < 2) 
            {
                Console.WriteLine("Введите больший радиус кольца: ");
                R1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите меньший радиус кольца: ");
                R2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Площадь этого кольца = " + RingS(R1, R2));
                i++;
            }
            */


            //Задание 4
            /*
            double x, y;
            Console.WriteLine("Введите координату (x,y) по-очередно: ");
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            Console.WriteLine(Quarter(x, y) + " четверть.");
            Console.ReadLine();
            */


            //Задание 5
            /*
            long N;
            Console.WriteLine("Введите N: ");
            N = long.Parse(Console.ReadLine());
            Console.WriteLine("Двойной факториал вашего числа = " + Fact2(N));
            Console.ReadLine();
            */

        }

        static void PowerA3(double a, out double b)
        {
            b = Math.Pow(a, 3);
        }

        static int Sign(double x)
        {
            return x < 0 ? -1 : x == 0 ? 0 : 1;
        }

        static double RingS(double x, double y)
        {
            return ((x * Math.PI) - (y * Math.PI));
        }

        static double Quarter(double x, double y)
        {
            if (x > 0 && y > 0) return 1;
            else if (x < 0 && y > 0) return 2;
            else if (x < 0 && y < 0) return 3;
            else return 4;
        }

        static long Fact2(long N)
        {
            long res = 1;
            for (int i = N % 2 == 0 ? 2 : 1; i <= N; i += 2)
               res *= i;
            return res;
        }
    }
}


