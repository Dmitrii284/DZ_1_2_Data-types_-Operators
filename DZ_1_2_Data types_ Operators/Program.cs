/*
 * Задача 5
 Пользователь вводит с клавиатуры дату. Приложение должно отобразить название сезона и дня недели. 
Например, если введено 22.12.2021, приложение должно 
отобразить Winter Wednesday

 */

//using global::System.Globalization;

//namespace DZ_1_2_Data_types__Operators
//{
//    internal partial class Program
//    {
        //public enum EnumSeason
        //{
        //    Winter,
        //    Spring,
        //    Summer,
        //    Autumn
        //}

        //public static int Main(string[] args)
        //{
        //    static string GetSeason(DateTime date)
        //    {
        //        string season = "";
        //        int month = DateTime.Now.Month;
        //        public enum Season
        //{ Winter = 1,
        //    Spring = 3,
        //            ,
        //    1, 2; }
        //Winter = 12, 1, 2;
                  
                // switch(month)
                //{
                //    case 12:
                //    case 1: 
                //    case 2:  season = "Winter"; break;
                //    case 3:
                //    case 4:
                //    case 5: season = "Spring"; break;
                //    case 6:
                //    case 7:
                //    case 8: season = "Summer"; break;
                //    case 9:
                //    case 10:
                //    case 11: season = "Autumn"; break;
                //    default: throw new ArgumentException("Invalid date");                
                
//            }

//             Console.WriteLine("Task 5\nFind out what time of year and day of the week!!\nEnter the datr with format 20.10.2023 -> ");
//             string? input = Console.ReadLine();

//            if(DateTime.TryParseExact(input,"dd.MM.yyyy", CultureInfo.InvariantCulture,DateTimeStyles.None, out DateTime date))
//            {
//                string season = date.ToString("MM", CultureInfo.InvariantCulture);
//                string dayOfWeek = date.ToString("dddd", CultureInfo.InvariantCulture);
//                Console.WriteLine($"Resault:{season}, {dayOfWeek}");
//            }
//            Console.WriteLine("Mistake!Invalid date format!");

//            return 0;
//        }
//    }
//}

using System;
using System.Globalization;

namespace SeasonAndDayOfWeek
{
    class Program
    {
        enum Season
        {
            Winter,
            Spring,
            Summer,
            Autumn
        };
        

        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Console.WriteLine("Задача 5\nПользователь вводит дату. Приложение должно отобразить название сезона и дня недели.");
            Console.Write("Введите дату (dd.MM.yyyy): ");
            string? input = Console.ReadLine();

            if (DateTime.TryParseExact(input, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            {
                Season season = GetSeason(date);
                string dayOfWeek = date.ToString("dddd", CultureInfo.InvariantCulture);

                Console.WriteLine($"Название сезона: {season}");
                Console.WriteLine($"День недели: {dayOfWeek}");
            }
            else
            {
                Console.WriteLine("Ошибка! Некорректный формат даты.");
            }
        }

        static Season GetSeason(DateTime date)
        {
            int month = date.Month;

            if (month == 12 || month == 1 || month == 2)
            {
                return Season.Winter;
            }
            else if (month >= 3 && month <= 5)
            {
                return Season.Spring;
            }
            else if (month >= 6 && month <= 8)
            {
                return Season.Summer;
            }
            else
            {
                return Season.Autumn;
            }
        }
    }
}




