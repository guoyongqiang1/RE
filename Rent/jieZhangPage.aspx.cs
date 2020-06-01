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
    public partial class jieZhangPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=.;database=Rent;uid=Rent;pwd=Rent;";
            con.Open();
            string sql = "update house set houseState='已出租' where UserID='"+Users.userID+"' and houseID='"+Request.QueryString["JhouseID"].ToString()+"'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("<script>alert('您已支付成功！！！祝您居住愉快！！！');</script>");
            Response.Redirect("userDaiJieZhangHouse.aspx");
        }
    }
}