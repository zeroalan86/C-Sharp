using Hackathon006.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon006
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefuleTable data = new RefuleTable()
            {
                RefuelingDate = dateTimePicker1.Value,
                Liter = (double)numericUpDown1.Value,
                Kilometer = (double)numericUpDown2.Value
            };
            try
            {
                RefuleModel context = new RefuleModel();
                context.RefuleTable.Add(data);
                context.SaveChanges();
                MessageBox.Show("存檔完成");
            }
            catch (Exception ex)
            { MessageBox.Show($"發生錯誤{ex.ToString()}"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
