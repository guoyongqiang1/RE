<%@ Page Title="" Language="C#" MasterPageFile="~/headerAndFooter.Master" AutoEventWireup="true" CodeBehind="houseInfo.aspx.cs" Inherits="Rent.houseInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <link rel="stylesheet" href="changeImages.css" />
    <style>
        select#ContentPlaceHolder1_DropDownList1 {
            float:right;
        }
    </style>
      <div class="main" id="main" runat="server">
        <%-- 轮播 --%>
        <div class="header" aria-dropeffect="popup" style="margin-bottom:15px;">
        <div class="all" id='all'>
            <div class="screen" id="screen">
                <ul id="ul">
                    <li>
                        <img src="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1577011330450&di=82b8ffc9ce430a789a0f5d8fd4504ea8&imgtype=0&src=http%3A%2F%2Fstatic-xiaoguotu.17house.com%2Fxgt%2Fs%2F16%2F1463128769176.jpg" width="1060" height="400" /></li>
                    <li>
                        <img src="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1577011462213&di=b5832b4872c5c25dbda8904c4e49f5b9&imgtype=0&src=http%3A%2F%2Fpic.shejiben.com%2Fcase%2F2015%2F10%2F26%2F20151026153008-e591ac62.jpg" width="1060" height="400" /></li>
                    <li>
                        <img src="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1577011502553&di=81d213624c685b1b13ac1cf17cfeaf17&imgtype=0&src=http%3A%2F%2Fwww.360aiyi.com%2Fdown%2F201803%2F7228e2f71fe6b6ec68a5a1b77cc23707.jpg" width="1060" height="400" /></li>
                    <li>
                        <img src="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1577011544630&di=088aff462a4efcfab0cd9d0dbc76e465&imgtype=0&src=http%3A%2F%2Fgss0.baidu.com%2F9vo3dSag_xI4khGko9WTAnF6hhy%2Fzhidao%2Fpic%2Fitem%2F472309f790529822e39facfedaca7bcb0a46d45b.jpg" width="1060" height="400" /></li>
                    <li>
                        <img src="https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1577011547045&di=e130d33c58c74d23a340493dd46771be&imgtype=0&src=http%3A%2F%2Fpic2.to8to.com%2Fcase%2F2014%2F05%2F28%2F20140528164631-66dcc8ad.jpg" width="1060" height="400" /></li>
                </ul>
                <ol>
                </ol>
                <div id="arr">
                    <span id="left"><</span>
                    <span id="right">></span>
                </div>
            </div>
        </div>
    </div>
        <hr />
        <asp:Label ID="Label2" runat="server" Text="Label" Font-Size="Small"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Font-Size="Small">
            <asp:ListItem>默认排序</asp:ListItem>
            <asp:ListItem>按升序租金</asp:ListItem>
            <asp:ListItem>按升序面积</asp:ListItem>
            <asp:ListItem>按时间升序最新发布</asp:ListItem>
        </asp:DropDownList>
        <hr />
     </div>
     
<script src="changeImages.js"></script>
</asp:Content>
