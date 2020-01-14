using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Лабораторная 11
            //Задание 1
            
            int A, B;
            Console.WriteLine("Введите число A: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число B: ");
            B = int.Parse(Console.ReadLine());
            for (int i = A; i <= B; i++)
                for (int j = 0; j < i; j++)
                    Console.WriteLine(i);
            Console.ReadLine();
            


            //Задание 2
            /*
            int A, B, s = 0;
            Console.WriteLine("Введите число A: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число B: ");
            B = int.Parse(Console.ReadLine());
            while (A - B >= 0)
            {
                A -= B;
                s++;
            }
            Console.WriteLine(s);
            Console.ReadLine();
            */


            //Задание 3
            /*
            int N, K = 0, i = 0;
            Console.WriteLine("Введите N: ");
            N = int.Parse(Console.ReadLine());
            while (i <= N)
            {
                K++;
                i += K; 
            }
            Console.WriteLine("Сумма = " + i + "\nЧисло K = " + K);
            Console.ReadLine();
            */


            //Задание 4
            /*
            double P, K = 0, S = 1000;
            Console.WriteLine("Введите процент 0 < P < 25: ");
            P = double.Parse(Console.ReadLine());
            while (S < 1100)
            {
                S += (S*(P/100));
                K++;
            }
            Console.WriteLine("Через " + K + " месяцев вклад привысит 1100р." + "\nИтоговый вклад = " + S + "р.");
            Console.ReadLine();
            */


            //Задание 5
            /*
            int A, B;
            Console.WriteLine("Введите число A: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число B: ");
            B = int.Parse(Console.ReadLine());
            if (A == B) Console.WriteLine(A);
            else
            {
                if (A > B) A -= B;
                else B -= A;
                Console.WriteLine(A);
            }
            Console.ReadLine();
            */


            //Задание 6
            /*
            int N, K = 0, i;
            int[] Arr = new int[100];
            Console.WriteLine("Введите число Фибоначчи N: ");
            N = int.Parse(Console.ReadLine());
            Arr[0] = 0;
            Arr[1] = 1;
            for (i = 2; i < 100; i++)
            {
                Arr[i] = Arr[i - 1] + Arr[i - 2];
                if (N == Arr[i]) K = i;
            }
            Console.WriteLine("Ваше число находится на " + K +" месте");
            Console.ReadLine();
            */
        }
    }
}
