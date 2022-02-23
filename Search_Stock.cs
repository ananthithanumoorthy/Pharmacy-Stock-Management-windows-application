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
using System.Data;

namespace Medical_Store_System
{
    public partial class Search_Stock : Form
    {
        public Search_Stock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Item_Name.Text=="")
                {
                    Console.WriteLine("Please enter the Item Name");
                }
                if (txt_Item_NUM.Text=="")
                {
                    Console.WriteLine("Please enter the Item Number");
                }

                SqlConnection conn = new SqlConnection("Data Source=ANANTHITHANUMOO;Initial Catalog=MedicalDB;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("select * from Stock where name='" + txt_Item_Name.Text + "' and no='" + txt_Item_NUM.Text + "'", conn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                cmd.ExecuteNonQuery();
                dataGridView1.DataSource = ds.Tables[0];



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
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
