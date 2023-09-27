/*
 * Задача 5
 Пользователь вводит с клавиатуры дату. Приложение должно отобразить название сезона и дня недели. 
Например, если введено 22.12.2021, приложение должно 
отобразить Winter Wednesday

 */

using System.Collections;
using System.Globalization;
using System.Collections.Generic;
using System.Data;



namespace DZ_1_2_Data_types__Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 5
            Console.WriteLine("Task 5\nFind out what time of year and day of the week!!\nEnter the datr with format 20.10.2023 -> ");
            string input = Console.ReadLine();

            DateTime date;
            if (DateTime.TryParseExact(input,"dd.MM.YYYY", CultureInfo.InvariantCulture, DateTimeStyles.None, out date)) {
                string season = GetSeason(date);
                string dayOfWeek = date.ToString("dddd", CultureInfo.InvariantCulture);
                Console.WriteLine($"Result: {season}{dayOfWeek}");
            }
            Console.WriteLine("Mistake!Invalid date format!");
        }

      static string GetSeason(DateTime date)  {

            Dictionary<int, string> season = new Dictionary<int, string>
            (
                { 1, "Winter" },
                { 2, "Spring" },
                { 3, "Summer" },
                { 4, "Autumn" }
            );
            int month = date.Month;
            int seasonNumber = (month + 3) % 3;
            return season[seasonNumber];
        }        
    }
}
public interface Dictionary<TKey, TValue>
{
   public TKey key { get; set; }
   public TValue this[TKey key] { get; set; }
}
public class SeasonMap< TKey, TValue> {
    private readonly System.Collections.Generic.Dictionary<TKey, TValue> _map
        = new System.Collections.Generic.Dictionary<TKey, TValue>();
    public TValue this[TKey key]
    {
        get { return _map[key]; }
        set { _map[key] = value; }
    }
    public void Add(TKey tkey, TValue value) { _map.Add(tkey, value); }
    public bool ContainsKey(TKey key) { return _map.ContainsKey(key); }
}

