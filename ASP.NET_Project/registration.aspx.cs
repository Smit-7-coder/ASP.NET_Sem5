using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ASP.NET_Project
{
    public partial class registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\ASP.NET\\ASP.NET_Sem5\\ASP.NET_Project\\App_Data\\Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            string query = "Insert into Register Values('"+Nametxt.Text+"','"+Passwordtxt.Text+"', '"+Emailtxt.Text+"', '"+Contactxt.Text+"')";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('Registration Successfull')</script>");
            con.Close();
        }
    }
}