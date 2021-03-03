using System;
using System.Linq;
using System.Text.RegularExpressions;

// Сергей Иванов
// Задание 5.1
// Создать программу, которая будет проверять корректность ввода логина.
// Корректным логином будет строка от 2 до 10 символов, 
// содержащая только буквы латинского алфавита или цифры,
// при этом цифра не может быть первой:
// а) без использования регулярных выражений;
// б) **с использованием регулярных выражений.


namespace _5_1_LoginCorrection
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = String.Empty;

            Console.WriteLine("Проверка корректности ввода логина");
            Console.Write("Введите логин: ");
            login = Console.ReadLine();
            
            int Ln = login.Length;
            char[] Ch = login.ToArray();
            int n = Ch.Length;
			bool check = false;

            if(Ch[0] >= '0' && Ch[0] <= '9'){ check = false; }
            else{ 

            	if(Ln < 2 || Ln > 10){ check = false; } 
            	else{

          			for(int i=0;i<n;i++){
       
               			if((Ch[i] >= 'a' && Ch[i] <= 'z') || (Ch[i] >= 'A' && Ch[i] <= 'Z') || (Ch[i] >= '0' && Ch[i] <= '9'))
                   	    	{ check = true; }
               			else{ check = false; break; }  
           	 		}
           	    }
            }

            if(check == false){ Console.WriteLine("Логин введён некорректно!"); }
            else{ Console.WriteLine("Поздравляем! Логин введён корректно!"); }

            //////////// С использованием регулярных выражений ////////

            Regex pattern = new Regex("[0-9A-Za-z]");
            Regex pattern2 = new Regex("^[^0-9]");
            Regex pattern3 = new Regex("[а-яА-Я]");

            if(Ln < 2 && Ln > 10)
            {
            	if(pattern2.IsMatch(login))
            	{ 
            		if(pattern.IsMatch(login))
            		{ 
            			if(pattern3.IsMatch(login)) 
            			{ Console.WriteLine("Логин введён некорректно!"); } 
                    	else{ Console.WriteLine("Поздравляем! Логин введён корректно!"); }
            		} 
            	}
            	else{ Console.WriteLine("Логин введён некорректно!"); }
            }
            else{ Console.WriteLine("Логин введён некорректно!"); }



        }
    }
}
