<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="P3newWebform.aspx.cs" Inherits="P3new1.P3newWebform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>

        <h1>Book Store</h1>
        <!--<asp:Panel ID="GetbooksPanel" runat="server">-->
        <asp:Table ID="Table1" runat="server" BorderStyle="Dashed" BackColor="#CCFFFF" BorderColor="#9900CC" GridLines="Both"></asp:Table> <!--</asp:Panel>-->
        <br/> <br/>

        <asp:Label ID="Label1" runat="server" Text="ID"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Enter ID" Display="Dynamic" ControlToValidate="TextBox1" ValidationGroup="add" ForeColor="Green" ></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Please Enter only positive integers" Display="Dynamic" ControlToValidate="TextBox1" ValidationGroup="add" ValidationExpression="^[0-9]*$" ForeColor="Green" ></asp:RegularExpressionValidator>
        &nbsp;&nbsp;&nbsp;
         <br/> <br/>


        <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>

        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please Enter Name" Display="Dynamic" ControlToValidate="TextBox2" ValidationGroup="add" ForeColor="Green"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Please Enter only a string of alphabets and spaces" Display="Dynamic" ControlToValidate="TextBox2" ValidationGroup="add" ValidationExpression="^[a-zA-Z |\.]*$" ForeColor="Green" ></asp:RegularExpressionValidator>
        &nbsp;&nbsp;&nbsp;  
         <br/> <br/>
              
        <asp:Label ID="Label3" runat="server" Text="Author"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please Enter  Author Name" Display="Dynamic" ControlToValidate="TextBox3" ValidationGroup="add" ForeColor="Green"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="Please Enter only a string of alphabets and spaces" Display="Dynamic" ControlToValidate="TextBox3" ValidationGroup="add" ValidationExpression="^[a-zA-Z |\.]*$" ForeColor="Green" ></asp:RegularExpressionValidator>
        &nbsp;&nbsp;&nbsp;
        <br/> <br/>

        <asp:Label ID="Label4" runat="server" Text="Year"></asp:Label>

        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Please Enter Year" Display="Dynamic" ControlToValidate="TextBox4" ValidationGroup="add" ForeColor="Green"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ErrorMessage="Please Enter only non-negative integers upto 2015" Display="Dynamic" ControlToValidate="TextBox4" ValidationExpression="^[0-9]*$" ValidationGroup="add" MinimumValue="1" MaximumValue="2015" ForeColor="Green" ></asp:RegularExpressionValidator>
        
        &nbsp;&nbsp;&nbsp;   
         <br/> <br/> 
                   
        <asp:Label ID="Label5" runat="server" Text="Price"></asp:Label>

        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Please Enter Price" Display="Dynamic" ControlToValidate="TextBox5" ValidationGroup="add" ForeColor="Green"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ErrorMessage="Please Enter only positive float numbers" Display="Dynamic" ControlToValidate="TextBox5" ValidationGroup="add" ValidationExpression="^[0-9]*(?:\.[0-9]*)?$" ForeColor="Green" ></asp:RegularExpressionValidator>
        &nbsp;&nbsp;&nbsp;
         <br/> <br/>

        <asp:Label ID="Label6" runat="server" Text="Stock"></asp:Label>

        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Please Enter Stock" Display="Dynamic" ControlToValidate="TextBox6" ValidationGroup="add" ForeColor="Green"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ErrorMessage="Please Enter only positive integers" Display="Dynamic" ControlToValidate="TextBox6" ValidationGroup="add" ValidationExpression="^[1-9]\d*$" ForeColor="Green" ></asp:RegularExpressionValidator>
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" AutoPostBack="true" ValidationGroup="add" />         
        <br/> <br/>
         <br/> <br/>

        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Value="0">Select</asp:ListItem>
            <asp:ListItem>Num</asp:ListItem>
            <asp:ListItem>ID</asp:ListItem>
            <asp:ListItem>Year</asp:ListItem>
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Please Select an Option" InitialValue="0" ControlToValidate="DropDownList1" Display="Dynamic" ValidationGroup="del" ForeColor="Green"></asp:RequiredFieldValidator>
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBox7" ErrorMessage="Please Enter a Value" ValidationGroup="del"  Display="Dynamic" ForeColor="Green" > </asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ControlToValidate="TextBox7" ErrorMessage="Please Enter a Valid Data" ValidationGroup="del"  Display="Dynamic" ForeColor="Green" ValidationExpression="^[0-9]\d*$"></asp:RegularExpressionValidator>
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Delete" OnClick="Button2_Click" ValidationGroup="del" />
        <br/> <br/>

        <asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
            <asp:ListItem Value="0">Select</asp:ListItem>
            <asp:ListItem>ID</asp:ListItem>
            <asp:ListItem>Name</asp:ListItem>
            <asp:ListItem>Author</asp:ListItem>
            <asp:ListItem>Year</asp:ListItem>
        </asp:DropDownList>

        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="Please select an option" ControlToValidate="DropDownList2" InitialValue="0" ValidationGroup="srh" Display="Dynamic" ForeColor="Green"></asp:RequiredFieldValidator>
        
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="Please Enter a Valid Data" ControlToValidate="TextBox8" ValidationGroup="srh" Display="Dynamic" ForeColor="Green"></asp:RequiredFieldValidator>
        
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="Search" OnClick="Button3_Click" ValidationGroup="srh" />
         <br/> <br/>

        <asp:Table ID="Table2" runat="server" BorderStyle="Dashed" BackColor="#FFCCFF" BorderColor="#9900CC" GridLines="Both"></asp:Table>
        <br/> <br/>

        <h2>Purchase Books</h2>
        <br/> <br/>
        <asp:Label ID="Label7" runat="server" Text="Total Budget"></asp:Label>
        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
        <br/> <br/>

        <asp:Label ID="Label8" runat="server" Text="Book Number"></asp:Label>
        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
        <asp:Label ID="Label9" runat="server" Text="Amount"></asp:Label>
        <asp:Button ID="Button4" runat="server" Text="More" />
        <br/> <br/>

        <asp:Button ID="Button5" runat="server" Text="Purchase" />
        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>




    </form>
</body>
</html>
