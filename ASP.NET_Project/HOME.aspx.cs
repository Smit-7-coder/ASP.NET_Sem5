using System;
using System.IO;

namespace ASP.NET_Project
{
    public partial class HOME : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if (email == "admin@gmail.com" && password == "12345")
            {
                lblMessage.CssClass = "text-success";
                lblMessage.Text = "Login Successful";
            }
            else
            {
                lblMessage.CssClass = "text-danger";
                lblMessage.Text = "Invalid Email or Password";
            }
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (fuImage.HasFile)
            {
                string folder = Server.MapPath("~/Uploads/");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                string extension = Path.GetExtension(fuImage.FileName);

                string fileName = Guid.NewGuid().ToString() + extension;

                string path = Path.Combine(folder, fileName);

                fuImage.SaveAs(path);

                lblMessage.CssClass = "text-success";
                lblMessage.Text = "File Uploaded Successfully";
            }
            else
            {
                lblMessage.CssClass = "text-danger";
                lblMessage.Text = "Please Select a File";
            }
        }
    }
}