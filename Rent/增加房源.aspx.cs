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
    public partial class 增加房源 : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            
            //UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!Page.IsPostBack)
            {
                Session["update"] = false;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "server=.;database=Rent;uid=Rent;pwd=Rent;";
                con.Open();
                string sql = "select distinct 区 from housePlace1";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DropDownList1.DataSource = dt;
                DropDownList1.DataTextField = "区";
                DropDownList1.DataBind();
                con.Close();

                Session["update"] = true;//以此达到防止返回数据时，重新刷新页面（load事件）
                if (DropDownList1.SelectedItem.Value != "未绑定")
                {
                    string 区 = DropDownList1.SelectedItem.Value;//记得获取DropDownList1的值，因为要从服务器中发过来
                    SqlConnection con1 = new SqlConnection();
                    con1.ConnectionString = "server=.;database=Rent;uid=Rent;pwd=Rent;";
                    con1.Open();
                    string sql1 = "select 街道 from housePlace1 where 区='" + DropDownList1.SelectedItem.Value + "'";
                    SqlDataAdapter da1 = new SqlDataAdapter(sql1, con1);
                    da1.SelectCommand.Parameters.Add("区", 区);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);

                    DropDownList2.DataSource = dt1;
                    DropDownList2.DataTextField = "街道";//重点易忘记
                    DropDownList2.DataBind();

                    con1.Close();
                }
            }
            
        }

        protected void TextBox9_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            this.TextBox9 .Text  = string.Format("{0}", ran.Next(999999999));
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                //LinkButton1.Visible = true;
                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "server=.;database=Rent;uid=Rent;pwd=Rent";
                con1.Open();
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = con1;
                cmd1.CommandText = "select * from house where houseID='" + this.TextBox7.Text + "'";
                SqlDataReader dr = cmd1.ExecuteReader();
                //int i1 = Convert.ToInt32(cmd1.ExecuteNonQuery());
                if (dr.Read())
                {
                    con1.Close();
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "server=.;database=Rent;uid=Rent;pwd=Rent";
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "update house set houseImageUrl='https://image18.5i5j.com/erp/house/4379/43797328/shinei/naflafbo7e14fdaf.jpg_P5.jpg',houseUrl='houseXiangXiInfo.aspx',houseName='升龙城11号院，精装修，家具家电齐全，拎包入住，朝东户型',http='http://img1.juimg.com/160316/330503-1603160U41282.jpg',housePlot='" + this.TextBox11.Text + "',houseCity='郑州',houseCountry='中国',houseprovince='河南省',houseDistrict='" + DropDownList1.SelectedItem.Value + "',houseStreet='" + DropDownList2.SelectedItem.Value + "',houseAdress='" + this.TextBox2.Text + "',houseType='" + this.DropDownList3.SelectedItem.ToString() + "',hopePrice=" + float.Parse(this.TextBox5.Text) + ",houseArea=" +float.Parse(this.TextBox6.Text) + ",ownerID='" + Rent.Owner.ownerID + "',ownerPhone='" + this.TextBox8.Text + "',houseState='未出租' where houseID='" + this.TextBox7.Text + "'";
                    int i = Convert.ToInt32(cmd.ExecuteNonQuery());
                    if (i >= 1)
                    {
                       //  Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "close", "<script language='javascript' type='text/javascript'>window.opener.location.reload(true);window.close();</script>");
                        Response.Redirect("addHouseTiShi.aspx");
                    }
                    else
                    {
                        Response.Write("<script language=javascript >alert('提交失败！');window.navigate('../index.asp');<");
                        Response.Write("/Script>");
                    }
                    con.Close();
                }
                else
                {
                    Response.Write("<script language=javascript >alert('房屋账号已存在！');window.navigate('../index.asp');<");
                    Response.Write("/Script>");
                }
            }
            //else if (CheckBox2.Checked)
            //{
            //    SqlConnection con1 = new SqlConnection();
            //    con1.ConnectionString = "server=DESKTOP-COM9042;database=Rent;uid=Rent;pwd=Rent";
            //    con1.Open();
            //    SqlCommand cmd1 = new SqlCommand();
            //    cmd1.Connection = con1;
            //    cmd1.CommandText = "select * from house where houseID='" + this.TextBox7.Text + "'";
            //    SqlDataReader dr = cmd1.ExecuteReader();
            //    //int i1 = Convert.ToInt32(cmd1.ExecuteNonQuery());
            //    if (!dr.Read())
            //    {
            //        con1.Close();
            //        SqlConnection con = new SqlConnection();
            //        con.ConnectionString = "server=DESKTOP-COM9042;database=Rent;uid=Rent;pwd=Rent";
            //        con.Open();
            //        SqlCommand cmd = new SqlCommand();
            //        cmd.Connection = con;
            //        cmd.CommandText = "insert into house (houseID,houseDistrict,houseStreet,houseAdress,houseType,hopePrice,houseArea,ownerID,houseState) values (" + this.TextBox7.Text + ",'" + DropDownList1.SelectedItem.Value + "','" + DropDownList2.SelectedItem.Value + "','" + this.TextBox2.Text + "','" + this.TextBox10.Text + "'," + this.TextBox5.Text + "," + this.TextBox6.Text + ",12,'未出租')";
            //        int i = Convert.ToInt32(cmd.ExecuteNonQuery());
            //        if (i >= 1)
            //        {
            //            Response.Write("<script language=javascript >alert('提交成功！');window.navigate('../index.asp');<");
            //            Response.Write("/Script>");
            //        }
            //        else
            //        {
            //            Response.Write("<script language=javascript >alert('提交失败！');window.navigate('../index.asp');<");
            //            Response.Write("/Script>");
            //        }
            //        con.Close();
            //    }
                //else
                //{
                //    Response.Write("<script language=javascript >alert('房屋账号已存在！');window.navigate('../index.asp');<");
                //    Response.Write("/Script>");
            //    }
            //}
            else 
            {
                Response.Write("<script language=javascript >alert('请选择看房时间！');window.navigate('../index.asp');<");
                Response.Write("/Script>");
                //Response.Write("<script>alert('请选择看房时间');</script>");
                //跳转到主页面
            }
        }

        protected void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["update"] = true;//以此达到防止返回数据时，重新刷新页面（load事件）
            if (DropDownList1.SelectedItem.Value != "未绑定")
            {
                string 区 = DropDownList1.SelectedItem.Value;//记得获取DropDownList1的值，因为要从服务器中发过来
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "server=.;database=Rent;uid=Rent;pwd=Rent;";
                con.Open();
                string sql = "select 街道 from housePlace1 where 区='" + DropDownList1.SelectedItem.Value + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.SelectCommand.Parameters.Add("区", 区);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DropDownList2.DataSource = dt;
                DropDownList2.DataTextField = "街道";//重点易忘记
                DropDownList2.DataBind();

                con.Close();
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            if (TextBox7.Text == "")
            {
                Response.Write("<script language=javascript >alert('请设置房屋账号！');window.navigate('../index.asp');<");
                Response.Write("/Script>");
            }
            else 
            {
                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "server=.;database=Rent;uid=Rent;pwd=Rent";
                con1.Open();
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = con1;
                cmd1.CommandText = "select * from house where houseID='" + this.TextBox7.Text + "'";
                SqlDataReader dr = cmd1.ExecuteReader();
                //int i1 = Convert.ToInt32(cmd1.ExecuteNonQuery());
                if (!dr.Read())
                {
                    con1.Close();
                    Rent.House.houseID = this.TextBox7.Text;
                    Response.Redirect("经纪人.aspx");
                }
                else
                {
                        Response.Write("<script language=javascript >alert('房屋账号已存在！');window.navigate('../index.asp');<");
                        Response.Write("/Script>");
                }
            }
            //身份标注
        }
        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                LinkButton1.Visible = true;
            }
        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}