using System;

// Сергей Иванов
// Задание 2.7
// a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
// б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.

namespace _2_7_RecursMethod
{
    class Program
    {
        static int RecursivePrint(int a, int b){
            
            Console.WriteLine(a);
            a=a+1; 
            if(a>b){ return 0; }
            else{ return RecursivePrint(a,b); }
        }

        static int RecursiveSum(int a, int b){

        	Console.WriteLine(a+b);
        	a=a+1;
        	if(a>b){ return 0; }
        	else{ return RecursiveSum(a,b); }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Числа от A до B. A должно быть меньше B.");
            
            Console.Write("Введите число A = ");
            int a = int.Parse(Console.ReadLine());
            
            Console.Write("Введите число B = ");
            int b = int.Parse(Console.ReadLine());
            
            RecursivePrint(a,b); 
            Console.WriteLine("____");
            RecursiveSum(a,b);          	

            

        }
    }
}
