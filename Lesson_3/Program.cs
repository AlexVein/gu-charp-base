using System;
using Lesson_3.Task_1;
using Lesson_3.Task_2;
using Lesson_3.Task_3;
using Lesson_3.Task_4;

namespace Lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("1. Вывести элменты диагонали массива" +
                                  "\n2. Телефонный справочник" +
                                  "\n3. Инверсия строки" +
                                  "\n4. \"Морской бой\" "+
                                  "\n\n0. Выход");

                Console.Write("\n\nВведите нужный пункт и нажмите Enter: ");
                var select = Console.ReadLine();

                if (select.Equals("0"))
                    break;

                Console.Clear();

                switch (select)
                {
                    case "1":
                        var task_1 = new PrintArray();
                        task_1.Start();
                        Console.ReadLine();
                        break;
                    case "2":
                        var task_2 = new PhoneBook();
                        task_2.Start();
                        Console.ReadLine();
                        break;
                    case "3":
                        var task_3 = new InvertedString();
                        task_3.Start();
                        Console.ReadLine();
                        break;
                    case "4":
                        var task_4 = new SeaBattle();
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
