<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchWebForm.aspx.cs" Inherits="ClientWebApplication.SearchWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Search</title>
    <link rel="stylesheet" href="ClientDash.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="search">
            <h1>Search</h1>
            <br />
            <asp:Label ID="lblText" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:ScriptManager ID="ScriptManager1" runat="server" />
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:TextBox ID="txtProductId" runat="server"></asp:TextBox>
                    <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
                    <asp:Button ID="prevbtn" runat="server" Text="Previous" OnClick="prevbtn_Click" />
                    <asp:GridView ID="gridViewSearch" runat="server" AutoGenerateColumns="true"></asp:GridView>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
