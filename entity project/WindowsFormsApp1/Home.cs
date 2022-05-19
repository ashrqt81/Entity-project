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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addstock s = new addstock();
            s.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addProduct p = new addProduct();
            p.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addSalepermission s = new addSalepermission();
            s.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addPermission x = new addPermission();
            x.ShowDialog();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addCustomer s = new addCustomer();
            s.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            addBuddy x = new addBuddy();
            x.ShowDialog();

        }
    }
}
