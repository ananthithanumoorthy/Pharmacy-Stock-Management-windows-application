using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Controller2
{
    public class Class1
    {
		
			public int AddStock(string a, string b, string c, string d)
			{
				SqlConnection conn = new SqlConnection("Data Source = ANANTHITHANUMOO; Initial Catalog =MedicalDB; Integrated Security = true");
				SqlCommand cmd = new SqlCommand("insert into Stock values('" + a + "','" + b + "','" + c + "','" + d + "')", conn);
				conn.Open();
				return cmd.ExecuteNonQuery();
			}

			//public int ViewStock()
			//{
			//	SqlConnection conn = new SqlConnection(" Data Source=ANANTHITHANUMOO; Initial Catalog = MedicalDB; Integrated Security = true");
			//	SqlCommand cmd = new SqlCommand("select * from [Stock]", conn);
			//	conn.Open();
			//	SqlDataAdapter da = new SqlDataAdapter(cmd);
			//	DataSet ds = new DataSet();
			  
			//int i=da.Fill(ds);
			//	return i;
			//}

			public int LogIn(string a, string b)
			{
				SqlConnection conn = new SqlConnection(" Data Source=ANANTHITHANUMOO; Initial Catalog = MedicalDB; Integrated Security = true");
				SqlCommand cmd = new SqlCommand("select * from UserTable where UserName='" + a + "' and Pwd='" + b + "'", conn);
				conn.Open();
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataSet ds = new DataSet();
				da.Fill(ds);
				return Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
			}

			public int NewUser(string a, string b, string c, string d)
			{
				SqlConnection conn = new SqlConnection("Data Source = ANANTHITHANUMOO; Initial Catalog =MedicalDB; Integrated Security = true");
				SqlCommand cmd = new SqlCommand("insert into UserTable values('" + a + "','" + b + "','" + c + "','" + d + "')", conn);
				conn.Open();
				return cmd.ExecuteNonQuery();
			}

			public int DeleteStock(string a, string b, string c)
			{
				SqlConnection conn = new SqlConnection("Data Source = ANANTHITHANUMOO; Initial Catalog =MedicalDB; Integrated Security = true");
				SqlCommand cmd = new SqlCommand("delete from Stock where name='" + a + "' and  no='" + b + "' and  price= '" + c + "' ", conn);
				conn.Open();
				//SqlDataAdapter da = new SqlDataAdapter(cmd);
				//DataSet ds = new DataSet();
				//da.Fill(ds);
				return cmd.ExecuteNonQuery();
			}
		}
	
}
