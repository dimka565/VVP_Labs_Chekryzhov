using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Лаба 10
            //Задание 1
            
            double N;
            Console.WriteLine("Введите цену за 1 кг конфет: ");
            N = double.Parse(Console.ReadLine());
            for (double i = 1; i < 10; i++)
                Console.WriteLine(i / 10 + " кг конфет стоят " + i * N / 10);
            Console.ReadLine();
            



            //Задание 2
            /*
            double N, s = 1;
            Console.WriteLine("Введите число N: ");
            N = double.Parse(Console.ReadLine());
            for (double i = 0; i <= N / 10; i += 0.1)
                s *= (i + 1);
            Console.WriteLine(s);
            Console.ReadLine();
            */


            //Задание 3
            /*
            int N, N2 = 0;
            Console.WriteLine("Введите число N: ");
            N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                N2 += (2 * i - 1);
                Console.WriteLine(N2);
            }
            Console.ReadLine();
            */


            //Задание 4
            /*
            int N, A, s = 0;
            Console.WriteLine("Введите число А: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите степерь N: ");
            N = int.Parse(Console.ReadLine());
            for (int i = 0; i <= N; i++)
            {
                s += Convert.ToInt32(Math.Pow(A, i));
            }
            Console.WriteLine(s);
            Console.ReadLine();
            */



            //Задание 5
            /*
            int N, A, s = 0;
            Console.WriteLine("Введите число А: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите степерь N: ");
            N = int.Parse(Console.ReadLine());
            for (int i = 0; i <= N; i++)
            {
                s = -s;
                s += Convert.ToInt32(Math.Pow(A, i));
            }
            Console.WriteLine(s);
            Console.ReadLine();
            */
        }
    }
}
