using System;

// Сергей Иванов
// Задание 2.2
// Написать метод подсчета количества цифр числа.

namespace _2_2_CountDigit
{
    class Program
    {

        static int CountDigit(int a){
        	
        	int val = a;
        	int count = 0;
        	
        	if (val != 0){       	    
        	    while(val != 0){
        		    val = val/10;
                    count++;
        	    }
            } else { count = 1;}

        	return count;
        }

        static void Main(string[] args)
        {
            bool f = true;

            Console.WriteLine("Подсчёт количества цифр числа");
            Console.Write("Введите число: ");

            string A = Console.ReadLine();

            for(int i = 0; i < A.Length; i++){
                if(!(A[i]>='0' && A[i]<='9')){
                   f = false;
                   break;
                }
            }

            if(f == true) 
            {
                int a = int.Parse(A);
                int count = CountDigit(a);
                Console.WriteLine("Количество цифр в числе: " + count);
            }
            else { Console.WriteLine("Вы ввели не число."); }


                
                

                
            
        }
    }
}
