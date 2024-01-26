<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add_CategoryWebForm.aspx.cs" Inherits="AdminWebPannel.Add_CategoryWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add-Category</title>
    <link rel="stylesheet" href="Style.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="category">
            <h1>Add Category</h1>

            <asp:Label class="label" ID="lblText" runat="server" Text="Label" ForeColor="Red"></asp:Label>

            <table>
                <tr>
                    <td>
                        <h3>Category Id:</h3>
                    </td>
                    <td>
                        <asp:TextBox ID="txtCategoryId" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <h3>Category Name:</h3>
                    </td>
                    <td>
                        <asp:TextBox ID="txtCategoryName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnAddCategory" runat="server" Text="Add & Save Category" OnClick="btnAddCategory_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="prevbtn" runat="server" Text="Back-Home" OnClick="prevbtn_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
