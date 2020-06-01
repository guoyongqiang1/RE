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
    public partial class agentMainInfo : System.Web.UI.Page
    {
        protected static int count = 2;
        public void Agenthouse(string sql)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=.;database=Rent;uid=Rent;pwd=Rent;";
            con.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = con;
            SqlDataAdapter da1 = new SqlDataAdapter(sql, con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);

            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                Image newImage = new Image();
                newImage.ImageUrl = dt1.Rows[i].ItemArray[15].ToString();
                newImage.Width = 230;
                newImage.Height = 180;
                HyperLink newHyperLink = new HyperLink();
                newHyperLink.Text = dt1.Rows[i].ItemArray[17].ToString();

                //在跳转页面的时候，往页面后面加一个你想要传递的参数和值 ，之后在跳转到的页面上就可以直接调用了
                newHyperLink.NavigateUrl = "houseXiangXiInfo.aspx?HouseID=" + dt1.Rows[i].ItemArray[0].ToString();

                Label la = new Label();
                la.Text = dt1.Rows[i].ItemArray[1].ToString() + " | " + dt1.Rows[i].ItemArray[2].ToString() + " | " + dt1.Rows[i].ItemArray[3].ToString()
                    + " | " + dt1.Rows[i].ItemArray[4].ToString()
                    + " | " + dt1.Rows[i].ItemArray[5].ToString()
                    + " | " + dt1.Rows[i].ItemArray[6].ToString()
                    + " | " + dt1.Rows[i].ItemArray[7].ToString();

                Label la1 = new Label();
                la1.Text = dt1.Rows[i].ItemArray[9].ToString() + "";
                //la1.Font.Size = 19;  没有效果
                Label la2 = new Label();
                la2.Text = la1.Text + "元/月";
                la2.Font.Size = 14;
                la2.ForeColor = System.Drawing.Color.Red;
                Label la3 = new Label();
                la3.Text = dt1.Rows[i].ItemArray[8].ToString() + " · "
                    + dt1.Rows[i].ItemArray[10].ToString();

                Label la4 = new Label();
                la4.Text = dt1.Rows[i].ItemArray[13].ToString();

                //样式
                Panel pa = new Panel();
                main.Controls.Add(pa);
                //总的大盒子的样式
                this.main.Style.Add("width", "806px");
                this.main.Style.Add("margin-bottom", "25px");
                this.main.Style.Add("margin-top", "37px");

                //每一个div的样式
                pa.Style.Add("height", "180px");
                pa.Style.Add("margin-bottom", "25px");

                //图片的样式
                Panel image = new Panel();
                pa.Controls.Add(image);
                image.Style.Add("float", "left");
                image.Style.Add("width", "230px");
                image.Style.Add("height", "180px");
                image.Controls.Add(newImage);

                Panel right = new Panel();
                pa.Controls.Add(right);
                right.Style.Add("float", "right");
                right.Style.Add("position", "relative");
                right.Style.Add("width", "575px");
                right.Style.Add("height", "180px");
                right.Style.Add("padding", "10px 0px 10px 35px");

                Panel price = new Panel();
                right.Controls.Add(price);
                price.Style.Add("float", "right");
                price.Style.Add("text-align", "center");
                price.Style.Add("line-height", "180px");
                price.Style.Add("width", "90px");
                price.Style.Add("height", "100%");
                price.Controls.Add(la2);

                Panel title = new Panel();
                right.Controls.Add(title);
                title.Style.Add("padding-bottom", "14px");
                title.Controls.Add(newHyperLink);

                Panel Htype = new Panel();
                right.Controls.Add(Htype);
                Htype.Style.Add("padding-bottom", "10px");
                Htype.Controls.Add(la3);

                Panel Haddress = new Panel();
                right.Controls.Add(Haddress);
                Haddress.Style.Add("padding-bottom", "10px");
                Haddress.Controls.Add(la);
            }
        }

        public void Agent(string sql)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=.;database=Rent;uid=Rent;pwd=Rent;";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Image agentImage = new Image();
            agentImage.ImageUrl = dt.Rows[0].ItemArray[8].ToString();
            agentImage.Width = 124;
            agentImage.Height = 165;

            Label lagentTel = new Label();
            lagentTel.Text = "经纪人电话：" + dt.Rows[0].ItemArray[1].ToString();

            Label lagentName = new Label();
            lagentName.Text = "经纪人姓名：" + dt.Rows[0].ItemArray[2].ToString();

            main1.Style.Add("width", "500px");
            main1.Style.Add("height", "165px");
            image1.Controls.Add(agentImage);
            image1.Style.Add("width", "124px");
            image1.Style.Add("height", "165px");
            image1.Style.Add("float", "left");
            agentName1.Controls.Add(lagentName);
            agentName1.Style.Add("padding-bottom", "25px");
            agentPhone1.Controls.Add(lagentTel);
            agentPhone1.Style.Add("float", "left");

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string sql = "select * from agent where agentID='" + Request.QueryString["agentID"].ToString() + "'";
                Agent(sql);
                //string sql1 = "";
            }
        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            string sql1 = "select * from agent where agentID='" + Request.QueryString["agentID"].ToString() + "'";
            if (count % 2 == 0)
            {
                Label1.Visible = true;
                string sql = "select * from house where houseState='未出租' and agentID='" + Request.QueryString["agentID"].ToString() + "'";
                Agenthouse(sql);
            }
            else
            {
                Label1.Visible = false;
            }
            count++;
            Agent(sql1);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("houseXiangXiInfo.aspx");
        }
    }
}