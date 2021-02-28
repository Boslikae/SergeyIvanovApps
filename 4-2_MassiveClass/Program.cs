using System;
using System.IO;
using System.Threading;

// Сергей Иванов
// Задача 4.2
// Реализуйте задачу 1 (4.1) в виде статического класса StaticClass;
// а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
// б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
// в)**Добавьте обработку ситуации отсутствия файла на диске.


namespace _4_2_MassiveClass
{

    public static class Massive
    {

        public static void MassiveDiv3(int[] array){

            int count = 0;
        	int Ln = array.Length;
            
            for(int i = 0; i<Ln; i++){

                if(array[i]%3==0){ Console.WriteLine(" -> " + array[i]); }
                else{ Console.WriteLine("    " + array[i]); }

            }
            
            for(int i=1; i<Ln; i++){

                if((array[i]%3==0) != (array[i-1]%3==0)){ count++; }

            }
            
            Console.WriteLine("Количество пар элементов массива, в которых только одно число делится на три: " + count );
        }

        public static bool CheckFile(string path){
            
            bool f = false;
        	if(File.Exists(path)){  f = true; } 
         	else { Console.WriteLine("Ошибка! Файла не существует."); f = false; }
         	return f;
        }

        public static int[] MassiveFromFile(string path){

            bool f = Massive.CheckFile(path);
            int[] digits = new int[0]; 
            
            if(f==true){

                string text = File.ReadAllText(path);
                Console.WriteLine($"Текст из файла: {text}");
            	string[] nums = text.Split(' ');
                int n = nums.Length;
               
                int count = 0;
                int k = 0;

                for(int i=0; i<n; i++)
                {
                    if(nums[i]!=String.Empty){ count++; }                   
                }

                Array.Resize(ref digits, digits.Length + count);
                
                for(int i=0; i<n; i++)
                {
                    if(nums[i]!=String.Empty){ 

                        digits[k] = int.Parse(nums[i]);
                        //Console.WriteLine($"{k} - {digits[k]}");
                        k++; 
                    }                                                        
                }
            }
               
            return digits;
        }
    }

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

            int[] digits = new int[0];
            string path = "File.txt";

            for(int i = 0; i<array.Length; i++)
            { 
            	array[i] = R(); 
            }

        
            Massive.MassiveDiv3(array);

            
            Console.WriteLine("_____");


            digits = Massive.MassiveFromFile(path);


            Console.WriteLine("Массив из файла: ");

            for(int i=0; i<digits.Length; i++)
            {
                Console.WriteLine($"[{i}] - {digits[i]}",3);
            }

        } 


            

        
    }
}
