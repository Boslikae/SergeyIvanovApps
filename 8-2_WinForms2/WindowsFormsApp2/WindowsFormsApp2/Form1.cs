using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Xml.Serialization;



namespace WindowsFormsApp2
{   
   public partial class Form1 : Form
    {

        static void SaveAsXmlFormat(List<Numbers> obj, string fileName)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Numbers>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, obj);
            fStream.Close();
        }

        static void LoadFromXmlFormat(ref List<Numbers> obj, string fileName)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Numbers>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            obj = (List<Numbers>)xmlFormat.Deserialize(fStream);
            fStream.Close();
        }

        public void createList()
        {
            string[] TN = { "ноль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять", "десять", "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнацдать", "двадцать" };
            int i = 0;
            List<Numbers> list = new List<Numbers>();

            foreach (string tn in TN)
            {            
                Numbers numb = new Numbers { number = i, textNumber = tn };
                list.Add(numb);
                i++;
            }

            SaveAsXmlFormat(list, "data.xml");
        }
        
        public List<Numbers> LoadList()
        {
            List<Numbers> list = new List<Numbers>();
            LoadFromXmlFormat(ref list, "data.xml");
            return list;
        }

        public void LoadTextBox(List<Numbers> list)
        {
            foreach (var v in list)
            {
                if (numericUpDown1.Value == v.number && numericUpDown1.Value <= 20)
                {
                    textBox1.Text = $"{numericUpDown1.Value} - {v.textNumber}"; break;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();

            //createList();

            List<Numbers> list = new List<Numbers>();
            list = LoadList();
            LoadTextBox(list);
           
            
            // json //
            //Numbers numbers = new Numbers { number = 0, textNumber = "zero" };
            //Numbers numbers1 = new Numbers { number = 1, textNumber = "one" };
            //string json = JsonSerializer.Serialize<Numbers>(numbers);

        }

        public void ChangeTextBox()
        {
            List<Numbers> list = LoadList();
            LoadTextBox(list);
        }

        public void ReadFile()
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ChangeTextBox();
        }
    }
}
