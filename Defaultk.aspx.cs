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
    public partial class WebForm13 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        protected void btnSee_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowImagekmain.aspx");
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string L_plate_no = PlateNum.Text;
                string L_plate_state = PlateState.Text;
                string Model = txtProductDescription.Text;
                string ProdType = txtProductType.Text;
               // string Color = txtColor.Text;
               // string Class = txtClass.Text;
                string price_per_day = txtProdprice.Text;
                string price_per_week = txtPricePerWeek.Text;
                string price_per_month = txtProductMonth.Text;
                string Outlet = txtOutlet.Text;
                


                byte[] pictureId = FileUpload1.FileBytes;


                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ApplicationServices"].ConnectionString);
                string query = "INSERT INTO Productdetails( L_plate_no,L_plate_state, Model,ProdType,price_per_day,price_per_week,price_per_month,Outlet,ProductImage) VALUES(@L_plate_no,@L_plate_state,@Model,@ProdType,@price_per_day,@price_per_week,@price_per_month,@Outlet,@PictureId)";

                // SqlConnection con = new SqlConnection(constr);
                SqlCommand com = new SqlCommand(query, con);
                com.Parameters.Add("@L_plate_no", SqlDbType.VarChar).Value = L_plate_no;
                com.Parameters.Add("@L_plate_state", SqlDbType.VarChar).Value = L_plate_state;
                com.Parameters.Add("@Model", SqlDbType.VarChar).Value = Model;
                //com.Parameters.Add("@Color", SqlDbType.VarChar).Value = Color;
                com.Parameters.Add("@ProdType", SqlDbType.VarChar).Value = ProdType;
                com.Parameters.Add("@price_per_day", SqlDbType.VarChar).Value = price_per_day;
                com.Parameters.Add("@price_per_week", SqlDbType.VarChar).Value = price_per_week;
                com.Parameters.Add("@price_per_month", SqlDbType.VarChar).Value = price_per_month;
                com.Parameters.Add("@Outlet", SqlDbType.VarChar).Value = Outlet;
                com.Parameters.Add("@PictureId", SqlDbType.VarBinary).Value = pictureId;

                con.Open();
                int result = com.ExecuteNonQuery();
                con.Close();

                if (result > 0)
                {
                    lblMessage.Text = "Car Saved Successfully";
                }
            }
            else
            {
                lblMessage.Text = "Please Select Car Product Image File";
            } 
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Adminfirst.aspx");
        }

        
        protected void txtProductDescription_TextChanged(object sender, EventArgs e)
        {

        }

        protected void PlateNum_TextChanged(object sender, EventArgs e)
        {

        }

        protected void PlateState_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtProdprice_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtOutlet_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtProductType_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtPricePerWeek_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtProductMonth_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}