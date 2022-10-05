using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;

namespace ClassWork4
{
    class Program
    {
        public static void Task_5_1()
        {
            Console.Write("Введите первое число ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число ");
            int b = Convert.ToInt32(Console.ReadLine());    
            Console.WriteLine("Максимальное значение " + Max(a,b));
        }
        public static void Task_5_2()
        {
            Console.Write("Введите первое число ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число ");
            int b = Convert.ToInt32(Console.ReadLine());
            Swap(ref a,ref b);
        }
        public static void Task_5_3()
        {
            Console.Write("Введите число ");
            int a = Convert.ToInt32(Console.ReadLine());
            bool res;
            long factor;
            Factorial(a, out res, out factor);
            if (res == true)
            { Console.WriteLine(factor); }
            else
            { Console.WriteLine(res); }
        }
        public static void Task_5_4()
        {
            Console.Write("Введите число ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Factorial(a));
        }
        public static void HomeTask_5_1()
        {
            Console.Write("Введите первое число ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье число ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Euclid(a,b));
        }
        public static void HomeTask_5_2()
        {
            Console.Write("Введите порядковый номер числа ряда Фибоначчи ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fibonachi(n));
        }
        static void Main(string[] args)
        {
            HomeTask_5_1();
        }
        public static int Max(int a, int b)
        {
            if (a >= b)
            {
                return a;
            }
            if (b > a)
            {
                return b;
            }
            return 0;
        }
        public static void Swap(ref int a, ref int b)
        {
            int n = a;
            a = b;
            b = n;
            Console.WriteLine("a=" + a + ", b=" + b);
        }
        public static void Factorial(int a, out bool res, out long f)
        {
            long factor = 1;
            f = 0;
            try
            {
                checked
                {
                    for (int i = 1; i < a + 1; i++)
                    {
                        factor *= i;
                    }
                    res = true;
                }
                f = factor;
            }
            catch (OverflowException)
            {
                res = false;
            }
        }
        public static long Factorial(int a)
        {
            long factor = 0;
            if (a == 1)
            { factor = 1; }
            else
            { factor = a * Factorial(a - 1); }
            return factor;
        }
        public static int Fibonachi(int n)
        {
            if (n == 0 || n == 1)
            { return n; }
            else
            { return Fibonachi(n - 1) + Fibonachi(n - 2); }
        }
        public static int Euclid(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a = a % b;
                }
                else
                { b = b % a; }
            }
            return a + b;
        }
        public static int Euclid(int a, int b, int c)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a = a % b;
                }
                else
                { b = b % a; }
            }
            while (c != 0 && b != 0)
            {
                if (c > b)
                {
                    c = c % b;
                }
                else
                {
                    b = b % c;
                }
            }
            return Max(a + b, b + c);
        }
    }
}
