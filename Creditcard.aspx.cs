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
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string Creditcard, UserID;
                Creditcard = Label7.Text;
                UserID = txtUserc.Text;
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ApplicationServices"].ConnectionString);
                // string valCmd = "select Username,CreditcardNumber from Creditcard";
                // SqlCommand CMD = new SqlCommand(valCmd, con);


                con.Open();
               // int n = Convert.ToInt32(Label7.Text);

                string cmd = "insert into Credit values('" + txtUserc.Text + "','" + TextBox1.Text + "','" + txtNamec.Text + "','" + txtTypec.Text + "','" + txtTypec.Text + "','" + txtSsnc.Text + "','" + txtExpiryc.Text + "') ";
                    SqlCommand Cmd = new SqlCommand(cmd, con);




                   int result= Cmd.ExecuteNonQuery();
                    Response.Cookies["Username"].Value = txtUserc.Text;
                    Response.Cookies["CreditcardNumber"].Value = txtUserc.Text;


                    con.Close();
                    if (result > 0)
                    {
                        
                        //Label8.Text = "Credit card details saved Successfully";
                       // Session["Message"] = Label8.Text;
                        Response.Redirect("LogoutMari.aspx");

                    }
            


                
               
            }




        }

          protected void val(object source, ServerValidateEventArgs args)
        {
            SqlConnection valcon = new SqlConnection(ConfigurationManager.ConnectionStrings["ApplicationServices"].ConnectionString);
            string valcom = "select * from Creditcard";
            SqlCommand ValCOM = new SqlCommand(valcom, valcon);
            valcon.Open();
            if (valcon.State == ConnectionState.Open)
            {
                SqlDataReader valrd = ValCOM.ExecuteReader();
                while (valrd.Read())
                {
                    if (valrd[0].ToString().Equals(txtUserc.Text))
                    { 
                        args.IsValid = false; 
                    }
                    else 
                    { 
                        args.IsValid = true; 
                    }
                }



            }

            valcon.Close();
        }

          protected void txtUserc_TextChanged(object sender, EventArgs e)
          {
              SqlConnection valcon = new SqlConnection(ConfigurationManager.ConnectionStrings["ApplicationServices"].ConnectionString);
              string valcom = "select * from Creditcard";
              SqlCommand ValCOM = new SqlCommand(valcom, valcon);
              valcon.Open();
              if (valcon.State == ConnectionState.Open)
              {
                  SqlDataReader valrd = ValCOM.ExecuteReader();
                  while (valrd.Read())
                  {
                      if (valrd[0].ToString().Equals(txtUserc.Text))
                      {
                          Label7.Text = valrd.GetValue(1).ToString();
                          txtNamec.Text = valrd.GetValue(2).ToString();
                          txtTypec.Text = valrd.GetValue(3).ToString();
                          txtSsnc.Text = valrd.GetValue(4).ToString();
                          txtExpiryc.Text = valrd.GetValue(5).ToString();
                          
                      }
                     
                  }



              }

              valcon.Close();
          }



        
    }

    }
