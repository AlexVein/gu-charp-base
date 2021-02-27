/*
 * Написать метод GetFullName(string firstName, string lastName, string patronymic),
 * принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО.
 * Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.
 */

using System;

namespace Lesson_4.Task_1
{
    public class FullName
    {
        public void Start()
        {
            Console.WriteLine(GetFullName("Иван", "Иванов", "Иванович"));
            Console.WriteLine(GetFullName("Пётр", "Петров", "Петрович"));
            Console.WriteLine(GetFullName("Сидор", "Сидоров", "Сидорович"));
            Console.WriteLine(GetFullName("Константин", "Константиновский", "Константинович"));
        }

        /// <summary>
        /// Возвращает ФИО из переданных элементов
        /// </summary>
        /// <param name="firstName">Имя</param>
        /// <param name="lastName">Фамилия</param>
        /// <param name="patronymic">Отчество</param>
        /// <returns>ФИО</returns>
        private string GetFullName(string firstName, string lastName, string patronymic)
        {
            return $"{lastName} {firstName} {patronymic}";
        }
    }
}