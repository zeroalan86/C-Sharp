using Homework002.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BindData();
        }

        private void BindData()
        {
            var context = new PerformanceModel1();
            var list = context.PerformanceTable.ToList();
            dataGridView1.DataSource = list;
            var list1 = context.ProductTable.ToList();
            dataGridView2.DataSource = list1;
            var result =
                   from t in list
                   join s in list1
                   on t.Productitem equals s.Productitem
                   select new ResultInfo
                   { Salesman = t.Salesman, Product = t.Productitem, Price = s.Price, Total = t.Quantity * s.Price, ProductQuentity = t.Quantity };
            var a = result.Max(x => x.Total);
            var b = result.Where(x => x.Total == a);
            foreach (var item in b)
            {
                label2.Text = item.Salesman;
            }

            var result1 =
                from o in result
                group o by o.Product;
            List<int> f = new List<int>();
            foreach (var item in result1)
            {
                var c =  item.Sum(y => y.Total);
                f.Add(c);  
            }

            IEnumerable<string> best;
            foreach(var item in result1)
            {
                best =item.Where(x=>item.Sum(y => y.Total) == f.Max(z=>z)).Select(x => item.Key);      //key = ProductName
                foreach(var i in best)
                {
                    label4.Text = i.ToString();
                }
            }
        }
    }
}
