using System;

// Сергей Иванов
// Задание 2.5
// а) Написать программу, которая запрашивает массу и рост человека, 
// вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
// б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

namespace _2_5_IMT2
{
    class Program
    {
    	static double ParseThis(string s){

    		double d = double.Parse(s);
    		return d;
    	}

        static double IMT(double m, double h){

        	double I = ( m /(h*h) );
        	Console.WriteLine(I);
        	return I;
        }

        static void Main(string[] args)
        {
            string head = "Программа Индекс массы тела";
            string mes1 = "Масса (кг): ";
            string mes2 = "Рост (м): ";
            string imtMes = "Индекс массы тела = "; 
            string answer = "";

            double m;
            double h;
            double e;

            double imt;

            Console.WriteLine(head);

            Console.Write(mes1);
            m = ParseThis(Console.ReadLine());

            Console.Write(mes2);
            h = ParseThis(Console.ReadLine());

            imt = Math.Round(IMT(m, h), 2);

            Console.WriteLine(imtMes + imt);

            Console.Write("Хотите получить рекоммендации по своему индексу массы тела?" );
            answer = Console.ReadLine().ToLower();

            if(answer == "да" || answer == "ага" || answer == "угу" || answer == "yes" || answer == "yup"){
              
                if (imt >= 18.5 && imt <= 25) { Console.WriteLine("У вас нормальный индекс массы тела!"); }
                else if( imt > 25){ 
                   	e = Math.Ceiling(( 25*(h*h) ));
               	    Console.WriteLine($"Вам нужно сбросить хотя бы {m-e} кг."); }
                else if( imt < 18.5){ 
               	    e = Math.Ceiling(( 18.5*(h*h) ));
                    Console.WriteLine($"Вам нужно набрать хотя бы {e-m} кг."); }

            }
            else { Console.WriteLine("Нет так нет!"); }


            Console.WriteLine("____");


        }
    }
}

