using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Rent
{
    public partial class ZhuXiao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Users.userID == "" && Agent.agentTel == "" && Owner.ownerPhone == "" && Admin.adminID == "")
            {
                Response.Redirect("Login-ap.aspx");
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
                con.Open();
                if (Users.userID != "" && Agent.agentTel == "" && Owner.ownerPhone == "" && Admin.adminID == "")
                {
                    string sql1 = "delete users where userID='" + Users.userID + "'";
                    SqlCommand cmd = new SqlCommand(sql1, con);
                    cmd.ExecuteNonQuery();
                    Users.userID ="";
                }
                if (Users.userID == "" && Agent.agentTel != "" && Owner.ownerPhone == "" && Admin.adminID == "")
                {
                    string sql1 = "delete agent where agentTel='" + Agent.agentTel + "'";
                    SqlCommand cmd = new SqlCommand(sql1, con);
                    cmd.ExecuteNonQuery();
                    Agent.agentTel = "";
                }
                if (Users.userID == "" && Agent.agentTel == "" && Owner.ownerPhone != "" && Admin.adminID == "")
                {
                    string sql1 = "delete owner where ownerPhone='" + Owner.ownerPhone + "'";
                    SqlCommand cmd = new SqlCommand(sql1, con);
                    cmd.ExecuteNonQuery();
                    Owner.ownerPhone = "";
                }
                if (Users.userID == "" && Agent.agentTel == "" && Owner.ownerPhone == "" && Admin.adminID != "")
                {
                    string sql1 = "delete admin where adminID='" + Admin.adminID + "'";
                    SqlCommand cmd = new SqlCommand(sql1, con);
                    cmd.ExecuteNonQuery();
                    Admin.adminID = "";
                }
                Response.Write("<script>alert('您已经成功注销');</script>");
                con.Close();

                Response.Redirect("houseInfo.aspx");
            }
        }
    }
}