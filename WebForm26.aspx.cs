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
    public partial class WebForm26 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox2.Text=Session["totalcost"].ToString();
            
             SqlConnection a = new SqlConnection(ConfigurationManager.ConnectionStrings["ApplicationServices"].ConnectionString);

                String cmd = "select creditlevel from Logindetails";

                SqlCommand b = new SqlCommand(cmd, a);

                a.Open();

                b.ExecuteNonQuery();



                SqlConnection valcon = new SqlConnection(ConfigurationManager.ConnectionStrings["ApplicationServices"].ConnectionString);
                string valcom = "select * from Logindetails";
                SqlCommand ValCOM = new SqlCommand(valcom, valcon);
                valcon.Open();
                if (valcon.State == ConnectionState.Open)
                {
                    SqlDataReader valrd = ValCOM.ExecuteReader();
                    while (valrd.Read())
                    {

                        if (valrd[0].ToString().Equals(Session["Username"].ToString()))
                        {
                            TextBox1.Text = valrd.GetValue(7).ToString();
                            if (TextBox1.Text == "Silver")
                            {
                                string cost = valrd.GetValue(8).ToString();
                                int c = Convert.ToInt32(cost);
                                int x = c - 1000;
                                TextBox4.Text = x.ToString();

                               
                            }
                            else if (TextBox1.Text == "Gold")
                            {
                                string cost = valrd.GetValue(8).ToString();
                                int c = Convert.ToInt32(cost);
                                int x = c - 2000;
                                TextBox4.Text = x.ToString();


                            }

                            else if (TextBox1.Text == "Platinum")
                            {
                                string cost = valrd.GetValue(8).ToString();
                                int c = Convert.ToInt32(cost);
                                int x = c - 3000;
                                TextBox4.Text = x.ToString();


                            }

                        }

                    }





                    valcon.Close();
                }

               
            }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Response.Redirect("OrderConfirmation.aspx");
            
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        }
    }
