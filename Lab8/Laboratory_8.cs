using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int n, v;
            Console.WriteLine("Введите направление (С, З, Ю, В): ");
            string c = string.Format(Console.ReadLine());
            v = 0;
            if (c == "С" || c == "c") { v = 0; }
            else if (c == "З" || c == "з") { v = 0; }
            else if (c == "Ю" || c == "ю") { v = 0; }
            else if (c == "В" || c == "в") { v = 0; }
            string[] nap = { "Север", "Запад", "Юг", "Восток" };
            Console.WriteLine("Введите команду: ");
            n = int.Parse(Console.ReadLine());
            if (n == 0 || n == 1 || n == -1)
            {
                v = (v + n) % 4;
                Console.WriteLine("Нынешнее направление робота: " + nap[v]);
            }
            Console.ReadLine();
            */

            //Лабораторная 9
            //Задание 1
            /*
            int A, B;
            string[] S = new string[9] { "первое ", "второе ", "третье ", "четвертое ", "пятое ", "шестое ", "седьмое ", "восьмое ", "девятое " };
            string[] D = new string[9] { "одинадцатое ", "двенадцатое ", "тринадцатое ", "четырнадцатое ", "пятнадцатое ", "шестнадцатое ", "семнадцатое ", "восемнадцатое ", "девятнадцатое " };
            string[] M = new string[12] { "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября", "октября", "ноября", "декабря" };
            Console.WriteLine("Введите номер дня: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер месяца: ");
            B = int.Parse(Console.ReadLine());
            if (A < 10) Console.WriteLine(S[A - 1]);
            else if (A < 20) Console.WriteLine(D[A % 10 - 1]);
            else if (A < 30) Console.WriteLine("двадцать " + (S[A % 10 - 1]));
            else if (A == 10) Console.WriteLine("десятое ");
            else if (A == 20) Console.WriteLine("двадцатое ");
            else if (A == 30) Console.WriteLine("тридцатое ");
            else Console.Write("тридцать первое ");
            if (B < 13) Console.Write(M[B - 1]);
            Console.ReadLine();
            */


            //Задание 2
            /*
            task2();
            */


            //Задание 3
            /*
            task3();
            */


            //Задание 4
            /*
            task4();
            */

            //Задание 5

            int N, k;
            string s;
            string[] Animals = new string[] { " крысы", " коровы", " тигра", " зайца", " дракона", " змеи", " лошади", " овцы", " обезьяны", " курицы", " собаки", " свиньи" };
            string[] Colors1 = new string[] { "зеленой", "красной", "желтой", "белой", "черной" };
            string[] Colors2 = new string[] { "зеленого", "красного", "желтого", "белого", "черного" };
            Console.WriteLine("Введите год: ");
            N = int.Parse(Console.ReadLine());
            k = N % 60;
            //Console.Write(Colors1[k % 12]);
            Console.Write(Animals[k % 12 - 4]);
            Console.ReadLine();








        }


        static void task2()
        {
            string[] way = new string[4] { "Север", "Юг", "Запад", "Восток" };
            string[] com = new string[3] { "Продолжать движение", "Поворот налево", "Поворот направо" };
            int n;
            string a, s, d;
            Console.WriteLine("Введите направление робота (С, Ю, З, В): ");
            a = Console.ReadLine();
            Console.WriteLine("Введите команду (0, 1, -1): ");
            n = int.Parse(Console.ReadLine());
            s = "";
            d = "";
            if (a == "С")
                s = way[0];
            else if (a == "Ю")
                s = way[1];
            else if (a == "З")
                s = way[2];
            else if (a == "В")
                s = way[3];
            else
            {
                Console.WriteLine("Вы ввели не существующую команду, попробуйте еще раз.");
                task2();
            }
            if (n == 0)
                d = com[0];
            else if (n == 1)
                d = com[1];
            else if (n == -1)
                d = com[2];
            else
            {
                Console.WriteLine("Вы ввели не существующую команду, попробуйте еще раз.");
                task2();
            }
            Console.WriteLine(s + " " + d);
            Console.ReadLine();
        }

        static void task3()
        {
            string[] tens = new string[] { "Десять", "Двадцать", "Тридцать", "Сорок" };
            string[] ones = new string[] { "Одно", "Два", "Три", "Четыре", "Пять", "Шесть", "Семь", "Восемь", "Девять" };
            string[] others = new string[] { "Одиннадцать", "Двенадцать", "Тринадцать", "Четырнадцать", "Пятнадцать", "Шестнадцать", "Семнадцать", "Восемнадцать", "Девятнадцать" };
            int x;
            string p;
            Console.WriteLine("Введите число от 10 до 40: ");
            x = int.Parse(Console.ReadLine());
            if ((x < 10) || (x > 40))
                task3();
            if (x == 10 || x == 20 || x == 30 || x == 40)
                Console.WriteLine(tens[x / 10 - 1] + " Учебных заданий");
            if ((x / 10 == 1) && (x % 10 != 0))
                Console.WriteLine(others[x % 10 - 1] + " Учебных заданий");
            if ((x / 10 == 2) && (x % 10 != 0) && (x % 10 > 3))
                Console.WriteLine(tens[x / 10 - 1] + " " + ones[x % 10 - 1] + " Учебных заданий");
            else if ((x / 10 == 2) && (x % 10 > 1) && (x % 10 <= 3))
                Console.WriteLine(tens[x / 10 - 1] + " " + ones[x % 10 - 1] + " Учебных задания");
            else if ((x / 10 == 2) && (x % 10 == 1))
                Console.WriteLine(tens[x / 10 - 1] + " " + ones[x % 10 - 1] + " Учебное задание");
            if ((x / 10 == 3) && (x % 10 != 0) && (x % 10 > 3))
                Console.WriteLine(tens[x / 10 - 1] + " " + ones[x % 10 - 1] + " Учебных заданий");
            else if ((x / 10 == 3) && (x % 10 > 1) && (x % 10 <= 3))
                Console.WriteLine(tens[x / 10 - 1] + " " + ones[x % 10 - 1] + " Учебных задания");
            else if ((x / 10 == 3) && (x % 10 == 1))
                Console.WriteLine(tens[x / 10 - 1] + " " + ones[x % 10 - 1] + " Учебное задание");
            Console.ReadLine();

        }

        static void task4()
        {
            string[] hundreds = new string[] { "Сто ", "Двести ", "Триста ", "Четыреста ", "Пятьсот ", "Шестьсот ", "Семьсот ", "Восемьсот ", "Девятьсот ", };
            string[] tens = new string[] { "десять", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто", };
            string[] ones = new string[] { " один", " два", " три", " четыре", " пять", " шесть", " семь", " восемь", " девять", };
            int a;
            string d1, d2, d3;
            d1 = "";
            d2 = "";
            d3 = "";
            Console.WriteLine("Введите число от 100 до 999: ");
            a = int.Parse(Console.ReadLine());
            if ((a < 100) || (a > 999))
                task4();
            if ((a / 100 == 1) || (a / 100 == 2) || (a / 100 == 3) || (a / 100 == 4) || (a / 100 == 5) || (a / 100 == 6) || (a / 100 == 7) || (a / 100 == 8) || (a / 100 == 9))
                d1 = hundreds[a / 100 - 1];
            if ((a % 100 / 10 == 1) || (a % 100 / 10 == 2) || (a % 100 / 10 == 3) || (a % 100 / 10 == 4) || (a % 100 / 10 == 5) || (a % 100 / 10 == 6) || (a % 100 / 10 == 7) || (a % 100 / 10 == 8) || (a % 100 / 10 == 9))
                d2 = tens[a % 100 / 10 - 1];
            if ((a % 10 == 1) || (a % 10 == 2) || (a % 10 == 3) || (a % 10 == 4) || (a % 10 == 5) || (a % 10 == 6) || (a % 10 == 7) || (a % 10 == 8) || (a % 10 == 9))
                d3 = ones[a % 10 - 1];
            Console.WriteLine(d1 + d2 + d3);
            Console.ReadLine();
        }


    }
}
