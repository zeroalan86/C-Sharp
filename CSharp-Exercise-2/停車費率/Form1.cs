using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework006
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int StartDay = dateTimePicker1.Value.Day;
            int StartHour = dateTimePicker1.Value.Hour;
            int StartMinute = dateTimePicker1.Value.Minute;
            int EndDay = dateTimePicker2.Value.Day;
            int EndHour = dateTimePicker2.Value.Hour;
            int EndMinute = dateTimePicker2.Value.Minute;
            int Totalday = EndDay - StartDay;
            int Totalhour = EndHour - StartHour;
            int TotalMinute = EndMinute - StartMinute;
            


            if(Totalhour <= 2)
            {
                label2.Text = (((Totalhour * 60 + TotalMinute) / 30) * 30).ToString();
            }
            else if(Totalhour < 4)
            {
                label2.Text = (((Totalhour * 60 + TotalMinute) / 30) * 40).ToString();
            }
            else if(Totalhour >= 4)
            {
                label2.Text = ((((Totalday * 24 + Totalhour) * 60 + TotalMinute) / 30) * 60).ToString();
            }
        }
    }
}
