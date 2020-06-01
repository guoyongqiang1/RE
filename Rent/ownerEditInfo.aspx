<%@ Page Language="C#" MasterPageFile="~/headerAndFooter.Master" AutoEventWireup="true" CodeBehind="ownerEditInfo.aspx.cs" Inherits="Rent.ownerEditInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 27px;
        }
    </style>
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" HorizontalAlign="Center">
            <Columns>
                <asp:BoundField DataField="ownerID" HeaderText="房东ID" />
                <asp:BoundField DataField="ownerName" HeaderText="房东个人姓名" />
                <asp:BoundField DataField="ownerPhone" HeaderText="房东个人电话" />
                <asp:BoundField DataField="ownerPwd" HeaderText="房东个人密码" />
                <asp:BoundField DataField="ownerImage" HeaderText="房东照片" />
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
    
    </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="添加" />

     <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="返回" />

     <table border="0" class="table1" id="table1" runat="server">
        <tr>
            <td style="text-align:right">房东ID：</td>
            <td style="text-align:left">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="text-align:right">房东姓名：</td>
            <td style="text-align:left">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="text-align:right" class="auto-style1">房东电话：</td>
            <td style="text-align:left" class="auto-style1">
                <asp:TextBox ID="TextBox3" runat="server" v-model="currentData.loanRate" minlength="11" maxlength="11" οnkeyup="this.value=this.value.replace(/[^0-9.]/g,'')"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="text-align:right">房东密码：</td>
            <td style="text-align:left">
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="text-align:right">房东照片：</td>
            <td style="text-align:left">
                <asp:TextBox ID="TextBox5" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td colspan="2" style="text-align:center">
                <asp:Button ID="Button2" runat="server" Text="确定" OnClick="Button2_Click" />
             </td>
        </tr>
    </table>
</asp:Content>
