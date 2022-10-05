using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        public static void Task_1()
        {
            Console.Write("Введите а ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите c ");
            double c = Convert.ToDouble(Console.ReadLine());
            EquatSolut(a, b, c);
        }
        public static void Task_2()
        {
            int[] array = new int[20];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Введите первое число ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == n2)
                {
                    array[i] = n1;
                    continue;
                }
                if (array[i] == n1)
                {
                    array[i] = n2;
                    continue;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        public static void Task_3()
        {
            int[] bubble = { 52, 44, 13, 26, 1 };
            BubbleSort(bubble);
        }
        public static void Task_4()
        {
            int[] array = { 52, 44, 13, 26, 1 };
            int res = 1;
            double armean;
            Console.WriteLine("Сумма " + ArrayOper(ref res, out armean, array));
            Console.WriteLine("Произведение " + res);
            Console.WriteLine("Среднее арифметическое " + armean);
        }
        public static void Task_5()
        {
            Null();
            One();
            Two();
            Three();
            Four();
        }
        public static void Task_6()
        {

        }
        public static void Task_7()
        {

        }
        static void Main(string[] args)
        {
            Task_5();
        }
        public static void EquatSolut(double a, double b, double c)
        {
            double discr = b * b - 4 * a * c;
            double x, x1, x2;
            if (discr > 0)
            {
                x1 = (-b + Math.Sqrt(discr)) / 2 * a;
                x2 = (-b - Math.Sqrt(discr)) / 2 * a;
                Console.WriteLine("Корни уравнения " + x1 + " и " + x2);
            }
            else if (discr == 0)
            {
                x = -b / 2 * a;
                Console.WriteLine("Корень уравнения " + x);
            }
            else
            { Console.WriteLine("Нет действительных корней"); }
        }
        public static void BubbleSort(params int[] bubble)
        {
            int var;
            for (int i = 0; i < bubble.Length; i++)
            {
                for (int j = 0; j < bubble.Length - 1 - i; j++)
                {
                    if (bubble[j] > bubble[j + 1])
                    {
                        var = bubble[j];
                        bubble[j] = bubble[j + 1];
                        bubble[j + 1] = var;
                    }
                }
            }
            for (int k = 0; k < bubble.Length; k++)
            {
                Console.Write(bubble[k] + " ");
            }
        }
        public static double ArrayOper(ref int res, out double armean, params int[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                res *= array[i];
            }
            armean = sum / array.Length;
            return sum;
        }
        public static void Null()
        {
            string s = "#";
            for (int i = 1; i < 7; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    if (i == 1 || i == 6)
                    {
                        if (j == 2 || j == 3)
                        { Console.Write(s); }
                        else
                        { Console.Write(" "); }
                    }
                    else
                    {
                        if (j == 1 || j == 4)
                        { Console.Write(s); }
                        else
                        { Console.Write(" "); }
                    }
                }
                Console.WriteLine();
            }
        }
        public static void One()
        {
            string s = "#";
            for (int i = 1; i < 7; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    if (i == 2)
                    {
                        if (j == 3 || j == 4)
                        { Console.Write(s); }
                        else
                        { Console.Write(" "); }
                    }
                    else if (i == 3)
                    {
                        if (j == 2 || j == 4)
                        { Console.Write(s); }
                        else
                        { Console.Write(" "); }
                    }
                    else if (i == 4)
                    {
                        if (j == 1 || j == 4)
                        { Console.Write(s); }
                        else
                        { Console.Write(" "); }
                    }
                    else
                    {
                        if (j == 4)
                        { Console.Write(s); }
                        else
                        { Console.Write(" "); }
                    }
                }
                Console.WriteLine();
            }
        }
        public static void Two()
        {
            string s = "#";
            for (int i = 1; i < 7; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    if (i == 2)
                    {
                        if (j == 1 || j == 4)
                        { Console.Write(s); }
                        else
                        { Console.Write(" "); }
                    }
                    else if (i == 3)
                    {
                        if (j == 4)
                        { Console.Write(s); }
                        else
                        { Console.Write(" "); }
                    }
                    else if (i == 4)
                    {
                        if (j == 3)
                        { Console.Write(s); }
                        else
                        { Console.Write(" "); }
                    }
                    else if (i == 5)
                    {
                        if (j == 2)
                        { Console.Write(s); }
                        else
                        { Console.Write(" "); }
                    }
                    else if (i == 6)
                    {
                        Console.Write(s);
                    }
                    else if (i == 1)
                    {
                        if (j == 2 || j == 3)
                        { Console.Write(s); }
                        else
                        { Console.Write(" "); }
                    }
                }
                Console.WriteLine();
            }
        }
        public static void Three()
        {
            string s = "#";
            for (int i = 1; i < 8; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    if (i == 1 || i == 7 || i == 4)
                    {
                        if (j == 2 || j == 3)
                        { Console.Write(s); }
                        else
                        { Console.Write(" "); }
                    }
                    else if (i == 2 || i == 6)
                    {
                        if (j == 1 || j == 4)
                        { Console.Write(s); }
                        else
                        { Console.Write(" "); }
                    }
                    else
                    {
                        if (j == 4)
                        { Console.Write(s); }
                        else
                        { Console.Write(" "); }
                    }
                }
                Console.WriteLine();
            }
        }
        public static void Four()
        {
            string s = "#";
            for (int i = 1; i < 7; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    if (i == 1 || i == 2 || i == 3)
                    {
                        if (j == 1 || j == 4)
                        { Console.Write(s); }
                        else
                        { Console.Write(" "); }
                    }
                    else if (i == 5 || i == 6)
                    {
                        if (j == 4)
                        { Console.Write(s); }
                        else
                        { Console.Write(" "); }
                    }
                    else
                    {
                        Console.Write(s);
                    }
                }
                Console.WriteLine();
            }

        }
    }
}