using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_lesson_4
{
    //Написать программу, вычисляющую число Фибоначчи для заданного значения
    //рекурсивным способом. Предыдущее число + Предпредыдущее число = Текущее число.

    internal class Program
    {


        static int Fibonacci(int i )
        {
            if ( i == 0 || i == 1 ) return i;
            int x = Fibonacci(i - 1) + Fibonacci(i - 2);
            Console.WriteLine(x);
            return x;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("До какого числа выводить значения Фибоначчи? ");
            int i = int.Parse(Console.ReadLine());
            if (i <= 15)
                Fibonacci(i);
            else
                Console.WriteLine("Вы ввели слишком большое число,введите число поменьше. ");
        }
    }
}
