using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class addstock : Form
    {
        public addstock()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateStock s = new updateStock();
            s.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model1 Ent = new Model1();
            stock stock = new stock();
            stock.name = textBox1.Text;
            
            stock.createdDate = Convert.ToDateTime(textBox2.Text);
            stock.address = textBox3.Text;
           
            stock.employeeName = textBox4.Text;

            Ent.stock.Add(stock);
            Ent.SaveChanges();

            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = string.Empty;
            MessageBox.Show("تمت الاضافه");
        }

    }
}

