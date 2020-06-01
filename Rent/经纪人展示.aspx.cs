using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data .SqlClient;
using Rent;

namespace WebApplication1
{
    public partial class 经纪人展示 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Users.userID == "" && Owner.ownerID == "")
                {
                    Response.Redirect("Login-ap.aspx");
                }
                else
                {
                    //需要身份选择，以下为用户功能
                    if (Users.userID != "" && Agent.agentID == "" && Owner.ownerID == "" && Admin.adminID == "")
                    {
                        this.Button2.Visible = true;
                        this.yao();
                        string sid = Request.QueryString["id"].ToString();
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = "server=.;database=Rent;uid=Rent;pwd=Rent";

                        SqlDataAdapter sda = new SqlDataAdapter("select * from likeagent where  agentID='" + sid + "' and userID='" + Users.userID + "'", con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        int i = dt.Rows.Count;
                        if (i >= 1)
                        {
                            this.Button2.Text = "取消收藏";
                        }
                        else
                            this.Button2.Text = "收藏";
                        con.Close();
                    }

                    //以下，如果身份为房东
                    if (Users.userID == "" && Agent.agentID == "" && Owner.ownerID != "" && Admin.adminID == "")
                    {
                        this.Button3.Visible = true; this.yao();
                        string sid = Request.QueryString["id"].ToString();
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = "server=.;database=Rent;uid=Rent;pwd=Rent";
                        string sql = "select * from house where  agentID='" + sid + "' and ownerID='" + Owner.ownerID + "' and houseID='" + Rent.House.houseID + "'";
                        SqlDataAdapter sda = new SqlDataAdapter(sql, con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        int i = dt.Rows.Count;
                        if (i >= 1)
                        {
                            this.Button3.Text = "取消选择";
                        }
                        else
                            this.Button3.Text = "选择";
                        con.Close();
                    }
                }
            }
        }
        private void yao()
        {
            string sid= Request.QueryString["id"].ToString();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=.;database=Rent;uid=Rent;pwd=Rent";
            con.Open();
            string sql1=string.Format("select * from agent where agentID='{0}'",sid);
            SqlDataAdapter sda = new SqlDataAdapter(sql1, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            this.GridView1.DataSource = dt;
            GridView1.DataSourceID = null;
            this.GridView1.DataKeyNames = new string[] { "agentID" };
            this.GridView1.DataBind();
            con.Close();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            yao();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("经纪人.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Button2.Text == "收藏")
            {

                string aid = Request.QueryString["id"].ToString();
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "server=.;database=Rent;uid=Rent;pwd=Rent";
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into likeagent (userID,agentID) values ('" + Users.userID + "','" + aid + "')";
                int i = Convert.ToInt32(cmd.ExecuteNonQuery());
                if (i >= 1)
                {
                    Response.Write("<script language=javascript >alert('收藏成功！');window.navigate('../index.asp');<");
                    Response.Write("/Script>");
                    this.Button2.Text = "取消收藏";
                }
                else
                    Response.Write("<script language=javascript >alert('收藏失败！');window.navigate('../index.asp');<");
                Response.Write("/Script>");
                con.Close();
            }
            else if (Button2.Text == "取消收藏")
            {
                
                string aid = Request.QueryString["id"].ToString();
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "server=.;database=Rent;uid=Rent;pwd=Rent";
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from likeagent where  userID='"+Users.userID +"' AND agentID ='"+aid+"'";
                int i = Convert.ToInt32(cmd.ExecuteNonQuery());
                if (i >=1)
                {
                    Response.Write("<script language=javascript >alert('取消收藏！');window.navigate('../index.asp');<");
                    Response.Write("/Script>");
                    this.Button2.Text = "收藏";
                }
                else
                {
                    Response.Write("<script language=javascript >alert('取消收藏失败！');window.navigate('../index.asp');<");
                    Response.Write("/Script>");
                }
                con.Close();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (Button3.Text == "选择")
            {
                try
                {
                    string aid = Request.QueryString["id"].ToString();
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "server=.;database=Rent;uid=Rent;pwd=Rent";
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "insert into house (houseID,agentID,ownerID) values ('" + House.houseID + "','" + aid + "','" + Owner.ownerID + "')";
                    int i = Convert.ToInt32(cmd.ExecuteNonQuery());
                    if (i >= 1)
                    {
                        Response.Write("<script language=javascript >alert('选择成功！');window.navigate('../index.asp');<");
                        Response.Write("/Script>");
                        this.Button3.Text = "取消选择";
                    }
                    else
                    {
                        Response.Write("<script language=javascript >alert('选择失败！');window.navigate('../index.asp');<");
                        Response.Write("/Script>");
                    }
                    con.Close();
                }
                catch {
                    Response.Write("<script language=javascript >alert('您已经选过经纪人了！');window.navigate('../index.asp');<");
                    Response.Write("/Script>");
                }
            }
            else if (Button3.Text == "取消选择")
            {

                string aid = Request.QueryString["id"].ToString();
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "server=.;database=Rent;uid=Rent;pwd=Rent";
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete  house where agentID='"+aid+"' and houseID='" + Rent.House.houseID+ "' and ownerID='" + Owner.ownerID + "'";
                int i = Convert.ToInt32(cmd.ExecuteNonQuery());
                if (i >= 1)
                {
                    this.Button3.Text = "选择";
                }
                else
                    Response.Write("<script language=javascript >alert('取消收藏失败！');window.navigate('../index.asp');<");
                Response.Write("/Script>");
                con.Close();
            }
        }
    }
}