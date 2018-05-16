using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinterHomework009
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //CreateListstart();
            //CreateListend();
            CreateListprice();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)        //南下 判斷訖站
            {
                _listend = new List<string>();
                foreach (trainlist t in southPrice)
                {
                    if (t.fromlocation.ToString() == comboBox1.SelectedItem.ToString() && !_listend.Exists((x) => x == t.location.ToString()))
                    {
                        _listend.Add(t.location.ToString());
                    }
                }
            }
            else
            {
                _listend = new List<string>();
                foreach (trainlist t in northPrice)
                {
                    if (t.fromlocation.ToString() == comboBox1.SelectedItem.ToString() && !_listend.Exists((x) => x == t.location.ToString()))
                    {
                        _listend.Add(t.location.ToString());
                    }
                }
            }

            SetCombobox();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (radioButton1.Checked == true)                          因combobox1與combobox2會互斥
            //{
            //    _liststart = new List<string>();
            //    foreach (trainlist t in southPrice)
            //    {
            //        if (t.location.ToString() == comboBox2.SelectedItem.ToString() && !_liststart.Exists((x) => x == t.fromlocation.ToString()))
            //        {
            //            _liststart.Add(t.fromlocation.ToString());
            //        }
            //    }
            //}
            //else
            //{
            //    _liststart = new List<string>();
            //    foreach (trainlist t in northPrice)
            //    {
            //        if (t.location.ToString() == comboBox2.SelectedItem.ToString() && !_liststart.Exists((x) => x == t.fromlocation.ToString()))
            //        {
            //            _liststart.Add(t.fromlocation.ToString());
            //        }
            //    }
            //}

            //SetCombobox();
        }

        private List<string> _liststart;
        private List<string> _listend;
        private List<trainlist> southPrice;
        private List<trainlist> northPrice;
        //private void CreateListstart()
        //{
        //    _liststart = new List<trainlist>();
        //    _liststart.Add(new trainlist { fromlocation = "臺北" });
        //    _liststart.Add(new trainlist { fromlocation = "新竹" });
        //    _liststart.Add(new trainlist { fromlocation = "臺中" });
        //    _liststart.Add(new trainlist { fromlocation = "嘉義" });
        //    _liststart.Add(new trainlist { fromlocation = "臺南" });
        //    _liststart.Add(new trainlist { fromlocation = "高雄" });
        //}

        //private void CreateListend()
        //{
        //    _listend = new List<trainlist>();
        //    _listend.Add(new trainlist { location = "臺北" });
        //    _listend.Add(new trainlist { location = "新竹" });
        //    _listend.Add(new trainlist { location = "臺中" });
        //    _listend.Add(new trainlist { location = "嘉義" });
        //    _listend.Add(new trainlist { location = "臺南" });
        //    _listend.Add(new trainlist { location = "高雄" });
        //}

        private void CreateListprice()
        {
            southPrice = new List<trainlist>();
            southPrice.Add(new trainlist { fromlocation = "臺北", location = "新竹", price = 177 });
            southPrice.Add(new trainlist { fromlocation = "新竹", location = "臺中", price = 197 });
            southPrice.Add(new trainlist { fromlocation = "臺中", location = "嘉義", price = 224 });
            southPrice.Add(new trainlist { fromlocation = "嘉義", location = "臺南", price = 139 });
            southPrice.Add(new trainlist { fromlocation = "臺南", location = "高雄", price = 106 });
            southPrice.Add(new trainlist { fromlocation = "臺北", location = "臺中", price = 375 });
            southPrice.Add(new trainlist { fromlocation = "新竹", location = "嘉義", price = 421 });
            southPrice.Add(new trainlist { fromlocation = "臺中", location = "臺南", price = 363 });
            southPrice.Add(new trainlist { fromlocation = "嘉義", location = "高雄", price = 245 });
            southPrice.Add(new trainlist { fromlocation = "臺北", location = "嘉義", price = 598 });
            southPrice.Add(new trainlist { fromlocation = "新竹", location = "臺南", price = 560 });
            southPrice.Add(new trainlist { fromlocation = "臺中", location = "高雄", price = 469 });
            southPrice.Add(new trainlist { fromlocation = "臺北", location = "臺南", price = 738 });
            southPrice.Add(new trainlist { fromlocation = "新竹", location = "高雄", price = 755 });
            southPrice.Add(new trainlist { fromlocation = "臺北", location = "高雄", price = 842 }); //south
            northPrice = new List<trainlist>();
            northPrice.Add(new trainlist { fromlocation = "新竹", location = "臺北", price = 177 });
            northPrice.Add(new trainlist { fromlocation = "臺中", location = "新竹", price = 197 });
            northPrice.Add(new trainlist { fromlocation = "嘉義", location = "臺中", price = 224 });
            northPrice.Add(new trainlist { fromlocation = "臺南", location = "嘉義", price = 139 });
            northPrice.Add(new trainlist { fromlocation = "高雄", location = "臺南", price = 106 });
            northPrice.Add(new trainlist { fromlocation = "臺中", location = "臺北", price = 375 });
            northPrice.Add(new trainlist { fromlocation = "嘉義", location = "新竹", price = 421 });
            northPrice.Add(new trainlist { fromlocation = "臺南", location = "臺中", price = 363 });
            northPrice.Add(new trainlist { fromlocation = "高雄", location = "嘉義", price = 245 });
            northPrice.Add(new trainlist { fromlocation = "嘉義", location = "臺北", price = 598 });
            northPrice.Add(new trainlist { fromlocation = "臺南", location = "新竹", price = 560 });
            northPrice.Add(new trainlist { fromlocation = "高雄", location = "臺中", price = 469 });
            northPrice.Add(new trainlist { fromlocation = "臺南", location = "臺北", price = 738 });
            northPrice.Add(new trainlist { fromlocation = "高雄", location = "新竹", price = 755 });
            northPrice.Add(new trainlist { fromlocation = "高雄", location = "臺北", price = 842 }); //north
        }

        private void SetCombobox()
        {
            comboBox1.DataSource = _liststart;
            comboBox2.DataSource = _listend;
            comboBox1.DisplayMember = "fromlocation";
            comboBox2.DisplayMember = "location";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Returnticket = 0;
            int Discountticket = 0;
            int otherticket = 0;
            foreach (var item in southPrice)
            {
                if(comboBox1.SelectedItem.ToString() == item.fromlocation && comboBox2.SelectedItem.ToString() == item.location)
                {
                    label4.Text = item.price.ToString();
                    if(checkBox1.Checked == true)
                    {
                        Returnticket = Convert.ToInt32(Math.Ceiling((decimal)item.price * 0.9m));
                        label4.Text = Returnticket.ToString();
                    }
                    else if(checkBox2.Checked == true)
                    {
                        Discountticket = Convert.ToInt32(Math.Ceiling((decimal)item.price * 0.9m));
                        label4.Text = Discountticket.ToString();
                    }
                    else if((checkBox1.Checked == true) && (checkBox2.Checked == true))
                    {
                        otherticket = Convert.ToInt32(Math.Ceiling((decimal)item.price * 0.81m));
                        label4.Text = otherticket.ToString();
                    }
                    break;
                    
                }
                else if(comboBox1.SelectedItem.ToString() == item.fromlocation && comboBox2.SelectedItem.ToString() == item.location)  
                {
                    label4.Text = item.price.ToString();
                    if (checkBox1.Checked == true)
                    {
                        Returnticket = Convert.ToInt32(Math.Ceiling((decimal)item.price * 0.9m));
                        label4.Text = Returnticket.ToString();
                    }
                    else if (checkBox2.Checked == true)
                    {
                        Discountticket = Convert.ToInt32(Math.Ceiling((decimal)item.price * 0.9m));
                        label4.Text = Discountticket.ToString();
                    }
                    else if ((checkBox1.Checked == true) && (checkBox2.Checked == true))
                    {
                        otherticket = Convert.ToInt32(Math.Ceiling((decimal)item.price * 0.81m));
                        label4.Text = otherticket.ToString();
                    }
                    break;
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            _liststart = new List<string>();
            foreach(trainlist t in southPrice)
            {
                if(!_liststart.Exists((x)=>x == t.fromlocation.ToString()))
                {
                    _liststart.Add(t.fromlocation.ToString());
                }
            }

            _listend = new List<string>();
            foreach (trainlist t in southPrice)
            {
                if (!_listend.Exists((x) => x == t.location.ToString()))
                {
                    _listend.Add(t.location.ToString());
                }
            }

            SetCombobox();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            _liststart = new List<string>();
            foreach (trainlist t in northPrice)
            {
                if (!_liststart.Exists((x) => x == t.fromlocation.ToString()))
                {
                    _liststart.Add(t.fromlocation.ToString());
                }
            }

            _listend = new List<string>();
            foreach (trainlist t in northPrice)
            {
                if (!_listend.Exists((x) => x == t.location.ToString()))
                {
                    _listend.Add(t.location.ToString());
                }
            }

            SetCombobox();
        }
    }
}
