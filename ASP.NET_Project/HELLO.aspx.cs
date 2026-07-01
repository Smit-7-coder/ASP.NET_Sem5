using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_Project
{
    public partial class HELLO : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label3.Visible = false;
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void LOGIN_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtEmail.Text);
            int b = Convert.ToInt32(txtPassword.Text);

            int c = a + b;
            Label3.Visible = true;
            Label3.Text = "Sum = " + c;
        }

        protected void sub_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtEmail.Text);
            int num2 = Convert.ToInt32(txtPassword.Text);

            int subs = num1 - num2;
            Label3.Visible = true;
            Label3.Text = "Substraction = " + subs;
        }

        protected void TextBox1_TextChanged1(object sender, EventArgs e)
        {

        }
    }
}