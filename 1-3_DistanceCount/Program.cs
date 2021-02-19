using System;

// Сергей Иванов
// Задание 1.3:
// а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
// по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
// Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
// б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;

namespace DistanceCount
{
    class Program
    {
        static double ParseThis(string s){

    		double d = double.Parse(s);
    		return d;
    	}

    	static double CountR(string A, string B){

    		double x1, y1, x2, y2;
    		string[] Aa = A.Split(";");
    		string[] Bb = B.Split(";");

    		x1 = ParseThis(Aa[0]);
            y1 = ParseThis(Aa[1]);

            x2 = ParseThis(Bb[0]);
            y2 = ParseThis(Bb[1]);
            
            double r = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
            return r;
    	}

        static void Main(string[] args)
        {
        	string Head = "Программа Расстояние между точками A и B";
        	string mes1 = "Введите координаты точки А(x;y): ";
        	string mes2 = "Введите координату точки B(x;y): ";

            string A;
            string B;

            double x1, y1;
            double x2, y2;

            double r;

            Console.WriteLine(Head);

            Console.Write(mes1);
            A = Console.ReadLine();

            Console.Write(mes2);
            B = Console.ReadLine();

            r = CountR(A, B);

            Console.WriteLine("Расстояние между точками А и B => R = " + "{0:f2}",r);

        }
    }
}
