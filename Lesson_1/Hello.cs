/*
 * Написать программу, выводящую в консоль текст: «Привет, %имя пользователя%, сегодня %дата%».
 * Имя пользователя сохранить из консоли в промежуточную переменную.
 */

using System;


namespace Lesson_1
{
    class Hello
    {
        static void Main()
        {
            Console.Write("Please enter your name: ");
            var name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}. Today is {DateTime.Now:d}.");
            Console.ReadLine();
        }
    }
}
