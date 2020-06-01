using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Rent;
public partial class house : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (CommDB.ID == "")
        {
            Response.Redirect("Login-ap.aspx");
        }
        else
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
            con.Open();

            SqlCommand cmd1 = new SqlCommand("select userID from likehouse where houseID='" + CommDB.houseid + "'", con);
            cmd1.ExecuteNonQuery();
            SqlDataReader sdr1 = cmd1.ExecuteReader();
            if (sdr1.Read())
            {
                SqlCommand cmd2 = new SqlCommand("select userID from likehouse where houseID='" + Rent.CommDB.houseid + "'", con);
                sdr1.Close();
                cmd2.ExecuteNonQuery();

                SqlDataReader sdr2 = cmd1.ExecuteReader();
                sdr2.Close();
                if (cmd1.ExecuteScalar().ToString() == Rent.CommDB.ID)
                {
                    this.Button1.Text = "取消收藏";

                }
                else
                {
                    this.Button1.Text = "收藏";

                }


                con.Close();

            }
        }

        SqlConnection con1 = new SqlConnection();
        con1.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
        con1.Open();
        SqlCommand cmd = new SqlCommand("select houseCountry, houseCity ,houseStreet ,houseAdress ," +
            "houseType,hopePrice,houseArea,ownerPhone," +
            "timeLooking,agentID,houseState,http from house where houseID=" + Rent.CommDB.houseid, con1);
        cmd.ExecuteNonQuery();
        SqlDataReader sdr = cmd.ExecuteReader();
        while (sdr.Read())
        {
            Label1.Text=sdr["houseCountry"].ToString();
            Label2.Text = sdr["houseCity"].ToString();
            Label3.Text = sdr["houseStreet"].ToString();
            Label4.Text = sdr["houseAdress"].ToString();
            Label5.Text = sdr["houseType"].ToString();
            Label6.Text = sdr["hopePrice"].ToString()+"美元/月";
            Label7.Text = sdr["houseArea"].ToString()+"㎡";
            Label8.Text = sdr["ownerPhone"].ToString();
            //Label9.Text = sdr["timeLooking"].ToString();
            //Label10.Text = sdr["agentID"].ToString();
            //Label11.Text = sdr["houseState"].ToString();
            Image1.ImageUrl = sdr["http"].ToString();
        }
        sdr.Close();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (CommDB.ID == "")
        {
            Response.Redirect("Login-ap.aspx");
        }
        else
        {
            if (Button1.Text == "收藏")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
                con.Open();

                SqlCommand cmd1 = new SqlCommand("insert into likeHouse (userID,houseID)values(" + "'" + CommDB.ID + "'" + "," + CommDB.houseid + ")", con);
                if (Convert.ToInt32(cmd1.ExecuteNonQuery()) == 1)
                {
                    Response.Write("<script>alert('收藏成功')</script>");
                    this.Button1.Text = "取消收藏";
                }
                con.Close();
            }

            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
                con.Open();
                SqlCommand cmd = new SqlCommand("delete  from likehouse where houseID='" + CommDB.houseid + "'", con);

                if (Convert.ToInt32(cmd.ExecuteNonQuery()) == 1)
                {

                    Response.Write("<script>alert('取消收藏成功')</script>");
                    this.Button1.Text = "收藏";
                }
                con.Close();
            }
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Outsea.aspx");
    }
}