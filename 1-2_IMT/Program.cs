using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Сергей Иванов
// Задание 1.2:
// Ввести вес и рост человека. 
// Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h);
// где m — масса тела в килограммах, h — рост в метрах

namespace IMT
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

            //string massStr;
            //string heightStr;

            double massDbl;
            double heightDbl;

            double imt;


            Console.WriteLine(head);

            Console.Write(mes1);
            massDbl = ParseThis(Console.ReadLine());

            Console.Write(mes2);
            heightDbl = ParseThis(Console.ReadLine());

            imt = Math.Round(IMT(massDbl, heightDbl), 2);

            Console.WriteLine(imtMes + imt);
            Console.WriteLine("____");


        }
    }
}
