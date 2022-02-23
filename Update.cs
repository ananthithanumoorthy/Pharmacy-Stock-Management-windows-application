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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home Hm_Obj = new Home();
            Hm_Obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=ANANTHITHANUMOO;Initial Catalog=MedicalDB;Integrated Security=true");
                
                SqlCommand cmd = new SqlCommand("update Stock set price='" + txt_Price.Text + "' where name='" + txt_Item_Name.Text + "'", conn);

                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
                int x = cmd.ExecuteNonQuery();
                if (x == 1)
                {

                    Console.WriteLine("Stock Details Updated Successfully");

                }
                else
                {
                    Console.WriteLine("something went erong");
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void Update_Load(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(" Data Source=ANANTHITHANUMOO; Initial Catalog = MedicalDB; Integrated Security = true");
            SqlCommand cmd = new SqlCommand("select * from Stock;", conn);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home hm_Obj = new Home();
            hm_Obj.Show();
            this.Hide();
        }
    }
}
