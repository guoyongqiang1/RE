using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Rent
{
    public partial class headerAndFooter : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Users.userID == "" && Agent.agentTel == "" && Owner.ownerPhone=="" &&  Admin.adminID == "")
            {
                Label2.Text = "登录 / 注册";
                Label3.Visible = false;
                usersXiaLa.Style.Add("display", "none");
                ownerXiaLa.Style.Add("display", "none");
                agentXiaLa.Style.Add("display", "none");
                adminXiaLa.Style.Add("display", "none");
              //  dropdown.Style.Add("display","none");
            }
            else
            {
                Label2.Text = "个人中心";
                if (Users.userID != "" && Agent.agentTel == "" && Owner.ownerPhone == "" && Admin.adminID == "")
                {
                    Label4.Visible = false;
                    addHouse.Style.Add("display", "none");
                    Label3.Text = Users.userID;
                    BeforeLogin.Style.Add("display","none");
                    ownerXiaLa.Style.Add("display", "none");
                    agentXiaLa.Style.Add("display", "none");
                    adminXiaLa.Style.Add("display", "none");
                }
                if (Users.userID == "" && Agent.agentTel != "" && Owner.ownerPhone == "" && Admin.adminID == "")
                {
                    Label4.Visible = false;
                    Label3.Text = Agent.agentTel;
                    addHouse.Style.Add("display", "none");
                    BeforeLogin.Style.Add("display", "none");
                    usersXiaLa.Style.Add("display", "none");
                    ownerXiaLa.Style.Add("display", "none");
                    adminXiaLa.Style.Add("display", "none");
                }
                if (Users.userID == "" && Agent.agentTel == "" && Owner.ownerPhone != "" && Admin.adminID == "")
                {
                    Label4.Text = "我要出租";
                    agent.Style.Add("display", "none");
                    Label3.Text = Owner.ownerPhone;
                    BeforeLogin.Style.Add("display", "none");
                    usersXiaLa.Style.Add("display", "none");
                    adminXiaLa.Style.Add("display", "none");
                    agentXiaLa.Style.Add("display", "none");
                }
                if (Users.userID == "" && Agent.agentTel == "" && Owner.ownerPhone == "" && Admin.adminID != "")
                {
                    Label4.Visible = false;
                    addHouse.Style.Add("display", "none");
                    Label3.Text = Admin.adminID;
                    BeforeLogin.Style.Add("display", "none");
                    usersXiaLa.Style.Add("display", "none");
                    agentXiaLa.Style.Add("display", "none");
                    ownerXiaLa.Style.Add("display", "none");
                }
                Label3.Style.Add("float", "left");
                Label3.Style.Add("padding-top","13px");
            }
        }
    }
}