using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Лаба13
            //Задание 1
            /*
            int N, x = 1;
            Console.Write("Введите число N: ");
            N = int.Parse(Console.ReadLine());
            int[] mass = new int[N];
            for (int i = 0; i < N; i++)
            {
                mass[i] = x;
                x += 2;
                Console.Write((mass[i]) + " ");
            }
            Console.ReadLine();
            */


            //Задание 2
            /*
            int N, A, D;
            Console.Write("Введите размер массива N: ");
            N = int.Parse(Console.ReadLine());
            Console.Write("Введите первый член прогрессии А: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Введите знаменатель D: ");
            D = int.Parse(Console.ReadLine());
            int[] mass = new int[N];
            for(int i = 0; i < N; i++)
                Console.WriteLine(A * Math.Pow(D, i));
            Console.ReadLine();
            */


            //Задание 3
            /*
            int N, A, B;
            Console.Write("Введите размер массива N: ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите числа А и В: ");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            int[] mass = new int[N];
            mass[0] = A; mass[1] = B;
            for(int i = 2; i < N; i++)
                mass[i] = (mass[i - 1] + mass[i - 2]);
            for (int i = 0; i < N; i++)
                Console.Write(mass[i] + " ");
            Console.ReadLine();
            */


            //Зaдание 4
            /*
            int N;
            Console.WriteLine("Введите размер массива N: ");
            N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            Random rand = new Random();
            for (int i = 0; i < N; i++)
                Console.Write((A[i] = rand.Next(0, 100)) + " ");
            Console.WriteLine();
            for (int i = 0; i < N/2; i++)
            {
                Console.Write(A[i] + " ");
                Console.Write(A[N - (i+1)] + " ");
            }
            Console.ReadLine();
            */


            //Задание 5
            
            Console.WriteLine("Введите размер массива N: ");
            int N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            Random rand = new Random();
            for (int i = 0; i < N; i++)
                Console.Write((A[i] = rand.Next(0, 100)) + " ");
            Console.WriteLine();
            for (int i = 1; i < N; i += 2)
                Console.Write((A[i] + " "));
            for (int i = ((N-1)/2)*2; i >= 0; i -= 2)
                Console.Write((A[i]) + " ");
            Console.ReadLine();
            


        }
    }
}
