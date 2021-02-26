/*
 * Написать метод по определению времени года.
 * На вход подаётся число – порядковый номер месяца.
 * На выходе — значение из перечисления (enum) — Winter, Spring, Summer, Autumn.
 * Написать метод, принимающий на вход значение из этого перечисления
 * и возвращающий название времени года (зима, весна, лето, осень).
 * Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года.
 * Если введено некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».
 */

using System;

namespace Lesson_4.Task_3
{
    public class SeasonYear
    {
        [Flags]
        enum Seasons
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }

        private int month;
        private Seasons season;

        public void Start()
        {
            Console.Write("Введите порядковый номер месяца: ");
            try
            {
                month = Convert.ToInt32(Console.ReadLine());
                if (month < 1 || month > 12)
                {
                    Console.WriteLine("Ошибка: введите число от 1 до 12.");
                    return;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка: введите число от 1 до 12.");
                return;
            }

            GetSeason(month, ref season);
            Console.WriteLine($"\n{GetRusName(season)}");
        }

        private string GetRusName(Seasons season)
        {
            if (season.Equals(Seasons.Autumn))
                return "Осень";

            if (season.Equals(Seasons.Spring))
                return "Весна";

            if (season.Equals(Seasons.Summer))
                return "Лето";

            return "Зима";
        }

        private void GetSeason(int month, ref Seasons season)
        {
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    season = Seasons.Winter;
                    break;
                case 3:
                case 4:
                case 5:
                    season = Seasons.Spring;
                    break;
                case 6:
                case 7:
                case 8:
                    season = Seasons.Summer;
                    break;
                case 9:
                case 10:
                case 11:
                    season = Seasons.Autumn;
                    break;
            }
        }
    }
}