<%@ Page Title="" Language="C#" MasterPageFile="~/经纪人主页面.Master" AutoEventWireup="true" CodeBehind="经纪人.aspx.cs" Inherits="WebApplication1.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

       
       

       
        .f1 {}

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div>
            <table style="width: 594px">
                <tr>
                    <td >
                        <asp:GridView ID="GridView1" runat="server" BorderStyle="Dashed" CellSpacing="10" CssClass="f1" AutoGenerateColumns="False" Font-Overline="False" Font-Size="Large" Height="16px" OnRowDataBound="GridView1_RowDataBound" Width="626px" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1">
                            <Columns>
                                <asp:BoundField DataField="agentID" HeaderText="经纪人工号" SortExpression="agentID" />
                                <asp:HyperLinkField DataNavigateUrlFields="agentID"
                                     DataNavigateUrlFormatString="经纪人展示.aspx?id={0}" DataTextField="agentName"  HeaderText="经纪人姓名" />
                                <asp:BoundField DataField="agentTel" HeaderText="经纪人手机号" />
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
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="返回" />
                        <br />
                    </td>
                </tr>
            </table>
        </div>
</asp:Content>
