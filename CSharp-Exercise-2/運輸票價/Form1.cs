using HoneWork003.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoneWork003
{
    public partial class Form1 : Form
    {
        public TrainStationTable Data { get; set; }

        public Form1()
        {
            InitializeComponent();
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (TrainStationModel tsm = new TrainStationModel())
            {
                var list = tsm.TrainStationTable.ToList();
                if (radioButton1.Checked == true)
                {
                    var end = from o in list
                              where o.StartStation.ToString() == ((TrainStationTable)(comboBox1.SelectedItem)).StartStation.ToString()
                              select o;
                    comboBox2.DataSource = end.ToList();
                    comboBox2.DisplayMember = "EndStation";
                }
                else
                {
                    var end = list.Where((x) => x.EndStation.ToString() == ((TrainStationTable)(comboBox1.SelectedItem)).EndStation.ToString());
                    comboBox2.DataSource = end.ToList();
                    comboBox2.DisplayMember = "StartStation";
                }
            }
        }
        private void SetSouthComboBox()
        {
            using (TrainStationModel tsm = new TrainStationModel())
            {
                var list = tsm.TrainStationTable.ToList();
                var start = list.Distinct(new TicketStartEquityComparer()).ToList();
                var end = list.Distinct(new TicketEndEquityComparer()).ToList();
                comboBox1.DataSource = start;
                comboBox2.DataSource = end;
                comboBox1.DisplayMember = "StartStation";
                comboBox2.DisplayMember = "EndStation";
            }
         }

        private void SetNorthComboBox()
        {
            using (TrainStationModel tsm = new TrainStationModel())
            {
                var list = tsm.TrainStationTable.ToList();
                var start = list.Distinct(new TicketStartEquityComparer()).ToList();
                var end = list.Distinct(new TicketEndEquityComparer()).ToList();
                comboBox1.DataSource = end;
                comboBox2.DataSource = start;
                comboBox1.DisplayMember = "EndStation";
                comboBox2.DisplayMember = "StartStation";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SetSouthComboBox();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            SetNorthComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var tsm = new TrainStationModel())
            {
                var list = tsm.TrainStationTable.ToList();
                if(radioButton1.Checked == true)//south
                {
                    var southprice = list.Where((x) => x.StartStation.ToString() == ((TrainStationTable)(comboBox1.SelectedItem)).StartStation.ToString() && x.EndStation.ToString() == ((TrainStationTable)(comboBox2.SelectedItem)).EndStation.ToString());
                    if(checkBox1.Checked == true && checkBox2.Checked == true)
                    {
                        label3.Text = (Math.Ceiling(southprice.First().Fare * 0.81 * 2)).ToString();
                    }
                    else if(checkBox2.Checked == true)
                    {
                        label3.Text = (Math.Ceiling(southprice.First().Fare * 0.9)).ToString();
                    }
                    else if (checkBox1.Checked == true)
                    {
                         label3.Text = (Math.Ceiling(southprice.First().Fare * 2 * 0.9)).ToString();
                    }
                    else
                    {
                        label3.Text = southprice.First().Fare.ToString();
                    }
                }
                else         //north
                {
                    var northprice = list.Where((x) => x.EndStation.ToString() == ((TrainStationTable)(comboBox1.SelectedItem)).EndStation.ToString() && x.StartStation.ToString() == ((TrainStationTable)(comboBox2.SelectedItem)).StartStation.ToString());
                    if (checkBox1.Checked == true && checkBox2.Checked == true)
                    {
                        label3.Text = (Math.Ceiling(northprice.First().Fare * 0.81 * 2)).ToString();
                    }
                    else if (checkBox2.Checked == true)
                    {
                        label3.Text = (Math.Ceiling(northprice.First().Fare * 0.9)).ToString();
                    }
                    else if (checkBox1.Checked == true)
                    {
                        label3.Text = (Math.Ceiling(northprice.First().Fare * 2 * 0.9)).ToString();
                    }
                    else
                    {
                        label3.Text = northprice.First().Fare.ToString();
                    }
                }
            }
        }
    }
}
