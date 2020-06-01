<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="客服.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style2 {
            text-align: center;
            color: #0000FF;
            font-size: x-large;
            font-weight: 400;
            font-family: "Adobe 仿宋 Std R";
        }
        .auto-style3 {
            text-align: center;
            color: #0000FF;
            font-size: x-large;
            font-family: "Adobe 仿宋 Std R";
        }
        .table {
        position :absolute ;
        left :25%;
        width:500px;
        height :300px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" >
    <div >
        <table  class ="table">
            <tr>
                
                <td colspan="2"><h1 class="auto-style3" style="border-width: medium; color: #FF66FF; background-color: #9933FF; text-decoration: underline; border-style:dashed; border-top-color: #FF66FF;" >客服聊天室</h1>
</td>
            </tr>
            <tr>
                <td colspan="2"><asp:TextBox ID="TextBox3" runat="server" Height="277px" ReadOnly="True" TextMode="MultiLine" Width="725px" BackColor="#CC99FF"></asp:TextBox>
</td>
            </tr>
            <tr>
                <td colspan="2"><asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="内容刷新" />
</td>
            </tr>
            <tr>
                <td >姓名：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</td>
                <td >内容：<asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine"></asp:TextBox>
</td>
            </tr>
            <tr>
                <td><asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="提交" />
</td>
               <td><asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="退出聊天室" />
  </td>          </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
