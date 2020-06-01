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
    public partial class ownerHouseInfo : System.Web.UI.Page
    {
        //因为增加了一列 租户的信息 所以要更改※※※※※※※※※※※※※
        public string sql2 = "select * from agent,house,users where house.UserID=users.UserID and agent.agentID=house.agentID and ownerID=(select ownerID from owner where ownerPhone='" + Owner.ownerPhone + "' and houseState='已出租')";
        public string sql1 = "select * from agent,house where agent.agentID=house.agentID and ownerID=(select ownerID from owner where ownerPhone='" + Owner.ownerPhone + "' and houseState='商议中')";
        public string sql0 = "select * from house where ownerID=(select ownerID from owner where ownerPhone='" + Owner.ownerPhone + "' and houseState='未出租')";
     

        protected void bind1(string sql)
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
                GridView1.DataKeyNames = new string[] { "houseID"};
                GridView1.DataBind();
            }
        }
        protected void bind2(string sql)
        {
            string mystr = System.Configuration.ConfigurationManager.ConnectionStrings["myconnstring"].ToString();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = mystr;
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView2.DataSource = dt;
                GridView2.DataBind();
            }
        }
        protected void bind3(string sql)
        {
            string mystr = System.Configuration.ConfigurationManager.ConnectionStrings["myconnstring"].ToString();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = mystr;
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView3.DataSource = dt;
                GridView3.DataBind();
            }
        }
        protected void bind4(string sql)
        {
            string mystr = System.Configuration.ConfigurationManager.ConnectionStrings["myconnstring"].ToString();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = mystr;
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView4.DataSource = dt;
                GridView4.DataBind();
            }
        }

   
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Owner.ownerPhone == "")
            {
                Response.Redirect("Login-ap.aspx");
            }
            else
            {
                if (!IsPostBack)
                {
                    string sql = "select * from owner where ownerPhone='" + Owner.ownerPhone + "'";
                    bind4(sql);
                    Label5.Text = "";
                    Label6.Text = "";
                    Label7.Text = "";
                }
            }
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            this.GridView1.EditIndex = -1;//???????????/////
            
            this.bind1(sql0);
        }

        //当点击编辑时，所要触发的事件
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;//获取和设置要编辑行的索引
            this.bind1(sql0);
        }

        //当更改完成后，点击更新时所要触发的事件
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string houseCountry = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[1].Controls[0])).Text.ToString();
            string houseCity = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[2].Controls[0])).Text.ToString();
            string houseProvince = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[3].Controls[0])).Text.ToString();
            string houseDistrict = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[4].Controls[0])).Text.ToString();
            string houseStreet = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[5].Controls[0])).Text.ToString();
            string housePlot = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[6].Controls[0])).Text.ToString();
            string houseAdress = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[7].Controls[0])).Text.ToString();
            string houseType = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[8].Controls[0])).Text.ToString();

            float hopePrice = float.Parse(((TextBox)(GridView1.Rows[e.RowIndex].Cells[9].Controls[0])).Text.ToString());
            float houseArea = float.Parse(((TextBox)(GridView1.Rows[e.RowIndex].Cells[10].Controls[0])).Text.ToString());
            string houseID = GridView1.Rows[e.RowIndex].Cells[0].Text;
           // DateTime timeLooking = DateTime.Parse(((TextBox)(GridView1.Rows[e.RowIndex].Cells[12].Controls[0])).Text.ToString());

            string sql = "update house set houseCountry='"+houseCountry+"',houseCity='"+houseCity
                +"',houseProvince='"+houseProvince+"',houseDistrict='"+houseDistrict
                +"',houseStreet='"+houseStreet+"',housePlot='"+housePlot
                + "',houseAdress='" + houseAdress + "',houseType='" + houseType 
                + "', hopePrice=" + hopePrice + ",houseArea=" + houseArea + " where houseID='" + houseID + "'";
            bind1(sql);
            GridView1.EditIndex = -1; 
            bind1(sql0);
            
        }


        //清除数据
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string houseID = GridView1.DataKeys[e.RowIndex].Value.ToString();
            string sql = "delete from house where houseID='"+houseID+"'";
            string mystr = System.Configuration.ConfigurationManager.ConnectionStrings["myconnstring"].ToString();
            using (SqlConnection conn = new SqlConnection())
            {
                    conn.ConnectionString = mystr;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql,conn);
                    cmd.ExecuteNonQuery();
                    bind1(sql0);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int find = 0;
            string mystr = System.Configuration.ConfigurationManager.ConnectionStrings["myconnstring"].ToString();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = mystr;
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql0, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    find = 1;
                }
                else
                {
                    find = 2;
                }
                if (find == 1)
                {
                    Label5.Text = "";
                    GridView1.Visible = true;
                    bind1(sql0);
                }
                if (find == 2)
                {
                    Label5.Text = "您名下的房子没有空闲的！！！";
                   // bind1(sql0);
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int find = 0;
            string mystr = System.Configuration.ConfigurationManager.ConnectionStrings["myconnstring"].ToString();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = mystr;
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql1, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    find = 1;
                }
                else
                {
                    find = 2;
                }
                if (find == 1)
                {
                    Label6.Text = "";
                    GridView2.Visible = true;
                    bind2(sql1);
                }
                if (find == 2)
                {
                    Label6.Text = "您名下的所有房子没有正在商议中的！！！";
                   
                }
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int find = 0;
            string mystr = System.Configuration.ConfigurationManager.ConnectionStrings["myconnstring"].ToString();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = mystr;
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql2, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    find = 1;
                }
                else
                {
                    find = 2;
                }
                if (find == 1)
                {
                    Label7.Text = "";
                    GridView3.Visible = true;
                    bind3(sql2);
                }
                if (find == 2)
                {
                    Label7.Text = "您名下的所有房子没有租出去的！！！";

                }
            }
            
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            GridView1.Visible = false;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            GridView2.Visible = false;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            GridView3.Visible = false;
        }
    }
}