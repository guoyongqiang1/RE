<%@ Page Language="C#" AutoEventWireup="true" Inherits="Likehouse" Codebehind="Likehouse.aspx.cs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>收藏的房源</h2>
            <span>用户<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            </span>&nbsp;<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" EnableModelValidation="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:BoundField DataField="houseID" HeaderText="房源号" />
                    <asp:BoundField DataField="houseAdress" HeaderText="详细地址" />
                    <asp:BoundField DataField="houseType" HeaderText="类型" />
                    <asp:BoundField DataField="hopePrice" HeaderText="期待价格" />
                    <asp:BoundField DataField="houseArea" HeaderText="面积" />
                    <asp:BoundField DataField="ownerPhone" HeaderText="房东电话" />
                    <asp:BoundField DataField="timeLooking" HeaderText="看房时间" />
                    <asp:BoundField DataField="agentID" HeaderText="经纪人" />
                    <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            </asp:GridView>
            <br />
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="取消收藏" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Height="26px" OnClick="Button2_Click" Text="返回" Width="58px" />
    </form>
</body>
</html>
