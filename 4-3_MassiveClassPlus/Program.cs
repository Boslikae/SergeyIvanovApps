using System;
using System.IO;
using System.Threading;

// Сергей Иванов
// Задание 4.3
// а) Дописать класс для работы с одномерным массивом. Реализовать конструктор,
// создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом. 
// Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse, 
// возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений), 
// метод Multi, умножающий каждый элемент массива на определённое число, 
// свойство MaxCount, возвращающее количество максимальных элементов. 
// б)** Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
// е) --> ??? <-- *** Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary<int,int>)

namespace _4_2_MassiveClassPlus
{

    class Program
    {

        static void Main(string[] args)
        {
            int a = 0;
            int val = 0;
            int step = 0;
            int Sum = 0;
            int x = 2;

            Console.Write("Размер массива: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Начальное число первого элемента массива: ");
            val = int.Parse(Console.ReadLine());

            Console.Write("Шаг: ");
            step = int.Parse(Console.ReadLine());


            MyArray array = new MyArray(a);
            int n = array.Length();

            for(int i=0;i<n;i++)
            {
               	array.Set(i,val);
               	val = val + step;
            }
            
           	for(int i=0;i<n;i++)
           	{
           		Console.WriteLine(array.Get(i));
           	}

           	Sum = array.Sum(n);
           	Console.WriteLine($"Сумма всех элементов массива = {Sum}");

           	Console.WriteLine($"Длина массива = {array.Length()}");
 			Console.WriteLine("_______");


            Console.WriteLine("метод reverse: ");
            MyArray array2 = new MyArray(n);

            array2 = array.Reverse(array);
            

            for(int i=0;i<n;i++)
            {
            	Console.WriteLine(array2.Get(i));
            }

            Console.WriteLine("Первый массив: ");
            for(int i=0;i<n;i++)
            {
            	Console.WriteLine(array.Get(i));
            }

            Console.WriteLine("_______");

            Console.WriteLine("метод multi: ");
            array2 = array2.Multi(array2,x);

            for(int i=0;i<n;i++)
            {
            	Console.WriteLine(array2[i]);
            }

            Console.WriteLine("_______");

            int MaxCount = array.MaxCount();
            Console.WriteLine($"Количество максимальных элементов в массиве = {MaxCount}");

        


        }         
    }
}
