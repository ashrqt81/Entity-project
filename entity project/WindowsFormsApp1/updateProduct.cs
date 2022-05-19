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
    public partial class updateProduct : Form
    {
        public updateProduct()
        {
            InitializeComponent();
        }

        private void updateProduct_Load(object sender, EventArgs e)
        {
            Model1 ent = new Model1();
           // dataGridView1.ClearSelection();
            foreach (product p in ent.product)
            {

                comboBox1.Items.Add(p.productId.ToString());
                // dataGridView1.DataSource=object.st.ToList(st.stockId + st.name + st.address + st.employeeName);

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(comboBox1.Text);
            Model1 ent = new Model1();
            product p = (from d in ent.product
                         where d.productId == id
                         select d).First();
            textBox1.Text = p.name;
            textBox2.Text = p.code.ToString();
            textBox3.Text = p.createddate.ToString();
            textBox4.Text = p.productionDate.ToString();//mtnsesh el date
            textBox5.Text = p.expireDate.ToString();//mtnsesh el date
            textBox6.Text = p.quantity;
            textBox7.Text = p.measureUnit;

        }

        private void update_Click(object sender, EventArgs e)
        {
            Model1 ent = new Model1();
            int id = int.Parse(comboBox1.Text);
            product p = ent.product.Find(id);
            if (p != null)
            {
                p.name = textBox1.Text;
                //stc.address = textBox2.Text;
                //stc.employeeName = textBox3.Text;
                //stc.createdDate = textBox4.Text;
                p.quantity = textBox5.Text;
                p.measureUnit = textBox6.Text;
                ent.SaveChanges();
                MessageBox.Show("done");

            }
            else
            {
                MessageBox.Show("not avilble products");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
