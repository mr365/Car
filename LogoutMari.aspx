<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogoutMari.aspx.cs" Inherits="Shop.WebForm29" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="~/Styles/show.css" />
    
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        Thank you for renting !!!
        <br />
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Click me for renting more</asp:LinkButton>
        <br />
        <br />
    
    </div>
    </form>
    <div id="footer"> <p>Copyright &copy; Bajaj Car Rental Company| All Rights Reserved</p></div>
</body>
</html>
