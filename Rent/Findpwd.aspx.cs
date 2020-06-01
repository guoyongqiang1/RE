using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Findpwd : System.Web.UI.Page
{
    public void update()
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
        con.Open();
        SqlCommand cmd2 = new SqlCommand("update " + this.DropDownList1.SelectedValue + " set "+ this.DropDownList1.SelectedValue+"Pwd='" + TextBox3.Text + "'  where " + this.DropDownList1.SelectedValue + "ID='" + TextBox1.Text + "'", con);
        cmd2.ExecuteNonQuery();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Random rad = new Random();
        string n = rad.Next(1000, 9999).ToString();
        if (!Page.IsPostBack)
        {
            TextBox5.Text = n;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            if (TextBox1.Text == "" || TextBox3.Text == "")
            {
                Response.Write("<script>alert('账号密码不能为空')</script>");
            }
            else
            {
                if (TextBox3.Text == TextBox4.Text)
                {
                    if (this.DropDownList1.SelectedValue == "users")
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
                        con.Open();


                        SqlCommand cmd = new SqlCommand("select * from users where userID='" + TextBox1.Text + "'", con);

                        cmd.ExecuteNonQuery();
                        SqlDataReader sda = cmd.ExecuteReader();
                        // sda.Close();
                        if (sda.Read())
                        {

                            SqlConnection con1 = new SqlConnection();
                            con1.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
                            con1.Open();
                            SqlCommand cmd2 = new SqlCommand("update users set userPwd='" + TextBox3.Text + "' where userID='" + TextBox1.Text + "'", con1);
                            cmd2.ExecuteNonQuery();
                            //update();
                            Response.Write("<script>alert('密码修改成功！！！')</script>");
                        }
                        else
                        {
                            Response.Write("<script>alert('请先注册用户！！！')</script>");
                        }
                        con.Close();

                    }

                    if (this.DropDownList1.SelectedValue == "owner")
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
                        con.Open();
                        SqlCommand cmd2 = new SqlCommand("select * from owner where ownerID='" + TextBox1.Text + "'", con);
                        cmd2.ExecuteNonQuery();
                        SqlDataReader sda1 = cmd2.ExecuteReader();
                        if (sda1.Read())
                        {
                            update();
                            Response.Write("<script>alert('密码修改成功')</script>");
                        }
                        else
                        {
                            Response.Write("<script>alert('请先注册用户！！！')</script>");
                        }
                        con.Close();
                    }

                    if (this.DropDownList1.SelectedValue == "agent")
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
                        con.Open();
                        SqlCommand cmd4 = new SqlCommand("select * from agent where agentID='" + TextBox1.Text + "'", con);
                        cmd4.ExecuteNonQuery();
                        SqlDataReader sda2 = cmd4.ExecuteReader();
                        if (sda2.Read())
                        {
                            update();
                            Response.Write("<script>alert('密码修改成功')</script>");
                        }
                        else
                        {
                            Response.Write("<script>alert('请先注册用户！！！')</script>");
                        }
                        con.Close();
                    }

                    if (this.DropDownList1.SelectedValue == "admin")
                    {
                        SqlConnection con1 = new SqlConnection();
                        con1.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
                        con1.Open();
                        SqlCommand cmd4 = new SqlCommand("select * from admin where adminID='" + TextBox1.Text + "'", con1);
                        cmd4.ExecuteNonQuery();
                        SqlDataReader sda2 = cmd4.ExecuteReader();
                        if (sda2.Read())
                        {
                            update();
                            Response.Write("<script>alert('密码修改成功')</script>");
                        }
                        else
                        {
                            Response.Write("<script>alert('请先注册用户！！！')</script>");
                        }
                        con1.Close();
                    }

                }
                else
                {
                    Response.Write("<script>alert('两次密码输入不同')</script>");
                }
            }
        }
        //catch {
        //    Response.Write("<script>alert('请检查输入的信息是否有误')</script>");
        //}
        catch {
            Response.Write("<script>alert('请检查输入的信息是否有误')</script>");
        }
    }
}
      