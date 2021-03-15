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
    public partial class Form1 : Form, IView
    {
        Presenter presenter;
        public Form1(int X)
        {
            InitializeComponent();
            presenter = new Presenter(this);
            btnCommand1.Text = $"+{presenter.b}";
            btnCommand2.Text = $"x{presenter.m}";
            lblNumber.Text = "1";
            lblCount.Text = "0";
            lblTask.Text = $"{X}";
            label3.Visible = false;
        }

        public string Numb => lblNumber.Text;

        public string Task => lblTask.Text;

       // public bool Victory => label3.Visible;

        public string Counter 
        {
            get => lblCount.Text;
            set => lblCount.Text = value;
        }

        public string Result { set => lblNumber.Text = value; }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            presenter.Sum();
            presenter.Counter();
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            presenter.Mult();
            presenter.Counter();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            presenter.Reset();
            presenter.ResetCounter();
        }

        private void lblNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblCount_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            presenter.CancelTurn();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
