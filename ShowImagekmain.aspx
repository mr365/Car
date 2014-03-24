<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowImagekmain.aspx.cs" Inherits="Shop.WebForm24" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
           <link rel="stylesheet" type="text/css" href="~/Styles/main.css" />

</head>
<body>
    <form id="form1" runat="server">
    <div id="ProductSelector">
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" DataKeyNames="L_plate_no"  DataSourceID="ProductsData" 
            Width="504px">
            <Columns>
            <asp:TemplateField>
              <ItemTemplate>
              <asp:CheckBox ID="chkStatus" runat="server" 
                            AutoPostBack="true" />
                          
               </ItemTemplate>  
           </asp:TemplateField>
            <asp:BoundField HeaderText="L_plate_no" DataField="L_plate_no" />
            <asp:BoundField HeaderText="Plate State" DataField="L_plate_state" />
            <asp:BoundField HeaderText="Model" DataField="Model" />
             <asp:BoundField HeaderText="Product Type" DataField="ProdType" />
                <asp:BoundField HeaderText="Price_per_day" DataField="price_per_day" />
                <asp:BoundField HeaderText="price_per_week" DataField="price_per_week" />
                <asp:BoundField HeaderText="price_per_month" DataField="price_per_month" />
                <asp:BoundField HeaderText="Outlet" DataField="Outlet" />
                <asp:TemplateField HeaderText="Picture">
                    <ItemTemplate>
                    <img src="ShowImageK.ashx?L_plate_no=<%# Eval("L_plate_no").ToString() %>" alt =" <%# Eval("Outlet") %>" width="150" height="100" />
                    </ItemTemplate>
                     </asp:TemplateField>
                      </Columns>
        </asp:GridView>
    
               
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Logout" />
    
                <asp:SqlDataSource ID="ProductsData" runat="server" 
      ConnectionString="<%$ ConnectionStrings:ApplicationServices %>"
     
      SelectCommand="Select L_plate_no,L_plate_state,Model,ProdType,price_per_day,price_per_week,price_per_month,Outlet,ProductImage from Productdetails ORDER BY L_plate_no ">
    </asp:SqlDataSource>

    
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Checkout" />

    
    </div>
    <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click1">Selection Page</asp:LinkButton>
    </form>
    <div id="footer"> <p>Copyright &copy; Bajaj Car Rental Company| All Rights Reserved</p></div>
</body>
</html>
