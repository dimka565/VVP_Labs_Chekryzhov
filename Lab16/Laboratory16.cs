using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер задания: ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
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
            Console.Write("Введите размер массива: ");
            int N = int.Parse(Console.ReadLine());
            int[] A = new int[N+1];
            for (int i = 0; i < N; i++)
                A[i] = int.Parse(Console.ReadLine());
            A[N - 1] = 0;
            for (int i = 0; i < N; i++)
            {
                if(A[i] == A[i+1])
                    A[i] = 0;
            }
            Console.WriteLine();
            for (int i = 0; i < N; i++)
                if (A[i] != 0) Console.Write(A[i] + " ");
            Console.ReadLine();
        }
        static void task2()
        {
            Console.Write("Введите размер массива: ");
            int N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
                A[i] = int.Parse(Console.ReadLine());
            int s = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = i+1; j < N; j++)
                {
                    if (A[i] == A[j])
                        s++;
                }
            }
            int M = N;
            if (s < 3)
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = i + 1; j < N; j++)
                    {
                        if (A[i] == A[j])
                        {
                            A[i] = 0;
                            A[j] = 0;
                            M -= 2;
                        }
                    }
                }
            }
            else M++;
            Console.Write("Количество элементов массива = " + (M));
            Console.WriteLine();
            Console.Write("Массив: ");
            Console.WriteLine();
            for (int i = 0; i < N; i++)
            {
                if (A[i] != 0)
                    Console.Write(A[i] + " ");
            }
            Console.ReadLine();
        }
        static void task3()
        { 
            Console.Write("Введите размер массива: ");
            int N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            Random rand = new Random();
            for (int i = 0; i < N; i++)
                A[i] = rand.Next(0, 100);
            for (int i = 0; i < N; i++)
                Console.Write(A[i] + " ");
            int max = A[0], min = A[0], s1 = 0, s2 = 0;
            for (int i = 1; i < N; i++)
            {
                if(max < A[i])
                    max = A[i];
                if (min > A[i])
                    min = A[i];
            }
            Console.WriteLine();
            for (int i = 0; i < N; i++)
            {
                if (A[i] == max) Console.Write("0 " + A[i] + " ");
                else if (A[i] == min) Console.Write(A[i] + " 0 ");
                else Console.Write(A[i] + " ");
            }
            Console.ReadLine();
        }
        static void task4()
        {
            Console.Write("Введите размер масива: ");
            int N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            Random rand = new Random();
            for (int i = 0; i < N; i++)
                A[i] = rand.Next(-10, 10);
            for (int i = 0; i < N; i++)
                Console.Write(A[i] + " ");
            Console.WriteLine();
            for (int i = 0; i < N; i++)
            {
                if (A[i] < 0) Console.Write(A[i] + " 0 ");
                else Console.Write(A[i] + " ");
            }
            Console.ReadLine();
        }
        static void task5()
        {
            Console.Write("Введите размер масива: ");
            int N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            Random rand = new Random();
            for (int i = 0; i < N; i++)
                A[i] = rand.Next(-10, 10);
            for (int i = 0; i < N; i++)
                Console.Write(A[i] + " ");
            Console.WriteLine();
            for (int i = 0; i < N; i++)
            {
                if (A[i] > 0) Console.Write("0 " + A[i] + " ");
                else Console.Write(A[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
