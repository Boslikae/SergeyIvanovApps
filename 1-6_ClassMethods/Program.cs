using System;

// Сергей Иванов
// Задание 1.6:
//*Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).

namespace _06_ClassMethods
{

    public class MyClass{

    	    static string EnterInfo(string mes)
    	    {
                Console.Write(mes + ": ");
                string info = Console.ReadLine();
                return info;
            }

            static double ParseThis(string s)
            {
                double d = double.Parse(s);
    		    return d;
    	    }

    	    static void SetCenter(string Head, int a)
    	    {
        	    Console.SetCursorPosition(
                left: (Console.WindowWidth - Head.Length)/2,
                top: Console.WindowHeight/2+a);
            }

            static void PrintInfo(string Info, int a)
            {
                SetCenter(Info, a);
                Console.WriteLine(Info);
            }

            static void Pause()
            {
                Console.ReadKey();
            }




    }

    class Program
    {
        static void Main(string[] args)
        {
        	
        }
    }
}
