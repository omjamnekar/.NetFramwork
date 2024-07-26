<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Color.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter a Name:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="Color" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Red" />
            <br />
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="Color" Text="Green" />
            <br />
            <asp:RadioButton ID="RadioButton3" runat="server" GroupName="Color" Text="Orange" />
            <br />
            <br />
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Bold" />
            <br />
            <asp:CheckBox ID="CheckBox2" runat="server" Text="Italic" />
            <br />
            <asp:CheckBox ID="CheckBox3" runat="server" Text="Underline" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
