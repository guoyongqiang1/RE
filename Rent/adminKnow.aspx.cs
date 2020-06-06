using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient; 
using BLL;
using Model;

namespace Rent
{
    public partial class adminKnow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            if (!Page.IsPostBack)
            {
                
               
                DataTable dt =

                SqlDataAdapter sda = new SqlDataAdapter("select * from know", con);
               
                this.GridView1.DataSource = dt;
                this.GridView1.DataKeyNames = new string[] { "title" };
                this.GridView1.DataBind();
                con.Close();
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from know where title=@title";
            cmd.Parameters.Add(new SqlParameter("@title", GridView1.DataKeys[e.RowIndex].Value.ToString()));
            cmd.ExecuteNonQuery();
            con.Close();
            GridView1.EditIndex = -1;

            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
            con1.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select * from know", con1);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            this.GridView1.DataSource = dt;
            this.GridView1.DataKeyNames = new string[] { "title" };
            this.GridView1.DataBind();
            con1.Close();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
            con1.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select * from know", con1);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            this.GridView1.DataSource = dt;
            this.GridView1.DataKeyNames = new string[] { "title" };
            this.GridView1.DataBind();
            con1.Close();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update know set title=@title,type=@type" +
                ",p=@p,url=@url where title=@oldtitle";
            cmd.Parameters.Add(new SqlParameter("@title", ((TextBox)(GridView1.Rows[e.RowIndex].Cells[0].Controls[0])).Text));
            cmd.Parameters.Add(new SqlParameter("@type", ((TextBox)(GridView1.Rows[e.RowIndex].Cells[1].Controls[0])).Text));
            cmd.Parameters.Add(new SqlParameter("@p", ((TextBox)(GridView1.Rows[e.RowIndex].Cells[2].Controls[0])).Text));
            cmd.Parameters.Add(new SqlParameter("@url", ((TextBox)(GridView1.Rows[e.RowIndex].Cells[3].Controls[0])).Text));
            cmd.Parameters.Add(new SqlParameter("@oldtitle", GridView1.DataKeys[e.RowIndex].Value.ToString()));
            cmd.ExecuteNonQuery();
            con.Close();
            GridView1.EditIndex = -1;

            SqlConnection con2 = new SqlConnection();
            con2.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
            con2.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select * from know", con2);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            this.GridView1.DataSource = dt;
            this.GridView1.DataKeyNames = new string[] { "title" };
            this.GridView1.DataBind();
            con2.Close();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            SqlConnection con2 = new SqlConnection();
            con2.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
            con2.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select * from know", con2);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            this.GridView1.DataSource = dt;
            this.GridView1.DataKeyNames = new string[] { "title" };
            this.GridView1.DataBind();
            con2.Close();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
                Panel1.Visible = true;
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text.Length != 4)
            {
                Response.Write("<script>alert('请输入四字文章类型')</script>");
            }
            else
            {

                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
                    con.Open();

                    SqlCommand cmd = new SqlCommand("insert into know values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    Response.Write("<script>alert('文章添加成功')</script>");
                    Panel1.Visible = false;

                    SqlConnection con1 = new SqlConnection();
                    con1.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
                    con1.Open();

                    SqlDataAdapter sda = new SqlDataAdapter("select * from know", con1);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    this.GridView1.DataSource = dt;
                    this.GridView1.DataKeyNames = new string[] { "title" };
                    this.GridView1.DataBind();
                    con1.Close();
                }
                catch
                {

                }
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminEditInfo.aspx");
        }

        //protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        //{
        //    if (e.Row.RowState == (DataControlRowState.Edit | DataControlRowState.Alternate) || e.Row.RowState == DataControlRowState.Edit)
        //    {
        //        TextBox tbUpdate;
        //        for (int i = 0; i < e.Row.Cells.Count; i++)
        //        {
        //            if (e.Row.Cells[i].Controls.Count != 0)
        //            {
        //                tbUpdate = e.Row.Cells[i].Controls[0] as TextBox;
        //                if (i == 0)
        //                {
        //                    if (tbUpdate != null)
        //                    {
        //                        tbUpdate.Width = Unit.Pixel(15);
        //                    }
        //                }
        //                else if (i == 1)
        //                {
        //                    if (tbUpdate != null)
        //                    {
        //                        tbUpdate.Width = Unit.Pixel(50);
        //                    }
        //                }
        //                else if (i == 2)
        //                {
        //                    if (tbUpdate != null)
        //                    {
        //                        tbUpdate.Width = Unit.Pixel(70);
        //                    }
        //                }
        //                else if (i == 3)
        //                {
        //                    if (tbUpdate != null)
        //                    {
        //                        tbUpdate.Width = Unit.Pixel(100);
        //                    }
        //                }

        //            }
        ////        }
        //    }
        //}
    }
}