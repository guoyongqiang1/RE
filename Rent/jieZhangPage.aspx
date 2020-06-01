<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="jieZhangPage.aspx.cs" Inherits="Rent.jieZhangPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <img src="https://qr.api.cli.im/qr?data=%25E6%2581%25AD%25E5%2596%259C%25E6%2582%25A8%25E4%25BB%2598%25E9%2592%25B1%25E6%2588%2590%25E5%258A%259F%25EF%25BC%2581%25EF%25BC%2581%25EF%25BC%2581%250A%25E7%25A5%259D%25E6%2582%25A8%25E5%25B1%2585%25E4%25BD%258F%25E6%2584%2589%25E5%25BF%25AB&level=H&transparent=false&bgcolor=%23FFFFFF&forecolor=%23000000&blockpixel=12&marginblock=1&logourl=&size=280&kid=cliim&key=28cd15e9d3e6cf0e4caaba476734778f" alt="支付二维码" />
    </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="支付成功" />
    </form>
</body>
</html>
