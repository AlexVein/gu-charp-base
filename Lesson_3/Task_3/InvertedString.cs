/*
 * Написать программу, выводящую введенную пользователем строку в обратном порядке
 * (olleH вместо Hello).
 */

using System;

namespace Lesson_3.Task_3
{
    public class InvertedString
    {
        public void Start()
        {
            Console.Write("Введите текст: ");
            var userText = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Обработанный текст:");
            for (int i = userText.Length - 1; i >= 0; i--)
            {
                Console.Write(userText[i]);
            }
        }
    }
}