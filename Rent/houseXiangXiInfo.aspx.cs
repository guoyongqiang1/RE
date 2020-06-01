using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace Rent
{
    public partial class houseXiangXiInfo : System.Web.UI.Page
    {
        public int count = 2;

        protected void getHouse(string sql,string sql1,string sql2)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=.;database=Rent;uid=Rent;pwd=Rent;";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            System.Web.UI.WebControls.Image HouseImage = new System.Web.UI.WebControls.Image();
            HouseImage.ImageUrl = dt.Rows[0].ItemArray[15].ToString();
            HouseImage.Width = 710;
            HouseImage.Height = 445;
            Label ltitle = new Label();
            ltitle.Text=dt.Rows[0].ItemArray[17].ToString();
            Label lprice = new Label();
            lprice.Text = dt.Rows[0].ItemArray[9].ToString() + "元/月";
            Label ltype = new Label();
            ltype.Text = dt.Rows[0].ItemArray[8].ToString();
            Label larea = new Label();
            larea.Text = dt.Rows[0].ItemArray[10].ToString() + "㎡";
            Label laddress = new Label();
            laddress.Text = dt.Rows[0].ItemArray[1].ToString() + " | " + dt.Rows[0].ItemArray[2].ToString() + " | " + dt.Rows[0].ItemArray[3].ToString()
                        + " | " + dt.Rows[0].ItemArray[4].ToString();
            Label laddress1 = new Label();
            laddress1.Text = dt.Rows[0].ItemArray[5].ToString()
                       + " | " + dt.Rows[0].ItemArray[6].ToString()
                       + " | " + dt.Rows[0].ItemArray[7].ToString();

            /*显示经纪人信息*/
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = con;
            SqlDataAdapter da1 = new SqlDataAdapter(sql1, con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);

            HyperLink linkagentName = new HyperLink();
            linkagentName.Text ="经纪人姓名："+ dt1.Rows[0].ItemArray[2].ToString();
            linkagentName.NavigateUrl = "agentMainInfo.aspx?agentID=" + dt1.Rows[0].ItemArray[0].ToString();

            Label lagentTel = new Label();
            lagentTel.Text = dt1.Rows[0].ItemArray[1].ToString();
            System.Web.UI.WebControls.Image AgentImage = new System.Web.UI.WebControls.Image();
            AgentImage.ImageUrl = dt1.Rows[0].ItemArray[8].ToString();
            AgentImage.Width = 80;
            AgentImage.Height = 106;

            HyperLink linkYaoYuYue = new HyperLink();
            linkYaoYuYue.Text = "我要预约";
            linkYaoYuYue.NavigateUrl = "YaoYuYue.aspx";

            /*显示房东信息*/
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con;
            SqlDataAdapter da2 = new SqlDataAdapter(sql2, con);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);

            HyperLink linkownerName = new HyperLink();
            linkownerName.Text ="房东姓名："+ dt2.Rows[0].ItemArray[1].ToString();
            linkownerName.NavigateUrl = "ownerMainInfo.aspx?ownerID=" + dt2.Rows[0].ItemArray[0].ToString();

            Label lownerTel = new Label();
            lownerTel.Text = dt2.Rows[0].ItemArray[2].ToString();
            System.Web.UI.WebControls.Image ownerImage = new System.Web.UI.WebControls.Image();
            ownerImage.ImageUrl = dt2.Rows[0].ItemArray[4].ToString();
            ownerImage.Width = 80;
            ownerImage.Height = 106;

            //
            /* 房源信息 */
            title.Controls.Add(ltitle);
            title.Style.Add("width", "1200px");
            title.Style.Add("margin", "0 auto");
            title.Style.Add("font-size","32px");
            price.Style.Add("color", "#323942");


            down.Style.Add("width", "1200px");
            down.Style.Add("margin", "0 auto");
            down.Style.Add("height", "450px");

            image.Controls.Add(HouseImage);
            image.Style.Add("float", "left");

            info.Style.Add("float", "right");
            info.Style.Add("width", "410px");
            info.Style.Add("height", "445px");

            price.Controls.Add(lprice);
            price.Style.Add("width", "410px");
            price.Style.Add("height", "25px");
            price.Style.Add("margin-bottom", "28px");
            price.Style.Add("text-align", "center");
            price.Style.Add("font-size", "32px");
            price.Style.Add("color", "#FB5033");

            info1.Style.Add("padding", "15px 0px 15px 0px");
            info1.Style.Add("width", "410px");
            info1.Style.Add("height", "56px");
            info1.Style.Add("border-top", "1px solid grey");
            info1.Style.Add("border-bottom", "1px solid grey");
            info1.Style.Add("line-height", "28px");
            info1.Style.Add("font-size", "19px");
            info1.Style.Add("color", "#535D6A");

            Htype.Controls.Add(ltype);
            Htype.Style.Add("width", "204px");
            Htype.Style.Add("height", "100%");
            Htype.Style.Add("float", "left");
            Htype.Style.Add("border-right", "1px solid grey");
            Htype.Style.Add("text-align", "center");

            Harea.Controls.Add(larea);
            Harea.Style.Add("width", "205px");
            Harea.Style.Add("height", "100%");
            Harea.Style.Add("float", "left");
            Harea.Style.Add("text-align", "center");

            info2.Style.Add("width", "410px");
            info2.Style.Add("height", "97px");

            Haddress.Controls.Add(laddress);
            Haddress.Style.Add("font-size", "15px");
            Haddress.Style.Add("padding-bottom", "25px");

            Haddress1.Controls.Add(laddress1);
            Haddress1.Style.Add("font-size", "15px");

            /* 房东信息 */
            owner.Style.Add("width", "410px");
            owner.Style.Add("height", "106px");
            owner.Style.Add("margin-bottom","28px");

            oimage.Controls.Add(ownerImage);
            oimage.Style.Add("width", "80px");
            oimage.Style.Add("height", "106px");
            oimage.Style.Add("float", "left");

            ownerInfo.Style.Add("width", "316px");
            ownerInfo.Style.Add("height", "106px");
            ownerInfo.Style.Add("float", "right");

            ownerName.Controls.Add(linkownerName);
            ownerName.Style.Add("padding-bottom", "25px");
            ownerName.Style.Add("padding-top", "17px");
            ownerName.Style.Add("font-size", "23px");
            ownerName.Style.Add("color", "#323942");

            ownerTel.Controls.Add(lownerTel);
            ownerTel.Style.Add("font-size", "23px");
            ownerTel.Style.Add("color", "#FB5033");

            /* 经济人信息 */
            agent.Style.Add("width", "410px");
            agent.Style.Add("height", "106px");

            agentInfo.Style.Add("width", "316px");
            agentInfo.Style.Add("height", "106px");
            agentInfo.Style.Add("float", "right");

            aimage.Controls.Add(AgentImage);
            aimage.Style.Add("width", "80px");
            aimage.Style.Add("height", "106px");
            aimage.Style.Add("float", "left");

            agentName.Controls.Add(linkagentName);
            agentName.Style.Add("padding-bottom", "25px");
            agentName.Style.Add("padding-top", "17px");
            agentName.Style.Add("font-size", "23px");
            agentName.Style.Add("color", "#323942");

            agentTel.Controls.Add(lagentTel);
            agentTel.Style.Add("font-size", "23px");
            agentTel.Style.Add("color", "#FB5033");

            YaoYuYue.Controls.Add(linkYaoYuYue);
            YaoYuYue.Style.Add("font-size", "32px");
            YaoYuYue.Style.Add("text-align", "center");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Users.userID != "")
            {

                //判断收藏按钮的颜色
                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "server=.;database=Rent;uid=Rent;pwd=Rent;";
                con1.Open();
                string sql3 = "select * from likehouse where UserID='" + Users.userID + "'" + " and HouseID='" + House.houseID + "'";
                SqlCommand cmd1 = new SqlCommand(sql3, con1);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                if (dr1.Read())
                {
                    Button1.Text = "♥取消收藏";
                    Button1.ForeColor = Color.Black;
                }
                else 
                {
                    Button1.Text = "♥收藏";
                    Button1.ForeColor = Color.Red;
                } 
            }

            //显示房屋信息和房东和经纪人
            try
            {
                House.houseID = Request.QueryString["HouseID"].ToString();
                string sql = "select * from house where houseID='" + House.houseID + "'";
                string sql1 = "select * from agent where agentID=(select agentID from house where houseID='" + House.houseID + "')";
                string sql2 = "select * from owner where ownerID=(select ownerID from house where houseID='" + House.houseID + "')";
                getHouse(sql, sql1, sql2);
            }
            catch
            {
                Response.Redirect("houseInfo.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Users.userID == "")
            {
                Response.Redirect("Login-ap.aspx");
            }
            else
            {
                //先判断这个用户是否收藏过这个房子
                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "server=.;database=Rent;uid=Rent;pwd=Rent;";
                con1.Open();
                string sql1 = "select * from likehouse where UserID='" + Users.userID + "'" + " and HouseID='" + House.houseID + "'";
                SqlCommand cmd1 = new SqlCommand(sql1, con1);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                if (dr1.Read())
                {
                    //取消收藏
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "server=.;database=Rent;uid=Rent;pwd=Rent;";
                    con.Open();
                    string sql = "delete likehouse where UserID='" + Users.userID + "' and HouseID='" + House.houseID + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    Response.Write("<script>alert('您已取消收藏！！！');</script>");
                    Button1.Text = "♥收藏";
                    Button1.ForeColor = Color.Red;
                }
                else
                {
                    //添加收藏
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "server=.;database=Rent;uid=Rent;pwd=Rent;";
                    con.Open();
                    string sql = "insert into likehouse(UserID,HouseID) values('" + Users.userID + "','" + House.houseID + "')";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    Response.Write("<script>alert('您已成功收藏！！！');</script>");
                    con.Close();
                    Button1.Text = "♥取消收藏";
                    Button1.ForeColor = Color.Black;
                }
            }
        }
    }
}