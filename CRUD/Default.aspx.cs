using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Web.Configuration;
using System.Web.UI.WebControls;

namespace CRUD
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Student", con);
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            da.Fill(ds);
            //GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            
        }

       
        protected void Button2_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.DeleteCommand = new SqlCommand("delete from login where id=@a", con);
            //da.DeleteCommand.Parameters.AddWithValue("@a",TextBox1.Text);
            da.DeleteCommand.ExecuteNonQuery();
            Response.Write("Information is deleted");
              
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter();            
            da.UpdateCommand = new SqlCommand("update login set id=@a,Name=@b where id=@a", con);
           // da.UpdateCommand.Parameters.AddWithValue("@a", TextBox1.Text);
           // da.UpdateCommand.Parameters.AddWithValue("@b", TextBox2.Text);
            da.UpdateCommand.ExecuteNonQuery();
            Response.Write("Information Updated.");
            
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
                
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
                string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(str);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Student", con);
                SqlCommand cmd = new SqlCommand();           
                DataSet ds = new DataSet();            
                da.Fill(ds);
                GridView1.DataSource = ds.Tables[0]; 
                GridView1.DataBind();
                        
        }

        protected void ChangePassword1_ChangedPassword(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.DeleteCommand = new SqlCommand("delete from login where id=@a", con);
          //  da.DeleteCommand.Parameters.AddWithValue("@a", TextBox1.Text);
            da.DeleteCommand.ExecuteNonQuery();
            Response.Write("Information is deleted");
            con.Close();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("insert into table values (@a,@b)");
            cmd.Connection = con;
         //   cmd.Parameters.AddWithValue("@a",TextBox1.Text);
         //   cmd.Parameters.AddWithValue("@b", TextBox2.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void SqlDataSource3_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {
            
        }
    }
}