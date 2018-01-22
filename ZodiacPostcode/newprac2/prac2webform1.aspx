<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="prac2webform1.aspx.cs" Inherits="newprac2.prac2webform1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">    
    <title></title>
</head>
<body style="background-color:#FFFF99"  >
    <form id="form1" runat="server">
    <div style="margin-left: auto; margin-right: auto; text-align: center;" >
        <h1>
            <asp:Label ID="Label1" runat="server" Text="ZODIAC FINDER" style="text-align: center; font-size: x-large; background-color: #FFFF99" ForeColor="Blue" ></asp:Label>
        </h1>
        

        <asp:Label ID="Label2" runat="server" Text="FIND DATE BY ZODIC NAME" ForeColor="Blue"></asp:Label>
        <br/> <br/>

        <asp:Label ID="Label3" runat="server" Text="NAME OF THE ZODIAC:"></asp:Label>&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" Width="100px" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ValidationGroup="set1" ForeColor="Red" ErrorMessage="Required Zodiac Name Field"></asp:RequiredFieldValidator>
        <asp:Button ID="Button1" runat="server" Text="GET DATE" OnClick="Button1_Click" ValidationGroup="set1" />&nbsp;&nbsp;&nbsp;
        <br/> <br/>


        <asp:Label ID="Label4" runat="server" Text="DATE:"></asp:Label>&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" Width="130px" runat="server"></asp:TextBox>
        <br/> <br/>
        <hr/>


        <asp:Label ID="Label5" runat="server" Text="FIND THE ZODIAC NAME BY DATE" ForeColor="Blue"></asp:Label>
        <br/> <br/>
        <asp:Label ID="Label6" runat="server" Text="MONTH:"></asp:Label>&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" Width="50px" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp;  
        <asp:RangeValidator ID="RangeValidator1" runat="server" Type="Integer" ErrorMessage="Month should be from 1 to 12" ControlToValidate="TextBox3" ValidationGroup="set2" MinimumValue="1" MaximumValue="12" Display="Dynamic" ForeColor="Red"></asp:RangeValidator>     
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox3" Display="Dynamic" ValidationGroup="set2" ErrorMessage="Month is required" ForeColor="Red" ></asp:RequiredFieldValidator> 
        <br/> <br/>
        <asp:Label ID="Label7" runat="server" Text="DAY:"></asp:Label>&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" Width="50px" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp;   
        <asp:RangeValidator ID="RangeValidator2" runat="server" Type="Integer" ErrorMessage="Date Out of Range" ValidationGroup="set2" ControlToValidate="TextBox4" MinimumValue="1" MaximumValue="31" Display="Dynamic" ForeColor="Red"></asp:RangeValidator>  
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" Controltovalidate ="TextBox4" Display="Dynamic" ValidationGroup="set2" runat="server" ErrorMessage="Day is required" ForeColor="Red"></asp:RequiredFieldValidator>
        <br/> <br/>
        <asp:Button ID="Button2" runat="server" Text="GET NAME" OnClick="Button2_Click" ValidationGroup="set2" />&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label8" runat="server" Text="NAME:"></asp:Label>&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox5" Width="150px" runat="server"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
