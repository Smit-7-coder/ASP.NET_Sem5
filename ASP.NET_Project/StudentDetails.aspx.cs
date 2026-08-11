using System;

namespace MultiViewDemo
{
    public partial class StudentDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // View 1 -> View 2
        protected void btnNext1_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        // View 2 -> View 1
        protected void btnPrevious_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }

        // View 2 -> View 3
        protected void btnNext2_Click(object sender, EventArgs e)
        {
            // Personal Information
            lblName.Text = txtName.Text;
            lblGender.Text = rblGender.SelectedValue;
            lblAddress.Text = txtAddress.Text;
            lblDegree.Text = ddlDegree.SelectedValue;

            // Contact Information
            lblEmail.Text = txtEmail.Text;
            lblContact.Text = txtContact.Text;

            MultiView1.ActiveViewIndex = 2;
        }

        // View 3 -> View 2
        protected void btnPrevious2_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }
    }
}