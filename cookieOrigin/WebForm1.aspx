﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="cookieOrigin.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ENTER NAME:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            CITY :<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            AGE:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
        </div>
    </form>
</body>
</html>