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
    public partial class ViewForm : Form
    {
        public ViewForm()
        {
            InitializeComponent();
            BindData();
        }

        private void BindData()
        {
            var context = new RefuleModel();
            var list = context.RefuleTable.ToList();
            dataGridView1.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Startdate = dateTimePicker1.Value;
            var Enddate = dateTimePicker2.Value;

            RefuleModel a = new RefuleModel();
            var middate1 = a.RefuleTable.Where((x) => x.RefuelingDate >= Startdate);
            var middate2 = middate1.Where((x) => x.RefuelingDate <= Enddate);
            var list1 = middate2.ToList();
            dataGridView1.DataSource = list1;
            
            var TotalLiter = a.RefuleTable.Sum(x => x.Liter);
            var TotalKilometer = a.RefuleTable.Sum(x => x.Kilometer);
            var TotalAverage = TotalKilometer / TotalLiter;
            label4.Text = TotalAverage.ToString();
        }
    }
}
