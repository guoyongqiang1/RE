<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="二七_长江路.aspx.cs" Inherits="WebApplication1.二七_长江路" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style2 {
            height: 24px;
        }
        .auto-style1 {
            height: 18px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <div>
    <h1>吉屋出租</h1>
        您的位置是：<asp:SiteMapPath ID="SiteMapPath1" runat="server">
        </asp:SiteMapPath>
    <table width="1000px">
        <tr>
            <td class="auto-style2">
                
                城市：<asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" >中原</asp:LinkButton>
&nbsp;
                <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click" >二七</asp:LinkButton>
&nbsp;
                <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click" >金水</asp:LinkButton>
                
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                
                &nbsp;
                <asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton5_Click" >碧云路</asp:LinkButton>
                &nbsp;
                <asp:LinkButton ID="LinkButton6" runat="server" OnClick="LinkButton6_Click1" >大学中路</asp:LinkButton>
&nbsp;&nbsp;
                <asp:LinkButton ID="LinkButton7" runat="server" OnClick="LinkButton7_Click1" >长江路</asp:LinkButton>
&nbsp;
                
                <br />
                
                <br />
                
                </td>
        </tr>
        </table>
    </div>
        <asp:GridView ID="GridView1" runat="server" Height="290px" Width="569px" AutoGenerateColumns="False" AllowPaging="True">
                    <Columns>
                        <asp:BoundField DataField="agentID" HeaderText="经纪人工号" />
                        <asp:HyperLinkField DataNavigateUrlFields="agentID" DataNavigateUrlFormatString="经纪人展示.aspx?id={0}" DataTextField="agentName" HeaderText="经纪人姓名" />
                        <asp:BoundField DataField="agentTel" HeaderText="经纪人电话" />
                    </Columns>
                    
      <PagerTemplate>
     
         <asp:Label ID="lblPage" CssClass="PagerFont" runat="server" Text='<%# "第" + (((GridView)Container.NamingContainer).PageIndex + 1)  + "页/共" + (((GridView)Container.NamingContainer).PageCount) + "页" %> '></asp:Label>
         <asp:LinkButton ID="lbnFirst" CssClass="PagerFont" runat="Server" Text="首页"  Enabled='<%# ((GridView)Container.NamingContainer).PageIndex != 0 %>' CommandName="Page" CommandArgument="First" ></asp:LinkButton>
         <asp:LinkButton ID="lbnPrev" CssClass="PagerFont" runat="server" Text="上一页" Enabled='<%# ((GridView)Container.NamingContainer).PageIndex != 0 %>' CommandName="Page" CommandArgument="Prev"  ></asp:LinkButton>
         <asp:LinkButton ID="lbnNext" CssClass="PagerFont" runat="Server" Text="下一页" Enabled='<%# ((GridView)Container.NamingContainer).PageIndex != (((GridView)Container.NamingContainer).PageCount - 1) %>' CommandName="Page" CommandArgument="Next" ></asp:LinkButton>
         <asp:LinkButton ID="lbnLast" CssClass="PagerFont" runat="Server" Text="尾页"   Enabled='<%# ((GridView)Container.NamingContainer).PageIndex != (((GridView)Container.NamingContainer).PageCount - 1) %>' CommandName="Page" CommandArgument="Last" ></asp:LinkButton>
         
     </PagerTemplate>
                </asp:GridView>
    
    </div>
    </form>
</body>
</html>
