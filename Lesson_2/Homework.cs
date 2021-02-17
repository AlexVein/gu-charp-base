using System;

namespace Lesson_2
{
    class Homework
    {
        enum Months
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        [Flags]
        enum Schedule
        {
            Monday = 0b0000001,
            Tuesday = 0b0000010,
            Wednesday = 0b0000100,
            Thursday = 0b0001000,
            Friday = 0b0010000,
            Saturday = 0b0100000,
            Sunday = 0b1000000
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("1. Среднесуточная температура" +
                                  "\n2. Название месяца по номеру" +
                                  "\n3. Проверка числа на четность" +
                                  "\n4. Печать чека" +
                                  "\n5. \"Дождливая зима\"" +
                                  "\n6. Расписание офисов" +
                                  "\n\n0. Выход");

                Console.Write("\n\nВведите нужный пункт и нажмите Enter: ");
                var select = Console.ReadLine();

                if (select.Equals("0"))
                    break;

                Console.Clear();

                switch (select)
                {
                    case "1":
                        Task_1();
                        Console.ReadLine();
                        break;
                    case "2":
                        Task_2();
                        Console.ReadLine();
                        break;
                    case "3":
                        Task_3();
                        Console.ReadLine();
                        break;
                    case "4":
                        Task_4();
                        Console.ReadLine();
                        break;
                    case "5":
                        Task_5();
                        Console.ReadLine();
                        break;
                    case "6":
                        Task_6();
                        Console.ReadLine();
                        break;
                    default:
                        continue;
                }
            }
        }


        /// <summary>
        /// Запросить у пользователя минимальную и максимальную температуру за сутки
        /// и вывести среднесуточную температуру.
        /// </summary>
        private static void Task_1()
        {
            Console.Write("Введите минимальную температуру за сутки: ");
            var minTemp = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите максимальную температуру за сутки: ");
            var maxTemp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\nСредняя температура за сутки = {avgTemp(minTemp, maxTemp):f}");
        }
        

        /// <summary>
        /// Запросить у пользователя порядковый номер текущего месяца и вывести его название.
        /// </summary>
        private static void Task_2()
        {
            Console.Write("Введите порядковый номер месяца: ");
            var month = Convert.ToByte(Console.ReadLine());

            Console.WriteLine($"{month} по порядку месяц - {(Months)(--month)}");
        }

        /// <summary>
        /// Определить, является ли введённое пользователем число чётным.
        /// </summary>
        private static void Task_3()
        {
            Console.Write("Введите число: ");
            var num = Convert.ToInt32(Console.ReadLine());
            var result = num % 2 == 0 ? "четное" : "не четное";

            Console.WriteLine($"Число {num} - {result}");
        }

        /// <summary>
        /// Для полного закрепления понимания простых типов найдите любой чек,
        /// либо фотографию этого чека в интернете и схематично нарисуйте его в консоли,
        /// только за место динамических, по вашему мнению, данных (это может быть дата, название магазина, сумма покупок)
        /// подставляйте переменные, которые были заранее заготовлены до вывода на консоль.
        /// </summary>
        private static void Task_4()
        {
            DateTime date = DateTime.Now;
            int checkNum = 1448;
            int shift = 123;
            string fio = "Иванов И.И.";
            int count_1 = 500;
            int count_2 = 2;
            string item_1 = "Какой-то товар";
            string item_2 = "Какой-то другой товар";
            double price_1 = 3.00;
            double price_2 = 500.00;
            double ndsRate = 0.18;

            var sum_1 = (price_1 * count_1);
            var sum_2 = (price_2 * count_2);
            var nds_1 = sum_1 * ndsRate;
            var nds_2 = sum_2 * ndsRate;

            Console.WriteLine($"\t\tКассовый чек" +
                              $"\n\nПРИХОД" +
                              $"\n\nООО \"Рога и Копыта\"" +
                              $"\nИНН 1234567890" +
                              $"\n123456, г. Какойтов, ул. Уличная, 1" +
                              $"\n8 800 123-45-67" +
                              $"\n\n{date.ToString("dd.MM.yy HH:mm")}\t\tЧек №\t\t{checkNum}" +
                              $"\nКассир: {fio}\tСмена №\t\t{shift}" +
                              $"\n\n---------------------------------------------" +
                              $"\n{item_1}" +
                              $"\n\t\t\t{count_1} X {price_1}\t= {sum_1:f}" +
                              $"\n\t\t\tНДС {ndsRate * 100}%\t= {nds_1:f}" +
                              $"\n{item_2}" +
                              $"\n\t\t\t{count_2} X {price_2}\t= {sum_2:f}" +
                              $"\n\t\t\tНДС {ndsRate * 100}%\t= {nds_2:f}" +
                              $"\n\n---------------------------------------------" +
                              $"\n\nИТОГ\t\t\t\t{(sum_1 + sum_2):f}");
        }

        /// <summary>
        /// Если пользователь указал месяц из зимнего периода, а средняя температура > 0,
        /// вывести сообщение «Дождливая зима».
        /// </summary>
        private static void Task_5()
        {
            Console.Write("Введите минимальную температуру за сутки: ");
            var minTemp = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите максимальную температуру за сутки: ");
            var maxTemp = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите порядковый номер месяца: ");
            var month = Convert.ToByte(Console.ReadLine());

            if (month < 3 || month == 12)
            {
                if (avgTemp(minTemp, maxTemp) > 0)
                {
                    Console.WriteLine("Дождливая зима.");
                }
            }
        }

        /// <summary>
        /// Для полного закрепления битовых масок, попытайтесь создать универсальную структуру расписания недели,
        /// к примеру, чтобы описать работу какого либо офиса.
        /// Явный пример - офис номер 1 работает со вторника до пятницы,
        /// офис номер 2 работает с понедельника до воскресенья и выведите его на экран консоли.
        /// </summary>
        private static void Task_6()
        {
            Schedule firstOffice = Schedule.Tuesday | Schedule.Wednesday | Schedule.Thursday | Schedule.Friday;
            Schedule secondOffice = Schedule.Monday | Schedule.Tuesday | Schedule.Wednesday | Schedule.Thursday |
                                    Schedule.Friday | Schedule.Saturday | Schedule.Sunday;

            Console.WriteLine($"Рабочие дни для первого офиса:\n\t{firstOffice}");
            Console.WriteLine();
            Console.WriteLine($"Рабочие дни для второго офиса:\n\t{secondOffice}");
        }

        /// <summary>
        /// Расчитывает среднее значение температуры
        /// </summary>
        /// <param name="minTemp">Минимальная температура</param>
        /// <param name="maxTemp">Максимальная температура</param>
        /// <returns>Среднее значение</returns>
        private static double avgTemp(double minTemp, double maxTemp)
        {
            return (minTemp + maxTemp) / 2;
        }
    }
}
