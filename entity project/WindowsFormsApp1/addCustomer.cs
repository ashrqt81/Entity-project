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
    public partial class addCustomer : Form
    {
        public addCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model1 Ent = new Model1();
            buddy b = new buddy();
            b.buddyType = buddyType.customer;
            b.name = textBox1.Text;
            b.phone = textBox2.Text;
            b.fax = textBox3.Text;
            b.mail = textBox4.Text;
            b.website = textBox5.Text;


            Ent.buddy.Add(b);
            Ent.SaveChanges();

            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = string.Empty;
            MessageBox.Show("تمت الاضافه");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateCustomer d = new updateCustomer();
            d.ShowDialog();

        }
    }
}
