<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OutletFirst.aspx.cs" Inherits="Shop.WebForm12" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
           <link rel="stylesheet" type="text/css" href="~/Styles/main.css" />

</head>
<body>
    <form id="form2" runat="server">
    <div>
    
        <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Newark</asp:LinkButton>
    
    </div>
    <p>
        <asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click">Harrison</asp:LinkButton>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click1">Home Page</asp:LinkButton>
        </p>
    </form>
     <div id="footer"> <p>Copyright &copy; Bajaj Car Rental Company| All Rights Reserved</p></div>
</body>
</html>
