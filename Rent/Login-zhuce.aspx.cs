using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Model;
using BLL;

public partial class Login : System.Web.UI.Page
{
    
   
    protected void Page_Load(object sender, EventArgs e)
    {
        Random rad = new Random();
        string n = rad.Next(1000, 9999).ToString();
        if (!Page.IsPostBack)
        {
            Label1.Text =n;
        }                   
        
    }

   

    protected void Button1_Click1(object sender, EventArgs e)
    {
        if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "")
        {
            Response.Write("<script>alert('请先填写账号密码及验证码')</script>");
        }
        else
        {
            //判断验证码是否正确
            if (TextBox2.Text == Label1.Text)
            {
                /*租户*/
                if (this.DropDownList1.SelectedValue == "user")
                {
                    UsersModel model = new UsersModel();
                    model.userID = TextBox1.Text;
                    //先判断ID号是否存在
                    UsersBLL bll = new UsersBLL();
                    DataTable dt = bll.GetUsersInfoById(model);
                    
                    if (dt.Rows.Count!=0)
                    {
                        Response.Write("<script>alert('账号已存在')</script>");
                    }

                    else
                    {                  
                        //再ID号不重复的情况下 对姓名和电话号码进行判断
                         
                        if (TextBox4.Text==model.userName && TextBox5.Text==model.userPhone)
                        {
                            Response.Write("<script>alert('所填姓名与电话已存在，请重新填写')</script>");
                        }
                        else
                        {
                            UsersModel mode1 = new UsersModel();
                            model.userID = TextBox1.Text;
                            model.userPwd = TextBox3.Text;
                            model.userName = TextBox4.Text;
                            model.userPhone = TextBox5.Text;
                            model.UserAge = int.Parse(TextBox6.Text);
                            UsersBLL bll1 = new UsersBLL();
                            int affectRows = bll1.InsertUsersInfo(mode1);
                            
                            Response.Write("<script>alert('手机号已自动注册，请登录')</script>");
                            Response.Redirect("Login-ap.aspx");
                           
                        }
                    }
                }

                /*房东*/
                if (this.DropDownList1.SelectedValue == "owner")
                {
                    OwnersModel model = new OwnersModel();
                    model.ownerID = TextBox1.Text;
                    //先判断ID号是否存在
                    OwnersBLL bll = new OwnersBLL();
                    DataTable dt = bll.GetUsersInfoById(model);


                   if (dt.Rows.Count!=0)
                    {
                        Response.Write("<script>alert('账号已存在')</script>");
                    }
                    else
                    {                 

                         if (TextBox4.Text == model.ownerName && TextBox5.Text == model.ownerPhone)
                        {
                            Response.Write("<script>alert('所填姓名与电话已存在，请重新填写')</script>");
                        }
                        else
                        {
                            OwnersModel mode1 = new OwnersModel();
                            model.ownerID = TextBox1.Text;
                            model.ownerPwd = TextBox3.Text;
                            model.ownerName = TextBox4.Text;
                            model.ownerImage = "https://image.5i5j.com/picture/8108815.jpg";
                            model.ownerAge = int.Parse(TextBox6.Text);
                            OwnersBLL bll1 = new OwnersBLL();
                            int affectRows = bll1.InsertOwnersInfo(mode1);

                             
                            Response.Write("<script>alert('手机号已自动注册，请登录')</script>");
                            Response.Redirect("Login-ap.aspx");
                           
                        }
                    }             
                }

                /*经济人*/
                if (this.DropDownList1.SelectedValue == "agent")
                {

                    AgentsModel model = new AgentsModel();
                    model.agentID = TextBox1.Text;
                    //先判断ID号是否存在
                    AgentsBLL bll = new AgentsBLL();
                    DataTable dt = bll.GetAgentsInfoById(model);


                    if (dt.Rows.Count != 0)
                    {
                        Response.Write("<script>alert('账号已存在')</script>");
                    }
                    else
                    {            
                       
                        if (TextBox4.Text == model.agentName && TextBox5.Text ==model.agentTel)
                        {
                            Response.Write("<script>alert('所填姓名与电话已存在，请重新填写')</script>");
                        }
                        else
                        {
                            AgentsModel mode1 = new AgentsModel();
                            model.agentID = TextBox1.Text;
                            model.agentPwd = TextBox3.Text;
                            model.agentTel = TextBox5.Text;
                            model.agentName = TextBox4.Text;
                            model.agentAge = int.Parse(TextBox6.Text);
                            AgentsBLL bll1 = new AgentsBLL();
                            int affectRows = bll1.InsertAentsInfo(mode1);
                                                     
                            Response.Write("<script>alert('手机号已自动注册，请登录')</script>");
                            Response.Redirect("Login-ap.aspx");
                           
                        }
                    }             
                }


                /*管理人*/
                if (this.DropDownList1.SelectedValue == "admin")
                {


                    AdminsModel model = new AdminsModel();
                    model.adminID = TextBox1.Text;
                    //先判断ID号是否存在
                    AdminsBLL bll = new AdminsBLL();
                    DataTable dt = bll.GetAdminsInfoById(model);


                    if (dt.Rows.Count != 0)
                    {
                        Response.Write("<script>alert('账号已存在')</script>");
                    }
                    else
                    {                 
                        
                       if (TextBox4.Text == model.adminName && TextBox5.Text == model.adminTel)
                        {
                            Response.Write("<script>alert('所填姓名与电话已存在，请重新填写')</script>");
                        }
                        else
                        {
                            AdminsModel mode1 = new AdminsModel();
                            model.adminID = TextBox1.Text;
                            model.adminPwd = TextBox3.Text;
                            model.adminName = TextBox4.Text;
                            model.adminTel = TextBox5.Text;
                            model.adminAge = int.Parse(TextBox6.Text);
                            AdminsBLL bll1 = new AdminsBLL();
                            int affectRows = bll1.InsertAdminsInfo(mode1);

                          
                            Response.Write("<script>alert('手机号已自动注册，请登录')</script>");
                            Response.Redirect("Login-ap.aspx");
                           
                        }
                    }            
                }
            }
            else
            {
                Response.Write("<script>alert('验证码错误')</script>");
            }
        }

    }
}