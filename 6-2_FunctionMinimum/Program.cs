using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Collections.Generic;

// Сергей Иванов
// Задание 6.2
// Модифицировать программу нахождения минимума функции так,
// чтобы можно было передавать функцию в виде делегата. 
// а) Сделать меню с различными функциями и представить пользователю выбор, 
// для какой функции и на каком отрезке находить минимум. 
// Использовать массив (или список) делегатов, в котором хранятся различные функции.
// б) *Переделать функцию Load, чтобы она возвращала массив считанных значений. 
// Пусть она возвращает минимум через параметр (с использованием модификатора out). 

namespace _6_2_FunctionMinimum
{
    public delegate double Fun(double x, string key);

	class Program
	{ 
        public static double F(double x, string key)
        {
            switch(key)
            {
                case "1": return x * x;
                case "2": return x * x-50*x+10;
                case "3": return x * x * x;
                case "4": return x*x*x - 25*x*x + 10*x - 3;
                case "5": return Math.Sin(x);
                case "6": return Math.Cos(x);
                default: return 0;
            }
            
        }

        public static double ParseToDouble(string s){

            double d = double.Parse(s);
            return d;
        }

        public static void SaveFunc(string fileName, double a, double b, double h, Fun FF, string key)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x<=b)
            {
                bw.Write(FF(x, key));
                x += h; // x=x+h;
            }
            bw.Close();
            fs.Close();
        }

        public static double Load(string fileName)
        {
    		FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for(int i=0;i<fs.Length/sizeof(double);i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }

        static void Main(string[] args)
        {
            string[] Functions = {"X^2", "X^2-50X+10", "X^3", "X^3-25X^2+10X-3", "SinX", "CosX"};
            int i = 1;

            Console.WriteLine("Выберите функцию: ");

            foreach(string Func in Functions){
              Console.WriteLine($"{i} - {Func}");
              i++;
            }
 
            string key = Console.ReadLine();
            string ptr = "[0-6]";

            Regex pattern = new Regex(ptr);

            if(pattern.IsMatch(key))
            { 
            Console.Write("Начальное значение a = ");
            double a = ParseToDouble(Console.ReadLine());
            Console.Write("Конечное значение b = ");
            double b = ParseToDouble(Console.ReadLine());
            Console.Write("Шаг h = ");
            double h = ParseToDouble(Console.ReadLine());

            SaveFunc("data.bin", a, b, h, F, key);
            Console.WriteLine(Load("data.bin"));
            Console.ReadKey(); 
            }
            else{ Console.WriteLine("Ошибка"); }
            
            
        }
    }
}
