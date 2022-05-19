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
    public partial class addBuddy : Form
    {
        public addBuddy()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {//start wx textbox2
            Model1 Ent = new Model1();
            buddy b = new buddy();
            b.buddyType = buddyType.supplier;
            b.name = textBox2.Text;
            b.phone = textBox3.Text;
            b.fax = textBox4.Text;
            b.mail = textBox5.Text;
            b.website = textBox6.Text;
           

            Ent.buddy.Add(b);
            Ent.SaveChanges();

            textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text =  string.Empty;
            MessageBox.Show("تمت الاضافه");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateBuddy x = new updateBuddy();
            x.ShowDialog();
        }
    }
}
