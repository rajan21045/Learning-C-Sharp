<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyForm.aspx.cs" Inherits="Rajan.MyForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
<div>
<asp:Label ID="num1" runat="server" Text="First Number:"></asp:Label>
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<br /> <br />
<asp:Label ID="num2" runat="server" Text="Second Number:"></asp:Label>
<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br /> <br />
<asp:Button ID="btnResult" runat="server" Text="Get Result" OnClick="btnResult_Click" />
       <br /> <br />
       <asp:Label ID="lblResult" runat="server">Result: </asp:Label>
</div>

    </form>
</body>
</html>
