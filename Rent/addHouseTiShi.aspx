<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addHouseTiShi.aspx.cs" Inherits="Rent.addHouseTiShi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="position:fixed;bottom:50%;right:50%;">
        <h1>您已经成功提交房子信息！！！</h1>
    </div>
        <asp:Button ID="Button1" runat="server" Text="返回" style="position:fixed; top: 15px; left: 10px;" OnClick="Button1_Click"/>
    </form>
</body>
</html>
