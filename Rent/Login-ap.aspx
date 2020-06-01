<%@ Page Language="C#" AutoEventWireup="true" Inherits="Login_ap" Codebehind="Login-ap.aspx.cs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/login.css" rel="stylesheet" />
    <style>
        .a {
        text-decoration: none;
        font-size: 14px;
        padding-left: 358px;
    } 
        .b {
                text-decoration: none;
                font-size: 14px;
                padding-left: 334px;
            } 
    </style>
</head>
<body>
    <form id="form2" runat="server">
       <div id="tab">
      <div class="tab_box"> 
        <!-- 登录开始 -->
          <div><a href="Login-zhuce.aspx" class="a">注册</a>
              <a href="Findpwd.aspx" class="b">忘记密码</a>
          </div>
       
     
        <div id="username">
          <label>用户名：</label>
            <asp:TextBox ID="TextBox1" runat="server" Height="24px" Width="125px"></asp:TextBox>
        </div>
        <div id="password">
          <label>&nbsp;&nbsp;&nbsp;&nbsp; 密码:&nbsp;&nbsp; </label>
            <asp:TextBox ID="TextBox2" runat="server" Height="24px" Width="125px" TextMode="Password"></asp:TextBox>
        </div>    
         <div id="identity">
          <label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 身份：</label><asp:DropDownList ID="DropDownList1" runat="server" Height="26px" Width="160px" style="border-radius:5px;border-color:darkgrey">
                 <asp:ListItem Value="用户">用户</asp:ListItem>
                 <asp:ListItem Value="房东">房东</asp:ListItem>
                 <asp:ListItem Value="经纪人">经纪人</asp:ListItem>
                 <asp:ListItem Value="管理员">管理员</asp:ListItem>
             </asp:DropDownList>
        </div>
        <div id="login" >
            <asp:Button ID="Button1" runat="server" Text="立即登录"  BackColor="#ff66cc" Font-Size="Large" ForeColor="White" Height="45px" Width="100%" style="border-radius:10px" onClick="Button1_Click"/>
        </div>
      
    </div>
   <!-- 登录结束-->
  </div>
</div>

<div class="screenbg">
 <img style="width:100%;height:100%;" src="backImage.jpg">
</div>
            </form>
    </body>
</html>
