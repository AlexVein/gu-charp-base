using System;
using Lesson_4.Task_1;

namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("1. Метод \"GetFullName\"" +
                                  "\n2. " +
                                  "\n3. " +
                                  "\n4. " +
                                  "\n\n0. Выход");

                Console.Write("\n\nВведите нужный пункт и нажмите Enter: ");
                var select = Console.ReadLine();

                if (select.Equals("0"))
                    break;

                Console.Clear();

                switch (select)
                {
                    case "1":
                        var task_1 = new FullName();
                        task_1.Start();
                        Console.ReadLine();
                        break;
                    case "2":
                    case "3":
                    case "4":
                        break;
                    default:
                        continue;
                }
            }
        }
    }
}
