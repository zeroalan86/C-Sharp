using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework005
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Cabbage = (int)(numericUpDown1.Value);
            int Driedbeans = (int)(numericUpDown2.Value);
            int Kelp = (int)(numericUpDown3.Value);
            int Meat = (int)(numericUpDown4.Value);
            int Total = Cabbage * 30 + Driedbeans * 15 + Kelp * 15 + Meat * 40;
            label10.Text = Total.ToString();

            int Thousand = Total / 1000;
            label18.Text = Thousand.ToString();
            int FiveHundred = (Total % 1000) / 500;
            label19.Text = FiveHundred.ToString();
            int Hundred = (Total % 1000 % 500) / 100;
            label20.Text = Hundred.ToString();
            int Fifty = (Total % 1000 % 500 % 100) / 50;
            label21.Text = Fifty.ToString();
            int Ten = (Total % 1000 % 500 % 100 % 50) / 10;
            label22.Text = Ten.ToString();
            int Five = (Total % 1000 % 500 % 100 % 50 % 10) / 5;
            label23.Text = Five.ToString();
            int one = (Total % 1000 % 500 % 100 % 50 % 10 % 5) / 1;
            label24.Text = one.ToString();
        }
    }
}
