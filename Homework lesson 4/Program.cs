using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_homework
{
    class program
    {
        /*Написать метод GetFullName(string firstName, string lastName, string
        patronymic), принимающий на вход ФИО в разных аргументах и возвращающий
        объединённую строку с ФИО. Используя метод, написать программу, выводящую в консоль
        3–4 разных ФИО.
        
        модификаторы тип_возвращаемого_значения название_метода(параметры)
        {
        Тело  метода
        } */


        static void Main(string[] args)
        {
            string[] users = new string[4];
            for (int i = 0; i < users.Length; i++)
            {
                users[i] = GetFullName();
            }

            foreach (string i in users)
            {
                Console.WriteLine(i);
            }

        }


        static string GetFullName()
        {
            Console.WriteLine("Введите ваше имя. ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Введите вашу фамилию. ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Введите ваше отчество. ");
            string patronymic = Console.ReadLine();

            return (firstName + " " + lastName + " " + " " + patronymic);
        }

    }

}

