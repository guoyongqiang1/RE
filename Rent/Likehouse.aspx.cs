using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Rent;
public partial class Likehouse : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = Rent.CommDB.ID;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
        con.Open();
        string sql = "select house.houseID, house.houseAdress,house.houseType,house.hopePrice, house.houseArea, " +
            "house.ownerPhone, house.timeLooking, " +
            "house.agentID, house.houseState from house , likehouse" +
            " where likehouse.houseID = house.houseID and likehouse.userID = '" + Rent.CommDB.ID+ "'";
        SqlDataAdapter sda = new SqlDataAdapter(sql, con);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        this.GridView1.DataSource = dt; 
        //this.GridView1.DataKeyNames = new string[] { " houseID" };
        this.GridView1.DataBind();
        con.Close();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
        con.Open();
        SqlCommand cmd = new SqlCommand("delete  from likehouse where houseID='"+CommDB.selected+"'", con);
      
        if (Convert.ToInt32( cmd.ExecuteNonQuery())>0)
        { 

        Response.Write("<script>alert('取消收藏成功')</script>");
        }
        con.Close();

        SqlConnection con1 = new SqlConnection();
        con1.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
        con1.Open();
        string sql = "select house.houseID, house.houseAdress,house.houseType,house.hopePrice, house.houseArea, " +
            "house.ownerPhone, house.timeLooking, " +
            "house.agentID, house.houseState from house , likehouse" +
            " where likehouse.houseID = house.houseID and likehouse.userID = '" + CommDB.ID + "'";
        SqlDataAdapter sda = new SqlDataAdapter(sql, con1);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        this.GridView1.DataSource = dt;
        //this.GridView1.DataKeyNames = new string[] { " houseID" };
        this.GridView1.DataBind();
        con.Close();
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow selectrow = GridView1.SelectedRow;
        CommDB.selected = selectrow.Cells[0].Text;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("self1.aspx");
    }
}