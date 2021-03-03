/*
 * Написать программу, которая при старте дописывает текущее время в файл «startup.txt».
 */

using System;
using System.IO;

namespace Lesson_5.Task_2
{
    public class Startup
    {
        private DateTime startTime;
        private const string fileName = "startup.txt";

        public void Start()
        {
            startTime = DateTime.Now;
            File.AppendAllText(fileName, $"{startTime.ToLongTimeString()}\n");
            Console.WriteLine($"Время запуска записано в файл {fileName}");
        }
    }
}