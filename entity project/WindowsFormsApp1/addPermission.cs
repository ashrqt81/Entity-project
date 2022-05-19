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
    public partial class addPermission : Form
    {
        public addPermission()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //purchase
            Model1 ent = new Model1();
            permission p = new permission();
            p.productId = Convert.ToInt32(textBox1.Text);
            p.StockId = Convert.ToInt32(textBox2.Text);
            p.number = Convert.ToInt32(textBox3.Text);
            p.createdDate = Convert.ToDateTime(textBox4.Text);
            p.empName = textBox5.Text;
            p.buddyId = Convert.ToInt32(textBox6.Text);
            p.permissionType = permissionType.purchase;
            ent.Permission.Add(p);
            ent.SaveChanges();//////////////

            productStock productStock = ent.ProductStock.Where(a => a.ProductId == p.productId && a.stockId == p.StockId).FirstOrDefault();
            if(productStock == null)
            {
                productStock proStock = new productStock();
                proStock.stockId = p.StockId;
                proStock.ProductId = p.productId;
                proStock.quantity = p.number; 
                ent.ProductStock.Add(proStock);
                ent.SaveChanges();


            }else
            {
                productStock.quantity += p.number;
                ent.SaveChanges();
            }
          
           
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = string.Empty;
            // dataGridView1.DataSource=object.st.ToList(st.stockId + st.name + st.address + st.employeeName);
            MessageBox.Show("done");
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updatePermission x = new updatePermission();
            x.ShowDialog();
        }
    }
}
