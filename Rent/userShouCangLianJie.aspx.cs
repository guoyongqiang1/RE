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
    public partial class userShouCangLianJie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "server=.;database=Rent;uid=Rent;pwd=Rent;";
            con1.Open();
            string sql = "delete likehouse where UserID='" + Users.userID + "' and HouseID='" + Request.QueryString["likeHouseID"].ToString() + "'";
            SqlCommand cmd = new SqlCommand(sql, con1);
            cmd.ExecuteNonQuery();
            Response.Redirect("userShouCang.aspx");
        }
    }
}