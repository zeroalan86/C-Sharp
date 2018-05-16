using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int[] answer = new int[10];
        private string[] gress = new string[10];

        private Random random = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 4; i++)
            {
                int r = random.Next(0, 10);
                bool same = false;
                foreach (var n in answer)
                {
                    if (r == n) { same = true; break; }
                    if (n == 10) { same = false; break; }
                }
                if (same == false)
                {
                    answer[i] = r;
                }
                else
                {
                    i--;
                }
            }
            button1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string num = "";
            int a = 0, b = 0;
            if (textBox1.TextLength != 4)
            {
                MessageBox.Show("請輸入4個不同的數字");
            }
            else
            {
                for (int i = 1; i <= 4; i++)
                {
                    gress[i] = textBox1.Text.Substring(i - 1, 1);
                    num += gress[i].ToString();
                }
                if ((gress[1] == gress[2] || gress[1] == gress[3]
                    || gress[1] == gress[4] || gress[2] == gress[3]
                    || gress[2] == gress[4] || gress[3] == gress[4]))
                {
                    MessageBox.Show("數字不可相同");
                }
                else
                {
                    for (int k = 0; k <= 4; k++)
                    {
                        for (int j = 0; j <= 4; j++)
                        {
                            if (gress[k] == answer[j].ToString())
                            {
                                if (k == j)
                                {
                                    a++;
                                }
                                else if (k != j)
                                {
                                    b++;
                                }
                            }
                        }
                    }
                    textBox2.Text += num + "--" + a.ToString() + "A" + b.ToString() + "B" + "\r\n";
                    textBox1.Focus();
                    textBox1.SelectAll();
                }
                if (a == 4 && b == 0)
                {
                    MessageBox.Show("全對");
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            for (int i = 1; i <= 4; i++)
            {
                label3.Text += answer[i];
            }
        }
    }
}

