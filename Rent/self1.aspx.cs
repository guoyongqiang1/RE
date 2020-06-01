using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Rent;

public partial class self1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //TextBox1.ReadOnly = true;
        //TextBox2.ReadOnly = true;
        //TextBox3.ReadOnly = true;
        //TextBox4.ReadOnly = true;
        if (Users.userID == "" && Agent.agentTel == "" && Owner.ownerPhone == "" && Admin.adminID == "")
        {
            Response.Redirect("Login-ap.aspx");
        }
        if (Users.userID != "" && Agent.agentTel == "" && Owner.ownerPhone == "" && Admin.adminID == "")
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
            con.Open();

            SqlCommand cmd = new SqlCommand("select userID,userName,userAge ,userPhone from users where userID=" + "'" + Users.userID + "'", con);
            cmd.ExecuteNonQuery();
            SqlDataReader sdr3 = cmd.ExecuteReader();
            while (sdr3.Read())
            {
                TextBox1.Text = sdr3["userID"].ToString();
                TextBox2.Text = sdr3["userName"].ToString();
                TextBox3.Text = sdr3["userAge"].ToString();
                TextBox4.Text = sdr3["userPhone"].ToString();
            }
            sdr3.Close();


            SqlCommand cmd1 = new SqlCommand("select COUNT (*) from likehouse where userID=" + "'" + CommDB.ID + "'", con);
            cmd1.ExecuteNonQuery();
            SqlDataReader sdr1 = cmd1.ExecuteReader();
            while (sdr1.Read())
            {
                TextBox5.Text = sdr1[0].ToString();
            }

            sdr1.Close();


            SqlCommand cmd2 = new SqlCommand("select COUNT (*) from likeagent where userID=" + "'" + Rent.CommDB.ID + "'", con);
            cmd1.ExecuteNonQuery();
            SqlDataReader sdr2 = cmd2.ExecuteReader();
            while (sdr2.Read())
            {
                TextBox6.Text = sdr2[0].ToString();
            }
            sdr2.Close();
            con.Close();
        }


        if (Users.userID == "" && Agent.agentTel == "" && Owner.ownerPhone == "" && Admin.adminID != "")
        {
            Label1.Visible = false; Label2.Visible = false;
            TextBox5.Visible = false; TextBox6.Visible = false;
            Button1.Visible = false; Button2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
            con.Open();
            string sql="select adminID,adminPwd,adminName ,adminTel,adminAge from admin where adminID='"+Admin.adminID+"'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            SqlDataReader sdr3 = cmd.ExecuteReader();
            while (sdr3.Read())
            {
                TextBox1.Text = sdr3["adminID"].ToString();
                TextBox2.Text = sdr3["adminName"].ToString();
                TextBox3.Text = sdr3["adminAge"].ToString();
                TextBox4.Text = sdr3["adminTel"].ToString();
            }
            sdr3.Close();
        }
    }



    protected void Button3_Click(object sender, EventArgs e)
    {

        Response.Redirect("edit.aspx");
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("likehouse.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("likeagent.aspx");
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("houseInfo.aspx");
    }
}

