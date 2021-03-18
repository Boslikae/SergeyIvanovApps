using System;
using System.Reflection;

// Сергей Иванов
// Задание 8.1
// С помощью рефлексии выведите все свойства структуры DateTime

namespace _8_1_DateTimeProperty
{
    class Program
    {
       
  		static PropertyInfo GetPropertyInfo(object obj,string str)
        {
            return obj.GetType().GetProperty(str);
        }

        static Type GetType_(object obj)
        {
              return typeof(DateTime);
        }

        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime();
 			
 			Type t = GetType_(dateTime);

            foreach(var s in t.GetProperties())
            {
                Console.WriteLine(s);
            }

            //Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").CanRead);
            //Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").CanWrite);
            //Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").GetValue(dateTime, null));
            //Console.ReadKey();


        }
    }
}
