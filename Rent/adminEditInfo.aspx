<%@ Page Title="" Language="C#" MasterPageFile="~/headerAndFooter.Master" AutoEventWireup="true" CodeBehind="adminEditInfo.aspx.cs" Inherits="Rent.adminEditInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Font-Size="X-Large" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        <asp:ListItem>---请选择---</asp:ListItem>
        <asp:ListItem>租户</asp:ListItem>
        <asp:ListItem>房东</asp:ListItem>
        <asp:ListItem>经纪人</asp:ListItem>
        <asp:ListItem>添加知识</asp:ListItem>
    </asp:DropDownList>
</asp:Content>
