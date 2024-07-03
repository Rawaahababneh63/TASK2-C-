using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Label3.Text =$"Name :{TextBox1.Text}";
            Label4.Text = $" Email :{TextBox2.Text}";
            Label5.Text =$" ID :{TextBox3.Text}" ;


            if (RadioButton1.Checked)
            {
                Label6.Text = " Gender : Female";
            }
            else if (RadioButton2.Checked)
            {
                Label6.Text = " Gender :Male";
            }


            Label8.Text=string.Empty ;
            if (CheckBox3.Checked)
            {
                Label8.Text = "C++  ";
            }
            if (CheckBox2.Checked)
            {
                Label8.Text += "C#   ";
            }
           if (CheckBox1.Checked)
            {
                Label8.Text += "C   ";
            }
            Label10.Text =$"Message : {TextBox4.Text}";
        }
    }
}