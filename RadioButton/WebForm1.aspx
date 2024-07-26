<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="RadioButton.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Select Your Gender<br />
            <br />
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="Gender" Text="Male" />
&nbsp;
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="Gender" Text="Female" />
            <br />
            <br />
            Select Your Hobbies<br />
            <br />
            <asp:RadioButton ID="RadioButton3" runat="server" GroupName="H" Text="Cricket" />
&nbsp;
            <asp:RadioButton ID="RadioButton4" runat="server" GroupName="H" Text="Reading" />
&nbsp;
            <asp:RadioButton ID="RadioButton5" runat="server" GroupName="H" Text="Watching Movies" />
&nbsp;
            <asp:RadioButton ID="RadioButton6" runat="server" GroupName="H" Text="Playing Games" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
