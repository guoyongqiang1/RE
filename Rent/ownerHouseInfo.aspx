<%@ Page Language="C#" MasterPageFile="~/headerAndFooter.Master" AutoEventWireup="true" CodeBehind="ownerHouseInfo.aspx.cs" Inherits="Rent.ownerHouseInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="Label4" runat="server" Font-Size="XX-Large" Text="房东信息"></asp:Label>
        <br />
        <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" HorizontalAlign="Center">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
                <asp:BoundField DataField="ownerName" HeaderText="房东姓名" ReadOnly="True" />
                <asp:BoundField DataField="ownerPhone" HeaderText="房东电话" ReadOnly="True" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
    
        <br />
        <asp:Button ID="Button1" runat="server" Text="修改房屋信息" OnClick="Button1_Click" />
    
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="隐藏" />
    
        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="158px" Width="903px" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Visible="False" HorizontalAlign="Center">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
                <asp:BoundField DataField="houseID" HeaderText="编号" ReadOnly="True" />
                <asp:BoundField DataField="houseCountry" HeaderText="国家" />
                <asp:BoundField DataField="houseCity" HeaderText="城市" />
                <asp:BoundField DataField="houseProvince" HeaderText="省" />
                <asp:BoundField DataField="houseDistrict" HeaderText="区/县" />
                <asp:BoundField DataField="houseStreet" HeaderText="街道" />
                <asp:BoundField DataField="housePlot" HeaderText="小区" />
                <asp:BoundField DataField="houseAdress" HeaderText="详细住址" />
                <asp:BoundField DataField="houseType" HeaderText="房屋类型" />
                <asp:BoundField DataField="hopePrice" HeaderText="月租" />
                <asp:BoundField DataField="houseArea" HeaderText="面积" />
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowSelectButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
        <br/><br/><br/><br/>
        <asp:Button ID="Button2" runat="server" Text="查看正在商议中的房源信息" OnClick="Button2_Click" />
    
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="隐藏" />
    
        <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
    
        <br/>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" Height="143px" Width="903px" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Visible="False" HorizontalAlign="Center">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
                <asp:BoundField DataField="houseID" HeaderText="编号" ReadOnly="True" />
                <asp:BoundField DataField="houseCountry" HeaderText="国家" />
                <asp:BoundField DataField="houseCity" HeaderText="城市" />
                <asp:BoundField DataField="houseProvince" HeaderText="省" />
                <asp:BoundField DataField="houseDistrict" HeaderText="区/县" />
                <asp:BoundField DataField="houseStreet" HeaderText="街道" />
                <asp:BoundField DataField="housePlot" HeaderText="小区" />
                <asp:BoundField DataField="houseAdress" HeaderText="详细住址" />
                <asp:BoundField DataField="hopePrice" HeaderText="月租" />
                <asp:BoundField DataField="houseArea" HeaderText="面积" />
                <asp:BoundField DataField="agentName" HeaderText="经纪人姓名" ReadOnly="True" />
                <asp:BoundField DataField="agentTel" HeaderText="经纪人电话" ReadOnly="True" />
                <asp:BoundField DataField="timeLooking" HeaderText="看房时间" DataFormatString="{0:d}" ReadOnly="True" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
        <br/><br/>
        <asp:Button ID="Button3" runat="server" Text="查看已出租的房源信息" OnClick="Button3_Click" />
    
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="隐藏" />
    
        <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
    
        <br/>
        <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" Height="143px" Width="903px" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Visible="False" HorizontalAlign="Center">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
                <asp:BoundField DataField="houseID" HeaderText="编号" ReadOnly="True" />
                <asp:BoundField DataField="houseCountry" HeaderText="国家" ReadOnly="True" />
                <asp:BoundField DataField="houseCity" HeaderText="城市" ReadOnly="True" />
                <asp:BoundField DataField="houseProvince" HeaderText="省" ReadOnly="True" />
                <asp:BoundField DataField="houseDistrict" HeaderText="区/县" ReadOnly="True" />
                <asp:BoundField DataField="houseStreet" HeaderText="街道" ReadOnly="True" />
                <asp:BoundField DataField="housePlot" HeaderText="小区" ReadOnly="True" />
                <asp:BoundField DataField="houseAdress" HeaderText="详细住址" ReadOnly="True" />
                <asp:BoundField DataField="hopePrice" HeaderText="月租" ReadOnly="True" />
                <asp:BoundField DataField="houseArea" HeaderText="面积" ReadOnly="True" />
                <asp:BoundField DataField="agentName" HeaderText="经纪人姓名" ReadOnly="True" />
                <asp:BoundField DataField="agentTel" HeaderText="经纪人电话" ReadOnly="True" />
                <asp:BoundField DataField="timeLooking" HeaderText="看房时间" DataFormatString="{0:d}" ReadOnly="True" />
                <asp:BoundField DataField="UserName" HeaderText="租户姓名" ReadOnly="True" />
                <asp:BoundField DataField="UserPhone" HeaderText="租户电话" ReadOnly="True" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
    </asp:Content>