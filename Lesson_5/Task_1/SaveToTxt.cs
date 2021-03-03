/*
 * Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.
 */

using System;
using System.IO;
using System.Text;

namespace Lesson_5.Task_1
{
    public class SaveToTxt

    {
        private string text = string.Empty;
        private const string fileName = "Task_1.txt";

        public void Start()
        {
            Console.Write("Введите текст: ");
            text = Console.ReadLine();

            File.WriteAllText(fileName, text, Encoding.UTF8);
            Console.WriteLine($"Текст успешно записан в файл {fileName}");
        }
    }
}