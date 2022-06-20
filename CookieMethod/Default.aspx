<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CookieMethod.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Записать cookie" Height="43px" Width="125px" OnClick="Button1_Click" />
        <p>
            <asp:HyperLink ID="HyperLink1" NavigateUrl="~/ReadCooke.aspx" runat="server">Прочитать</asp:HyperLink>
        </p>
    </form>
</body>
</html>
