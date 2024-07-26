<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="multiView.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID="View1" runat="server">
                ENTER NAME :<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                AGE:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br />
                CITY:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Next" />
            </asp:View>
            <br />
            <br />
            <asp:View ID="View2" runat="server">
                ENTER&nbsp; PHONE NUMBER:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                <br />
                ENTER EMAIL ID:<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                <br />
                ADDRESS:<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                <br />
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Submit" />
            </asp:View>
            <br />
            <br />
            <asp:View ID="View3" runat="server">
                <asp:Label ID="Label1" runat="server"></asp:Label>
                <br />
                <br />
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Previous" />
                <br />
            </asp:View>
            <br />
        </asp:MultiView>
        <div>
        </div>
    </form>
</body>
</html>
