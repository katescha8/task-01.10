using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

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
            string? ans;
            bool res=true;
            do
            { 
                try
                {
                    Console.Write("Введите число ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    if (n >= 0 && n <= 9)
                    {
                        switch (n)
                        {
                            case 0: Null(); break;
                            case 1: One(); break;
                            case 2: Two(); break;
                            case 3: Three(); break;
                            case 4: Four(); break;
                            case 5: Five(); break;
                            case 6: Six(); break;
                            case 7: Seven(); break;
                            case 8: Eight(); break;
                            case 9: Nine(); break;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Thread.Sleep(3000);
                        Console.ResetColor();
                        Console.Clear();
                        Console.WriteLine("Ошибка!!!");
                    }
                }
                catch(Exception)
                { Console.WriteLine("Неверный формат ввода "); }
                Console.WriteLine("Продолжить?");
                ans = Console.ReadLine();
                if (ans == "exit" || ans == "закрыть")
                { res = false; }
            } while (res != false) ;
        }
        public static void Task_6()
        {
            Grandfather opa1, opa2, opa3, opa4, opa5;
            string[] obscene_words = {"Бл@#ь", "3,14здец","Идите на%*#"};
            opa1.Name = "Николай Васильевич";
            opa1.level = LevelOfGrumbling.One;
            string[] s1 = {"Дураки" };
            opa1.array = s1;
            opa1.bruise = AmountOfBruise(opa1.array, obscene_words);
            Console.WriteLine(opa1.Name +"-" + opa1.bruise + " фингала(ов)");

            opa2.Name = "Александр Сергеевич";
            opa2.level = LevelOfGrumbling.Two;
            string[] s2 = { "Клеветники", "Бл@#ь" };
            opa2.array = s2;
            opa2.bruise = AmountOfBruise(opa2.array, obscene_words);
            Console.WriteLine(opa2.Name + "-"+opa2.bruise+" фингала(ов)");

            opa3.Name = "Фёдор Михайлович";
            opa3.level = LevelOfGrumbling.Three;
            string[] s3 = { "Идиоты","Паршивцы", "3,14здец" };
            opa3.array = s3;
            opa3.bruise = AmountOfBruise(opa3.array, obscene_words);
            Console.WriteLine(opa3.Name + "-"+opa3.bruise + " фингала(ов)");

            opa4.Name = "Антон Павлович";
            opa4.level = LevelOfGrumbling.One;
            string[] s4 = { "Дебилы", "3,14здец", "Идите на%*#" };
            opa4.array = s4;
            opa4.bruise = AmountOfBruise(opa4.array, obscene_words);
            Console.WriteLine(opa4.Name + "-"+opa4.bruise + " фингала(ов)");

            opa5.Name = "Владимир Владимирович";
            opa5.level = LevelOfGrumbling.One;
            string[] s5 = { "Мудаки", "3,14здец", "Идите на%*#", "Бл@#ь" };
            opa5.array = s5;
            opa5.bruise = AmountOfBruise(opa5.array, obscene_words);
            Console.WriteLine(opa5.Name + "-"+opa5.bruise + " фингала(ов)");
        }
        public static void Task_7()
        {
            int[] array = { 24, 12, 39, 100, 87, 26, 17 };
            int first = 0;
            int last = array.Length - 1;
            QuickSort(array, first, last);
            Cout(array);
        }
        static void Main(string[] args)
        {
            Task_7();
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
        public static void Five()
        {
            string s = "#";
            for (int i = 1; i < 7; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    if (i == 4 || i == 5)
                    {
                        if (j == 4)
                        { Console.Write(s); }
                        else
                        { Console.Write(" "); }
                    }
                    else if (i == 3 || i == 6)
                    {
                        if (j == 1 || j == 2 || j == 3)
                        { Console.Write(s); }
                        else
                        { Console.Write(" "); }
                    }
                    else if (i == 2)
                    {
                        if (j == 1)
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
        public static void Six()
        {
            string s = "#";
            for (int i = 1; i < 7; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    if (i == 4 || i == 5)
                    {
                        if (j ==1 || j == 4)
                        { Console.Write(s); }
                        else
                        { Console.Write(" "); }
                    }
                    else if (i == 3 || i == 6)
                    {
                        if (j == 1 || j == 2 || j == 3)
                        { Console.Write(s); }
                        else
                        { Console.Write(" "); }
                    }
                    else if (i == 2)
                    {
                        if (j == 1)
                        { Console.Write(s); }
                        else
                        { Console.Write(" "); }
                    }
                    else
                    {
                        if (j == 4 || j == 2 || j == 3)
                        { Console.Write(s); }
                        else
                        { Console.Write(" "); }
                    }
                }
                Console.WriteLine();
            }
        }
        public static void Seven()
        {
            string s = "#";
            for (int i = 1; i < 7; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    if (i == 2|| i == 3)
                    {
                        if (j == 4)
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
                        if (j == 1)
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
                    else
                    {
                         Console.Write(s);
                    }
                }
                Console.WriteLine();
            }
        }
        public static void Eight()
        {
            string s = "#";
            for (int i = 1; i < 8; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    if (i == 1 || i == 4|| i == 7)
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
        public static void Nine()
        {
            string s = "#";
            for (int i = 1; i < 8; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    if (i == 1 || i == 7 )
                    {
                        if (j == 2 || j == 3)
                        { Console.Write(s); }
                        else
                        { Console.Write(" "); }
                    }
                    else if (i == 2 || i == 6|| i == 3)
                    {
                        if (j == 1 || j == 4)
                        { Console.Write(s); }
                        else
                        { Console.Write(" "); }
                    }
                    else if (i == 5)
                    {
                        if (j == 4)
                        { Console.Write(s); }
                        else
                        { Console.Write(" "); }
                    }
                    else
                    {
                        if (j == 2|| j == 3 ||j == 4)
                        { Console.Write(s); }
                        else
                        { Console.Write(" "); }
                    }
                }
                Console.WriteLine();
            }
        }
        public enum LevelOfGrumbling
        {
            One=1,
            Two=2,
            Three=3,
            Four=4,
            Five=5
        }
        public struct Grandfather
        {
            public string Name;
            public LevelOfGrumbling level;
            public byte bruise;
            public string[] array;
        }
        public static byte AmountOfBruise(string[] array, params string[] words)
        {
            byte b = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (words[j] == array[i])
                    {
                        b++;
                    }
                }
            }
            return b;
        }
        public static void QuickSort(int[] array, int first,int last)
        {
            if (first >= last)
            {
                return;
            }
            int var = fission(array, first, last);
            QuickSort(array, first, var - 1);
            QuickSort(array, var + 1, last);
        }
        public static int fission(int[] array, int start, int end)
        {
            int temp;
            int marker = start;
            for (int i = start; i < end; i++)
            {
                if (array[i] < array[end]) 
                {
                    temp = array[marker]; 
                    array[marker] = array[i];
                    array[i] = temp;
                    marker += 1;
                }
            }
            temp = array[marker];
            array[marker] = array[end];
            array[end] = temp;
            return marker;
        }
        public static void Cout(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}