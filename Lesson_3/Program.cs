using System;
using Lesson_3.Task_1;
using Lesson_3.Task_2;
using Lesson_3.Task_3;

namespace Lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var task_1 = new PrintArray();
            var task_2 = new PhoneBook();
            var task_3 = new InvertedString();

            //task_1.Start();
            //task_2.Start();
            task_3.Start();

            Console.ReadLine();
        }
    }
}
