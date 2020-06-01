<%@ Page Language="C#" AutoEventWireup="true" Inherits="edit" Codebehind="edit.aspx.cs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">


        .auto-style1 {
            height: 24px;
        }

        .auto-style2 {
            width: 308px;
        }

        </style>
</head>
<body>
     <form id="form1" runat="server">
         <center>
        <div>
            <h2>个人信息修改</h2>
            <table style="text-align:center;border:double">
                
                <tr class="auto-style1">
                    <td rowspan="5" >
                        <asp:Image ID="Image1" runat="server" Height="128px" ImageUrl="~/picts/self.jpg" Width="128px" />
                    </td>
                    <td class="auto-style2">用户名<asp:TextBox ID="TextBox1" runat="server" MaxLength="11"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="用户名不能为空"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr class="auto-style1">
                    <td class="auto-style2" >
                        姓名
                     
                        <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged" MaxLength="5"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="姓名不能为空"></asp:RequiredFieldValidator>
                    </td>
                    
                </tr>
                <tr class="auto-style1">
                    <td class="auto-style2" >年龄<asp:TextBox ID="TextBox3" runat="server" MaxLength="3" v-model="currentData.loanRate" onkeyup="this.value=this.value.replace(/[^0-9.]/g,'')"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="年龄不能为空"></asp:RequiredFieldValidator>
                    </td>
                    
                </tr>
                  <tr class="auto-style1">
                   <td class="auto-style2">手机号<asp:TextBox ID="TextBox4" runat="server" MaxLength="11" v-model="currentData.loanRate" onkeyup="this.value=this.value.replace(/[^0-9.]/g,'')"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="手机号不能为空"></asp:RequiredFieldValidator>

                   </td>
                    
                </tr>
                <tr class="auto-style1">
                   <td class="auto-style2">密码<asp:TextBox ID="TextBox5" runat="server" MaxLength="11" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox4" ErrorMessage="密码不能为空"></asp:RequiredFieldValidator>

                   </td>
                    
                </tr>
               
                <tr class="auto-style1"><td colspan="2" >

        <asp:Button ID="Button3" runat="server" Text="保存" OnClick="Button3_Click" Width="60px" />
            
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button4" runat="server" CausesValidation="False" OnClick="Button4_Click" Text="返回" Width="60px" />
            
                    </td></tr>
            </table>
          </div>
            
        <div>
        
       
        
        </div>
            
    
   
        </div>
             </center>
    </form>
</body>
</html>
