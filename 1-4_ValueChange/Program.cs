using System;

// Сергей Иванов
// Задание 1.4:
// Написать программу обмена значениями двух переменных.
// а) с использованием третьей переменной;
// б) *без использования третьей переменной.

namespace _04_ValueChange
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 100;
            int B = 17;
            int C;

            Console.WriteLine("Программа обмена значениями двух переменных");
            Console.WriteLine("Значение переменной A = " + A);
            Console.WriteLine("Значение переменной B = " + B);

            
            Console.WriteLine("Нажмите Ввод для обмена значениями переменных A и B с использованием третьей переменной C.");
            Console.ReadLine();

            C = B;
            B = A;
            A = C;

            Console.WriteLine("Значение переменной A = " + A);
            Console.WriteLine("Значение переменной B = " + B);

            Console.WriteLine("Намите Ввод для обмена значениями переменных A и B без использование третьей переменной");

            A = A + B;
            B = A - B;
            A = A - B;

            Console.WriteLine("Значение переменной A = " + A);
            Console.WriteLine("Значение переменной B = " + B);

            Console.WriteLine("_____");


        }
    }
}
