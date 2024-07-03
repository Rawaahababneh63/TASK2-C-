<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication6.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            right: 319px;
            bottom: -21px;
            width: 407px;
            height: 465px;
            position: absolute;
        }
        .auto-style2 {
            right: 300px;
            bottom: 100px;
            margin-left: 131px;
        }
    </style>
    </head>
<body>
   
    
    <form id="form1" runat="server" class="auto-style1" style="padding: 10px; margin: 100px; background-color: #3399FF; text-align: left;">
        <p>
            <asp:Label ID="Label1" runat="server" Text="Name  "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            Email&nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p>
            Gender&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="gender"  Text="Female" />
            &nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="gender"  Text="Male" />
        </p>
        <p>
            &nbsp;<asp:Label ID="Label7" runat="server" Text="Courses"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="CheckBox3" runat="server" Text="C++" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="CheckBox2" runat="server" Text="C#" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="CheckBox1" runat="server" Text="C" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
        <p>
            &nbsp;&nbsp;<asp:Label ID="Label9" runat="server" Height="100px" Text="Message"></asp:Label>
            &nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox4" runat="server" Height="98px"></asp:TextBox>
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
   
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Submit" Height="30px" CssClass="auto-style2" Width="116px" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <p>
            <asp:Label ID="Label3" runat="server"></asp:Label>
        </p>
        <asp:Label ID="Label4" runat="server"></asp:Label>
        <p>
            <asp:Label ID="Label5" runat="server"></asp:Label>
        </p>
        <p> <asp:Label ID="Label6" runat="server"></asp:Label>
          </p>
        <asp:Label ID="Label8" runat="server"></asp:Label>
        <p>
            <asp:Label ID="Label10" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
   
    
</body>
</html>
