<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderDisplay.aspx.cs" Inherits="Shop.WebForm23" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            text-align: justify;
            font-size: larger;
        }
        .style2
        {
            text-decoration: underline;
            color: #0000FF;
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

     <p>
        Thank you for shopping&nbsp; .<asp:Label ID="lbUsername" runat="server" 
             Text="Label"></asp:Label>
     </p>
    <p>
        Your order number
        <asp:Label ID="lbOrdernum" runat="server" Text="Label"></asp:Label>
&nbsp;purchased for
        <asp:Label ID="lbTotalcost" runat="server" Text="Label"></asp:Label>
     </p>
     <p>
         &nbsp;</p>
     <p class="style2">
         </p>
    <div class="style1">

    
    

        <br />
        You can track your order with this <strong>
        <asp:Label ID="lbTracknum" runat="server" Text="Label"></asp:Label>
        </strong>&nbsp;tracking number</div>
   
    <p>
        <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Home Page</asp:LinkButton>
     </p>
   
    <p>
        <asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click">Logout</asp:LinkButton>
     </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
   
    </form>

    </body>
</html>
