/*
 * Написать программу, вычисляющую число Фибоначчи для заданного значения рекурсивным способом.
 */

using System;

namespace Lesson_4.Task_4
{
    public class FibonacciNum
    {
        private int num;

        public void Start()
        {
            Console.Write("Введите номер искомого числа Фибоначчи: ");
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine($"\n{e}");
                Console.WriteLine("\n\nНеобходимо ввести целое число!");
                return;
            }

            Console.WriteLine($"{num} число Фибоначчи = {CalcFibonacci(num)}");
        }

        /// <summary>
        /// Рекурсивно расчитывает искомое число Фибоначчи
        /// </summary>
        /// <param name="num">Порядковый номер искомого числа</param>
        /// <returns>Значение искомого числа Фибоначчи</returns>
        private int CalcFibonacci(int num)
        {
            if (num == 0) return 0;
            if (num == 1) return 1;

            return CalcFibonacci(num - 2) + CalcFibonacci(num - 1);
        }
    }
}