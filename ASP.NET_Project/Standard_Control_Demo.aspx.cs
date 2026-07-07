using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_Project
{
    public partial class Standard_Control_Demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible = false;
            Label2.Visible = false;
            Label3.Visible = false;
            Label4.Visible = false;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Label1.Visible = true;
            Label2.Visible = true;
            Label1.Text = "You Selected: " + Calendar1.SelectedDate.ToString("dd-MM-yyyy");
            Label2.Text = "You Selected: " + Calendar1.SelectedDate.DayOfWeek.ToString();
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label2.Visible = true;
            if (RadioButton1.Checked)
            {
                Label2.Text = "You Selected Male";
            }
            else if(RadioButton2.Checked)
            {
                
                    Label2.Text = "You Selected Female";
                
            }
            else
            {
                Label2.Text = "Select Atleat any one option";
            }
        }
        protected void See_Price(object sender, EventArgs e)
        {
            Label3.Visible = true;
            Label4.Visible = true;
            Label3.Text = "";

            int Total = 0;

            if (CheckBox1.Checked)
            {
                Label3.Text += CheckBox1.Text + " - ₹1000<br/>";
                Total += 1000;
            }

            if (CheckBox2.Checked)
            {
                Label3.Text += CheckBox2.Text + " - ₹2000<br/>";
                Total += 2000;
            }

            if (CheckBox3.Checked)
            {
                Label3.Text += CheckBox3.Text + " - ₹3000<br/>";
                Total += 3000;
            }

            if (Total == 0)
            {
                Label3.Text = "Please select at least one item.";
                Label4.Text = "";
            }
            else
            {
                Label4.Text = "Total Price: ₹" + Total;
            }
        }

        protected void List_Click(object sender, EventArgs e)
        {
            Label4.Visible = true;
            Label4.Text = ListBox1.Text;
        }

    }
}