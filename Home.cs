using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller2;

namespace Medical_Store_System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ViewStock vwObj = new ViewStock();
            vwObj.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AddStock adstockObj = new AddStock();
            adstockObj.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Update Upt_Obj = new Update();
            Upt_Obj.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            DeleteStock dlObj = new DeleteStock();
            dlObj.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Search_Stock Search_Obj = new Search_Stock();
            Search_Obj.Show();
            this.Hide();
        }
    }
}
