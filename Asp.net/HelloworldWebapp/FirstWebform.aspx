<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FirstWebform.aspx.cs" Inherits="HelloworldWebapp.FirstWebform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Hello World</h1>
            Enter Name<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="ClickMe" OnClick="Greet"/><br />
            <asp:Label ID="lblmsg" runat="server" Text="Label"></asp:Label>
        </div>        
    </form>
</body>
</html>
