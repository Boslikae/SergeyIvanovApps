using System;

// Сергей Иванов
// Задание 2.4
// Реализовать метод проверки логина и пароля. 
// На вход подается логин и пароль. 
// На выходе истина, если прошел авторизацию, и ложь, если не прошел 
// (Логин: root, Password: GeekBrains).
// Используя метод проверки логина и пароля, 
// написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
// С помощью цикла do while ограничить ввод пароля тремя попытками.

namespace _2_4_Login
{
    class Program
    {
        static bool Authorization(string login, string password){
            bool check;
            string CurrentLogin = "root";
            string CurrentPassword = "GeekBrains";

            if(login == CurrentLogin && password == CurrentPassword){ check = true; }
            else{ check = false; }

            return check;
        }

        static void Main(string[] args)
        {
        	string login;
        	string password;

        	bool check;
        	int c = 0;
        	int attempts = 3;
        	int n = attempts;

            Console.WriteLine("Проверка логина и пароля");



            do{
                Console.Write("Введите логин: ");
                login = Console.ReadLine();

                Console.Write("Введите пароль: ");
                password = Console.ReadLine();

                check = Authorization(login, password);	
                c++;
                n = attempts - c;
                    if (check == false){ 
                     	if(n==1){ Console.WriteLine($"У вас осталось {n} попытка!"); }
                	    else if(n>1 && n <= 4){ Console.WriteLine($"У вас осталось {n} попытки!");  }              
                    }
                }
            while(c != attempts);

                        
            if(check==true){ Console.WriteLine("Авторизация пройдена!"); }
            else { Console.WriteLine("Логин или пароль введены неправильно!"); }

        }
    }
}
