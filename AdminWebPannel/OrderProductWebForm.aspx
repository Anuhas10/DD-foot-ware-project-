<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderProductWebForm.aspx.cs" Inherits="AdminWebPannel.OrderProductWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Place-Order</title>
    <link rel="stylesheet" href="Style2.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="content">
            <h1>Place Order</h1>

            <asp:Label ID="lblText" runat="server" Text=""></asp:Label>
            <br />
            <br />

            <label for="txtOrderId">Order ID:</label>
            <asp:TextBox ID="txtOrderId" runat="server"></asp:TextBox>
            <label for="txtOrderProductId">Product ID:</label>
            <asp:TextBox ID="txtOrderProductId" runat="server"></asp:TextBox>
            <label for="txtOrderQuantity">Quantity:</label>
            <asp:TextBox ID="txtOrderQuantity" runat="server"></asp:TextBox>
            <asp:Button ID="btnPlaceOrder" runat="server" Text="Place Order" OnClick="btnPlaceOrder_Click"/>
            <br />
            <br />
            <asp:Button ID="btnBack" runat="server" Text="Back-Home" OnClick="btnBack_Click" />
            
        </div>
    </form>
</body>
</html>
