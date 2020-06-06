using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BLL;
using DAL;
using Model;

namespace WebApplication1
{
    public partial class 金水路段 : System.Web.UI.Page
    {
        private void yao()
        {
            
        } 
        protected void Page_Load(object sender, EventArgs e)
        {
          JinShuiBLL jinShuiBLL=new JinShuiBLL();
            this.GridView1.DataSource =jinShuiBLL.getJinShuiTable();
            this.GridView1.DataKeyNames = new string[] { "agentID" };
            this.GridView1.DataKeyNames = new string[] { "agentID" };
            this.GridView1.DataBind();
           
        }

        protected void LinkButton1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("中原路段.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

            this.GridView1.PageIndex = e.NewPageIndex;
            this.yao();
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("二七路段.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("金水路段.aspx");
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("金水_博颂路.aspx");
        }

        protected void LinkButton6_Click1(object sender, EventArgs e)
        {

            Response.Redirect("金水_黄河路.aspx");
        }

        protected void LinkButton7_Click1(object sender, EventArgs e)
        {

            Response.Redirect("金水_绿城广场.aspx");
        }

    }
}