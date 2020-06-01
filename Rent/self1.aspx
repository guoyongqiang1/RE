<%@ Page Language="C#" AutoEventWireup="true" Inherits="self1" Codebehind="self1.aspx.cs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

       
        .block-right {
            padding-top:0;
            float:left;
        margin-top:150px;
        margin-left:20px;                               
        width:67%;
        height:100%;
        display:block;
        box-shadow:1px 1px 0.2px rgba(0,0,0,0.1);
        }
        .img {
        width:90px;
        height:90px;
        padding-top:0px;
        }
               
        .box-xiao {
            margin-top:30px;
            margin-left:5px;
        height:120px;
       
        border-radius:5px;
        }
        .a-top {
            padding:14px;
        margin-left:25px;
        font-size:18px;
        color: black;
        text-decoration:none;
        float:right;
    }

        .auto-style1 {
            height: 24px;
        }

        .auto-style2 {
            height: 30px;
        }

        .auto-style3 {
            height: 27px;
        }

        </style>
</head>
<body>
    <form id="form2" runat="server">
        <div >
            <center>
             <h2>个人信息</h2>
            <table style="text-align:center ;border:double">
                
                <tr style="height:30px">
                    <td rowspan="3" >
                        <asp:Image ID="Image1" runat="server" Height="128px" ImageUrl="~/picts/self.jpg" Width="128px" />
                    </td>
                    <td>账户ID<asp:TextBox ID="TextBox1" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                </tr>
                <tr style="height:30px">
                    <td class="auto-style2">姓名<asp:TextBox ID="TextBox2" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                    
                </tr>
                <tr style="height:30px">
                    <td class="auto-style1">年龄<asp:TextBox ID="TextBox3" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                    
                </tr>
                  <tr style="height:30px">
                   <td></td>
                    <td class="auto-style1">手机号<asp:TextBox ID="TextBox4" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                    
                </tr>
                <tr style="height:30px">
                    
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="收藏的房源"></asp:Label>
                    </td>
                    <td>
                        
                        <asp:TextBox ID="TextBox5" runat="server" ReadOnly="True"></asp:TextBox>
                        
                        <asp:Button ID="Button1" runat="server" Text="查看" OnClick="Button1_Click" />
                        
                </tr>
                <tr style="height:30px"><td>
                    <asp:Label ID="Label2" runat="server" Text="收藏的经纪人"></asp:Label>
                     
                    </td>
                    <td>
                     
                    <asp:TextBox ID="TextBox6" runat="server" ReadOnly="True"></asp:TextBox>
                        <asp:Button ID="Button2" runat="server" Text="查看" OnClick="Button2_Click" />
                    </td>
                </tr>
                <tr style="height:30px"><td colspan="2" class="auto-style3" >

        <asp:Button ID="Button3" runat="server" Text="编辑" OnClick="Button3_Click" Width="60px" />
            
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button4" runat="server" Text="返回" Width="60px" OnClick="Button4_Click" />
            
                    </td></tr>
            </table>
        </div>
            
        <div>
        
       
        </center>
        </div>
            
    </form>
</body>
</html>
