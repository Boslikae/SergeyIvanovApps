using System;

// Сергей Иванов
// Задание 2.6
// *Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. 
// Хорошим называется число, которое делится на сумму своих цифр.
// Реализовать подсчет времени выполнения программы, используя структуру DateTime.

namespace _2_6_GoodDigit
{
    class Program
    {

    	static int CharToInt(char c)
        {
           return (int)(c - '0');
        }

        static void Main(string[] args)
        {
        	DateTime start = DateTime.Now;

            Console.WriteLine("Хорошие числа");

            int a = 1000000000;
            string strA = "";
            int sum = 0;
            int temp;

            int k = 0;
            int i = 0;
            int j = 1;

            
            for(i=1;i<=a;i++)
            {
                strA = i.ToString();

                foreach(char c in strA)
                {
                    temp = CharToInt(c);                    
                    sum = sum + temp;                    
            	    k++;
            	}

            	k = 0;

            	if(i%sum == 0) { 
            		Console.WriteLine(j+". i = "+i);
            		j++; }
            
                sum = 0;
 
            }

            Console.WriteLine("Количество хороших чисел: " + j);
            Console.WriteLine(DateTime.Now - start);
            




        }
    }
}
