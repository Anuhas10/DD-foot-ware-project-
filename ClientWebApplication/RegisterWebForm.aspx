<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterWebForm.aspx.cs" Inherits="ClientWebApplication.RegisterWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
    <link rel="stylesheet" href="Reg_Style.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="register">
    <h1>Register Form</h1>

    <table>
        <tr>
            <td class="style1">
                <h3>User ID</h3>
            </td>
            <td>
                <asp:TextBox ID="txtUserId" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td class="style1">
                <h3>UserName</h3>
            </td>
            <td>
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td class="style1">
                <h3>User-Type</h3>
            </td>
            <td>
                <asp:DropDownList ID="dlUserType" runat="server">
                    <asp:ListItem>Admin</asp:ListItem>
                    <asp:ListItem>Client</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>

         <tr>
            <td class="style1">
                <h3>Password</h3>
            </td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td class="style1">
                <h3>Confirm Password</h3>
            </td>
            <td>
                <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td class="style1">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            </td>
            <td>
                <asp:Button ID="btnPrev" runat="server" Text="Previous" OnClick="btnPrev_Click" />
            </td>
        </tr>

    </table>

    <asp:Label ID="lblText" runat="server" Text="Label"></asp:Label>

</div>
    </form>
</body>
</html>
