using System;

// Сергей Иванов
// Задание 2.1
// Написать метод, возвращающий минимальное из трех чисел.

namespace _2_1_MinDigit
{
    class Program
    {
        static int MinDigit(int a, int b, int c){
        	
        	int m = 0;

        	    if (a <= b && a <= c){ m = a; }
                else if (b <= a && b <= c) { m = b; }
        	    else if (c <= a && c <= b) { m = c; }
 
        	return m;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Минимальное число из трех");
            Console.WriteLine("Введите 3 числа: ");

            Console.Write ("a = "); int a = int.Parse(Console.ReadLine());
            Console.Write ("b = "); int b = int.Parse(Console.ReadLine());
            Console.Write ("c = "); int c = int.Parse(Console.ReadLine());

            int min = MinDigit(a,b,c);

            Console.WriteLine("Минимальное число: " + min);


           
            }
        }
    }
