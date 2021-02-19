using System;

// Сергей Иванов
// Задание 2.3 
// С клавиатуры вводятся числа, пока не будет введен 0.
// Подсчитать сумму всех нечетных положительных чисел.

namespace _2_3_SumDigit
{
    class Program
    {
        static void Main(string[] args)
        {   
        	string head = "Сумма всех нечётных положительных чисел";
            
            Console.WriteLine(head);
            
            int a = 1;
            int sum = 0;

            while(a != 0){
            	Console.Write("Введите число: ");
            	a = int.Parse(Console.ReadLine());

                if(a > 0 && a % 2 == 1){ sum = sum + a; }

                Console.WriteLine("Сумма: " + sum);

            }

            Console.WriteLine(head);

        }
    }
}
