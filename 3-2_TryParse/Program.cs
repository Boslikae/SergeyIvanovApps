using System;

// Сергей Иванов
// Задание 3.2
// а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке).
// Требуется подсчитать сумму всех нечетных положительных чисел.
// Сами числа и сумму вывести на экран, используя tryParse;
// б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные. 
// При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;

namespace _3_2_TryParse
{
    class Program
    {

    	static int Sum(int a, int sum){
            
            if(a > 0 && a % 2 == 1){ sum = sum + a; }
            return sum;
    	}

    	static bool check(bool f)
    	{
    		if(f == false) Console.WriteLine("Введены некорректные данные");
    		return f;
    	}

        static void Main(string[] args)
        {
            int a = 1;
            int sum = 0;
            string head = "Сумма всех положительных нечетных чисел";

            Console.WriteLine(head);

            Console.WriteLine("Введите любое число (0 - выход)");

            while(true)
            {
            Console.Write("число: ");
            string A = Console.ReadLine(); 
            bool f = int.TryParse(A, out a);
            
            if(A == "0") break;
            check(f);
           
            sum = Sum(a, sum);
            Console.WriteLine("// сумма: " + sum);

            }


        }
    }
}
