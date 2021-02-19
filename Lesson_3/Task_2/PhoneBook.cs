/*
 * Написать программу — телефонный справочник — создать двумерный массив 5*2,
 * хранящий список телефонных контактов: первый элемент хранит имя контакта,
 * второй — номер телефона/e-mail.
 */

using System;

namespace Lesson_3.Task_2
{
    public class PhoneBook
    {
        string[,] phoneBook =
        {
            {"Alex Dawson", "5693"}, 
            {"Jude Rise", "5612"}, 
            {"Mark Zukken", "6213"},
            {"John Raily", "6136"}
        };

        public void Start()
        {
            Console.WriteLine("Name\t\tPhone\n---------------------");

            for (int i = 0; i < phoneBook.GetLength(0); i++)
            {
                for (int j = 0; j < phoneBook.GetLength(1); j++)
                {
                    Console.Write($"{phoneBook[i, j]}\t");
                }

                Console.WriteLine();
            }
        }
    }
}