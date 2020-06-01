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
    public partial class 管理员管理 : System.Web.UI.Page
    {
        SqlConnection myconn = new SqlConnection();
        SqlCommand mycmd = new SqlCommand();
        string mystr = System.Configuration.ConfigurationManager.ConnectionStrings["myconnstring1"].ToString();
        private void yao()
        {
            string sqlstr = "select * from agent";
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

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            myconn = new SqlConnection(mystr);
            string  agentTel= ((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text.ToString();
            string  agentName= ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text.ToString();
            string  agentAge= ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text.ToString();
            string  agentArea= ((TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0]).Text.ToString();
            string  agentDistrict= ((TextBox)GridView1.Rows[e.RowIndex].Cells[5].Controls[0]).Text.ToString();
            string  agentTimes= ((TextBox)GridView1.Rows[e.RowIndex].Cells[6].Controls[0]).Text.ToString();
            string  agentTrantimes= ((TextBox)GridView1.Rows[e.RowIndex].Cells[7].Controls[0]).Text.ToString();
            string sqlstr = "update agent set agentTel='" + agentTel + "',agentName='" + agentName + "',agentAge='" + agentAge + "',agentArea='" + agentArea + "',agentDistrict='" + agentDistrict + "',agentTimes='" + agentTimes + "',agentTrantimes='" + agentTrantimes + "'  where agentID='"+GridView1.DataKeys [e.RowIndex ].Value .ToString()+"'";
            mycmd = new SqlCommand(sqlstr, myconn);
            myconn.Open();
            mycmd.ExecuteNonQuery();
            myconn.Close();
            GridView1.EditIndex = -1;
            yao();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string sqlstr = "delete from agent where agentID=" + GridView1.DataKeys[e.RowIndex].Value.ToString() + "";
            myconn = new SqlConnection(mystr);
            mycmd = new SqlCommand(sqlstr, myconn);
            myconn.Open();
            mycmd.ExecuteNonQuery();
            myconn.Close();
            yao();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {

            GridView1.EditIndex = e.NewEditIndex;
            yao();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.GridView1.PageIndex = e.NewPageIndex;
            this.yao();
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
                                tbUpdate.Width = Unit.Pixel(100);
                            }
                        }
                        else if (i == 2)
                        {
                            if (tbUpdate != null)
                            {
                                tbUpdate.Width = Unit.Pixel(40);
                            }
                        }
                        else if (i == 3)
                        {
                            if (tbUpdate != null)
                            {
                                tbUpdate.Width = Unit.Pixel(40);
                            }
                        }
                        else if (i == 4)
                        {
                            if (tbUpdate != null)
                            {
                                tbUpdate.Width = Unit.Pixel(80);
                            }
                        }
                        else if (i == 5)
                        {
                            if (tbUpdate != null)
                            {
                                tbUpdate.Width = Unit.Pixel(100);
                            }
                        }
                        else if (i == 6)
                        {
                            if (tbUpdate != null)
                            {
                                tbUpdate.Width = Unit.Pixel(50);
                            }
                        }
                        else if (i == 7)
                        {
                            if (tbUpdate != null)
                            {
                                tbUpdate.Width = Unit.Pixel(50);
                            }
                        }

                    }
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminEditInfo.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            this.Label5.Visible = true;
            this.Label6.Visible = true;
            this.Label7.Visible = true;
            this.Label8.Visible = true;
            this.Label10.Visible = true;
            this.Label11.Visible = true;
            this.Label12.Visible = true;
            this.Label13.Visible = true;
            this.TextBox1.Visible = true;
            this.TextBox2.Visible = true;
            this.TextBox3.Visible = true;
            this.TextBox4.Visible = true;
            this.TextBox6.Visible = true;
            this.TextBox7.Visible = true;
            this.TextBox8.Visible = true;
            this.TextBox9.Visible = true;
            

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (this.TextBox1.Text != "" && this.TextBox2.Text !="" && this.TextBox3.Text != "" && this.TextBox4.Text !="" && this.TextBox6.Text != "" && this.TextBox7.Text != "" && this.TextBox8.Text != "" && this.TextBox9.Text != "")
            {
                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "server=.;database=Rent;uid=Rent;pwd=Rent";
                con1.Open();
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = con1;
                cmd1.CommandText = "select * from agent where agentID='" + this.TextBox1.Text + "'";
                SqlDataReader dr = cmd1.ExecuteReader();
                //int i1 = Convert.ToInt32(cmd1.ExecuteNonQuery());
                if (!dr.Read())
                {
                    con1.Close();
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "server=.;database=Rent;uid=Rent;pwd=Rent";
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "insert into agent(agentID,agentTel,agentName,agentAge,agentArea,agentDistrict,agentTrantimes,agentTimes) values('" + this.TextBox1.Text + "'," + this.TextBox2.Text + ",'" + this.TextBox3.Text + "'," + this.TextBox4.Text + ",'" + this.TextBox6.Text + "','" + this.TextBox7.Text + "'," + this.TextBox8.Text + "," + this.TextBox9.Text + ")";
                    int i = Convert.ToInt32(cmd.ExecuteNonQuery());
                    if (i >= 1)
                    {
                        Response.Write("<script language=javascript >alert('添加成功！');window.navigate('../index.asp');<");
                        Response.Write("/Script>"); 
                        Response.Redirect("adminEditInfo.aspx");
                    }
                    else
                    {
                        Response.Write("<script language=javascript >alert('添加失败！');window.navigate('../index.asp');<");
                        Response.Write("/Script>");
                        Response.Redirect("管理员管理.aspx"); 
                    }
                    con.Close();
                }
                else
                {
                    Response.Write("<script language=javascript >alert('经纪人账号已存在！');window.navigate('../index.asp');<");
                    Response.Write("/Script>");
                    Response.Redirect("管理员管理.aspx"); 
                }
                
            }
            else
            {
                Response.Write("<script language=javascript >alert('输入不能为空！');window.navigate('../index.asp');<");
                Response.Write("/Script>"); 
                Response.Redirect("管理员管理.aspx");
            }
        }
    }
}