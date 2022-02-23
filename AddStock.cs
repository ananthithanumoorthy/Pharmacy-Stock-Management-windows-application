using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Controller2;
namespace Medical_Store_System
{
    public partial class AddStock : Form
    {
        public AddStock()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home hmObj = new Home();
            hmObj.Show();
            this.Hide();
        }
        Controller2.Class1 Obj = new Controller2.Class1();
        private void button1_Click(object sender, EventArgs e)
        {


            if (txt_Itemno.Text == "")
            {
                MessageBox.Show("Please enter Item No");
                txt_Itemno.Focus();
                return;
            }
            if (txt_ItName.Text == "")
            {
                MessageBox.Show("Please enter ItemName");
                txt_ItName.Focus();
                return;
            }
            
            if (txt_Price.Text == "")
            {
                MessageBox.Show("Please enter price");
                txt_Price.Focus();
                return;
            }
            if (txt_qty.Text == "")
            {
                MessageBox.Show("Please enter Quantity");
                txt_qty.Focus();
                return;
            }
           
            int x=  Obj.AddStock(txt_ItName.Text, txt_ItName.Text, txt_Price.Text, txt_qty.Text);
            
            

            if (x == 1)
            {
                MessageBox.Show("Stock added succefully");

            }
            else
            {
                MessageBox.Show("Stock added succefully");
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home hm_obj = new Home();
            hm_obj.Show();
            this.Hide();
        }
    }
}
