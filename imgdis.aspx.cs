using System;
using System.IO;
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
    public partial class WebForm15 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             SqlConnection a = new SqlConnection(ConfigurationManager.ConnectionStrings["ApplicationServices"].ConnectionString);
             String cmd = "select * from Productdetails where ProdID='pd5'";

             SqlCommand b = new SqlCommand(cmd, a);



            a.Open();

            using (SqlDataReader reader = b.ExecuteReader())
            {
                if (reader.Read())
                {
                    byte[] picData = reader["ProductImage"] as byte[] ?? null;

                   if (picData != null)
                    {
                        
                            using (MemoryStream ms = new MemoryStream(picData))
                            {
                                // Load the image from the memory stream. How you do it depends
                                // on whether you're using Windows Forms or WPF.
                                // For Windows Forms you could write:
                                try
                                {
                                    System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(ms);
                                }
                                catch(Exception ea)
                                {
                                    Console.WriteLine("{0} Exception caught.", ea);
                                }
                            }
                        }
                       

                    }
                }
            }
        }
    }
