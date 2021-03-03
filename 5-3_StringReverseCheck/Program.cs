using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Collections.Generic;

// Сергей Иванов
// Задание 5.3
// *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
// Например:
// badc являются перестановкой abcd.

namespace _5_3_StringReverseCheck
{
    class Program
    {
        static bool StringReverseCheck(string str1, string str2)
        {
        	if(str1.Length!=str2.Length){ return false; }
        	else
        	{
        		char[] a1 = str1.ToArray();
           		int n = str1.Length;
           		string ptr = String.Empty;
                
                for(int i=n-1;i>=0;i--)
                {
                    ptr = ptr + a1[i];
                }

				Regex pattern = new Regex($"^{ptr}");
                
                if(pattern.IsMatch(str2)){ return true; }
                else { return false; }               
        	}
        
        	return false;
        }

        static void Main(string[] args)
        {
            
            string str1 = "qwerty";
            string str2 = "ytrewq";
            string str3 = "qweRty";
            string str4 = "ytRewq ";
            string str5 = " qweRty";


            string[] str = {str1, str2, str3, str4, str5};
            int n = str.Length;
            bool check = false;

            Console.WriteLine("Являются ли следующие строки перестановкой друг друга: ");

            for(int i=0;i<n;i++)
            {
            	for(int j=0;j<n;j++)
            	{
            		if(i!=j)
            		{
            		 	check = StringReverseCheck(str[i],str[j]); 
            			Console.WriteLine($"строка '{str[i]}' и строка '{str[j]}' -> {check}");
            		}
            	}	
            }


        }
    }
}
