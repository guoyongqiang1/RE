<%@ Page Language="C#" MasterPageFile="~/header.Master" AutoEventWireup="true" Inherits="Outsea" Codebehind="Outsea.aspx.cs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .up {
            width: 100%;
            height: 500px;
            left: 0;
            top: 0;
            margin-top: -55px;
            position: absolute;
            box-sizing: border-box;
            background-image: url(http://localhost:49383/picts/3.jpg);
            background-position: center;
            background-size: cover;
        }
        /*.down {
        width:100%;
        top:450px;
        left:0;
        background-color:aliceblue;
        
        }*/
        .auto-style2 {
            height: 0px;
        }
    </style>
    <%--<div class="" id="main" runat="server">--%>
        <div><h1 style="text-align:center">海外查询</h1></div>
        <table style="position:absolute;left:42%;">
            <tr style="width:800px;">
                <td class="auto-style2" >            
              <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" style="float:right">
                </asp:DropDownList></td>
                    <td class="auto-style2" > <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True">
            </asp:DropDownList>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="搜索" />
                </td>
            <td><asp:Button ID="Button2" runat="server" Text="返回" OnClick="Button2_Click" /></td>
            </tr>
           
        </table>
     <div class="bigBox" id="bigBox" runat="server"></div>
    <%-- </div>--%>
        
        <p>
            &nbsp;</p>
        <asp:Image ID="Image1" runat="server" />
</asp:Content>
