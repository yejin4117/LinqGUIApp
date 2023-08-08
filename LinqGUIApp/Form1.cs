using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqGUIApp
{
    public partial class Form1 : Form
    {
        static private List<Product> products = new List<Product>()
        {
            new Product(){ Name ="맥북", Price=2000000},
            new Product(){ Name ="메모장", Price=2000},
            new Product(){ Name ="샤프", Price=3000},
            new Product(){ Name ="노트", Price=3000},
            new Product(){ Name ="웹캠", Price=200000},
            new Product(){ Name ="스마트폰", Price=2100000},
            new Product(){ Name ="가방", Price=50000},
            new Product(){ Name ="껌", Price=1000},
            new Product(){ Name ="비닐봉지", Price=100},
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            productBindingSource.DataSource = products;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            productBindingSource.DataSource = from item in products
                                              where item.Price >= 1500
                                              orderby item.Price descending
                                              select item;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            productBindingSource.DataSource = from item in products
                                              orderby item.Name ascending
                                              select item;
        }
    }
}