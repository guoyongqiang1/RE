<%@ Page Language="C#"  MasterPageFile="~/headerAndFooter.Master" AutoEventWireup="true" CodeBehind="管理员管理.aspx.cs" Inherits="WebApplication1.管理员管理" %>
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
                margin-top :100px;
            }
                        .table {
                            position:absolute;
                            /*top:30%;*/
     }     
            </style>
        <div class="panel panel-default">
        <div class="panel-heading">描写花的诗句</div>
        <div >
            <table class="table" >
           <tr>
               <td >
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"  PageSize ="5" DataSourceID="SqlDataSource2" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowDataBound="GridView1_RowDataBound">
                <Columns>
                    <asp:BoundField DataField="agentID" HeaderText="ID" SortExpression="agentID" ReadOnly ="true"  />
                    <asp:BoundField DataField="agentTel" HeaderText="联系电话" SortExpression="agentTel" />
                    <asp:BoundField DataField="agentName" HeaderText="姓名" SortExpression="agentName" />
                    <asp:BoundField DataField="agentAge" HeaderText="年龄" SortExpression="agentAge" />
                    <asp:BoundField DataField="agentArea" HeaderText="主负责区" SortExpression="agentArea" />
                    <asp:BoundField DataField="agentDistrict" HeaderText="主负责街道" SortExpression="agentDistrict" />
                    <asp:BoundField DataField="agentTimes" HeaderText="租赁成交套数" SortExpression="agentTimes" />
                    <asp:BoundField DataField="agentTrantimes" HeaderText="近30天租赁带看次数"   SortExpression="agentTrantimes" />
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
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RentConnectionString7 %>" SelectCommand="SELECT [agentID], [agentTel], [agentName], [agentAge], [agentArea], [agentDistrict], [agentTimes], [agentTrantimes] FROM [agent]" ProviderName="<%$ ConnectionStrings:RentConnectionString7.ProviderName %>"></asp:SqlDataSource>
        
               </td>
 </tr>
</table>

            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
<table width="800px" height="100px">        
    <tr>
        <td><asp:Label ID="Label5" runat="server" Text="ID：" Visible="False"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Visible="False"></asp:TextBox>
        </td>
        <td><asp:Label ID="Label6" runat="server" Text="联系电话：" Visible="False"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Visible="False"></asp:TextBox>
        </td>
        <td> <asp:Label ID="Label7" runat="server" Text="姓名：" Visible="False"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" Visible="False"></asp:TextBox>
        </td>
        <td> <asp:Label ID="Label10" runat="server" Text="主负责区：" Visible="False"></asp:Label>
            <asp:TextBox ID="TextBox6" runat="server" Visible="False"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td><asp:Label ID="Label8" runat="server" Text="年龄：" Visible="False"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" Visible="False"></asp:TextBox>

        </td>
        <td><asp:Label ID="Label13" runat="server" Text="近30天租赁带看次数：" Visible="False"></asp:Label>
            <asp:TextBox ID="TextBox9" runat="server" Visible="False"></asp:TextBox>

        </td>
        <td><asp:Label ID="Label11" runat="server" Text="主负责街道：" Visible="False"></asp:Label>
            <asp:TextBox ID="TextBox7" runat="server" Visible="False"></asp:TextBox>
        </td>
        <td><asp:Label ID="Label12" runat="server" Text="租赁成交套数：" Visible="False"></asp:Label>
            <asp:TextBox ID="TextBox8" runat="server" Visible="False"></asp:TextBox>
        </td>
    </tr>
</table>  
        </div>
       
        <div class="panel-footer">
            <asp:Button ID="Button2" runat="server" Text="添加" OnClick="Button2_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" Text="确认添加" OnClick="Button3_Click" />
&nbsp;&nbsp;&nbsp; 
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="返回" />
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label14" runat="server" Text=""></asp:Label>
            </div>
    </div>
    </asp:Content>