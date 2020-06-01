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
    public partial class InfoTiShiPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=.;database=Rent;uid=Rent;pwd=Rent;";
            con.Open();
            string sql = "update house set UserID=NULL ,houseState='未出租' where UserID='"+Users.userID+"' and houseID='"+Request.QueryString["UhouseID"].ToString()+"'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("userYiZuHouse.aspx");
        }
    }
}