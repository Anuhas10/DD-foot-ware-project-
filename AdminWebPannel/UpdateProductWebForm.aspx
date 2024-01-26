<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateProductWebForm.aspx.cs" Inherits="AdminWebPannel.UpdateProductWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Update-Product</title>
    <link rel="stylesheet" href="Style.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="content">
            <h1>Update Products</h1>

            <asp:Label ID="lblText" runat="server" Text="Label"></asp:Label>

            <table>
                <tr>
                    <td>
                        <h3>Product Id:</h3>
                    </td>
                    <td>
                        <asp:TextBox ID="txtProductId" runat="server" placeholder="enter"></asp:TextBox>
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
                        <asp:Button ID="btnUpdate" runat="server" Text="Update & Save" OnClick="btnUpdate_Click" />
                        <asp:Button ID="prevbtn" runat="server" Text="Back-Home" OnClick="prevbtn_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
