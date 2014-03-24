<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PayAmount.aspx.cs" Inherits="Shop.WebForm7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>

    </title>
    <link href="~/Styles/main.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        The Amount has to be paid is
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Button ID="Pay" runat="server" OnClick="Pay_Click" Text="Pay" />
    
    </div>
    </form>
    <div id="footer"> <p>Copyright &copy; Bajaj Car Rental Company| All Rights Reserved</p></div>
</body>
</html>
