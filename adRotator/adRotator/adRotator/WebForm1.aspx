<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="adRotator.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <h2>AdRotator Control Exmple</h2>

                <asp:AdRotator runat="server"  AdvertisementFile="~/XMLFile1.xml"/>
            </center>
        </div>
    </form>
</body>
</html>
