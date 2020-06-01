<%@ Page Language="C#" MasterPageFile="~/headerAndFooter.Master" AutoEventWireup="true" CodeBehind="经纪人管理.aspx.cs" Inherits="WebApplication1.经纪人管理" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <style>
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
             .table {
                 position:absolute;
                 /*top:30%;*/
                 left:20%;
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
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"   DataKeyNames="houseID" DataSourceID="SqlDataSource1" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AllowPaging="True" PageSize="5" OnRowDataBound="GridView1_RowDataBound" >
                <Columns>
                    <asp:BoundField DataField="houseID" HeaderText="ID" ReadOnly="True" SortExpression="houseID" />
                    <asp:BoundField DataField="houseDistrict" HeaderText="所在区" SortExpression="houseDistrict" />
                    <asp:BoundField DataField="houseStreet" HeaderText="所在街道" SortExpression="houseStreet" />
                    <asp:BoundField DataField="houseAdress" HeaderText="详细地址" SortExpression="houseAdress" />
                    <asp:BoundField DataField="houseType" HeaderText="户型" SortExpression="houseType" />
                    <asp:BoundField DataField="hopePrice" HeaderText="期望租价" SortExpression="hopePrice" />
                    <asp:BoundField DataField="houseArea" HeaderText="面积" SortExpression="houseArea" />
                    <asp:BoundField DataField="ownerID" HeaderText="房东ID" SortExpression="ownerID" />
                    <asp:BoundField DataField="ownerPhone" HeaderText="房东手机号码" SortExpression="ownerPhone" />
                    <asp:BoundField DataField="timeLooking" HeaderText="看房时间" SortExpression="timeLooking" />
                    <asp:BoundField DataField="houseState" HeaderText="房屋状态" ReadOnly="True" SortExpression="houseState" />
                    <asp:CommandField ShowEditButton="True" />
                    <asp:CommandField ShowDeleteButton="True" />
                </Columns>
                 <PagerTemplate>
     
         <asp:Label ID="lblPage" CssClass="PagerFont" runat="server" Text='<%# "第" + (((GridView)Container.NamingContainer).PageIndex + 1)  + "页/共" + (((GridView)Container.NamingContainer).PageCount) + "页" %> '></asp:Label>
         <asp:LinkButton ID="lbnFirst" CssClass="PagerFont" runat="Server" Text="首页"  Enabled='<%# ((GridView)Container.NamingContainer).PageIndex != 0 %>' CommandName="Page" CommandArgument="First" ></asp:LinkButton>
         <asp:LinkButton ID="lbnPrev" CssClass="PagerFont" runat="server" Text="上一页" Enabled='<%# ((GridView)Container.NamingContainer).PageIndex != 0 %>' CommandName="Page" CommandArgument="Prev"  ></asp:LinkButton>
         <asp:LinkButton ID="lbnNext" CssClass="PagerFont" runat="Server" Text="下一页" Enabled='<%# ((GridView)Container.NamingContainer).PageIndex != (((GridView)Container.NamingContainer).PageCount - 1) %>' CommandName="Page" CommandArgument="Next" ></asp:LinkButton>
         <asp:LinkButton ID="lbnLast" CssClass="PagerFont" runat="Server" Text="尾页"   Enabled='<%# ((GridView)Container.NamingContainer).PageIndex != (((GridView)Container.NamingContainer).PageCount - 1) %>' CommandName="Page" CommandArgument="Last" ></asp:LinkButton>
         
     </PagerTemplate>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RentConnectionString3 %>" SelectCommand="SELECT [houseID], [houseDistrict], [houseStreet], [houseAdress], [houseType], [hopePrice], [houseArea], [ownerID], [ownerPhone], [timeLooking], [houseState] FROM [house]"></asp:SqlDataSource>
            </td> 
               </tr> 
            </table>
    </div>

        <div class="panel-footer">这首诗取陶诗的意境</div>
        </div>
</asp:Content>
