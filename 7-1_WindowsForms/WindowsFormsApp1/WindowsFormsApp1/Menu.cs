using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Menu : Form
    {
        int X;
        public Menu()
        {
            InitializeComponent();
        }

        protected int GenerateX(int a, int b)
        {
            Random rnd = new Random();
            int X = rnd.Next(a,b);
            return X;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            int a = 24;
            int b = 1024;
            X = GenerateX(a, b);
            MessageBox.Show($"Соберите число {X} за наименьшее число ходов!");
            var f = new Form1(X);
            f.Show();
        }

        private void btnGuessPlay_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 100;
            X = GenerateX(a, b);          
            var f = new Form2(X, a, b);
            f.Show();
        }
    }
}
