<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchProductWebForm.aspx.cs" Inherits="AdminWebPannel.SearchProductWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Search-Product</title>
    <link rel="stylesheet" href="Style.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="content">
            <table>
                <tr>
                    <td>
                        <h3>Product Name:</h3>
                    </td>
                    <td>
                        <asp:TextBox ID="txtproductId" runat="server"></asp:TextBox>
                    </td>
                    

                    <td>
                        <asp:Button ID="btnSearch" runat="server" Text="Search Product" OnClick="btnSearch_Click" />
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Button ID="prevbtn" runat="server" Text="Back-Home" OnClick="prevbtn_Click" />
                    </td>
                </tr>

                <asp:GridView ID="gvProduct" runat="server"></asp:GridView>

            </table>
        </div>
    </form>
</body>
</html>
