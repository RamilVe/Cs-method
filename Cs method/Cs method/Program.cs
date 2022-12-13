using System;

namespace Cs_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            var result = Increment(number);

            Console.WriteLine(result);
            Console.WriteLine(Increment(100));

            string fullname = MakeFullname("Hikmet", "Abbasov"); //Hikmet Abbasov

            Console.WriteLine(fullname);

            int num1 = GetNumber();
            Console.WriteLine(num1);

            var sumResult = Sum(143, 54);

            Console.WriteLine(sumResult);
            Console.WriteLine(Sum(340, 55));

            Console.WriteLine(GetAndSumTwo());

            SumShow(10, 99);
        }


        static int Increment (int num)
        {
            num += 1;
            return num;
        }

        static string MakeFullname(string name, string surname)
        {
            //var fn = name + " " + surname;
            var fn = $"{name} {surname}";
            return fn;
        }

        static int GetNumber()
        {
            string numberStr = Console.ReadLine();
            return Convert.ToInt32(numberStr);
        }

        static int Sum(int num1, int num2)
        {
            //var sum = num1 + num2;
            //return sum;

            return num1 + num2;
        }

        static void SumShow(int num1, int num2)
        {
            var sum = num1 + num2;
            Console.WriteLine(sum);
        }


        static int GetAndSumTwo()
        {
            Console.WriteLine("num1: ");
            var num1 = GetNumber();

            Console.WriteLine("num2: ");
            var num2 = GetNumber();

            return num1 + num2;

        }


    }
}
