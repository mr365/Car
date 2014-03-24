<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowImagek3.aspx.cs" Inherits="Shop.WebForm21" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
            <asp:BoundField HeaderText="L_plate_state" DataField="L_plate_state" />
            <asp:BoundField HeaderText="Model" DataField="Model" />
             <asp:BoundField HeaderText="Product Type" DataField="ProdType" />
                <asp:BoundField HeaderText="price_per_day" DataField="price_per_day" />
                <asp:TemplateField HeaderText="Picture">
                    <ItemTemplate>
                    <img src="ShowImageK.ashx?L_plate_no=<%# Eval("L_plate_no").ToString() %>" alt =" <%# Eval("L_plate_state") %>" width="150" height="100" />
                    </ItemTemplate>
                     </asp:TemplateField>
                      </Columns>
        </asp:GridView>
    
        <asp:Button ID="btnSelect" runat="server" onclick="btnSelect_Click" 
            Text="Add to cart" />
    
               
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Checkout" />
    
                <asp:SqlDataSource ID="ProductsData" runat="server" 
      ConnectionString="<%$ ConnectionStrings:ApplicationServices %>"
     
      SelectCommand="Select Select L_plate_no,L_plate_state,Model,ProdType,price_per_day,ProductImage from Productdetails where ProdType='Suv' ORDER BY L_plate_no ">
    </asp:SqlDataSource>
    </div>
    <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Selection Page</asp:LinkButton>
    </form>
</body>
</html>
