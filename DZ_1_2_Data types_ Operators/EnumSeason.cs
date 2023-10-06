/*
 * Задача 5
 Пользователь вводит с клавиатуры дату. Приложение должно отобразить название сезона и дня недели. 
Например, если введено 22.12.2021, приложение должно 
отобразить Winter Wednesday

 */

namespace DZ_1_2_Data_types__Operators
{
    internal partial class Program
    {
        public enum EnumSeason
        {
           1 =  "Winter",
            Spring,
            Summer,
            Autumn
        } 

        
    }
}
//public interface Dictionary<TKey, TValue>
//{
//   public TKey key { get; set; }
//   public TValue this[TKey key] { get; set; }
//}
//public class SeasonMap< TKey, TValue> {
//    private readonly System.Collections.Generic.Dictionary<TKey, TValue> _map
//        = new System.Collections.Generic.Dictionary<TKey, TValue>();
//    public TValue this[TKey key]
//    {
//        get { return _map[key]; }
//        set { _map[key] = value; }
//    }
//    public void Add(TKey tkey, TValue value) { _map.Add(tkey, value); }
//    public bool ContainsKey(TKey key) { return _map.ContainsKey(key); }
//}

