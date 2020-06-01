using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Rent;
public partial class edit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.ReadOnly = false;
        TextBox2.ReadOnly = false;
        TextBox3.ReadOnly = false;
        TextBox4.ReadOnly = false;


       
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            if (Users.userID != "" && Agent.agentTel == "" && Owner.ownerPhone == "" && Admin.adminID == "")
            {
                TextBox1.Text = this.TextBox1.Text;
                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
                con1.Open();
                string sql = "update  users set UserPwd='" + TextBox5.Text + "', UserID='" + TextBox1.Text + "',UserName= '" + TextBox2.Text + "',UserAge='" + TextBox3.Text + "', UserPhone='" + TextBox4.Text + "'where userID='" + Rent.CommDB.ID + "'";
                SqlCommand cmd1 = new SqlCommand(sql, con1);
                int i = Convert.ToInt32(cmd1.ExecuteNonQuery());
                if (i >= 0)
                {
                    Users.userID = TextBox1.Text;
                    Response.Write("<script>alert('修改成功')</script>");
                    Response.Redirect("self1.aspx");
                }
                else
                {
                    Response.Write("<script>alert('请先完善个人信息')</script>");
                }
            }

            if (Users.userID == "" && Agent.agentTel == "" && Owner.ownerPhone == "" && Admin.adminID != "")
            {
                try
                {
                    SqlConnection con1 = new SqlConnection();
                    con1.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
                    con1.Open();
                    string sql = "update admin set adminPwd='" + TextBox5.Text + "', adminID='" + TextBox1.Text + "',adminName= '" + TextBox2.Text + "',adminAge='" + TextBox3.Text + "', adminTel='" + TextBox4.Text + "'where adminID='" + Admin.adminID + "'";
                    SqlCommand cmd1 = new SqlCommand(sql, con1);
                    int i = Convert.ToInt32(cmd1.ExecuteNonQuery());
               
                        if (i >= 0)
                        {
                            Admin.adminID = TextBox1.Text;
                            Response.Write("<script>alert('修改成功')</script>");
                            Response.Redirect("self1.aspx");
                        }
                        else
                        {
                            Response.Write("<script>alert('请先完善个人信息')</script>");
                        }
                }
                catch
                {
                    Response.Write("<script>alert('此用户名已经用过！！！')</script>");
                }
            }
           
        }
    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {
          TextBox2.Text = this.TextBox2.Text;

    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("self1.aspx");
    }
}