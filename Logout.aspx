<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Logout.aspx.cs" Inherits="Shop.WebForm11" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <div>
    
    </div>
    <p>
        <asp:LinkButton ID="LinkButton1" runat="server" ForeColor="Purple" 
            onclick="LinkButton1_Click">Click me to shop again !!! :)</asp:LinkButton>
    </p>
    <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/thankyou.jpg" 
        Width="603px" />
    </form>
</body>
</html>
