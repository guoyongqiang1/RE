<%@ Page Language="C#" MasterPageFile="~/headerAndFooter.Master" AutoEventWireup="true" CodeBehind="房东info2.0.aspx.cs" Inherits="WebApplication1.房东info2__0" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style >
      .panel {
                margin-bottom: 20px;
                background-color: #fff;
                border: 1px solid transparent;
                border-radius: 4px;
                -webkit-box-shadow: 0 1px 1px rgba(0, 0, 0, .05);
                box-shadow: 0 1px 1px rgba(0, 0, 0, .05);
            }
            .panel-body {
                padding: 15px;
            }
            .panel-heading {
                padding: 10px 15px;
                background-color: #f5f5f5;
                border-bottom: 1px solid transparent;
                border-top-left-radius: 3px;
                border-top-right-radius: 3px;
            }
                .panel-heading > .dropdown .dropdown-toggle {
                    color: inherit;
                }
            .panel-title {
                margin-top: 0;
                margin-bottom: 0;
                font-size: 16px;
                color: inherit;
            }
            .panel-title > a {
                    color: inherit;
                }
            .panel-footer {
                padding: 10px 15px;
                background-color: #f5f5f5;
                border-top: 1px solid #ddd;
                border-bottom-right-radius: 3px;
                border-bottom-left-radius: 3px;
                margin-top :200px;
            }
            .auto-style1 {
                width: 876px;
            }
             .table {
                 position:absolute;
                 /*top:30%;*/
                 left:30%;
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
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ownerID" DataSourceID="SqlDataSource1"  OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"  OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDataBound="GridView1_RowDataBound"   >
            <Columns>
                <asp:BoundField DataField="ownerID" HeaderText="ID" ReadOnly="True" SortExpression="ownerID"  ItemStyle-Width="40px" ItemStyle-Height="30px"  />
                <asp:BoundField DataField="ownerName" HeaderText="姓名" SortExpression="ownerName" ItemStyle-Width="70px" ItemStyle-Height="30px"  />
                <asp:BoundField DataField="ownerPhone" HeaderText="联系电话" SortExpression="ownerPhone"  ItemStyle-Width="100px" ItemStyle-Height="30px" />
                <asp:BoundField DataField="ownerPwd" HeaderText="密码" SortExpression="ownerPwd"  ItemStyle-Width="70px" ItemStyle-Height="30px" />
                <asp:CommandField ShowEditButton="True" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RentConnectionString2 %>" DeleteCommand="DELETE FROM [owner] WHERE [ownerID] = @ownerID" InsertCommand="INSERT INTO [owner] ([ownerID], [ownerName], [ownerPhone], [ownerPwd]) VALUES (@ownerID, @ownerName, @ownerPhone, @ownerPwd)" SelectCommand="SELECT [ownerID], [ownerName], [ownerPhone], [ownerPwd] FROM [owner]" UpdateCommand="UPDATE [owner] SET [ownerName] = @ownerName, [ownerPhone] = @ownerPhone, [ownerPwd] = @ownerPwd WHERE [ownerID] = @ownerID">
          <DeleteParameters>
                <asp:Parameter Name="ownerID" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="ownerID" Type="String" />
                <asp:Parameter Name="ownerName" Type="String" />
                <asp:Parameter Name="ownerPhone" Type="String" />
                <asp:Parameter Name="ownerPwd" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="ownerName" Type="String" />
                <asp:Parameter Name="ownerPhone" Type="String" />
                <asp:Parameter Name="ownerPwd" Type="String" />
                <asp:Parameter Name="ownerID" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
     </td> 
               </tr> 
            </table>
    </div>

        <div class="panel-footer">这首诗取陶诗的意境</div>
    </div>
</asp:Content>
