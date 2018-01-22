

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dec2bin.aspx.cs" Inherits="WebApplication1.dec2bin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="css/dectobin.css" rel="stylesheet" type="text/css"/>
    <title></title>
    
</head>
<body>
    <form id="form1"  runat="server">
    <div style="margin-left: auto; margin-right: auto; text-align: center;"> 
        <h1>
            <asp:Label ID="Label5" runat="server" Text="BINARY CALCULATOR" style="text-align: center; font-size: x-large; background-color: #FFFF99" ></asp:Label>
        </h1>
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" Width="100px" runat="server"></asp:TextBox>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>SELECT</asp:ListItem>
            <asp:ListItem>+</asp:ListItem>
            <asp:ListItem>-</asp:ListItem>
            <asp:ListItem>*</asp:ListItem>
            <asp:ListItem>/</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="TextBox2" Width="100px" runat="server"></asp:TextBox>
        <asp:Button class="cal" ID="Button1" runat="server" Text="Calculate" OnClick="Button1_Click" />
        <br /><br />
        <asp:Label ID="Label1" runat="server" Text="=Base10:"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Label ID="Label2" runat="server" Text="=Base2:"></asp:Label>
        <asp:TextBox ID="TextBox4" Width="300px" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Button ID="Button2" Class="cal" runat="server" Text="Count" OnClick="Button2_Click" />
        <asp:Label ID="Label3" runat="server" Text="Num of 0"></asp:Label>
        <asp:TextBox ID="TextBox5" Width="50px" runat="server"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" Text="Num of 1"></asp:Label>
        <asp:TextBox ID="TextBox6" Width="50px" runat="server"></asp:TextBox>
    </div>
    </form>
</body>
</html>

        