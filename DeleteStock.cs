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
    public partial class DeleteStock : Form
    {
        public DeleteStock()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home hmObj = new Home();
            hmObj.Show();
            this.Hide();
        }
        Controller2.Class1 Obj = new Class1();
        private void button1_Click(object sender, EventArgs e)
        {

            if (txt_Item_Name.Text == "")
            {
                MessageBox.Show("Please enter the name of the item");
                txt_Item_Name.Focus();
                return;
            }
            if (txt_Item_No.Text == "")
            {
                MessageBox.Show("Please enter the no of the item");
                txt_Item_No.Focus();
                return;
            }
            if (txt_Price.Text == "")
            {
                MessageBox.Show("Please enter the price of the item");
                txt_Price.Focus();
                return;
            }
            int x = Obj.DeleteStock(txt_Item_Name.Text,txt_Item_No.Text,txt_Price.Text);
                
            if (x == 1)
            {
                MessageBox.Show("Stock Deleted succefully");
                Home hmObj = new Home();
                hmObj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Particular stock not available");
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home hmObj = new Home();
            hmObj.Show();
            this.Hide();
        }
    }
    
}
