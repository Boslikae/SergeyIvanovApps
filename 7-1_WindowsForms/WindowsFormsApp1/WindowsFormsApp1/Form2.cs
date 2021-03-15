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
    public partial class Form2 : Form
    {
        //Presenter presenter;
        public Form2(int X, int a, int b)
        {
            InitializeComponent();
            //presenter = new Presenter(this);
            lblHead.Text = $"Угадай число от {a} до {b}";
            lblTask.Text = $"{X}";
            lblTask.Visible = false;
            lblVictory.Visible = false;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if(textBox.Text == lblTask.Text) 
            {
                lblTask.Visible = true;
                lblVictory.Visible = true;
            }
            
        }
    }
}
