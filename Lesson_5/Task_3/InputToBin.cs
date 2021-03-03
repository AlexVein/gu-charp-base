/*
 * Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.
 */

using System;
using System.IO;

namespace Lesson_5.Task_3
{
    public class InputToBin
    {
        private string text = string.Empty;
        private const string fileName = "Task_3.bin";

        public void Start()
        {
            Console.WriteLine("Введите через пробел числа в диапазоне от 0 до 255:");
            text = Console.ReadLine();

            var arr = ConvertInput(text);

            File.WriteAllBytes(fileName, arr);
            Console.WriteLine($"Данные записаны в файл {fileName}");
        }

        private byte[] ConvertInput(string text)
        {
            byte[] temp = new byte[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                temp[i] = Convert.ToByte(text[i]);
            }

            return temp;
        }
    }
}