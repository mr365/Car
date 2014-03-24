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
    public partial class WebForm16 : System.Web.UI.Page
    {
        String con = ConfigurationManager.ConnectionStrings["ApplicationServices"].ConnectionString;

       

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindFiles();
            }

        }
        private void BindFiles()
        {
            DataTable table = new DataTable();


           
            using (SqlConnection cmd = new SqlConnection(con))
            {

                String sql = "Select L_plate_no,L_plate_state,Model,ProdType,price_per_day,Outlet,ProductImage from Productdetails ORDER BY L_plate_no ";

                using (SqlCommand command = new SqlCommand(sql, cmd))
                {
                   
                    using (SqlDataAdapter ad = new SqlDataAdapter(command))
                    {
                        
                        cmd.Open();
                        ad.Fill(table);
                        cmd.Close();

                    }
                  
                }
            }
            
            GridView1.DataBind();
        }

        protected void btnSelect_Click(object sender, EventArgs e)
        {
           
           
                var chkStatus = GridView1.Rows.Cast<GridViewRow>()
        .Where(row => ((CheckBox)row.FindControl("chkStatus")).Checked)
        .Select(row => GridView1.DataKeys[row.RowIndex].Value.ToString()).ToList();
                if (Session["Cart"] == null)
                {
                    Session["Cart"] = chkStatus;
                }
                else
                {
                    var cart = (List<string>)Session["Cart"];
                    foreach (var product in chkStatus)
                        cart.Add(product);
                    
                    Session["Cart"] = cart;
                }
                foreach (GridViewRow row in GridView1.Rows)
                {
                    CheckBox cb = (CheckBox)row.FindControl("chkStatus");
                    if (cb.Checked)
                        cb.Checked = false;
                }
           
          
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                CheckBox chkStatus = (CheckBox)GridView1.Rows[i].FindControl("chkStatus");
                if (chkStatus != null)
                {

                    if (chkStatus.Checked)
                    {
                       // Label1.Text = GridView1.Rows[i].Cells[4].Text;
                        RadioButtonList1.Items.Add(GridView1.Rows[i].Cells[4].Text);
                        RadioButtonList1.Items.Add(GridView1.Rows[i].Cells[5].Text);
                        RadioButtonList1.Items.Add(GridView1.Rows[i].Cells[6].Text);
                        // idCollection.Add(strID);
                    }
                }
            }
        }

        protected void LinkButton1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("OutletFirst.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
           
        }

        protected void PAY_Click(object sender, EventArgs e)
        {
            Session["field1"] = RadioButtonList1.SelectedItem;
            Response.Redirect("PayAmount.aspx");
        }

       
    }
}