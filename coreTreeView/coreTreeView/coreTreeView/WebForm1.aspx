<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="coreTreeView.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:SiteMapPath ID="SiteMapPath1" runat="server"></asp:SiteMapPath>
        <asp:Menu ID="Menu1" runat="server" OnMenuItemClick="Menu1_MenuItemClick" Orientation="Horizontal">
            <Items>
                <asp:MenuItem NavigateUrl="~/home.aspx" Text="home" Value="home"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/course.aspx" Text="course" Value="course"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/contectus.aspx" Text="contect us" Value="contect us"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/aboutUs.aspx" Text="about us" Value="about us"></asp:MenuItem>
            </Items>
        </asp:Menu>
        <br />
        <asp:TreeView ID="TreeView1" runat="server">
            <Nodes>
                <asp:TreeNode NavigateUrl="~/course.aspx" Text="course" Value="course">
                    <asp:TreeNode NavigateUrl="~/bscit.aspx" Text="BSCIT" Value="BSCIT">
                        <asp:TreeNode NavigateUrl="~/fy.aspx" Text="FY" Value="FY"></asp:TreeNode>
                        <asp:TreeNode NavigateUrl="~/sy.aspx" Text="SY" Value="SY"></asp:TreeNode>
                        <asp:TreeNode NavigateUrl="~/ty.aspx" Text="TY" Value="TY"></asp:TreeNode>
                    </asp:TreeNode>
                </asp:TreeNode>
                <asp:TreeNode NavigateUrl="~/registration.aspx" Text="registration" Value="registration">
                    <asp:TreeNode NavigateUrl="~/baf.aspx" Text="BAF" Value="BAF"></asp:TreeNode>
                    <asp:TreeNode NavigateUrl="~/bms.aspx" Text="BMS" Value="BMS"></asp:TreeNode>
                    <asp:TreeNode NavigateUrl="~/bscit.aspx" Text="BSCIT" Value="BSCIT"></asp:TreeNode>
                </asp:TreeNode>
            </Nodes>
        </asp:TreeView>
        
    </form>
</body>
</html>
