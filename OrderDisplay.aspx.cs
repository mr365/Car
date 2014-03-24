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
using System.Collections.ObjectModel;


namespace Shop
{
    public partial class WebForm23 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbUsername.Text = Session["Username"].ToString();

            lbOrdernum.Text = Session["ranorder"].ToString();
            lbTracknum.Text = Session["rantrack"].ToString();

            lbTotalcost.Text = Session["totalcost"].ToString();

           


        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Logout.aspx");
        }
    }
}