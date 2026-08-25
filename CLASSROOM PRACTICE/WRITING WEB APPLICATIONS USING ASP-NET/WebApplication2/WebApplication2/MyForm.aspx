<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyForm.aspx.cs" Inherits="WebApplication2.MyForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
      <form id="form1" runat="server">
<asp:Label ID="lblName" runat="server" Text="First Number:"></asp:Label>
<asp:TextBox ID="firstnum" runat="server"></asp:TextBox>
<br /> <br />
<asp:Label ID="lblAddress" runat="server" Text="Second Number:"></asp:Label>
<asp:TextBox ID="secnum" runat="server"></asp:TextBox>
        <br /> <br />
<asp:Button ID="btnSubmit" runat="server" Text="Submit" />
    </form>
</body>
</html>
