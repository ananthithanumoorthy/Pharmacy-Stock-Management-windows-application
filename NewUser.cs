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
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }
        Controller2.Class1 Obj = new Controller2.Class1();
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txt_UID.Text == "")
            {
                MessageBox.Show("Please enter ID");
                txt_UID.Focus();
                return;

            }
            if (txt_Name.Text == "")
            {
                MessageBox.Show("Please enter NAME");
                txt_Name.Focus();
                return;
            }

            if (txt_UName.Text == "")
            {
                MessageBox.Show("Please enter USERNAME");
                txt_UName.Focus();
                return;
            }
            if (txt_Pwd.Text == "")
            {
                MessageBox.Show("Please enter PASSWORD");
                txt_Pwd.Focus();
                return;
            }

            try
            {

                int x = Obj.NewUser(txt_Id.Text, txt_Name.Text, txt_UName.Text, txt_Pwd.Text);

                if (x == 1)
                {
                    MessageBox.Show("User Registered succefully");
                    Login lgObj = new Login();
                    lgObj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("User Registeration failed");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}

