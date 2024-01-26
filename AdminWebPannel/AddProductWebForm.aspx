<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddProductWebForm.aspx.cs" Inherits="AdminWebPannel.AddProductWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add_Product</title>
    <link rel="stylesheet" href="Style.css" />
</head>
<body>
    <form id="form1" runat="server">
            <div class="product">
                <h1>DD Add Product</h1>

                <asp:Label ID="lblText" runat="server" Text="Label"></asp:Label>

                <table>
                    <tr>
                        <td>
                            <h3>Product Id:</h3>

                        </td>
                        <td>
                            <asp:TextBox ID="txtProductId" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <h3>Product Name:</h3>

                        </td>
                        <td>
                            <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <h3>Category Name</h3>

                        </td>
                        <td>
                            <asp:DropDownList ID="dlCategoryName" runat="server"></asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <h3>Quantity:</h3>

                        </td>
                        <td>
                            <asp:TextBox ID="txtQty" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            <h3>Price:</h3>

                        </td>
                        <td class="auto-style1">
                            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="btnAddProduct" runat="server" Text="Add & Save Product" OnClick="Button1_Click" />
                        </td>
                        <td>
                            <asp:Button ID="previousbtn" runat="server" Text="Back-Home" OnClick="previousbtn_Click" />
                        </td>
                    </tr>
                </table>

            </div>
    </form>
</body>
</html>
