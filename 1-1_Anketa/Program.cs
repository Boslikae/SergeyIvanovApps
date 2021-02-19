using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

            // Сергей Иванов
            // Задание 1.1:
            // Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
            // В результате вся информация выводится в одну строчку:
            // а) используя  склеивание;
            // б) используя форматированный вывод;
            // в) используя вывод со знаком $.


namespace myApp
{
    class Program
    {
        static string EnterInfo(string mes){
            
            Console.Write(mes + ": ");
            string info = Console.ReadLine();
            return info;
        }

        static void Main(string[] args)
        {

        	string FirstName;
        	string LastName;
        	string Age;
            string Height;
            string Weight;

            string AllInfo;
            string sep = " | ";
            string sep2 = " ____ ";

            string mes1 = "Имя"; 
            string mes2 = "Фамилия";  
            string mes3 = "Возраст";
            string mes4 = "Рост";
            string mes5 = "Вес";

            string head = "Программа Анкета";
            
        	Console.WriteLine(head);
        	
            FirstName = EnterInfo(mes1);
            LastName = EnterInfo(mes2);
            Age = EnterInfo(mes3);
            Height = EnterInfo(mes4);
            Weight = EnterInfo(mes5);

            AllInfo = FirstName + sep + LastName + sep + Age + sep + Height + sep + Weight;
            Console.WriteLine("Cклеивание: " + AllInfo);
 
            Console.WriteLine(sep2);
 
            Console.WriteLine("Форматрование:");
            Console.WriteLine("Имя: {0}\nФамимлия: {1}\nВозраст: {2}\nРост: {3}\nВес: {4}\n", FirstName, LastName, Age, Height, Weight);

            Console.WriteLine(sep2);

            Console.WriteLine("Вывод со знаком $:");
            Console.WriteLine($"{mes1}:{FirstName}, {mes2}:{LastName}, {mes3}:{Age}, {mes4}:{Height}, {mes5}:{Weight}");

            Console.WriteLine(sep2);

        }

       
    }


}
