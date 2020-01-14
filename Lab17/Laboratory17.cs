using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
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
            Console.Write("Введите размер массива A: ");
            int N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
                A[i] = int.Parse(Console.ReadLine());
            int k = 0;
            int[] B = new int[N];
            int[] C = new int[N];
            for (int i = 0; i < N - 1; i++)
            {
                int j = 1;
                while (A[i] == A[i + 1] && i != N - 2)
                {
                    j++;
                    i++;
                }
                if (i == N - 2 && A[N - 2] == A[N - 1])
                    j++;
                B[k] = j;
                C[k] = A[i];
                k++;
            }
            if (A[N - 1] != A[N - 2])
            {
                B[k] = 1;
                C[k] = A[N - 1];
                k++;
            }
            Console.WriteLine();
            for (int i = 0; i < k; i++)
                Console.WriteLine(B[i] + "\t" + C[i]);
            Console.ReadLine();
        }
        static void task2()
        {
            Console.Write("Введите размер массива: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[N];
            int i, j, k = 1, m = 0;
            Console.Write("Введите число L: ");
            int L = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < N; i++)
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < N - 1; i++)
            {
                if (A[i] == A[i + 1])
                {
                    k += 1;
                }
                else
                {
                    m = k;
                    k = 1;
                }
                if (m != 0)
                {
                    if (m > L)
                    {
                        for (j = 0; j < m; j++)
                        {
                            A[i - j] = 0;
                        }
                    }
                }
            }
            k = 0;
            for (i = 0; i < N; i++)
            {
                if (A[i] == 0)
                {
                    k += 1;
                }
                else
                {
                    k = 0;
                }
                if (k < 2)
                {
                    Console.Write(A[i] + " ");
                }
            }
            Console.ReadKey();
        }
        static void task3()
        {
            Console.WriteLine("Введите размер массива: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[N];
            int i, j, k = 1, m = 0, a = 0, b = 0, c = 0, d = 1;
            Console.WriteLine("Введите число K: ");
            int K = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < N; i++)
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < N; i++)
            {
                if (i != N - 1)
                {
                    if (A[i] == A[i + 1])
                    {
                        k++;
                    }
                    else
                    {
                        m++;
                        if (m == K)
                        {
                            b = k;
                            a = A[i];
                        }
                        k = 1;
                    }
                }
                else
                {
                    c = A[i];
                    j = N - 2;
                    while (A[i] == A[j])
                    {
                        d++;
                        j--;
                    }
                }
            }
            m = 0;
            i = 0;
            while (m != K - 1)
            {
                Console.Write(A[i] + " ");
                if (A[i] != A[i + 1]) m++;
                i++;
            }
            for (j = 0; j < d; j++)
            {
                Console.Write(c + " ");
            }
            i++;
            while (A[i] != c)
            {
                Console.Write(A[i] + " ");
                i++;
            }
            for (j = 0; j < b; j++)
            {
                Console.Write(a + " ");
            }
            Console.ReadKey();
        }
        static void task4()
        {
            int x1, x2, y1, y2, d1, d2;
            Console.Write("Введите координаты 1 точки: ");
            x1 = int.Parse(Console.ReadLine());
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введите координаты 2 точки: ");
            x2 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());
            d1 = Math.Sqrt((x1 * x1) + (y1 * y1));
            d2 = Math.Sqrt((x2 * x2) + (y2 * y2));
            if (d1 > d2)
                Console.WriteLine("Первая точка дальше от начала координат.");
            else if (d2 > d1)
                Console.WriteLine("Вторая точка дальше от начала координат.");
            else
                Console.WriteLine("Точки на одинаковом расстоянии.");
            Console.ReadLine();
        }
        static void task5()
        {

        }
    }
}