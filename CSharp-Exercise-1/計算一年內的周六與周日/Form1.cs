using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinterHomework006
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var value1 = textBox1.Text;
            var value = Convert.ToInt32(value1);
            var saturday = 0;
            var sunday = 0;
            for (int month = 1; month <= 12; month++)
            {
                DateTime dt = new DateTime(value, month, 1);
                do
                {
                    if (dt.DayOfWeek == DayOfWeek.Saturday)
                    {
                        saturday++;
                    }
                    else if (dt.DayOfWeek == DayOfWeek.Sunday)
                    {
                        sunday++;
                    }
                    dt = dt.AddDays(1);    //??
                } while (dt.Month == month);
            }
            label1.Text = "周六天數為 :" + saturday;
            label2.Text = "周日天數為 :" + sunday;
        }
    }
}
