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
    public partial class userYiZuHouse : System.Web.UI.Page
    {
        protected void getNews(string sql)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=.;database=Rent;uid=Rent;pwd=Rent;";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Image newImage = new Image();
                newImage.ImageUrl = dt.Rows[i].ItemArray[15].ToString();
                newImage.Width = 230;
                newImage.Height = 180;
                Label newHyperLink = new Label();
                newHyperLink.Text = dt.Rows[i].ItemArray[17].ToString();

                Label la = new Label();
                la.Text = dt.Rows[i].ItemArray[1].ToString() + " | " + dt.Rows[i].ItemArray[2].ToString() + " | " + dt.Rows[i].ItemArray[3].ToString()
                    + " | " + dt.Rows[i].ItemArray[4].ToString()
                    + " | " + dt.Rows[i].ItemArray[5].ToString()
                    + " | " + dt.Rows[i].ItemArray[6].ToString()
                    + " | " + dt.Rows[i].ItemArray[7].ToString();

                Label la1 = new Label();
                la1.Text = dt.Rows[i].ItemArray[9].ToString() + "";
                //la1.Font.Size = 19;  没有效果
                Label la2 = new Label();
                la2.Text = la1.Text + "元/月";
                la2.Font.Size = 14;
                la2.ForeColor = System.Drawing.Color.Red;
                Label la3 = new Label();
                la3.Text = dt.Rows[i].ItemArray[8].ToString() + " · "
                    + dt.Rows[i].ItemArray[10].ToString();

                Label la4 = new Label();
                la4.Text = "您当时的看房时间："+dt.Rows[i].ItemArray[13].ToString();

                HyperLink NonZuLe = new HyperLink();
                NonZuLe.Text="(￢︿￢)不租了(￢︿￢)";
                NonZuLe.NavigateUrl = "InfoTiShiPage.aspx?UhouseID="+dt.Rows[i].ItemArray[0].ToString();

                //样式
                Panel pa = new Panel();
                main.Controls.Add(pa);
                //总的大盒子的样式
                this.main.Style.Add("width", "898px");
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
                right.Style.Add("width", "668px");
                right.Style.Add("height", "180px");
                right.Style.Add("padding", "10px 0px 10px 35px");


                Panel buzu = new Panel();
                right.Controls.Add(buzu);
                buzu.Style.Add("float", "right");
                buzu.Style.Add("text-align", "center");
                buzu.Style.Add("line-height", "180px");
                buzu.Style.Add("width", "145px");
                buzu.Style.Add("height", "100%");
                buzu.Controls.Add(NonZuLe);

                Panel price = new Panel();
                right.Controls.Add(price);
                price.Style.Add("float", "right");
                price.Style.Add("text-align", "center");
                price.Style.Add("line-height", "180px");
                price.Style.Add("width", "90px");
                price.Style.Add("height", "100%");
                price.Style.Add("margin-right", "16px");
                price.Controls.Add(la2);


               // price.Controls.Add(NonZuLe);

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

                Panel timeLooking = new Panel();
                right.Controls.Add(timeLooking);
                right.Style.Add("padding-bottom", "10px");
                timeLooking.Controls.Add(la4);
            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Users.userID=="")
            {
                Response.Redirect("Login-ap.aspx");
            }
            else
            {
                if (!IsPostBack)
                {
                    string sql = "select * from house where UserID='" + Users.userID + "' and houseState='已出租'";
                    getNews(sql);
                }
            }
        }
    }
}