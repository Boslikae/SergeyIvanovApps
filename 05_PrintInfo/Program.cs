using System;

// Сергей Иванов
// Задание 1.5:
// а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
// б) Сделать задание, только вывод организуйте в центре экрана
// в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y)

namespace _05_PrintInfo
{
    class Program
    {

        static void SetCenter(string Head, int a){
        	Console.SetCursorPosition(
            left: (Console.WindowWidth - Head.Length)/2,
            top: Console.WindowHeight/2+a);
        }

        static void PrintInfo(string Info, int a){
            SetCenter(Info, a);
            Console.WriteLine(Info);
        }

        static void Main(string[] args)
        {
        	string Head = "Программа вывода данных Анкеты";
        	string FirstName;
        	string LastName;
        	string City;

            Console.WriteLine(Head);
            Console.Write("Введите ваше имя: ");      
            FirstName = Console.ReadLine();
            Console.Write("Введите вашу фамилию: ");
            LastName = Console.ReadLine();
            Console.Write("Введите ваш город проживания: ");
            City = Console.ReadLine();

            Console.Clear();
            string[] Info = {Head, FirstName, LastName, City};

            for(int i=0;i<=3;i++){
            	PrintInfo(Info[i],i);
            }
            
            Console.ReadLine();

        }
    }
}
