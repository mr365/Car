<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Creditcard.aspx.cs" Inherits="Shop.WebForm4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="~/Styles/main.css" />
</head>
<body>
    <form id="form2" runat="server">
    <div>
    
    </div>
        <br />
    <asp:Label ID="Label1" runat="server" Text="UserName"></asp:Label>
    <asp:TextBox ID="txtUserc" runat="server" ></asp:TextBox>
    
    
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="Account Number"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    
    
     <p>
        <asp:Label ID="Label3" runat="server" Text="Name on the card"></asp:Label>
        <asp:TextBox ID="txtNamec" runat="server" ></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label4" runat="server" Text="Type of the card"></asp:Label>
        <asp:TextBox ID="txtTypec" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label5" runat="server" Text="SSN"></asp:Label>
        <asp:TextBox ID="txtSsnc" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label6" runat="server" Text="Expiry"></asp:Label>
        <asp:TextBox ID="txtExpiryc" runat="server" ></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Submit Details" 
            onclick="Button1_Click" />
    </p>
        <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
    </form>
    <div id="footer"> <p>Copyright &copy; Bajaj Car Rental Company| All Rights Reserved</p></div>
</body>
</html>
