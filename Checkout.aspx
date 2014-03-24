<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="Shop.WebForm18" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <asp:GridView ID="Basket" runat="server" AutoGenerateColumns="False" 
    GridLines="None" EnableViewState="False" ShowFooter="True" 
    DataKeyNames="L_plate_no" OnRowCreated="Basket_RowCreated" Width="418px">
    <Columns>

      <asp:TemplateField HeaderText="Remove">
        <ItemTemplate>
          <asp:CheckBox ID="RemovedProducts" runat="server" />
        </ItemTemplate>
      </asp:TemplateField>

      <asp:TemplateField HeaderText="Product" SortExpression="L_plate_state">
        <ItemTemplate>
          <asp:Label ID="L_plate_state" runat="server" Text='<%# Eval("L_plate_state") %>' />
        </ItemTemplate>
       

        <FooterTemplate>
          <strong>
            Total Price:
          </strong>
        </FooterTemplate>

      </asp:TemplateField>

       <asp:TemplateField HeaderText="Producttype" SortExpression="ProdType">
        <ItemTemplate>
          <asp:Label ID="ProductType" runat="server" Text='<%# Eval("ProdType") %>' />
        </ItemTemplate>
          </asp:TemplateField>

        <asp:TemplateField HeaderText="price_per_day" SortExpression="price_per_day">
        <ItemTemplate>
          <asp:Label ID="price_per_day" runat="server" Text='<%# Eval("price_per_day") %>' />
        </ItemTemplate>

        <FooterTemplate>
          <strong>
            <asp:Literal ID="TotalPrice" runat="server" />
          </strong>
        </FooterTemplate>

      </asp:TemplateField>

    </Columns>

  </asp:GridView>
  &nbsp;&nbsp;&nbsp;&nbsp;
  <asp:Button ID="ConfirmPurchase" runat="server" Text="Confirm Purchase" 
            onclick="ConfirmPurchase_Click" />
  <asp:SqlDataSource ID="BasketData" runat="server" 
    ConnectionString="<%$ ConnectionStrings:ApplicationServices %>" OnSelecting="BasketData_Selecting">
  </asp:SqlDataSource>
   <asp:SqlDataSource ID="OfferData" runat="server" 
    ConnectionString="<%$ ConnectionStrings:ApplicationServices %>">
  </asp:SqlDataSource>
    
    </div>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </form>
    <div id="footer"> <p>Copyright &copy; Bajaj Car Rental Company| All Rights Reserved</p></div>
</body>
</html>
