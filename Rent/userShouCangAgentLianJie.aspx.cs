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
    public partial class userShouCangAgentLianJie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            string sql = "delete likeagent where UserID='" + Users.userID + "' and agentID='" + Request.QueryString["likeAgentID"].ToString() + "'";
            SqlCommand cmd = new SqlCommand(sql, con1);
            cmd.ExecuteNonQuery();
            Response.Redirect("userShouCangAgent.aspx");
        }
    }
}