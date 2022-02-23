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
    public partial class ViewStock : Form
    {
        public ViewStock()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home hmObj = new Home();
            hmObj.Show();
            this.Hide();
        }
        Controller2.Class1 Obj1 = new Controller2.Class1();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(" Data Source=ANANTHITHANUMOO; Initial Catalog = MedicalDB; Integrated Security = true");
                SqlCommand cmd = new SqlCommand("select * from [Stock]", conn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                int i = da.Fill(ds);

                if (i >= 1)
            {
                Console.WriteLine("Here is available stocks");
                    dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                Console.WriteLine("No Stocks available");
            }
        }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            //dataGridView1.DataSource = x.Tables[0];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home hm_obj = new Home();
            hm_obj.Show();
            this.Hide();
        }
    }
    
}
