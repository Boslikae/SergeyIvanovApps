using System;

// Сергей Иванов
// Задание 3.3
// 3. *Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел. 
// Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
// Написать программу, демонстрирующую все разработанные элементы класса. 
// Достаточно решить 2 задачи. Все программы сделать в одном решении.
// ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение
// ArgumentException("Знаменатель не может быть равен 0");
// *** Добавить упрощение дробей.

namespace _3_3_Drobi
{

    struct Drob
    {
       public int a, b;

       public Drob(int ch, int zn)
       {
       	   a = ch;
       	   b = zn;
       }

       public string Print()
       {
       	string result = string.Empty;
        
        if(b==0){ result = "Ошибка! Знаменатель не может быть равен 0."; }
        else { result = $"{a}/{b}"; }

        return result;
       }

       public static Drob Simplify(Drob d1) //beta =)
       {
           Drob r = new Drob();

           for(int i=(d1.b/2); i>=2; i--)
           {
           	    if(d1.a%i==0 && d1.b%i==0){ 
           	     	r.a = d1.a/i;
           	   	    r.b = d1.b/i;
           	   	    break;
           	    }
           }
        
           return r;
       }

       public static Drob operator +(Drob d1, Drob d2)
       {
       	    Drob r = new Drob();
       	    if(d1.b == d2.b)
       	        { r.a = d1.a+d2.a;
       	          r.b = d1.b; }
            else{ r.a = (d1.a*d2.b)+(d2.a*d1.b);
            	  r.b = d1.b*d2.b; }

            r = Drob.Simplify(r);
       	    
       	    return r;
       }

       public static Drob operator -(Drob d1, Drob d2)
       { 
       	    Drob r = new Drob();
       	    if(d1.b == d2.b)
       	        { r.a = d1.a-d2.a;
       	          r.b = d1.b; }
       	    else{ r.a = (d1.a*d2.b)-(d2.a*d1.b);
            	  r.b = d1.b*d2.b; }

            r = Drob.Simplify(r);
      	
       	    return r;
       }

       public static Drob operator *(Drob d1, Drob d2)
       {
       	    Drob r = new Drob();
       	    r.a = d1.a*d2.a;
       	    r.b = d1.b*d2.b; 

            r = Drob.Simplify(r);

       	    return r;
       }

       public static Drob operator /(Drob d1, Drob d2)
       {
       	    Drob r = new Drob();
       	    r.a = d1.a*d2.b;
       	    r.b = d1.b*d1.a;

            r = Drob.Simplify(r);

       	    return r;
       }

    }

    class Program
    {
        static void Main(string[] args)
        {
        	string D = "";
        	Drob d1 = new Drob(11,116);
            Drob d2 = new Drob(12,132);
            Drob res = new Drob();

            Console.WriteLine("Дроби");

            while(D!="0"){
            	Console.WriteLine("d1 = " + d1.Print());
            	Console.WriteLine("d2 = " + d2.Print());
            	Console.WriteLine("выберите действие над комплексными числами (+, -, *, /, 0 - выход)");
                D = Console.ReadLine();
                switch(D){
            	    case "+": res = d1 + d2; break;
            	    case "-": res = d1 - d2; break;
            	    case "*": res = d1*d2; break;
            	    case "/": res = d1/d2; break;
            	    case "0": break;
            	    default: Console.WriteLine("Некорректная команда."); break;
            	}
                
                if(D=="+" || D=="-" || D=="*" || D=="/"){
            	    Console.WriteLine(res.Print());    
                    Console.WriteLine("__________");
                }
            }


        }
    }
}
