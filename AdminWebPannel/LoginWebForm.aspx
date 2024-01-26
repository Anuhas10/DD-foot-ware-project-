<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginWebForm.aspx.cs" Inherits="AdminWebPannel.LoginWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link rel="stylesheet" href="Login_Style.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="login">
            <h1>Login</h1>

            <table>
                <tr>
                    <td>
                        <h3>User ID</h3>
                    </td>
                    <td>
                        <asp:TextBox ID="txtUserId" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <h3>User Name</h3>
                    </td>
                    <td>
                        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <h3>Password</h3>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                    </td>
                </tr>

                <tr>
                    <td>
                        <h3>Don't have a account? <asp:LinkButton ID="lbtnSignUp" runat="server" OnClick="lbtnSignUp_Click">Sign-Up here</asp:LinkButton></h3>
                    </td>
                </tr>
            </table>

            <asp:Label ID="lblText" runat="server" Text="Label"></asp:Label>
            
        </div>
    </form>
</body>
</html>
