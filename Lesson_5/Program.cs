using System;
using Lesson_5.Task_1;
using Lesson_5.Task_2;

namespace Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("1. Сохранение в текстовый файл." +
                                  "\n2. Запись времени при старте" +
                                  "\n3. Запись в бинарный файл" +
                                  "\n\n0. Выход");

                Console.Write("\n\nВведите нужный пункт и нажмите Enter: ");
                var select = Console.ReadLine();

                if (select.Equals("0"))
                    break;

                Console.Clear();

                switch (select)
                {
                    case "1":
                        var task_1 = new SaveToTxt();
                        task_1.Start();
                        Console.ReadLine();
                        break;
                    case "2":
                        var task_2 = new Startup();
                        task_2.Start();
                        Console.ReadLine();
                        break;
                    case "3":
                        break;
                    default:
                        continue;
                }
            }
        }
    }
}
