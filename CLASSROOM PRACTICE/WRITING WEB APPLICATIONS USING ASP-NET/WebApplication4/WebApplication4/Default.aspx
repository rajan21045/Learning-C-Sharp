<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication4.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Name:"></asp:Label>
<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator
    ID="validator1"
    runat="server"
    ControlToValidate="txtName"
    ErrorMessage="Name is Required!"
    ForeColor="Red">
</asp:RequiredFieldValidator>

<br /><br />

<asp:Label ID="Label2" runat="server" Text="Email:"></asp:Label>
<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
<asp:RegularExpressionValidator
    ID="validator2"
    runat="server"
    ControlToValidate="txtEmail"
    ErrorMessage="Email is Invalid!"
    ForeColor="Red"
    ValidationExpression="\w+([-.+']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
</asp:RegularExpressionValidator>

<br /><br />

<asp:Label ID="Label3" runat="server" Text="Class:"></asp:Label>
<asp:TextBox ID="txtClass" runat="server"></asp:TextBox>
<asp:RangeValidator
    ID="validator3"
    runat="server"
    ControlToValidate="txtClass"
    ErrorMessage="Class must be between 1 and 12"
    ForeColor="Red"
    MinimumValue="1"
    MaximumValue="12"
    Type="Integer">
</asp:RangeValidator>

<br /><br />

<asp:Label ID="Label4" runat="server" Text="Age:"></asp:Label>
<asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
<asp:CompareValidator
    ID="validator4"
    runat="server"
    ControlToValidate="txtAge"
    ValueToCompare="100"
    Operator="LessThan"
    Type="Integer"
    ErrorMessage="Age must be less than 100!"
    ForeColor="Red">
</asp:CompareValidator>

<br /><br />

<asp:Button
    ID="btnSubmit"
    runat="server"
    Text="Submit"
    OnClick="btnSubmit_Click" />

<br /><br />

<asp:Label
    ID="lblMessage"
    runat="server"
    ForeColor="Green">
</asp:Label>

<br /><br />

<asp:ValidationSummary
    ID="validator5"
    runat="server"
    ForeColor="Red"
    HeaderText="Errors:"
    DisplayMode="BulletList"
    ShowSummary="true" />
        </div>
    </form>
</body>
</html>
