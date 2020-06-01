<%@ Page Language="C#" MasterPageFile="~/headerAndFooter.Master" AutoEventWireup="true" CodeBehind="经纪人展示.aspx.cs" Inherits="WebApplication1.经纪人展示" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="296px" OnPageIndexChanging="GridView1_PageIndexChanging" style="margin-right: 85px; margin-top: 0px" Width="1218px" AllowPaging="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="agentID" HeaderText="经纪人工号" SortExpression="agentID" />
            <asp:BoundField DataField="agentTel" HeaderText="经纪人电话" SortExpression="agentTel" />
            <asp:BoundField DataField="agentName" HeaderText="经纪人姓名" SortExpression="agentName" />
            <asp:BoundField DataField="agentAge" HeaderText="经纪人年龄" SortExpression="agentAge" />
            <asp:BoundField DataField="agentArea" HeaderText="经纪人所在区" SortExpression="agentArea" />
            <asp:BoundField DataField="agentDistrict" HeaderText="经纪人所在街道" SortExpression="agentDistrict" />
            <asp:BoundField DataField="agentTimes" HeaderText="租赁成交套数" SortExpression="agentTimes" />
            <asp:BoundField DataField="agentTrantimes" HeaderText="近30天租赁带看次数" SortExpression="agentTrantimes" />
        </Columns>
            <PagerStyle HorizontalAlign="Center" CssClass="PagerClass" Font-Size="20" Font-Italic="False" Font-Strikeout="False" Font-Underline="False" ForeColor="Black" />
               
      <PagerTemplate>
     
         <asp:Label ID="lblPage" CssClass="PagerFont" runat="server" Text='<%# "第" + (((GridView)Container.NamingContainer).PageIndex + 1)  + "页/共" + (((GridView)Container.NamingContainer).PageCount) + "页" %> '></asp:Label>
         <asp:LinkButton ID="lbnFirst" CssClass="PagerFont" runat="Server" Text="首页"  Enabled='<%# ((GridView)Container.NamingContainer).PageIndex != 0 %>' CommandName="Page" CommandArgument="First" ></asp:LinkButton>
         <asp:LinkButton ID="lbnPrev" CssClass="PagerFont" runat="server" Text="上一页" Enabled='<%# ((GridView)Container.NamingContainer).PageIndex != 0 %>' CommandName="Page" CommandArgument="Prev"  ></asp:LinkButton>
         <asp:LinkButton ID="lbnNext" CssClass="PagerFont" runat="Server" Text="下一页" Enabled='<%# ((GridView)Container.NamingContainer).PageIndex != (((GridView)Container.NamingContainer).PageCount - 1) %>' CommandName="Page" CommandArgument="Next" ></asp:LinkButton>
         <asp:LinkButton ID="lbnLast" CssClass="PagerFont" runat="Server" Text="尾页"   Enabled='<%# ((GridView)Container.NamingContainer).PageIndex != (((GridView)Container.NamingContainer).PageCount - 1) %>' CommandName="Page" CommandArgument="Last" ></asp:LinkButton>
         
     </PagerTemplate>
    </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RentConnectionString6 %>" SelectCommand="SELECT [agentID], [agentTel], [agentName], [agentAge], [agentArea], [agentDistrict], [agentTimes], [agentTrantimes] FROM [agent]"></asp:SqlDataSource>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Height="28px" OnClick="Button1_Click" Text="返回" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="收藏" Visible="False" />
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="选择" Visible="False" />
    
    </div>
</asp:Content>
