using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Лабараторная 14
            Console.WriteLine("Введите номер задания: ");
            int M = int.Parse(Console.ReadLine());
            switch (M)
            {
                case 1: task1(); break;
                case 2: task2(); break;
                case 3: task3(); break;
                case 4: task4(); break;
                case 5: task5(); break;
            }
           



        }

        static void task1()
        {
            int K, L, m = 0, b = 0;
            Console.Write("Введите длину массива N: ");
            int s = int.Parse(Console.ReadLine());
            Console.Write("Введите K: ");
            K = int.Parse(Console.ReadLine());
            Console.Write("Введите L: ");
            L = int.Parse(Console.ReadLine());
            int[] N = new int[s];
            for (int i = 0; i < s; i++)
                N[i] = int.Parse(Console.ReadLine());
            for (int i = (K - 1); i < L; i++)
            {
                m += N[i];
                b++;
            }
            Console.WriteLine("Среднее арифметическое от K до L = " + (m / b));
            Console.ReadLine();
        }
        static void task2()
        {
            int a = 0, d;
            Console.Write("Введите размер массива N: ");
            int s = int.Parse(Console.ReadLine());
            int[] N = new int[s];
            for (int i = 0; i < s; i++)
                N[i] = int.Parse(Console.ReadLine());
            d = N[2] - N[1];
            for (int i = 1; i < s; i++)
            {
                if (N[i] - N[i - 1] == d)
                    a = 1;
                else
                    a = 0;
            }
            Console.WriteLine("Результат = " + a);
            Console.ReadLine();
                



        }
        static void task3()
        {
            int A;
            Console.Write("Введите размер массива N: ");
            int s = int.Parse(Console.ReadLine());
            int[] N = new int[s];
            Random rand = new Random();
            for (int i = 0; i < s; i++)
            {
                N[i] = rand.Next(0, 100);
                Console.Write(N[i] + " ");
            }
            A = N[1];
            for (int i = 0; i < s; i += 2)
                if (N[i] < A)
                    A = N[i];
            Console.WriteLine("Минимальное чилсло с четным номером = " + A);
            Console.ReadLine();

        }
        static void task4()
        {
            int A = 0;
            Console.Write("Введите размер массива N: ");
            int s = int.Parse(Console.ReadLine());
            int[] N = new int[s];
            Random rand = new Random();
            for (int i = 0; i < s; i++)
            {
                N[i] = rand.Next(0, 100);
                Console.Write(N[i] + " ");
            }
            for (int i = 1; i < s-1; i++)
                if ((N[i] > N[i - 1]) && (N[i] > N[i + 1]))
                    A = i;
            Console.WriteLine("Локальный максимум = " + (A+1));
            Console.ReadLine();
        }
        static void task5()
        {
            Console.Write("Введите размер массива N: ");
            int s = int.Parse(Console.ReadLine());
            int[] N = new int[s];
            for (int i = 0; i < s; i++)
                N[i] = int.Parse(Console.ReadLine());
            for (int i = 0; i < s; i++)
                for (int j = i+1; j < (s); j++)
                    if (N[i] == N[j])
                        Console.WriteLine("Номера " + i + " и " + j + " одинаковые");
            Console.ReadLine();
        }






    }
}
