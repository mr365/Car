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
    public partial class WebForm18 : System.Web.UI.Page
    {

        Decimal cost;
        protected void Page_Load(object sender, EventArgs e)
        {
           if (Session["Cart"] == null)
                Response.Redirect("ShowImagek.aspx");
            BindBasket();
        }

        protected void RemoveProduct_Click(object sender, EventArgs e)
            {
            var cart = (List<string>)Session["Cart"];
            var removedProducts = Basket.Rows.Cast<GridViewRow>()
              .Where(row => ((CheckBox)row.FindControl("RemovedProducts")).Checked)
              .Select(row => Basket.DataKeys[row.RowIndex].Value.ToString()).ToList();
            cart.RemoveAll(removedProducts.Contains);
            BindBasket();
        }

        protected void BindBasket()
        {
            var sql = "SELECT L_plate_no, L_plate_state, ProdType, price_per_day, Outlet FROM Productdetails WHERE L_plate_no IN ({0})";

            var values = (List<string>)Session["Cart"];
            if (values.Count > 0)
            {

                var parms = values.Select((s, i) => "@p" + i.ToString()).ToArray();
                var inclause = string.Join(",", parms);
                BasketData.SelectCommand = string.Format(sql, inclause);
                BasketData.SelectParameters.Clear();
                for (var i = 0; i < parms.Length; i++)
                {
                    BasketData.SelectParameters.Add(parms[i].Replace("@", ""), values[i]);
                }

                DataView view = (DataView)BasketData.Select(DataSourceSelectArguments.Empty);

                //  var costQuery = view.Cast<DataRowView>().Select(drv => drv.Row.Field<decimal>("Price"));



                var costQuery = view.Cast<DataRowView>().Select(drv => drv.Row.Field<decimal>("Price"));


                cost = costQuery.Sum();
                Basket.DataSource = view;
                Basket.DataBind();
               







                Session["totalcost"] = cost;


            }


        }   

               
            

        
        protected void Basket_RowCreated(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Footer)
            {
                Literal total = (Literal)e.Row.FindControl("TotalPrice");
                total.Text = cost.ToString();
            }
        }

        protected void ConfirmPurchase_Click(object sender, EventArgs e)
        {
            string s = Session["Username"].ToString();
            int c = Convert.ToInt32(cost);


            SqlConnection a = new SqlConnection(ConfigurationManager.ConnectionStrings["ApplicationServices"].ConnectionString);


            SqlCommand b = new SqlCommand("UPDATE Logindetails set CreditLine='" + c + "' WHERE Username='" + s + "'", a);
            
            a.Open();
            b.ExecuteNonQuery();


            a.Close();
                

            
                Response.Redirect("Webform26.aspx");
        }
    }
}