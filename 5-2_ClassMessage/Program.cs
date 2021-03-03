using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Collections.Generic;

// Сергей Иванов
// Задание 5.2
// Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
// а) Вывести только те слова сообщения,  которые содержат не более n букв.
// б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
// в) Найти самое длинное слово сообщения.
// г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
// д) ***Создать метод, который производит частотный анализ текста. 
// В качестве параметра в него передается массив слов и текст, 
// в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. 
// Здесь требуется использовать класс Dictionary.

namespace _5_2_ClassMessage
{
	public static class Message
	{
		public static string[] SplitText(string text)
		{
      		string[] words = text.Split(' ',',','.','!',':',';','?','(',')','-');
      		return words;
		}

		public static string nLetters(string word, int n)
		{
           int Ln = word.Length;
           if(Ln<=n){ return word; }
           else{ return String.Empty; }
		}

		public static string RemoveEndSymbol(string word, char c)
		{
           Regex pattern = new Regex($"[{c}]$");
           if(pattern.IsMatch(word)){ return String.Empty; }
           else{ return word; }
		}

		public static string[] MostLongWords(string text)
		{
			string[] words = Message.SplitText(text);

			int n = words.Length;
			int max = words[0].Length;
			int c = 0;
			int count = 0;

			for(var i=0;i<n;i++)
            {
            	if(max < words[i].Length)
            	{ 
            		max = words[i].Length;
            		c = i;
            	}           	
            }

            for(int i=0;i<n;i++){ if(words[i].Length == max){ count++; } }
  
            string[] WORDS = new string[count];
            int j = 0;

            for(int i=0;i<n;i++)
            {
                if(words[i].Length == max){ WORDS[j]=words[i]; j++; }
            }

            return WORDS;
		}

		public static Dictionary<int, string> TextAnalytics(string text)
		{
			string[] words = Message.SplitText(text);
			int n = words.Length;
			int j = 0;

			Dictionary<int, string> TEXT = new Dictionary<int, string>();
			
            for(int i=0;i<n;i++)
            {
                if(words[i].Length!=0)
                { 
                	int c = 0;
                	for(int k=0;k<n;k++)
                	{
                		if(words[i]==words[k]){ c++; }
                	}

                	TEXT.Add(j, $"{words[i]} ({c})"); 
                	j++; 
                }               
            }
            
            return TEXT;

		}
	}

    class Program
    {
        static void Main(string[] args)
        {
            //string text = String.Empty;
            int n = 7;
            char c = 'й';


            string text = "Приветствую, старый друг! Я пишу тебе из далёкой и загадочной Патагонии - страны гор и приключений, вечных ледников и потрясающей природы!";
            
            Console.WriteLine(text);
            Console.WriteLine("______");

            //Console.Write("Введите сообщение: ");
            //text = Console.ReadLine();

            string[] words = Message.SplitText(text);

            foreach(var word in words)
            {
                string WORD = Message.nLetters(word, n);
                if(WORD != String.Empty){ Console.WriteLine($"{WORD} "); }               
            }

            Console.WriteLine("______");

            foreach(var word in words)
            {
            	string WORD = Message.RemoveEndSymbol(word, c);
            	if(WORD != String.Empty){ Console.WriteLine($"{WORD} "); }   
            }

            Console.WriteLine("______");

            string[] WORDS = Message.MostLongWords(text);
            foreach(string WORD in WORDS)
            {
            	Console.WriteLine(WORD);
            }
            
            Console.WriteLine("______");
            int Ln = WORDS.Length;
            StringBuilder sb = new StringBuilder($"{WORDS[0]}");
            for(int i=1;i<Ln;i++){
            	sb.Append($" {WORDS[i]}");
            }
            Console.WriteLine(sb);

            Console.WriteLine("______");

 			Dictionary<int, string> TEXT = new Dictionary<int, string>();
            TEXT = Message.TextAnalytics(text);
            foreach(KeyValuePair<int, string> keyValue in TEXT)
            		{
            			Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            		}

        }
    }
}
