using System;

// Сергей Иванов
// Задача 4.1
// Дан  целочисленный  массив  из 20 элементов.
// Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно.
// Заполнить случайными числами.  Написать программу, позволяющую найти и вывести количество пар элементов массива, 
// в которых только одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих элемента массива. 
// Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 

namespace _4_1_Massive
{
    class Program
    {
       static int R(){

    	    Random rnd = new Random();
            int res = rnd.Next(-10000,10000);
            return res;

        } 

        static void Main(string[] args)
        {
            int[] array = new int[20];
            int count = 0;
            int Ln = array.Length;

            for(int i = 0; i<Ln; i++)
            { 
            	array[i] = R(); 
            }          

            for(int i = 0; i<Ln; i++){

                if(array[i]%3==0){ Console.WriteLine(" -> " + array[i]); }
                else{ Console.WriteLine("    " + array[i]); }

            }
            
            for(int i=1; i<Ln; i++){

                if((array[i]%3==0) != (array[i-1]%3==0)){ count++; }

            }
            
            Console.WriteLine("Количество пар элементов массива, в которых только одно число делится на три: " + count );

            } 



        
    }
}
