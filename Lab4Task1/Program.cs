using System;
using static System.Console;
using static System.Math;

namespace Lab4
{
    partial class Task1
    {
        public static Dictionary<char, Func<MyFrac, MyFrac, MyFrac>> dict = new Dictionary<char, Func<MyFrac, MyFrac, MyFrac>>()
        {
            {'+',Plus},
            {'-',Minus},
            {'*',Multiply},
            {'/',Divide},
        };
        public static string ToStringWithIntPart(MyFrac drib)
        {
            if (drib.nom / drib.denom != 0&&drib.nom%drib.denom!=0)
            {
                long chastka = drib.nom / drib.denom;
                long ostacha = drib.nom % drib.denom;
                if (chastka < 0)
                {
                    return "-(" + chastka + "+" + new MyFrac(ostacha, drib.denom) + ")";
                }
                else
                {
                    return "(" + chastka + "+" + new MyFrac(ostacha, drib.denom) + ")";
                }
            }
            else if (drib.nom % drib.denom == 0)
            {
                return "("+drib.nom / drib.denom+")";
            }
            else
            {
                return drib.ToString();
            }
        }

        public static double DoubleValue(MyFrac drib)
        {
            return drib.nom / (double)drib.denom;
        }

        public static MyFrac Plus(MyFrac first, MyFrac second)
        {
            long nom = first.nom * second.denom + second.nom * first.denom;
            long denom = first.denom * second.denom;
            return new MyFrac(nom, denom);
        }

        public static MyFrac Minus(MyFrac first, MyFrac second)
        {
            long nom = first.nom * second.denom - second.nom * first.denom;
            long denom = first.denom * second.denom;
            return new MyFrac(nom, denom);
        }

        public static MyFrac Multiply(MyFrac first, MyFrac second)
        {
            long nom = first.nom * second.nom;
            long denom = first.denom * second.denom;
            return new MyFrac(nom, denom);
        }

        public static MyFrac Divide(MyFrac first, MyFrac second)
        {
            long nom = first.nom * second.denom;
            long denom = first.denom * second.nom;
            return new MyFrac(nom, denom);
        }

        public static MyFrac CalcExpr1(int length)
        {
                MyFrac result = new MyFrac(0, 1);
                int i = 1;
                while (i <= length)
                {
                    MyFrac add = new MyFrac(1, i * (i + 1));
                    result = Plus(result, add);
                    i++;
                }

                return result;
        }

        public static MyFrac CalcExpr2(int length)
        {
            MyFrac result = new MyFrac(1,1);
            for (int i = 2; i <=length; i++)
            {
                MyFrac drib = new MyFrac(1,i*i);
                MyFrac difference = Minus(new MyFrac(1, 1), drib);
                result = Multiply(result, difference);
            }
            return result;
        }


        public static void Main()
        {
            try
            {
                WriteLine("Введіть чисельник та знаменник першого дробу");
                int a = int.Parse(ReadLine());
                int b = int.Parse(ReadLine());

                WriteLine("\nВведіть чисельник та знаменник другого дробу");
                int c = int.Parse(ReadLine());
                int d = int.Parse(ReadLine());

                WriteLine("\nДійсні значення дробів: ");
                WriteLine("1 дріб: " + DoubleValue(new MyFrac(a, b)));
                WriteLine("2 дріб: " + DoubleValue(new MyFrac(c, d)));

                WriteLine("\nТепер виведемо мішані числа якщо вони є");
                WriteLine(ToStringWithIntPart(new MyFrac(a, b)));
                WriteLine(ToStringWithIntPart(new MyFrac(c, d)));

                Write("\nВведіть символ тої операції, яку хочете задіяти: ");
                char operation = char.Parse(ReadLine());

                WriteLine("Результат роботи");
                WriteLine(dict[operation](new MyFrac(a,b),new MyFrac(c,d)));

                WriteLine("\nВведіть тепер значення 'n' ");
                int length = int.Parse(ReadLine());
                WriteLine("Перше значення: "+CalcExpr1(length));
                WriteLine("Друге значення: "+CalcExpr2(length));
            }
            catch (Exception ex)
            {
                WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
