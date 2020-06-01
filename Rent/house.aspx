<%@ Page Language="C#" AutoEventWireup="true" Inherits="house" Codebehind="house.aspx.cs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
         /** {
        padding:0;
        margin:0;
        }*/
        .box {
       width: 890px;
    height: 560px;
    padding: 84px;
  
        }
        .img {
       width: 890px;
    height: 560px;
        }
        .box1 {
       margin-left: 81px;
    margin-top: -700px;
    width: 295px;
    position: relative;
        }
        .box2 {
        margin-left: 80px;
    margin-top: 0px;
    width: 200px;
    /* height: 100px; */
    position: absolute;
        }
        .box3 {
       margin-left: 1125px;
    margin-top: 15px;
    width: 200px;
    /* height: 100px; */
    position: absolute;
        }
        .box4 {
        margin-left: 1095px;
    margin-top: -43px;
    width: 240px;
    /* height: 100px; */
    position: absolute;
        }
        .box5 {
        margin-left: 1235px;
    margin-top: 13px;
    width: 200px;
    /* height: 100px; */
    position: absolute;
        }
        .box6 {
        margin-left: 1111px;
    margin-top: 410px;
    width: 200px;

        }
        .box7 {
          margin-left: 1107px;
    margin-top: 39px;
        }
        .box8 {
          margin-left: 1107px;
    margin-top: 10px;
        }
       .font1 {
        color: black;
    font-weight: 600;
    font-size: 25px;
        }
        .font2 {
        color: black;
    /* font-weight: 600; */
    font-size: 14px;
        }
         .font3 {
       color: black;
    font-size: 20px;
        }
          .font4 {
        color: red;
    font-size: 40px;
        }
           .font5 {
        color: grey;
    font-size: 24px;
        }
            .font6 {
       color: black;
    font-size: 25px;
        }
        .btn1 {
       background-color: coral;
    color: white;
    width: 185px;
    height: 30px;
        }
        .btn2 {
       color: white;
    background-color: coral;
    width: 185px;
    height: 30px;
        }
        .box9 {
       margin-left: 1115px;
    margin-top: -431px;
        }
        .pic {
        width: 173px;
    height: 200px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="box"> &nbsp;<asp:Image ID="Image1" runat="server"  class="img"/></div>           
        <div class="box1">
        <asp:Label ID="Label1" runat="server" Text="Label" CssClass="font1"></asp:Label>
        <asp:Label ID="Label2" runat="server" Text="Label" CssClass="font1">></asp:Label>
        <asp:Label ID="Label3" runat="server" Text="Label" CssClass="font1">></asp:Label>
       </div>
        <div class="box2"><asp:Label ID="Label4" runat="server" Text="Label" CssClass="font2"></asp:Label></div>    
       
        <div class="box3"><asp:Label ID="Label5" runat="server" Text="Label" CssClass="font3"></asp:Label></div>    
        <div class="box4"><asp:Label ID="Label6" runat="server" Text="Label" CssClass="font4"></asp:Label></div>           
        <div class="box5"><asp:Label ID="Label7" runat="server" Text="Label" CssClass="font5"></asp:Label></div>    
        <div class="box6"><asp:Label ID="Label8" runat="server" Text="Label" CssClass="font6"></asp:Label></div>    
        
       
       
         <div class="box7"><asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="收藏" class="btn1"/></div>
        <div class="box8"><asp:Button ID="Button2" runat="server" Height="27px" OnClick="Button2_Click" Text="返回" class="btn2"/></div>
        <div class="box9">
            <img src="picts/sss.jpg" alt="Alternate Text" class="pic"/></div>
        </div>
      </form>
</body>
</html>
