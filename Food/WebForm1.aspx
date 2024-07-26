<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Food.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            BUY FOOD<br />
            <br />
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Pizza Rs.70:" />
            <br />
            <br />
            :<asp:CheckBox ID="CheckBox2" runat="server" Text="Burger Rs.30" />
            <br />
            <br />
            :<asp:CheckBox ID="CheckBox3" runat="server" Text="Sandwich Rs.50" />
            <br />
            <br />
            :<asp:CheckBox ID="CheckBox4" runat="server" Text="Grilled Sandwich RS.70" />
        </div>
    </form>
</body>
</html>
