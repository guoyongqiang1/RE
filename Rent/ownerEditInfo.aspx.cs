using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Rent
{
    public partial class ownerEditInfo : System.Web.UI.Page
    {
        public static int Num = 2;
        protected void bind(string sql)
        {
            string mystr = System.Configuration.ConfigurationManager.ConnectionStrings["myconnstring"].ToString();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = mystr;
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataKeyNames = new string[] { "ownerID" };
                GridView1.DataBind();
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string sql = "select * from owner";
                bind(sql);

                table1.Style.Add("display","none");
            }
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            this.GridView1.EditIndex = -1;//???????????/////
            string sql = "select * from owner";
            this.bind(sql);
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;//获取和设置要编辑行的索引
            string sql = "select * from owner";
            this.bind(sql);
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string oldownerID = GridView1.DataKeys[e.RowIndex].Value.ToString();
            string newownerID = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[0].Controls[0])).Text.ToString();
            string ownerName = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[1].Controls[0])).Text.ToString();
            string ownerPhone = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[2].Controls[0])).Text.ToString();
            string ownerPwd = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[3].Controls[0])).Text.ToString();
            string ownerImage = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[4].Controls[0])).Text.ToString();
            string sql = "update owner set owner.ownerID='" + newownerID + "',ownerName='" + ownerName + "',ownerPhone='" + ownerPhone + "',ownerPwd='" + ownerPwd + "',ownerImage='" + ownerImage + "' where owner.ownerID='" + oldownerID + "'";
            bind(sql);
            GridView1.EditIndex = -1;
            string sql1 = "select * from owner";
            bind(sql1);
        }



        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string ownerID = GridView1.DataKeys[e.RowIndex].Value.ToString();
            string sql = "delete owner where ownerID='"+ownerID+"'";
            string mystr = System.Configuration.ConfigurationManager.ConnectionStrings["myconnstring"].ToString();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = mystr;
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                string sql1 = "select * from owner";
                bind(sql1);
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Num % 2 == 0)
            {
                table1.Style.Add("display", "block");
            }
            else
            {
                table1.Style.Add("display", "none");
            }
            Num++;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            {
                Response.Write("<script>alert('房东ID不能为空！！！');</script>");
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "server=.;database=Rent;uid=Rent;pwd=Rent;";
                con.Open();
                string sql2 = "select * from owner where ownerID='" + TextBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(sql2, con);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Response.Write("<script>alert('房东ID不能重复！！！');</script>");
                }
                else
                {
                    con.Close();
                    SqlConnection con1 = new SqlConnection();
                    con1.ConnectionString = "server=.;database=Rent;uid=Rent;pwd=Rent;";
                    con1.Open();
                    string sql1 = "select * from owner where ownerName='" + TextBox2.Text + "' and ownerPhone='" + TextBox3.Text + "'";
                    SqlCommand cmd1 = new SqlCommand(sql1, con1);
                    cmd1.ExecuteNonQuery();
                    SqlDataReader dr1 = cmd1.ExecuteReader();
                    if (dr1.Read())
                    {
                        Response.Write("<script>alert('这个房东已经注册过了！！！');</script>");
                    }
                    else
                    {
                        con1.Close();
                        SqlConnection con2 = new SqlConnection();
                        con2.ConnectionString = "server=.;database=Rent;uid=Rent;pwd=Rent;";
                        con2.Open();
                        string sql = "insert into owner(ownerID,ownerName,ownerPhone,ownerPwd,ownerImage) values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')";
                        SqlCommand cmd2 = new SqlCommand(sql, con2);
                        cmd2.ExecuteNonQuery();
                        string sql3 = "select * from owner";
                        bind(sql3);
                        Response.Write("<script>alert('成功添加！！！');</script>");
                        con2.Close();
                    }
                }
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminEditInfo.aspx");
        }

    }
}