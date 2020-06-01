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
    public partial class houseInfo : System.Web.UI.Page
    {
        protected void getNews(string sql)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent;";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

                Label2.Text = "共找到" + dt.Rows.Count + "套房源";
                
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Image newImage = new Image();
                    newImage.ImageUrl = dt.Rows[i].ItemArray[15].ToString();
                    newImage.Width = 230;
                    newImage.Height = 180;
                    HyperLink newHyperLink = new HyperLink();
                    newHyperLink.Text = dt.Rows[i].ItemArray[17].ToString();
                    
                    //在跳转页面的时候，往页面后面加一个你想要传递的参数和值 ，之后在跳转到的页面上就可以直接调用了
                    newHyperLink.NavigateUrl = "houseXiangXiInfo.aspx?HouseID="+dt.Rows[i].ItemArray[0].ToString();

                    Label la = new Label();
                    la.Text = dt.Rows[i].ItemArray[1].ToString() + " | " + dt.Rows[i].ItemArray[2].ToString() + " | " + dt.Rows[i].ItemArray[3].ToString()
                        + " | " + dt.Rows[i].ItemArray[4].ToString()
                        + " | " + dt.Rows[i].ItemArray[5].ToString()
                        + " | " + dt.Rows[i].ItemArray[6].ToString()
                        + " | " + dt.Rows[i].ItemArray[7].ToString();
                    
                    Label la1 = new Label();
                    la1.Text = dt.Rows[i].ItemArray[9].ToString()+"";
                    //la1.Font.Size = 19;  没有效果
                    Label la2 = new Label();
                    la2.Text = la1.Text + "元/月";
                    la2.Font.Size = 14;
                    la2.ForeColor = System.Drawing.Color.Red;
                    Label la3 = new Label();
                    la3.Text = dt.Rows[i].ItemArray[8].ToString() + " · "
                        + dt.Rows[i].ItemArray[10].ToString();

                    Label la4 = new Label();
                    la4.Text = dt.Rows[i].ItemArray[13].ToString();

                    //样式
                    Panel pa = new Panel();
                    main.Controls.Add(pa);
                    //总的大盒子的样式
                    this.main.Style.Add("width","1064px");
                    this.main.Style.Add("margin-bottom", "25px");
                    this.main.Style.Add("margin-top", "37px");

                    //每一个div的样式
                    pa.Style.Add("height","180px");
                    pa.Style.Add("margin-bottom", "25px");

                    //图片的样式
                    Panel image = new Panel();
                    pa.Controls.Add(image);
                    image.Style.Add("float","left");
                    image.Style.Add("width", "230px");
                    image.Style.Add("height", "180px");
                    image.Controls.Add(newImage);

                    Panel right=new Panel();
                    pa.Controls.Add(right);
                    right.Style.Add("float","right");
                    right.Style.Add("position", "relative");
                    right.Style.Add("width", "807px");
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
                    Htype.Style.Add("padding-bottom","10px");
                    Htype.Controls.Add(la3);

                    Panel Haddress = new Panel();
                    right.Controls.Add(Haddress);
                    Haddress.Style.Add("padding-bottom", "10px");
                    Haddress.Controls.Add(la);

                    Panel timeLooking = new Panel();
                    right.Controls.Add(timeLooking);
                    timeLooking.Style.Add("position", "absolute");
                    timeLooking.Style.Add("bottom", "0");
                    timeLooking.Style.Add("right", "0");
                    timeLooking.Controls.Add(la4);
                }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string sql = "select * from house where houseState ='未出租'";
                getNews(sql);
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "";
            if (DropDownList1.SelectedValue == "默认排序")
            {
                sql = "select * from house where houseState='未出租'";
            }
            if (DropDownList1.SelectedValue == "按升序租金")
            {
                sql = "select * from house where houseState='未出租' order by hopePrice ";
            }
            if (DropDownList1.SelectedValue == "按升序面积")
            {
                sql = "select * from house where houseState='未出租' order by houseArea";
            }
            if (DropDownList1.SelectedValue == "按时间升序最新发布")
            {
                sql = "select * from house where houseState='未出租' order by timeLooking";
            }
            getNews(sql);
        }
    }
}