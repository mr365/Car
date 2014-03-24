<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Defaultk.aspx.cs" Inherits="Shop.WebForm13" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
        <link href="~/Styles/main.css" rel="stylesheet" type="text/css" />

</head>
<body>
    <form id="form2" runat="server">
    <div>
        <br />
        L_plate_no:<asp:TextBox ID="PlateNum" runat="server" OnTextChanged="PlateNum_TextChanged"></asp:TextBox>
        <br />
        State:
    <asp:TextBox id="PlateState" runat="server" OnTextChanged="PlateState_TextChanged" />
    <br />
        Car Image: <asp:FileUpload id="FileUpload1" runat="server" />
        <asp:Button ID="btnSave" runat="server" Text="Save Details" 
            onclick="btnSave_Click" />
        <asp:Button ID="btnSee" runat="server" onclick="btnSee_Click" 
            Text="See images in database" Width="202px" />
        <br />
        Model:<asp:TextBox ID="txtProductDescription" runat="server" OnTextChanged="txtProductDescription_TextChanged"></asp:TextBox>
        <br />
        Car Type:<asp:TextBox ID="txtProductType" runat="server" OnTextChanged="txtProductType_TextChanged"></asp:TextBox>
        <br />
     
        PricePerDay:<asp:TextBox ID="txtProdprice" runat="server" OnTextChanged="txtProdprice_TextChanged"></asp:TextBox>
        <br />
        Outlet:<asp:TextBox ID="txtOutlet" runat="server" OnTextChanged="txtOutlet_TextChanged"></asp:TextBox>
        <br />   
        PricePerWeek:<asp:TextBox ID="txtPricePerWeek" runat="server" OnTextChanged="txtPricePerWeek_TextChanged"></asp:TextBox>
        <br />
        PricePerMonth:<asp:TextBox ID="txtProductMonth" runat="server" OnTextChanged="txtProductMonth_TextChanged"></asp:TextBox>
        <br />
        <br />
        <br />
        
    <asp:Label id="lblMessage" runat="server" />    
    
    </div>
    <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Admin main page</asp:LinkButton>
    </form>
    <div id="footer"> <p>Copyright &copy; Bajaj Car Rental Company| All Rights Reserved</p></div>
</body>
</html>
