using System;


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

        enum SeasonTimeEng
        {
            NaN = 0,
            Winter = 1,
            Spring = 2,
            Summer = 3,
            Autumn = 4,

        }


        static string translated(string chosedmonth)
        {

            if (chosedmonth == "Winter")
            { return "зима"; }
            else if (chosedmonth == "Spring")
            { return "весна"; }
            else if (chosedmonth == "Summer")
            { return "лето"; }
            else if (chosedmonth == "Autumn")
            { return "осень"; }
            else
            { return "Ошибка: введите число от 1 до 12"; }
        }

        static string ChooseMonth(int a)
        {
            if (a == 1 || a == 2 || a == 12)
            { return SeasonTimeEng.Winter.ToString(); }

            else if (a == 3 || a == 4 || a == 5)
            { return SeasonTimeEng.Spring.ToString(); }

            else if (a == 6 || a == 7 || a == 8)
            { return SeasonTimeEng.Summer.ToString(); }

            else if (a == 9 || a == 10 || a == 11)
            { return SeasonTimeEng.Autumn.ToString(); }

            else
            { return SeasonTimeEng.NaN.ToString(); ; }
        }

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Введите желаемое число от 1 до 12 (число является порядковым номером месяца). ");
                int MonthNumber = int.Parse(Console.ReadLine());

                string chosedmonth = ChooseMonth(MonthNumber);
                string endedshit = translated(chosedmonth);
                Console.WriteLine(endedshit);

            }
            while (true);
        }
    }
}
