<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminDashboardWebForm.aspx.cs" Inherits="AdminWebPannel.AdminDashboardWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin_Panel</title>
    <link rel="stylesheet" href="AdminDStyles.css" />
    <link rel="stylesheet" href="Style2.css" />
</head>
<body>
    
    <form id="form1" runat="server">
        <div class="main">
            <h1>DD FOOTWEAR ADMIN-PANNEL</h1>
        </div>
        

        <asp:Button ID="btnAddProduct" runat="server" Text="Add Product" OnClick="btnAddProduct_Click" />
        <br />
        <br />
        <asp:Button ID="btnViewProduct" runat="server" Text="View Product" OnClick="btnViewProduct_Click" />
        <asp:GridView ID="gvView" runat="server"></asp:GridView>
        <br />
        <br />
        <asp:Button ID="btnSearchProduct" runat="server" Text="Search Product" OnClick="btnSearchProduct_Click"  />
        <br />
        <br />
        <asp:Button ID="btnAddCategory" runat="server" Text="Add Category" OnClick="btnAddCategory_Click" />
        <br />
        <br />
        <asp:Button ID="btnAddStock" runat="server" Text="Add Stock" OnClick="btnAddStock_Click" />
        <br />
        <br />
        <asp:Button ID="btnUpdateProduct" runat="server" Text="Update Product" OnClick="btnUpdateProduct_Click" />
        <br />
        <br />
        <asp:Button ID="btnPlaceOrder" runat="server" Text="Place an Order" OnClick="btnPlaceOrder_Click" />
        <br />
        <br />
        <asp:Button ID="btnDelete" runat="server" Text="Delete Category & Products" OnClick="btnDelete_Click" />
        <br />
        <br />
        
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="btnLogout" runat="server" Text="Log-Out" OnClick="btnLogout_Click" />
        <br />
        <br />
    </form>
</body>
</html>