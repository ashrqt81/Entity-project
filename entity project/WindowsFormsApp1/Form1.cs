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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            Model1 Ent = new Model1();
            stock stock = new stock();
            stock.name = textBox1.Text;
            stock.address = textBox2.Text;
            stock.createdDate = Convert.ToDateTime(textBox3.Text);
            stock.employeeName = textBox4.Text;
            Ent.stock.Add(stock);
            Ent.SaveChanges();
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = string.Empty;
            MessageBox.Show("تمت الاضافه");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateStock frm2 = new updateStock();
           
            frm2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addProduct frm2 = new addProduct();
            frm2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            updateProduct up = new updateProduct();
            up.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addBuddy supplier = new addBuddy();
            supplier.ShowDialog();
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            addCustomer customer = new addCustomer();
            customer.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            updateCustomer updateCust = new updateCustomer();
            updateCust.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            addPermission per = new addPermission();
            per.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            updatePermission x = new updatePermission();
            x.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            addSalepermission s = new addSalepermission();
            s.ShowDialog();
        }
    }
}
