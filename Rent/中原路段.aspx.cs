﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data .SqlClient;

namespace WebApplication1
{
    public partial class 经纪人 : System.Web.UI.Page
    {
        private void yao()
         {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=.;database=Rent;uid=Rent;pwd=Rent";
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from agent where agentArea='中原'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            this.GridView1.DataSource = dt;
            this.GridView1.DataKeyNames = new string[]{"agentID" };
            this.GridView1.DataKeyNames = new string[] { "agentID" };
            this.GridView1.DataBind();
            con.Close();
        } 


        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            this.yao();
        }


        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            
        }
        protected void LinkButton3_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("中原_碧沙岗.aspx");
        }

        protected void LinkButton6_Click1(object sender, EventArgs e)
        {
            Response.Redirect("中原_航海西路.aspx");
        }

        protected void LinkButton7_Click1(object sender, EventArgs e)
        {
            Response.Redirect("中原_帝湖.aspx");
        }

        protected void LinkButton1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("中原路段.aspx");
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.GridView1.PageIndex = e.NewPageIndex;
            this.yao();
        }

        protected void LinkButton2_Click1(object sender, EventArgs e)
        {
            Response.Redirect("二七路段.aspx");
        }

        protected void LinkButton3_Click1(object sender, EventArgs e)
        {
            Response.Redirect("金水路段.aspx");
        }

    }
}