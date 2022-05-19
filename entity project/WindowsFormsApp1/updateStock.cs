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
    public partial class updateStock : Form
    {
        public updateStock()
        {
            InitializeComponent();
        }

        private void updateStock_Load(object sender, EventArgs e)
        {
            Model1 ent = new Model1();
            //dataGridView1.ClearSelection();
            foreach(stock st in ent.stock)
            {
                
                comboBox1.Items.Add(st.stockId.ToString());
               // dataGridView1.DataSource=object.st.ToList(st.stockId + st.name + st.address + st.employeeName);

            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model1 ent = new Model1();
            int id = int.Parse(comboBox1.Text);
            stock stc = ent.stock.Find(id);
            if(stc != null)
            {
                stc.name = textBox1.Text;
                stc.address = textBox2.Text;
                stc.employeeName = textBox3.Text;
                stc.createdDate = Convert.ToDateTime(textBox4.Text);
                ent.SaveChanges();
                MessageBox.Show("done");
             
            }
            else
            {
                MessageBox.Show("not avilble stock");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int id = int.Parse(comboBox1.Text);
            Model1 ent = new Model1();
            stock st = (from d in ent.stock
                        where d.stockId == id
                        select d).First();
            textBox1.Text = st.name;
            textBox2.Text = st.address;
            textBox3.Text = st.employeeName;
            textBox4.Text = st.createdDate.ToString();//mtnsesh el date
            //textBox4.Text = dateTime;

        }
    }
}
