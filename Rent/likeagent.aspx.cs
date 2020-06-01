using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Rent;
public partial class likeagent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = Rent.CommDB.ID;
      
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
        con.Open();

        SqlDataAdapter sda = new SqlDataAdapter("select * " +
            " from agent,likeagent" +
            " where agent.agentID = likeagent.agentID and likeagent.userID = '" + CommDB.ID+"'", con);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        this.GridView1.DataSource = dt;
        this.GridView1.DataKeyNames = new string[] { "agentID" };
        this.GridView1.DataBind();
        con.Close();
       
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow selectrow = GridView1.SelectedRow;
        Rent.CommDB.selected = selectrow.Cells[0].Text;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
        con.Open();
        SqlCommand cmd = new SqlCommand("delete  from likeagent where agentID='" + CommDB.selected+"'", con);
        if (Convert.ToInt32(cmd.ExecuteNonQuery()) > 0)
        {

            Response.Write("<script>alert('取消收藏成功')</script>");
        }
        con.Close();

        SqlConnection con1 = new SqlConnection();
        con1.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
        con1.Open();

        SqlDataAdapter sda = new SqlDataAdapter("select *" +
            " from agent,likeagent" +
            " where agent.agentID = likeagent.agentID and likeagent.userID = '" + CommDB.ID+"'", con1);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        this.GridView1.DataSource = dt;
        this.GridView1.DataKeyNames = new string[] { "agentID" };
        this.GridView1.DataBind();
        con.Close();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("self1.aspx");
    }
}