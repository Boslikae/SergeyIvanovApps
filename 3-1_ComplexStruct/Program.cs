using System;

// Сергей Иванов
// Задание 3.1
// а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
// б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
// в) Добавить диалог с использованием switch демонстрирующий работу класса.

namespace _3_1_ComplexStruct
{

    struct Complex
    {
    	public double a,b;

    	public Complex(double re, double im) //конструктор
    	{
            a = re;
            b = im;
    	}

    	public Complex(double reim) //конструктор
    	{
            a = reim;
            b = reim;
    	}

        //______________________________________

    	//public static implicit operator(int d) //неявное преобразование типа int к complex
    	//{
        //    return new Complex(d);
    	//}

    	//public static explicit operator(int d) //явное преобразование типа int к complex
    	//{
        //    return new Complex(d);
    	//}

    	//______________________________________

    	public string Print()
    	{
            string result = String.Empty;

            if(b < 0){ result = $"{a} - {-b}i"; } 
            else if(b == 0){ result = $"{a}"; }
            else{ result = $"{a} + {b}i"; }

            return result;
    	}

    	public static Complex operator +(Complex z1, Complex z2)
    	{
    		Complex r = new Complex();
            r.a = z1.a + z2.a;
            r.b = z1.b + z2.b;
            return r;
    	}

    	public static Complex Sum(Complex z1, Complex z2)
        {
            Complex r = new Complex();
            r.a = z1.a + z2.a;
            r.b = z1.b + z2.b;
            return r;
        }

       // public Complex Sum(Complex z1)
       // {
       // 	Complex r = new Complex();
       // 	r.a = z1.a + this.a;
       // 	r.b = z1.b + this.b;
       // 	return r;
       //}

        public static Complex operator -(Complex z1, Complex z2)
    	{
    		Complex r = new Complex();
            r.a = z1.a - z2.a;
            r.b = z1.b - z2.b;
            return r;
    	}

        public static Complex Sub(Complex z1, Complex z2)
        {
            Complex r = new Complex();
            r.a = z1.a - z2.a;
            r.b = z1.b - z2.b;
            return r;
        }

       // public Complex Sub(Complex z1)
       // {
       // 	Complex r = new Complex();
       // 	r.a = z1.a - this.a;
       // 	r.b = z1.b - this.b;
       // 	return r;
       // }

        public static Complex operator *(Complex z1, Complex z2)
        {
        	Complex r = new Complex();
        	r.a = (z1.a*z2.a)-(z1.b*z2.b);
        	r.b = (z1.a*z2.b)+(z1.b*z2.a);
        	return r;
        }

        public static Complex Mult(Complex z1, Complex z2)
        {
        	Complex r = new Complex();
        	r.a = (z1.a*z2.a)-(z1.b*z2.b);
        	r.b = (z1.a*z2.b)+(z1.b*z2.a);
        	return r;
        }

        public static Complex operator /(Complex z1, Complex z2)
        {
        	Complex r = new Complex();
        	r.a = ((z1.a*z2.a)+(z1.b*z2.b))/((z2.a*z2.a)+(z2.b*z2.b));
        	r.b = ((z1.b*z2.a)-(z1.a*z2.b))/((z2.a*z2.a)+(z2.b*z2.b));
        	return r;
        }

        public static Complex Div(Complex z1, Complex z2)
        {
        	Complex r = new Complex();
        	r.a = ((z1.a*z2.a)+(z1.b*z2.b))/((z2.a*z2.a)+(z2.b*z2.b));
        	r.b = ((z1.b*z2.a)-(z1.a*z2.b))/((z2.a*z2.a)+(z2.b*z2.b));
        	return r;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            string D = "";

            Complex z1 = new Complex(2, 3);

            Complex z2 = new Complex(-4, -8);

            Complex res = new Complex();

            //Complex z3 = new Complex(11);
            
            

            while(D!="0"){
                Console.WriteLine("z1 = " + z1.Print());
                Console.WriteLine("z2 = " + z2.Print());
                Console.WriteLine("выберите действие над комплексными числами (+, -, *, /, 0 - выход)");
                D = Console.ReadLine();
                switch(D){
            	    case "+": res = z1 + z2; break;
            	    case "-": res = z1 - z2; break;
            	    case "*": res = z1*z2; break;
            	    case "/": res = z1/z2; break;
            	    case "0": break;
            	    default: Console.WriteLine("Некорректная команда."); break;
            }

            if(D=="+" || D=="-" || D=="*" || D=="/"){ Console.WriteLine($"z1 {D} z2 = " + res.Print()); }
            
            Console.WriteLine("___________");
            }


            
           
        }
    }
}
