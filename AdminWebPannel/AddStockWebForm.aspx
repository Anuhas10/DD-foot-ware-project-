<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddStockWebForm.aspx.cs" Inherits="AdminWebPannel.AddStockWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add-Stock</title>
    <link rel="stylesheet" href="Style2.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="content">
            <h1>Add Stock</h1>
            <asp:Label ID="lblText" runat="server" Text=""></asp:Label>
            <br />
            <br />

            <label for="txtProductId">Product ID:</label>
            <asp:TextBox ID="txtProductId" runat="server"></asp:TextBox><br /><br />

            <label for="txtNewStock">New Stock:</label>
            <asp:TextBox ID="txtNewStock" runat="server"></asp:TextBox><br /><br />

            <asp:Button ID="btnAddStock" runat="server" Text="Add Stock" OnClick="btnAddStock_Click" />
            <br />
            <br />
            <br />

            <asp:Button ID="prevbtn" runat="server" Text="Back-Home" OnClick="prevbtn_Click" />

    
        </div>
    </form>
</body>
</html>
