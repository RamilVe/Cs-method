using System;

namespace Cs_method_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            Console.WriteLine("num1: ");
            string num1Str = Console.ReadLine();
            int num1 = Convert.ToInt32(num1Str);

            Console.WriteLine("num2: ");
            string num2Str = Console.ReadLine();
            int num2 = Convert.ToInt32(num2Str);

            Console.WriteLine(Sum(num1, num2));

            #endregion


            #region Task2
            Console.WriteLine("num: ");
            string numStr = Console.ReadLine();
            int num = Convert.ToInt32(numStr);

            Console.WriteLine(Square(num));

            #endregion

            #region Task3
            Console.WriteLine("Adinizi daxil edin: ");
            string name = Console.ReadLine();

            Console.WriteLine(HasA(name));
            
            #endregion

            #region Task4

            Console.WriteLine(SumofDigits());
            #endregion

            #region Task5

            Console.WriteLine("Eded1: ");
            string num1Str = Console.ReadLine();
            int num1 = Convert.ToInt32(num1Str);

            Console.WriteLine("Eded2: ");
            string num2Str = Console.ReadLine();
            int num2 = Convert.ToInt32(num2Str);

            Console.WriteLine("Eded3: ");
            string num3Str = Console.ReadLine();
            int num3 = Convert.ToInt32(num3Str);

            Console.WriteLine("Eded4: ");
            string num4Str = Console.ReadLine();
            int num4 = Convert.ToInt32(num4Str);

            Console.WriteLine(Average(num1, num2, num3, num4)); 
            #endregion
        }



        //Verilmiş iki ədədi toplayıb nəticəsini qaytaran metod
        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        //Verilmiş ədədin kvadratını qaytaran metod

        static int Square(int num)
        {
            int squareNum = num * num;
            return squareNum;
        }

        //Verilmiş string dəyərində a hərfinin olub olmadığını qaytaran metod
        static bool HasA(string name)
        {
            var hasA = false;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == 'a')
                {
                    hasA = true;
                    break;
                }
            }
            return hasA;

        }

        //Verilmiş ədədin rəqəmləri cəmini qaytaran metod
        static int SumofDigits()
        {
            Console.WriteLine("Eded yazin: ");
            string numberStr = Console.ReadLine();
            int number = Convert.ToInt32(numberStr);
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number = (number - number % 10) / 10;
            }
            return sum;
        }

        //Verilmiş 4 ədədin ortalamasını tapıq qaytaran metod
        static int Average(int num1,int num2, int num3, int num4)
        {
            int avg = (num1 + num2 + num3 + num4) / 4;
            return avg;

        }
    }
}
