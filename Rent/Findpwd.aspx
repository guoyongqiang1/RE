<%@ Page Language="C#" AutoEventWireup="true" Inherits="Findpwd" Codebehind="Findpwd.aspx.cs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <link href="css/login.css" rel="stylesheet" />
    
    <style>
        .c {
        text-decoration:none;
        font-size:14px;
        padding-left:306px;
        }
        .com {
       margin-top: -45px;
    margin-left: 880px;
    color: red;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
      



        <div id="tab">
      <div class="tab_box"> 
        <!-- 登录开始 -->
          <div><a href="Login-ap.aspx" class="c">账号密码登录</a>
          
          </div>
       
     
        <div id="username">
          <label>用户名：</label>
            <asp:TextBox ID="TextBox1" runat="server" Height="24px" Width="125px"></asp:TextBox>
        </div>
        
         <div id="identity">
          <label>&nbsp;&nbsp;身份：</label><asp:DropDownList ID="DropDownList1" runat="server" Height="26px" Width="160px" style="border-radius:5px;border-color:darkgrey">
                 <asp:ListItem Value="users">用户</asp:ListItem>
                 <asp:ListItem Value="owner">房东</asp:ListItem>
                 <asp:ListItem Value="agent">经纪人</asp:ListItem>
                 <asp:ListItem Value="admin">管理员</asp:ListItem>
             </asp:DropDownList>
        </div>
          <div id="Div1">
          <label>新密码：</label>
            <asp:TextBox ID="TextBox3" runat="server" Height="24px" Width="125px" TextMode="Password"></asp:TextBox></div>
              <div>
              <label>
              再输入密码:</label><asp:TextBox ID="TextBox4" runat="server" Height="24px" Width="109px" TextMode="Password"></asp:TextBox>
        </div>
          <div id="Div3">
          <label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 验证码：</label>
            <asp:TextBox ID="TextBox2" runat="server" Height="24px" Width="125px"></asp:TextBox>
              <asp:TextBox ID="TextBox5" runat="server" Height="21px" Width="49px"></asp:TextBox>
             
          </div>
        <div id="login" >
            <asp:Button ID="Button1" runat="server" Text="立即找回"  BackColor="#FF6600" Font-Size="Large" ForeColor="White" Height="45px" Width="100%" style="border-radius:10px" onClick="Button1_Click"/>
        </div>
      
    </div>
   <!-- 登录结束-->
  </div>

 <div class="com">
              <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox5" ControlToValidate="TextBox2">验证码输入错误</asp:CompareValidator>
              </div>
<div class="screenbg">
 <img  style="width:100%;height:100%;" src="backImage.jpg" />
</div>
            </form>
    </body>
</html>
