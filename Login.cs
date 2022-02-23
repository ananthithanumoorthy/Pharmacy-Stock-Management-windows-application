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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewUser usrObj = new NewUser();
            usrObj.Show();
            this.Hide();
        }


        Controller2.Class1 Obj = new Controller2.Class1();
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter UserName");
                textBox1.Focus();
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Please enter Password");
                textBox2.Focus();
                return;
            }
            int x = Obj.LogIn(textBox1.Text, textBox2.Text);
            if (x >= 1)
            {
                Home hmObj = new Home();
                hmObj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid UsrName/Password");
            }
          
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }
    }
}
