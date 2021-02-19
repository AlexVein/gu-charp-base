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
            var task_1 = new PrintArray();
            var task_2 = new PhoneBook();
            var task_3 = new InvertedString();
            var task_4 = new SeaBattle();

            //task_1.Start();
            //task_2.Start();
            //task_3.Start();
            task_4.Start();

            Console.ReadLine();
        }
    }
}
