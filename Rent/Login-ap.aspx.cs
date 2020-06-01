using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Rent;                      
using BLL;
using Model;

public partial class Login_ap : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "")
        {
            Response.Write("<script>alert('账号不能为空')</script>");
        }
        else
        {
            if (TextBox2.Text == "")
            {
                Response.Write("<script>alert('密码不能为空')</script>");
            }
        }

        //string role = this.DropDownList1.SelectedValue;
        try
        {
            
       
            if (this.DropDownList1.SelectedValue == "用户")
            {
                UsersModel model = new UsersModel();
                model.userID = TextBox1.Text;

                UsersBLL bll = new UsersBLL();
                DataTable dt = bll.GetUsersInfoById(model);

              
                //SqlDataReader sda = cmd.ExecuteReader();
                if (dt.Columns["usersPwd"].ToString() == TextBox2.Text)
                {
                    Rent.CommDB.ID = TextBox1.Text;
                    Rent.Users.userID = Rent.CommDB.ID;
                    Response.Write("<script>alert('成功登录')</script>");
                    
                    Response.Redirect("houseInfo.aspx");//跳转到主页面
                }
                else {
                    Response.Write("<script>alert('账号,密码输入错误或请先注册新用户！！！')</script>");
                }            
            }

            if (this.DropDownList1.SelectedValue == "房东")
            {
                OwnersModel model = new OwnersModel();
                model.ownerID = TextBox1.Text;

                OwnersBLL bll = new OwnersBLL();
                DataTable dt = bll.GetUsersInfoById(model);
                                                                  
                if (dt.Columns["ownerPwd"].ToString() == TextBox2.Text)
                {
                    Response.Write("<script>alert('成功登录')</script>");
                    Owner.ownerID = TextBox1.Text;
                    //获取ownerPhone的值
                    Owner.ownerPhone = dt.Columns["ownerPhone"].ToString();
                    Response.Redirect("houseInfo.aspx");//跳转到房东信息页面

                }
                else
                {
                    Response.Write("<script>alert('账号,密码输入错误或请先注册新用户！！！')</script>");
                }              
            }


            if (this.DropDownList1.SelectedValue == "经纪人")
            {
                AgentsModel model = new AgentsModel();
                model.agentID = TextBox1.Text;

                AgentsBLL bll = new AgentsBLL();
                DataTable dt = bll.GetAgentsInfoById(model);

                
                if (dt.Columns["agentPwd"].ToString() == TextBox2.Text)
                {
                    Agent.agentID = TextBox1.Text;
                    //获取agentTel的值
                                          
                    Agent.agentTel = dt.Columns["agentTel"].ToString();
                    Response.Write("<script>alert('成功登录')</script>");
                    Response.Redirect("houseInfo.aspx");//跳转到经纪人信息页面

                }
                else
                {
                    Response.Write("<script>alert('账号,密码输入错误或请先注册新用户！！！')</script>");
                }               
            }


            if (this.DropDownList1.SelectedValue == "管理员")
            {
                AdminsModel model = new AdminsModel();
                model.adminID = TextBox1.Text;

                AdminsBLL bll = new AdminsBLL();
                DataTable dt = bll.GetAdminsInfoById(model);

                                        
                if (dt.Columns["adminPwd"].ToString() == TextBox2.Text)
                {
                    Admin.adminID = TextBox1.Text;
                    Response.Write("<script>alert('成功登录')</script>");
                    Response.Redirect("adminEditInfo.aspx");//跳转到管理员信息页面

                }
                else
                {
                    Response.Write("<script>alert('账号,密码输入错误或请先注册新用户！！！')</script>");
                }             
            }
        }
        catch
        { 
          Response.Write("<script>alert('账号,密码输入错误或身份选择错误')</script>");
      
        }
    }
}
   

   