<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrontEnd.aspx.cs" Inherits="WebAPIDemo.FrontEnd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="SubmitButton_Click" Text="Submit" />
    </div>
    </form>
</body>
</html>
