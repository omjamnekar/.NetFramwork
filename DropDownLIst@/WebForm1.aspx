<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DropDownLIst_.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Select City:<asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Mumbai</asp:ListItem>
                <asp:ListItem>Pune</asp:ListItem>
                <asp:ListItem>Delhi</asp:ListItem>
                <asp:ListItem>Banglore</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Count" />
&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Selected Text" />
&nbsp;
            <asp:Button ID="Button3" runat="server" Text="Selected Value" />
&nbsp;
            <asp:Button ID="Button4" runat="server" Text="Index" />
&nbsp;<asp:Button ID="Button5" runat="server" Text="remove" />
&nbsp;
            <asp:Button ID="Button6" runat="server" Text="Add" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
