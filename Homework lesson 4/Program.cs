using System;
using System.Linq;
namespace ConsoleApp
{
    class Program
    {

        // Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом, и
        //возвращающую число — сумму всех чисел в строке.Ввести данные с клавиатуры и вывести
        //результат на экран.

        static void Main(string[] args)
        {
            Console.WriteLine("Введите желаемые числа через пробел. ");
            var sum = Console.ReadLine().Split().Select(int.Parse).Sum();
            Console.WriteLine("Сумма введённых чисел равна : " + sum);
        }


    }      
    
}
