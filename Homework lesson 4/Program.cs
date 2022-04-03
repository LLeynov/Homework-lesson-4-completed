using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;

namespace Homework_lesson_4
{
    /*Написать метод по определению времени года. На вход подаётся число – порядковый номер
    месяца. На выходе — значение из перечисления (enum) — Winter, Spring, Summer,
    Autumn. Написать метод, принимающий на вход значение из этого перечисления и
    возвращающий название времени года (зима, весна, лето, осень). Используя эти методы,
    ввести с клавиатуры номер месяца и вывести название времени года. Если введено
    некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».*/
    internal class Program
    {
        enum Currentmonth
        {
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12,
        }
        enum Timeofyear
        {
            Winter = 1,
            Spring = 2,
            Summer = 3,
            Autumn = 4,
        }
        
        static void Main(string[] args)
        {           
           Console.WriteLine("Введите желаемое число от 1 до 12 (число является порядковым номером месяца). ");
           int a = int.Parse(Console.ReadLine());
           //Console.WriteLine((Currentmonth)a);

           if (a == 1)
            {
                Console.WriteLine("Успех");
            }
            else
            {
                break;
            } 
            
        }
        
    }
}
