using System;
using Lesson_3.Task_1;
using Lesson_3.Task_2;

namespace Lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var task_1 = new PrintArray();
            var task_2 = new PhoneBook();

            //task_1.Start();
            task_2.Start();

            Console.ReadLine();
        }
    }
}
