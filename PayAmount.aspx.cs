﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shop
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session["field1"].ToString();
        }

        protected void Pay_Click(object sender, EventArgs e)
        {
            Response.Redirect("Creditcard.aspx");
        }
    }
}