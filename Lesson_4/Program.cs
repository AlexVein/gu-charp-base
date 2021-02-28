using System;
using Lesson_4.Task_1;
using Lesson_4.Task_2;
using Lesson_4.Task_3;
using Lesson_4.Task_4;

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
                                  "\n2. Подсчет суммы чисел из строки" +
                                  "\n3. Время года" +
                                  "\n4. Числа Фибоначчи" +
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
                        var task_2 = new SumNumbers();
                        task_2.Start();
                        Console.ReadLine();
                        break;
                    case "3":
                        var task_3 = new SeasonYear();
                        task_3.Start();
                        Console.ReadLine();
                        break;
                    case "4":
                        var task_4 = new FibonacciNum();
                        task_4.Start();
                        Console.ReadLine();
                        break;
                    default:
                        continue;
                }
            }
        }
    }
}
