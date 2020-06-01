<%@ Page Title="" Language="C#" MasterPageFile="~/headerAndFooter.Master" AutoEventWireup="true" CodeBehind="ownerMainInfo.aspx.cs" Inherits="Rent.ownerMainInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="main1" id="main1" runat="server">
            <div class="image1" id="image1" runat="server"></div>
            <div class="ownerPhone1" id="ownerPhone1" runat="server"></div>
            <div class="ownerName1" id="ownerName1" runat="server"></div>
        </div>
    <br/>
    <asp:Button ID="Button1" runat="server" Text="显示房源信息" OnClick="Button1_Click" />
    <asp:Label ID="Label1" runat="server" Text="以下为此房东名下所有可租房源" Visible="False"></asp:Label><asp:Button ID="Button2" runat="server" Text="返回" OnClick="Button2_Click" />
    <div class="main" id="main" runat="server"></div>
</asp:Content>
