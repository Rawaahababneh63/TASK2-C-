<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication6.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 328px;
            height: 214px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style1" style="padding: 5px; border-color: #000000; background-color: #000000; font-size: medium; color: #FFFFFF; position: absolute; right: 500px; bottom: 150px;">
        <div>

        </div>
        <asp:Label ID="Label1" runat="server" Text="Number 1"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Number 2"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
<%--&nbsp;<asp:Button runat="server" BackColor="Blue" OnClick="on click" Text="*" Width="34px" />--%>
&nbsp;&nbsp;<asp:Button ID="Button4" runat="server" BackColor="Blue" OnClick="Button4_Click" Text="*" Width="31px" />
        &nbsp;
        <asp:Button ID="Button2" runat="server" BackColor="Red" OnClick="Button2_Click" Text="+" Width="35px" />
&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" BackColor="Yellow" Text="-" Width="29px" OnClick="Button3_Click" />
        <p>
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
