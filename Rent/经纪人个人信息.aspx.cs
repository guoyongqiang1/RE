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
    public partial class 经纪人个人信息 : System.Web.UI.Page
    {
        SqlConnection myconn = new SqlConnection();
        SqlCommand mycmd = new SqlCommand();
        string mystr = System.Configuration.ConfigurationManager.ConnectionStrings["myconnstring1"].ToString();
        private void yao()
        {
            string sqlstr = "select * from agent where agentID='"+Rent.Agent.agentID+"'";
            myconn = new SqlConnection(mystr);
            SqlDataAdapter sda = new SqlDataAdapter(sqlstr, myconn);
            DataSet myds = new DataSet();
            myconn.Open();
            sda.Fill(myds, "agent");
            this.GridView1.DataSource = myds;
            this.GridView1.DataSourceID = null;
            this.GridView1.DataKeyNames = new string[] { "agentID" };
            this.GridView1.DataBind();
            myconn.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.yao();
            }
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            myconn = new SqlConnection(mystr);
            string agentPwd = ((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text.ToString();
            string agentName = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text.ToString();
            string agentTel = ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text.ToString();
            string agentAge = ((TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0]).Text.ToString();
            string agentArea = ((TextBox)GridView1.Rows[e.RowIndex].Cells[5].Controls[0]).Text.ToString();
            string agentDistrict = ((TextBox)GridView1.Rows[e.RowIndex].Cells[6].Controls[0]).Text.ToString();
            string agentTimes = ((TextBox)GridView1.Rows[e.RowIndex].Cells[7].Controls[0]).Text.ToString();
            string agentTrantimes = ((TextBox)GridView1.Rows[e.RowIndex].Cells[8].Controls[0]).Text.ToString();
            string agentImage = ((TextBox)GridView1.Rows[e.RowIndex].Cells[9].Controls[0]).Text.ToString();
            string sqlstr = "update agent set agentPwd='" + agentPwd + "',agentName='" + agentName + "',agentTel='" + agentTel + "',agentAge='" + agentAge + "',agentArea ='" + agentArea + "',agentDistrict='" + agentDistrict + "', agentTimes='" + agentTimes + "',agentTrantimes='" + agentTrantimes + "',agentImage='" + agentImage + "' where agentID='"+Rent.Agent.agentID+"';";
            mycmd = new SqlCommand(sqlstr, myconn);
            myconn.Open();
            mycmd.ExecuteNonQuery();
            myconn.Close();
            GridView1.EditIndex = -1;
            yao();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            yao();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            yao();
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowState == (DataControlRowState.Edit | DataControlRowState.Alternate) || e.Row.RowState == DataControlRowState.Edit)
            {
                TextBox tbUpdate;
                for (int i = 0; i < e.Row.Cells.Count; i++)
                {
                    if (e.Row.Cells[i].Controls.Count != 0)
                    {
                        tbUpdate = e.Row.Cells[i].Controls[0] as TextBox;
                        if (i == 0)
                        {
                            if (tbUpdate != null)
                            {
                                tbUpdate.Width = Unit.Pixel(15);
                            }
                        }

                        else if (i == 1)
                        {
                            if (tbUpdate != null)
                            {
                                tbUpdate.Width = Unit.Pixel(50);
                            }
                        }
                        else if (i == 2)
                        {
                            if (tbUpdate != null)
                            {
                                tbUpdate.Width = Unit.Pixel(50);
                            }
                        }
                        else if (i == 3)
                        {
                            if (tbUpdate != null)
                            {
                                tbUpdate.Width = Unit.Pixel(50);
                            }
                        }
                        else if (i == 4)
                        {
                            if (tbUpdate != null)
                            {
                                tbUpdate.Width = Unit.Pixel(50);
                            }
                        }
                        else if (i == 5)
                        {
                            if (tbUpdate != null)
                            {
                                tbUpdate.Width = Unit.Pixel(80);
                            }
                        }
                        else if (i == 6)
                        {
                            if (tbUpdate != null)
                            {
                                tbUpdate.Width = Unit.Pixel(80);
                            }
                        }
                        else if (i == 7)
                        {
                            if (tbUpdate != null)
                            {
                                tbUpdate.Width = Unit.Pixel(80);
                            }
                        }
                        else if (i == 8)
                        {
                            if (tbUpdate != null)
                            {
                                tbUpdate.Width = Unit.Pixel(80);
                            }
                        }
                        else if (i == 9)
                        {
                            if (tbUpdate != null)
                            {
                                tbUpdate.Width = Unit.Pixel(100);
                            }
                        }
                    }
                }
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}