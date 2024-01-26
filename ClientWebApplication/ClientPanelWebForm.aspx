<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClientPanelWebForm.aspx.cs" Inherits="ClientWebApplication.ClientPanelWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Client-Panel</title>
    <link rel="stylesheet" href="ClientDash.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="main">
            <h1>DD FOOTWEAR CLIENT-PANEL</h1>
        </div>

        <asp:Button ID="Button1" runat="server" Text="Search Product" OnClick="Button1_Click" />
        <br />
        <br />
        <br />
        <asp:Button ID="btnViewProduct" runat="server" Text="View Product" OnClick="btnViewProduct_Click" />
        <asp:GridView ID="gvProduct" runat="server"></asp:GridView>
        <br />
        <br />
        <br />
        <br />
        
        <div class="ror">
            <h2>Place Order</h2>
            <br />
            <asp:Label ID="lblText" runat="server" Text=""></asp:Label>
            <br />

            <label for="txtOrderId">Order ID:</label>
            <asp:TextBox ID="txtOrderId" runat="server"></asp:TextBox>
            <label for="txtProductId">Product ID:</label>
            <asp:TextBox ID="txtProductId" runat="server"></asp:TextBox>
            <label for="txtOrderQty">Quantity:</label>
            <asp:TextBox ID="txtOrderQty" runat="server"></asp:TextBox>
            <asp:Button ID="btnPlaceOrder" runat="server" Text="Place Order" OnClick="btnPlaceOrder_Click" />
        </div>

    </form>
</body>
</html>
