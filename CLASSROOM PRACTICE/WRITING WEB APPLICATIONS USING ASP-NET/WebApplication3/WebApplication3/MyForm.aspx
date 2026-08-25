<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyForm.aspx.cs" Inherits="WebApplication3.MyForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
<asp:Label ID="lblName" runat="server" Text="Name:"></asp:Label>
<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
<br /> <br />
<asp:Label ID="lblAddress" runat="server" Text="Address:"></asp:Label>
<asp:Label ID="txtAddress" runat="server"></asp:Label>
        <br /> <br />
<asp:Button ID="btnSubmit" runat="server" Text="Submit" />
    </form>
</body>
</html>
