using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        private void yao()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=.;database=Rent;uid=Rent;pwd=Rent";
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from agent", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            this.GridView1.DataSource = dt;
            this.GridView1.DataKeyNames = new string[] { "agentID" };
            this.GridView1.DataKeyNames = new string[] { "agentID" };
            this.GridView1.DataBind();
            con.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            this.yao();
        }

       /* public string GetUrl(object o)
        {
            return "Detail.aspx?id=" + o.ToString();
        }*/

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
           /* if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //jjr.agentName = ((HyperLink)e.Row.Cells[0].Controls[0]).Text;
            }
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                HyperLink hlf = (HyperLink)e.Row.Cells[1].Controls[0];

                int id = int.Parse(GridView1.DataKeys[e.Row.RowIndex].Value.ToString());
                switch (id)
                {
                    case 1:
                        hlf.NavigateUrl = "1.aspx";
                        break;
                    case 2:
                        hlf.NavigateUrl = "2.aspx";
                        break;
                }
            }*/
            /*if (e.Row.RowType == DataControlRowType.DataRow)
            {

                if (Convert.ToInt32(e.Row.Cells[3].Text.Trim()) > 5)
                {
                    e.Row.BackColor = Color.Red;
                }

            }*/
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
               // ((LinkButton)(e.Row.Cells[4].Controls[0])).Attributes.Add("onclick", "return confirm('确认删除吗？')");
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.GridView1.PageIndex = e.NewPageIndex;
            this.yao();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("经纪人.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            if (Rent.Users.userID == "" && Rent.Agent.agentID == "" && Rent.Owner.ownerID != "" && Rent.Admin.adminID == "")
            {
                Response.Redirect("增加房源.aspx");
            }
            if (Rent.Users.userID != "" && Rent.Agent.agentID == "" && Rent.Owner.ownerID == "" && Rent.Admin.adminID == "")
            {
                Response.Redirect("houseInfo.aspx");
            }
        }

    }
}