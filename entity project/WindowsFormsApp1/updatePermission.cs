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
    public partial class updatePermission : Form
    {
        public updatePermission()
        {
            InitializeComponent();
        }

        private void updatePermission_Load(object sender, EventArgs e)
        {
            Model1 ent = new Model1();
            // dataGridView1.ClearSelection();
            foreach (permission p in ent.Permission)
            {

                comboBox1.Items.Add(p.permissionId.ToString());
                // dataGridView1.DataSource=object.st.ToList(st.stockId + st.name + st.address + st.employeeName);

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(comboBox1.Text);
            Model1 ent = new Model1();
            permission p = (from d in ent.Permission
                            where d.permissionId == id

                            select d).First();
            textBox1.Text = p.empName;
            textBox2.Text = p.createdDate.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model1 ent = new Model1();
            int id = int.Parse(comboBox1.Text);
            permission p = ent.Permission.Find(id);
            if (p != null)
            {
                p.empName = textBox1.Text;
                p.createdDate = Convert.ToDateTime(textBox2.Text);
                ent.SaveChanges();
                MessageBox.Show("done");

            }
            else
            {
                MessageBox.Show("not avilble permission");
            }
        }
    }
}
