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
    public partial class YaoYuYue : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Users.userID == "")
            {
                Response.Redirect("loginUser.aspx");
            }
            else
            {
                if (!IsPostBack)
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "server=.;database=Rent;uid=Rent;pwd=Rent;";
                    con.Open();
                    string sql = "update house set houseState='商议中',UserID='" + Users.userID + "' where houseID='" + House.houseID + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    //  Response.Write("<script>alert(您已经成功预约！！！请与房东或者本房经纪人联系！！！);</script>");
                    Response.Redirect("houseInfo.aspx");
                }
            }
        }
    }
}