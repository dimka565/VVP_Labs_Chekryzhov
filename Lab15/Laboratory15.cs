using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Лабораторная 15
            Console.Write("Введите номер задания: ");
            int b = int.Parse(Console.ReadLine());
            switch (b)
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
            Console.Write("Введите размер массива N: ");
            int N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            int[] B = new int[N];
            int S = 0;
            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                A[i] = rand.Next(0, 100);
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < N; i++)
            {
                B[i] = rand.Next(0, 100);
                Console.Write(B[i] + " ");
            }
            for (int i = 0; i < N; i++)
            {
                S = A[i];
                A[i] = B[i];
                B[i] = S;
            }
            Console.WriteLine();
            Console.Write("Преобразованный массив А: ");
            for (int i = 0; i < N; i++)
                Console.Write(A[i] + " ");
            Console.WriteLine();
            Console.Write("Преобразованный массив B: ");
            for (int i = 0; i < N; i++)
                Console.Write(B[i] + " ");
            Console.ReadLine();
        }
        static void task2()
        {
            Console.Write("Введите размер массива N: ");
            int N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            int[] B = new int[N];
            int s = 0;
            Random rand = new Random();
            Console.Write("Массив А = ");
            for (int i = 0; i < N; i++)
            {
                A[i] = rand.Next(0, 100);
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Массив В = ");
            for (int i = 1; i <= N; i++)
            {
                s = 0;
                for (int j = 1; j <= i; j++)
                    s += A[j-1];
                s /= i;
                B[i-1] = s;
                Console.Write(B[i - 1] + " ");
            }
            Console.ReadLine();
        }
        static void task3()
        {
            Console.Write("Введите размер массива N: ");
            int N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            int s = 0;
            Random rand = new Random();
            Console.Write("Массив А = ");
            for (int i = 0; i < N; i++)
            {
                A[i] = rand.Next(0, 100);
                Console.Write(A[i] + " ");
            }
            for (int i = 0; i < N; i++)
                if (A[i] % 2 != 0)
                    s = A[i];
            Console.WriteLine();
            Console.Write("Массив А = ");
            for (int i = 0; i < N; i++)
            {
                if (A[i] % 2 != 0)
                    A[i] += s;
                Console.Write(A[i] + " ");
            }
                    Console.ReadLine();
        }
        static void task4()
        {
            Console.Write("Введите размер массива: ");
            int N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            Random rand = new Random();
            Console.Write("Массив А = ");
            for (int i = 0; i < N; i++)
            {
                A[i] = rand.Next(0, 100);
                Console.Write(A[i] + " ");
            }
            int max = A[0], min = A[0], s = 0, m = 0;
            for (int i = 0; i < N; i++)
            {
                if (A[i] > max)
                {
                    max = A[i];
                    s = i;
                }   
                if (A[i] < min)
                {
                    min = A[i];
                    m = i;
                }   
            }
            if (s > m)
                for (int i = m+1; i < s; i++)
                    A[i] = 0;
            else
                for (int i = s + 1; i < m; i++)
                    A[i] = 0;
            Console.WriteLine();
            Console.Write("Массив А = ");
            for (int i = 0; i < N; i++)
                Console.Write(A[i] + " ");
            Console.ReadLine();
        }
        static void task5()
        {
            Console.Write("Введите размер массива: ");
            int N = int.Parse(Console.ReadLine());
            int[] A = new int[N]; int s = 0;
            for (int i = 0; i < N; i++)
                A[i] = int.Parse(Console.ReadLine());
            for (int i = 1; i < N; i++)
            {
                if (A[i] < A[i-1])
                {
                    s = A[i];
                    A[i] = A[i-1];
                    A[i-1] = s;
                }
            }
            for (int i = 0; i < N; i++)
                Console.Write(A[i] + " ");
            Console.ReadLine();
        }
    }
}
