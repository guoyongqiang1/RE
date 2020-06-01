<%@ Page Title="" Language="C#" MasterPageFile="~/headerAndFooter.Master" AutoEventWireup="true" CodeBehind="houseXiangXiInfo.aspx.cs" Inherits="Rent.houseXiangXiInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main" id="main" runat="server">
        <div class="title" id="title" runat="server"></div>
        <div class="like" id="like" runat="server"><asp:Button ID="Button1" runat="server" Text="♥收藏" style="float:right" ForeColor="Red" OnClick="Button1_Click"/></div>
        <div class="down" id="down" runat="server">
            <div class="image" id="image" runat="server"></div>
            <div class="info" id="info" runat="server">
                <div class="price" id="price" runat="server"></div>
                <div class="info1" id="info1" runat="server">
                    <div class="Htype" id="Htype" runat="server"></div>
                    <div class="Harea" id="Harea" runat="server"></div>
                </div>
                <div class="info2" id="info2" runat="server">
                    <div class="Haddress" id="Haddress" runat="server"></div>
                    <div class="Haddress1" id="Haddress1" runat="server"></div>
                </div>
                <div class="owner" id="owner" runat="server">
                    <div class="oimage" id="oimage" runat="server"></div>
                    <div class="ownerInfo" id="ownerInfo" runat="server">
                        <div class="ownerName" id="ownerName" runat="server"></div>
                        <div class="ownerTel" id="ownerTel" runat="server"></div>
                    </div>
                </div>
                <div class="agent" id="agent" runat="server">
                    <div class="aimage" id="aimage" runat="server"></div>
                    <div class="agentInfo" id="agentInfo" runat="server">
                        <div class="agentName" id="agentName" runat="server"></div>
                        <div class="agentTel" id="agentTel" runat="server"></div>
                    </div>
                </div>
                <div class="YaoYuYue" id="YaoYuYue" runat="server"></div>
            </div>
        </div>
    </div>
</asp:Content>
