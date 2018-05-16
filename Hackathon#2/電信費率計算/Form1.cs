using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int StartHour = dateTimePicker1.Value.Hour;
            int StartMinute = dateTimePicker1.Value.Minute;
            int EndHour = dateTimePicker2.Value.Hour;
            int EndMinute = dateTimePicker2.Value.Minute;

            int TotalMinute = (EndHour - StartHour) * 60 + (EndMinute - StartMinute);
            label5.Text = TotalMinute.ToString();

            int Chu = 350 + TotalMinute * 4;
            int Fetnet = 400 + TotalMinute * 3;
            int Taiwan = 500 + TotalMinute * 2;

            label6.Text = Chu.ToString();
            label7.Text = Fetnet.ToString();
            label8.Text = Taiwan.ToString();

            List<Class1> list = new List<Class1>();
            list.Add(new Class1 { PhoneName = "中華電信", Price = Chu });
            list.Add(new Class1 { PhoneName = "遠傳電信", Price = Fetnet });
            list.Add(new Class1 { PhoneName = "台灣大哥大", Price = Taiwan });
            var min = list.Min((x) => x.Price);
            var name = list.Where((x) => x.Price == min);
            string a = string.Empty;
            foreach (var item in name)
            {
                a += item.PhoneName;
                label9.Text = a;
            }
        }
    }
}
