<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteItemsWebForm.aspx.cs" Inherits="AdminWebPannel.DeleteItemsWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Delete Category & Product</title>
    <link rel="stylesheet" href="Style3.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="content">
            <h1>Delete Category</h1>
            <br />
            <br />

            <asp:Label ID="lblText" runat="server" Text="Label"></asp:Label>

    <table>
        <tr>
            <td>
                <h3>Category Id:</h3>
            </td>
            <td>
                <asp:TextBox ID="txtCategoryId" runat="server" placeholder="Enter Category ID to Delete"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnDeleteCategory" runat="server" Text="Delete Category" OnClick="btnDeleteCategory_Click" />
            </td>
        </tr>
    </table>
</div>
        <br />
        <br />
        <br />


        <div class="content">
            <h1>Delete Product</h1>
            <br />
            <br />
            <asp:Label ID="lblText1" runat="server" Text="Label1"></asp:Label>
            <table>
                <tr>
                    <td>
                        <h3>Product Name:</h3>
                    </td>
                    <td>
                        <asp:TextBox ID="txtProductName" runat="server" placeholder="Enter Product Name to Delete"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnDeleteProduct" runat="server" Text="Delete Product" OnClick="btnDeleteProduct_Click" />
                    </td>
                </tr>
                <br />
                <br />
                <br />
                <tr>
                    <td>
                        <asp:Button ID="btnDash" runat="server" Text="Back to Dashboard" OnClick="btnDash_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
