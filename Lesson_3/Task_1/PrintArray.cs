/*
 * Написать программу, выводящую элементы двухмерного массива по диагонали.
 */

using System;

namespace Lesson_3.Task_1
{
    public class PrintArray
    {
        private byte size;


        public void Start()
        {
            while (true)
            {
                Console.Clear();
                UserAnswer();

                if (this.size < 2)
                {
                    Console.WriteLine("Размер матрицы должен задаваться положительным числом от 2 и выше." +
                                      "\nПовторите ввод.");
                    continue;
                }
                break;
            }

            var arr = FillArray(this.size);

            BaseArray(arr);
            Console.WriteLine();
            Result(arr);
        }

        /// <summary>
        /// Выводит элементы основной диагонали квадратной матрицы
        /// </summary>
        /// <param name="arr">Список элементов</param>
        private void Result(int[,] arr)
        {
            Console.Write("Элементы основной диагонали:");

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (i == j)
                    {
                        Console.Write($" {arr[i, j]}");
                    }
                }
            }
        }

        /// <summary>
        /// Выводит исходную квадратную матрицу
        /// </summary>
        /// <param name="arr">Исходная матрица</param>
        private void BaseArray(int[,] arr)
        {
            Console.WriteLine("Исходый массив:\n");

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    Console.Write($"\t{arr[i,j]}");
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// Заполняет массив случаными значениями
        /// </summary>
        /// <param name="size">Размер массива</param>
        /// <returns>Заполненный массив заданного размера</returns>
        private int[,] FillArray(byte size)
        {
            var rand = new Random();
            int[,] arr = new int[size,size];

            for (var i = 0; i < size; i++)
            {
                for (var j = 0; j < size; j++)
                {
                    arr[i,j] = rand.Next(100);
                }
            }

            return arr;
        }

        /// <summary>
        /// Запрашивает размер квадратной матрицы
        /// </summary>
        private void UserAnswer()
        {
           Console.Write("Введите размерность квадратной матрицы: ");
           byte.TryParse(Console.ReadLine(), out this.size);
        }
    }
}