using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;

namespace Shop
{
    /// <summary>
    /// Summary description for Handler1
    /// </summary>
    public class Handler1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            if (context.Request.QueryString["L_plate_no"] == null) { return; }

            String conn = ConfigurationManager.ConnectionStrings["ApplicationServices"].ConnectionString;
            String L_plate_no1 = context.Request.QueryString["L_plate_no"];

            using (SqlConnection connection = new SqlConnection(conn))
            {
                using (SqlCommand command = new SqlCommand("SELECT ProductImage from Productdetails where L_plate_no = @L_plate_no", connection))
                {
                    command.Parameters.Add(new SqlParameter("@L_plate_no", L_plate_no1));
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        try
                        {
                            reader.Read();
                            context.Response.BinaryWrite((byte[])reader[reader.GetOrdinal("ProductImage")]);
                            reader.Close();
                        }
                        catch (InvalidCastException e)
                        {
                            Console.WriteLine("{0} Exception caught.", e);
                        }
                    }
                }
            }

        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}