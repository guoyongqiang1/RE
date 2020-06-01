<%@ Page Language="C#" AutoEventWireup="true" Inherits="Login" Codebehind="Login-zhuce.aspx.cs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
   <link href="css/login.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
       <div id="tab">
      <div class="tab_box"  style="width:440px"> 
        <!-- 注册开始 -->
          <div><a href="Login-ap.aspx" class="a">登录</a></div>
        <div>
     
     
        <div id="username">
          <label>用户名：</label><asp:TextBox ID="TextBox1" runat="server" Height="24px" Width="125px"></asp:TextBox>
        </div>
        <div id="password">
        
             <div id="Div1">
          <label>姓名：</label><asp:TextBox ID="TextBox4" runat="server" Height="24px" Width="125px"></asp:TextBox>
        </div>
             <div id="Div2">
          <label>电话：</label><asp:TextBox ID="TextBox5" runat="server" Height="24px" Width="125px"></asp:TextBox>
        </div>
              <label>密码:&nbsp; </label>
            <asp:TextBox ID="TextBox3" runat="server" Height="24px" Width="125px" TextMode="Password"></asp:TextBox>
            </div>
            <div class="yespwd" id="yespwd">
            <label>
            再输入密码:</label><asp:TextBox ID="TextBox33" runat="server" Height="24px" Width="120px" TextMode="Password"></asp:TextBox>
           
               
        </div>
             <div id="Div3">
          <label>年龄：</label><asp:TextBox ID="TextBox6" runat="server" Height="24px" Width="125px"></asp:TextBox>
        </div>
         <div id="identity">
             <label>身份：</label><asp:DropDownList ID="DropDownList1" runat="server" Height="26px" Width="158px" style="border-radius:5px;border-color:darkgrey">
                 <asp:ListItem Value="user">用户</asp:ListItem>
                 <asp:ListItem Value="owner">房东</asp:ListItem>
                 <asp:ListItem Value="agent">经纪人</asp:ListItem>
                 <asp:ListItem Value="admin">管理员</asp:ListItem>
             </asp:DropDownList>
        </div>
            <div id="verification">
          <label>&nbsp;&nbsp;&nbsp;&nbsp; 验证码：</label><asp:TextBox ID="TextBox2" runat="server" Height="24px" Width="125px"></asp:TextBox>
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </div>
        <div id="login" >
            <asp:Button ID="Button1" runat="server" Text="立即注册"  BackColor="#FF6600" Font-Size="Large" ForeColor="White" Height="45px" Width="100%" style="border-radius:10px" OnClick="Button1_Click1" />
        </div>
     
    </div>
   <!-- 注册结束-->
  </div>
</div>
         <div class="twe"><asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox3" ControlToValidate="TextBox33" ErrorMessage="两次密码输入不同"></asp:CompareValidator></div>
 <div class="telZhengZe"><asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="请输入正确的手机号！！！" ForeColor="Red" ValidationExpression="(\(\d{3}\)|\d{3}-)?\d{8}" ControlToValidate="TextBox5"></asp:RegularExpressionValidator></div>
<div class="screenbg">
 <img  style="width:100%;height:100%;" src="backImage.jpg" />
</div>

   </form>
</body>
</html>
