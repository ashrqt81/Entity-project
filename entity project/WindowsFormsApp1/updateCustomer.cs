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
    public partial class updateCustomer : Form
    {
        public updateCustomer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Model1 ent = new Model1();
            int id = int.Parse(comboBox1.Text);
            buddy b = ent.buddy.Find(id);
            if (b != null)
            {
                b.name = textBox1.Text;
                b.phone = textBox2.Text;
                b.fax = textBox3.Text;
                b.mail = textBox4.Text;
                b.website = textBox5.Text;
                //stc.createdDate = textBox4.Text;
                ent.SaveChanges();
                MessageBox.Show("done");

            }
            else
            {
                MessageBox.Show("not avilble stock");
            }
        }

        private void updateCustomer_Load(object sender, EventArgs e)
        {
            Model1 ent = new Model1();
           // dataGridView1.ClearSelection();
            foreach (buddy b in ent.buddy)
            {
                if(b.buddyType==buddyType.customer)
                comboBox1.Items.Add(b.buddyId.ToString());
                // dataGridView1.DataSource=object.st.ToList(st.stockId + st.name + st.address + st.employeeName);

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int id = int.Parse(comboBox1.Text);
            Model1 ent = new Model1();
            buddy st = (from d in ent.buddy
                        where d.buddyId == id
                        where d.buddyType == buddyType.customer
                        select d).First();
            textBox1.Text = st.name;
            textBox2.Text = st.phone;
            textBox3.Text = st.fax;
            textBox4.Text = st.mail;
            textBox5.Text = st.website;

        }
    }
}
