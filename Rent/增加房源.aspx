<%@ Page Language="C#" MasterPageFile="~/headerAndFooter.Master" AutoEventWireup="true" CodeBehind="增加房源.aspx.cs" Inherits="WebApplication1.增加房源" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style type="text/css">
        .box1 {
        padding-left :100px;
        }
        .box2 {
        padding-left :80px
        }
        .box3 {
        padding-left :60px
        }
        
        .box4 {
        padding-left :70px
        }
    </style>
    <table border="1" style ="text-align :center;width:600px;height :600px;border:double">
        <caption><b style="font-size: xx-large">增加房源</b></caption>
        <tr>
            <td   >房子账号：</td>
            <td  colspan="2">
                <asp:TextBox ID="TextBox7" runat="server" CssClass="box1" ToolTip="自行编写"  OnTextChanged="TextBox6_TextChanged"  type="text" v-model="currentData.loanRate" maxlength="7" onkeyup="this.value=this.value.replace(/[^0-9.]/g,'')"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="请输入房子账号" ControlToValidate="TextBox7" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td >选择经纪人：</td>
            <td  colspan="2">
                <asp:CheckBox ID="CheckBox1" runat="server" Text="经过经纪人预定" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" />
                <asp:LinkButton ID="LinkButton1" runat="server" Visible="False" OnClick="LinkButton1_Click" CausesValidation="False">去选择经纪人</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td>房屋小区名：</td>
            <td colspan="2">
                <asp:TextBox ID="TextBox11" runat="server" CssClass="box1"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="TextBox11" ErrorMessage="请输入小区名" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td >房屋详细地址：</td>
            <td colspan="2">
                <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged" ToolTip="包括楼号，单元号，房间号" CssClass="box1"  ></asp:TextBox>

                <br />

                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="请输入详细地址" ForeColor="Red" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td >期望售价：</td>
            <td   colspan ="2">
                <asp:TextBox ID="TextBox5" runat="server" CssClass="box4"  type="text" v-model="currentData.loanRate" maxlength="7" onkeyup="this.value=this.value.replace(/[^0-9.]/g,'')"  ></asp:TextBox>
                元/月<br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="请输入期望售价" ControlToValidate="TextBox5" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td >房屋户型：</td><td colspan="2">
            <asp:DropDownList ID="DropDownList3" runat="server">
                <asp:ListItem>一室一厅一厕</asp:ListItem>
                <asp:ListItem>两室一厅一厕</asp:ListItem>
                <asp:ListItem>三室一厅一厕</asp:ListItem>
                <asp:ListItem>一室一厅两厕</asp:ListItem>
                <asp:ListItem>两室一厅两厕</asp:ListItem>
                <asp:ListItem>三室一厅两厕</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="请选择房屋户型" ControlToValidate="DropDownList3" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td  >面积：</td>
            <td  colspan ="2" >
                <asp:TextBox ID="TextBox6" runat="server" CssClass="box4" OnTextChanged="TextBox6_TextChanged"  type="text" v-model="currentData.loanRate" maxlength="7" onkeyup="this.value=this.value.replace(/[^0-9.]/g,'')"></asp:TextBox>
                平米
                 
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="请输入面积" ControlToValidate="TextBox6" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td >选择房子所在区域：</td>
            <td colspan="2">
                <asp:DropDownList ID="DropDownList1" runat="server" style="margin-left: 0px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                </asp:DropDownList>
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="请选择区域" ControlToValidate="DropDownList1" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td >房屋所在街道：</td>
            <td  colspan ="2">
                <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" >
                    <asp:ListItem>请自行选择房屋所在区域</asp:ListItem>
                </asp:DropDownList>
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="请选择街道" ControlToValidate="DropDownList2" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td >户主手机号码：</td>
            <td colspan="2">
                <asp:TextBox ID="TextBox8" runat="server" CssClass="box1" OnTextChanged="TextBox8_TextChanged"  type="text" v-model="currentData.loanRate" maxlength="11" onkeyup="this.value=this.value.replace(/[^0-9.]/g,'')" ></asp:TextBox>

                <br />

                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="请输入手机号码" ControlToValidate="TextBox8" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td >验证码：</td>
            <td colspan ="2" >
                <asp:TextBox ID="TextBox9" runat="server" OnTextChanged="TextBox9_TextChanged"  ></asp:TextBox>
                <asp:Button ID="Button3" runat="server" Text="获取验证码" Width="100px" OnClick="Button2_Click" CausesValidation="False" />
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="请输入验证码" ControlToValidate="TextBox9" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Button ID="Button1" runat="server" Text="提交委托" OnClick="Button1_Click" />
            </td>
        </tr>
        
    </table>
</asp:Content>
