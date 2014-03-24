using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Web.Security;

namespace Shop
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btSublg_Click(object sender, EventArgs e)
        {
            SqlConnection UGIcon = new SqlConnection(ConfigurationManager.ConnectionStrings["ApplicationServices"].ConnectionString);

            UGIcon.Open();

            if (TextBox1.Text == "admin" & TextBox2.Text == "admin")
            {
                Response.Redirect("AdminFirst.aspx");
            }

            else 
            {
                SqlCommand cmd = new SqlCommand("SELECT Username,Password FROM Logindetails WHERE Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'", UGIcon);

                SqlDataReader dr = cmd.ExecuteReader();

                string userText = TextBox1.Text;
                string passText = TextBox2.Text;




                while (dr.Read())
                {
                    if ((dr["Username"].ToString() == userText) && (dr["Password"].ToString() == passText))
                    {
                        Session["Username"] = userText;
                     //   Response.Redirect("Webform22.aspx");
                        Response.Redirect("OutletFirst.aspx");

                    }
                    else
                    {
                        Response.Write("Invalid!!");
                    }

                }
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm27.aspx");
        }

        
        }
    }
