/*
 * Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом,
 * и возвращающую число — сумму всех чисел в строке.
 * Ввести данные с клавиатуры и вывести результат на экран.
 */

using System;

namespace Lesson_4.Task_2
{
    public class SumNumbers
    {
        public void Start()
        {
            Console.Write("Введите числовой ряд через пробел: ");
            var numString = Console.ReadLine();

            Console.WriteLine($"\nСумма чисел = {CalcSum(numString)}");
        }

        /// <summary>
        /// Возвращает сумму чисел в числовом ряду
        /// </summary>
        /// <param name="numString">Числовой ряд</param>
        /// <returns>Сумма чисел</returns>
        private double CalcSum(string numString)
        {
            double result = 0;
            var arrNumbers = numString.Split();

            try
            {
                foreach (var arrNumber in arrNumbers)
                {
                    result += Convert.ToDouble(arrNumber);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 0;
            }

            return result;
        }
    }
}