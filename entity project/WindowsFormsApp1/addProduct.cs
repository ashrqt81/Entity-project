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
    public partial class addProduct : Form
    {
        public addProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model1 Ent = new Model1();
            product product = new product();
            product.name = textBox1.Text;
            product.code =Convert.ToInt32( textBox2.Text);
            product.createddate =Convert.ToDateTime( textBox3.Text);
            product.productionDate =Convert.ToDateTime( textBox4.Text);
            product.expireDate =Convert.ToDateTime( textBox5.Text);
            product.quantity = textBox6.Text;
            product.measureUnit = textBox7.Text;
           
            Ent.product.Add(product);
            Ent.SaveChanges();
            
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = string.Empty;
            MessageBox.Show("تمت الاضافه");
        }

        private void addProduct_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateProduct d = new updateProduct();
            d.ShowDialog();
        }
    }
}
