<%@ Page Title="" Language="C#" MasterPageFile="~/headerAndFooter.Master" AutoEventWireup="true" CodeBehind="adminKnow.aspx.cs" Inherits="Rent.adminKnow" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script  type="text/javascript">
        function CheckPwd(source, arguments) {
            if (arguments.Value.Length = 4) {
                arguments.IsValid = true;
            }
            else {
                arguments.IsValid = false;
            }
        }
</script>

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" EnableModelValidation="True" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
            <Columns>
                <asp:BoundField DataField="title" HeaderText="题目" />
                <asp:BoundField DataField="type" HeaderText="类型" />
                <asp:BoundField DataField="p" HeaderText="提示" />
                <asp:BoundField DataField="url" HeaderText="链接" />
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
        </asp:GridView>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="添加文章" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="返回" />
        <asp:Panel ID="Panel1" runat="server">
            <asp:Label ID="Label1" runat="server" Text="题目"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="题目不能为空"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="类型"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"  onkeyup="value=value.replace(/[ -~]/g,'')" onkeydown="if(event.keyCode==13)event.keyCode=9"></asp:TextBox>
            <asp:CustomValidator ID="CustomValidator1" runat="server" ClientValidationFunction="CheckPwd"
   ControlToValidate="TextBox2" ErrorMessage="请输入正确的文章类型" ></asp:CustomValidator>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="提示"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox3" ErrorMessage="提示不能为空"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="链接"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox4" ErrorMessage="链接不能为空"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="添加" />
        </asp:Panel>
</asp:Content>
