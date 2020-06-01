<%@ Page Language="C#" AutoEventWireup="true" Inherits="likeagent" Codebehind="likeagent.aspx.cs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        
        <h2>收藏的联系人</h2></div>
        <div>
            <span>用户</span>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <span>
            <br />
            </span>&nbsp;</div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="agentID" HeaderText="经纪人编号" />
                <asp:BoundField DataField="agentTel" HeaderText="联系方式" />
                <asp:BoundField DataField="agentName" HeaderText="姓名" />
                <asp:BoundField DataField="agentArea" HeaderText="工作区" />
                <asp:BoundField DataField="agentTimes" HeaderText="历史成交记录" />
                <asp:BoundField DataField="agentTrantimes" HeaderText="进30天租赁带看次数" />
                <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        </asp:GridView>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="取消收藏" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Height="27px" OnClick="Button2_Click" Text="返回" Width="60px" />
        </p>
    </form>
</body>
</html>
