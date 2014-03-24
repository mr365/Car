using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Security;
using System.Data;

namespace Shop
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (Page.IsValid)
            {
                try
                {
                    string Email, UserId;
                    Email = txtEmail.Text;
                    UserId = txtUser.Text;
                    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ApplicationServices"].ConnectionString);
                    string valCmd = "select Username,Email from Logindetails";
                    SqlCommand CMD = new SqlCommand(valCmd, con);
                    con.Open();
                    string cmd = "insert into Logindetails (Username,Password,Firstname,Lastname,MobileNumber,Address,Email) values('" + txtUser.Text + "','" + txtPass.Text + "','" + txtFname.Text + "','" + txtLname.Text + "','" + txtMnum.Text + "','" + txtAddress.Text + "','" + txtEmail.Text + "') ";
                    SqlCommand Cmd = new SqlCommand(cmd, con);



                    Cmd.ExecuteNonQuery();
                    Response.Cookies["Username"].Value = txtUser.Text;
                    Response.Cookies["Password"].Value = txtPass.Text;


                    con.Close();
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Username already exists");
                    lblMessage.Text="Username already exists";
                }

        }

            }
        protected void val(object source, ServerValidateEventArgs args)
        {
            SqlConnection valcon = new SqlConnection(ConfigurationManager.ConnectionStrings["ApplicationServices"].ConnectionString);
            string valcom = "select * from Logindetails";
            SqlCommand ValCOM = new SqlCommand(valcom, valcon);
            valcon.Open();
            if (valcon.State == ConnectionState.Open)
            {
                SqlDataReader valrd = ValCOM.ExecuteReader();
                while (valrd.Read())
                {
                    if (valrd[0].ToString().Equals(txtUser.Text))
                    { args.IsValid = false; }
                    else { args.IsValid = true; }
                }



            }

            valcon.Close();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Webform27.aspx");
        }



        
    }


}