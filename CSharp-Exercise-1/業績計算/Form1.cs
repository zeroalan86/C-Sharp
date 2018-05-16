using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinterHomework008
{
    public partial class Form1 : Form
    {
        private List<Stationeryshop> list;
        private List<Productsaleslist> _list;
        public Form1()
        {
            InitializeComponent();
            CreateData();
            CreateData2();
            dataGridView1.DataSource = list;
            dataGridView2.DataSource = _list;
            var bestsalesperson = list.Where(x => x.Sale == list.Max(y => y.Sale));
            var totalsalesmaxgoods = _list.Where(x=>x.Totalsales==_list.Max(y=>y.Totalsales));
            foreach(var i in bestsalesperson)
            {
                label5.Text = i.Person;
            }
            foreach (var item in totalsalesmaxgoods)
            {
                label6.Text = item.Goods;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CreateData()
        {
            list = new List<Stationeryshop>();
            list.Add(new Stationeryshop { Person = "Bill", Pen = "33", Pencil = "32", Eraser = "56", Ruler = "45", Liwhite = "33", Sale = "2593" });
            list.Add(new Stationeryshop { Person = "John", Pen = "77", Pencil = "33", Eraser = "68", Ruler = "45", Liwhite = "23", Sale = "3107" });
            list.Add(new Stationeryshop { Person = "David", Pen = "43", Pencil = "55", Eraser = "43", Ruler = "67", Liwhite = "65", Sale = "3739" });

        }

        private void CreateData2()
        {
            _list = new List<Productsaleslist>();
            _list.Add(new Productsaleslist { Goods = "原子筆", One = "12", Salesvolume = "153", Totalsales = "1836" });
            _list.Add(new Productsaleslist { Goods = "鉛筆", One = "16", Salesvolume = "120", Totalsales = "1920" });
            _list.Add(new Productsaleslist { Goods = "橡皮擦", One = "10", Salesvolume = "167", Totalsales = "1670" });
            _list.Add(new Productsaleslist { Goods = "直尺", One = "14", Salesvolume = "157", Totalsales = "2198" });
            _list.Add(new Productsaleslist { Goods = "立可白", One = "15", Salesvolume = "121", Totalsales = "1815" });
        }
    }
}
