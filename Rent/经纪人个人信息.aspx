<%@ Page Language="C#" MasterPageFile="~/headerAndFooter.Master" AutoEventWireup="true" CodeBehind="经纪人个人信息.aspx.cs" Inherits="WebApplication1.经纪人个人信息" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style type="text/css">

      .panel {
                margin-bottom: 20px;
                background-color: #fff;
                border: 1px solid transparent;
                border-radius: 4px;
                -webkit-box-shadow: 0 1px 1px rgba(0, 0, 0, .05);
                box-shadow: 0 1px 1px rgba(0, 0, 0, .05);
            }
            .panel-heading {
                padding: 10px 15px;
                background-color: #f5f5f5;
                border-bottom: 1px solid transparent;
                border-top-left-radius: 3px;
                border-top-right-radius: 3px;
            }
                .panel-body {
                padding: 15px;
            }
             .table {
                 position:absolute;
                 /*top:30%;*/
                 left:20%;
                 }

            .panel-footer {
                padding: 10px 15px;
                background-color: #f5f5f5;
                border-top: 1px solid #ddd;
                border-bottom-right-radius: 3px;
                border-bottom-left-radius: 3px;
                margin-top :200px;
            }
            </style>
        
        <h1>带有头和尾的面板</h1>


        <div class="panel panel-default">
        <div class="panel-heading">描写花的诗句</div>
        <div class="panel-body">
            <p>诗人对菊花由衷喜爱：开得正旺的菊花一簇簇、一丛丛，遍布屋舍四周，他沿着竹篱，忘情地欣赏这些亲手栽种的秋菊，不觉日已西斜。</p>
            
       <table class="table">
           <tr>
               <td>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource3"  OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"  OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDataBound="GridView1_RowDataBound"   >
            <Columns>
                <asp:BoundField DataField="agentID" HeaderText="ID"  ReadOnly ="true"  SortExpression="agentID"  />
                <asp:BoundField DataField="agentPwd" HeaderText="密码" SortExpression="agentPwd" />
                <asp:BoundField DataField="agentName" HeaderText="姓名" SortExpression="agentName"/>
                <asp:BoundField DataField="agentTel" HeaderText="电话" SortExpression="agentTel"   />
                <asp:BoundField DataField="agentAge" HeaderText="年龄" SortExpression="agentAge" />
                <asp:BoundField DataField="agentArea" HeaderText="主负责区" SortExpression="agentArea" />
                <asp:BoundField DataField="agentDistrict" HeaderText="主负责街道" SortExpression="agentDistrict"  ItemStyle-Width="40px" ItemStyle-Height="30px"  >
<ItemStyle Height="30px" Width="40px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="agentTimes" HeaderText="租赁成交套数" SortExpression="agentTimes" />
                <asp:BoundField DataField="agentTrantimes" HeaderText="近30天租赁带看次数" SortExpression="agentTrantimes" />
                <asp:BoundField DataField="agentImage" HeaderText="头像" SortExpression="agentImage" />
                <asp:CommandField ShowEditButton="True" />
            </Columns>
        </asp:GridView>
                   <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:RentConnectionString7 %>" SelectCommand="SELECT [agentDistrict], [agentName], [agentID], [agentTel], [agentAge], [agentArea], [agentTimes], [agentTrantimes], [agentPwd], [agentImage] FROM [agent]"></asp:SqlDataSource>
     </td> 
               </tr> 
            </table>
    </div>

        <div class="panel-footer">这首诗取陶诗的意境</div>
    </div>
</asp:Content>
