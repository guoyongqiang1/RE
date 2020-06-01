using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Rent;
public partial class Outsea : System.Web.UI.Page
{
    public void refresh()
    {
        SqlConnection con1 = new SqlConnection();
        con1.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
        con1.Open();

        SqlDataAdapter sda2 = new SqlDataAdapter("select  houseID, house.houseType, house.houseAdress, " +
            "house.hopePrice,http from house where house.houseCity = '" + this.DropDownList2.SelectedValue + "'", con1);
        DataTable dt2 = new DataTable();
        sda2.Fill(dt2);
        for (int i = 0; i <= dt2.Rows.Count - 1; i++)
        {
            Panel pl1 = new Panel();
            bigBox.Controls.Add(pl1);
            bigBox.Style.Add("position","absolute");
            bigBox.Style.Add("left", "50%");
            Image im = new Image();
            im.ImageUrl = dt2.Rows[i].ItemArray[4].ToString();
            pl1.Controls.Add(im);

            Panel pl2 = new Panel();
            bigBox.Controls.Add(pl2);
            HyperLink hk = new HyperLink();
            hk.Text = dt2.Rows[i].ItemArray[0].ToString();
            CommDB.houseid = dt2.Rows[i].ItemArray[0].ToString();
            hk.NavigateUrl = "house.aspx";
            hk.Font.Underline = false;
            Label lab2 = new Label();
            lab2.Text = "房子类型:" + dt2.Rows[i].ItemArray[1].ToString();

            hk.Style["font-size"] = "43px";
            hk.Style["color"] = "mediumblue";
            hk.Style["text-decoration"] = "underline";

            lab2.Style["font-size"] = "17px";
            lab2.Style["color"] = "black";
            pl2.Controls.Add(hk);
            pl2.Controls.Add(lab2);



            Panel pl3 = new Panel();
            bigBox.Controls.Add(pl3);
            Label lab3 = new Label();
            lab3.Text = "详细地址:" + dt2.Rows[i].ItemArray[2].ToString();
            lab3.Style["font-size"] = "28px";
            lab3.Style["color"] = "black";
            pl3.Controls.Add(lab3);

            Panel pl4 = new Panel();
            bigBox.Controls.Add(pl4);
            Label lab4 = new Label();
            lab4.Text = dt2.Rows[i].ItemArray[3].ToString() + "元/月";
            lab4.Style["font-size"] = "28px";
            lab4.Style["color"] = "red";
            pl4.Controls.Add(lab4);
            //Button btn = new Button();
            //btn.Text = "收藏";
            // pl.Controls.Add(btn);

            im.Style["height"] = "215px";
            im.Style["width"] = "255px";
            //pl1.Style["margin-top"] = "150px";
            pl1.Style["margin-left"] = "0%";
            pl1.Style["height"] = "215px";
            pl1.Style["width"] = "20%";
            pl1.Style["display"] = "block";
            pl1.Style["float"] = "left";

            //pl2.Style[" margin-top"] = "150px";
            pl2.Style["height"] = "70px";
            pl2.Style["width"] = "50%";
            pl2.Style[" float"] = "left";
            pl2.Style["display"] = "inline-block";
            pl2.Style["margin-left"] = "80px";

            pl3.Style["height"] = "70px";
            pl3.Style["width"] = "50%";
            pl3.Style[" float"] = "left";
            pl3.Style["display"] = "inline-block";
            pl3.Style["margin-top"] = "78px";
            pl3.Style["margin-left"] = "78px";

            pl4.Style["height"] = "70px";
            pl4.Style["width"] = "50%";
            pl4.Style[" float"] = "left";
            pl4.Style["display"] = "inline-block";
            pl4.Style["margin-top"] = "-201px";
            pl4.Style["margin-left"] = "691px";
            pl4.Style["position"] = "relative";

            Panel pl5 = new Panel();
            bigBox.Controls.Add(pl5);
            pl5.Controls.Add(pl1);
            pl5.Controls.Add(pl2);
            pl5.Controls.Add(pl3);
            pl5.Controls.Add(pl4);
            pl5.Style["background-color"] = "aliceblue";
            pl5.Style["width"] = "945px";
            pl5.Style["height"] = "215px";
            pl5.Style.Add("margin-left", "-430px");
            pl5.Style["margin-top"] = "83px";
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select distinct houseCountry from house ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            this.DropDownList1.DataSource = dt;
            this.DropDownList1.DataValueField = "houseCountry";
            this.DropDownList1.DataTextField = "houseCountry";
            this.DropDownList1.DataBind();
            con.Close();

            //SqlConnection con1 = new SqlConnection();
            //con1.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
            //con1.Open();

            //SqlDataAdapter sda1 = new SqlDataAdapter("select distinct houseCity from house where houseCountry='俄罗斯'", con1);
            //DataTable dt1 = new DataTable();
            //sda1.Fill(dt1);
            //this.DropDownList2.DataSource = dt1;
            //this.DropDownList1.DataValueField = "houseCity";
            //this.DropDownList2.DataTextField = "houseCity";
            //this.DropDownList2.DataBind();
            //con1.Close();




            SqlConnection con2 = new SqlConnection();
            con2.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
            con2.Open();
            SqlDataAdapter sda3 = new SqlDataAdapter("select houseID, house.houseType, house.houseAdress, " +
                "house.hopePrice ,http from house ", con2);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            for (int i = 0; i <= dt3.Rows.Count - 1; i++)
            {
                Panel pl1 = new Panel();
                bigBox.Controls.Add(pl1);
                Image im = new Image();
                im.ImageUrl = dt3.Rows[i].ItemArray[4].ToString();
                pl1.Controls.Add(im);

                Panel pl2 = new Panel();
                bigBox.Controls.Add(pl2);
                HyperLink hk = new HyperLink();
                hk.Text = dt3.Rows[i].ItemArray[0].ToString();
                CommDB.houseid = dt3.Rows[i].ItemArray[0].ToString();
                hk.NavigateUrl = "house.aspx";
                hk.Font.Underline = false;
                Label lab2 = new Label();
                lab2.Text = "房子类型:" + dt3.Rows[i].ItemArray[1].ToString();

                hk.Style["font-size"] = "43px";
                hk.Style["color"] = "mediumblue";
                hk.Style["text-decoration"] = "underline";

                lab2.Style["font-size"] = "17px";
                lab2.Style["color"] = "black";
                pl2.Controls.Add(hk);
                pl2.Controls.Add(lab2);



                Panel pl3 = new Panel();
                bigBox.Controls.Add(pl3);
                Label lab3 = new Label();
                lab3.Text = "详细地址:" + dt3.Rows[i].ItemArray[2].ToString();
                lab3.Style["font-size"] = "28px";
                lab3.Style["color"] = "black";
                pl3.Controls.Add(lab3);

                Panel pl4 = new Panel();
                bigBox.Controls.Add(pl4);
                Label lab4 = new Label();
                lab4.Text = dt3.Rows[i].ItemArray[3].ToString() + "元/月";
                lab4.Style["font-size"] = "28px";
                lab4.Style["color"] = "red";
                pl4.Controls.Add(lab4);
                //Button btn = new Button();
                //btn.Text = "收藏";
                // pl.Controls.Add(btn);

                im.Style["height"] = "215px";
                im.Style["width"] = "255px";
                //pl1.Style["margin-top"] = "150px";
                pl1.Style["margin-left"] = "0%";
                pl1.Style["height"] = "215px";
                pl1.Style["width"] = "20%";
                pl1.Style["display"] = "block";
                pl1.Style["float"] = "left";

                //pl2.Style[" margin-top"] = "150px";
                pl2.Style["height"] = "70px";
                pl2.Style["width"] = "50%";
                pl2.Style[" float"] = "left";
                pl2.Style["display"] = "inline-block";
                pl2.Style["margin-left"] = "80px";

                pl3.Style["height"] = "70px";
                pl3.Style["width"] = "50%";
                pl3.Style[" float"] = "left";
                pl3.Style["display"] = "inline-block";
                pl3.Style["margin-top"] = "78px";
                pl3.Style["margin-left"] = "78px";

                pl4.Style["height"] = "70px";
                pl4.Style["width"] = "50%";
                pl4.Style[" float"] = "left";
                pl4.Style["display"] = "inline-block";
                pl4.Style["margin-top"] = "-201px";
                pl4.Style["margin-left"] = "691px";
                pl4.Style["position"] = "relative";

                Panel pl5 = new Panel();
                this.Controls.Add(pl5);
                pl5.Controls.Add(pl1);
                pl5.Controls.Add(pl2);
                pl5.Controls.Add(pl3);
                pl5.Controls.Add(pl4);
                pl5.Style["background-color"] = "aliceblue";
                pl5.Style["width"] = "945px";
                pl5.Style["height"] = "215px";
                pl5.Style.Add("margin-left", "210px");
                pl5.Style["margin-top"] = "25px";

            }
        }
    }
     protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
        con.Open();
        string sql = "select distinct houseCity from house where houseCountry ='" + this.DropDownList1.SelectedValue+"'";
        SqlDataAdapter sda1 = new SqlDataAdapter(sql, con);
        DataTable dt1 = new DataTable();
        sda1.Fill(dt1);
        this.DropDownList2.DataSource = dt1;
        this.DropDownList2.DataValueField = "houseCity";
        this.DropDownList2.DataTextField = "houseCity";
        this.DropDownList2.DataBind();
        con.Close();

        Image g1 = new Image();
        g1.ImageUrl = "http://p3.ifengimg.com/haina/2016_37/ccbbafa53d1349e_w1920_h1200.jpg";
        g1.Width = 945;
        g1.Height = 520;
        g1.Style["width"] = "895px";
        g1.Style["height"] = "520px";
        g1.Style["margin-top"] = "-20px";
        g1.Style["margin-left"] = "295px";
        this.Controls.Add(g1);
    }

    protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
    {
        //SqlConnection con = new SqlConnection();
        //con.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
        //con.Open();
        //string s = TreeView1.SelectedValue;
        ////SqlCommand cmd = new SqlCommand("select *  from house where houseCity="+ s, con);
        ////cmd.ExecuteNonQuery();
        //// SqlDataReader sdr = cmd.ExecuteReader() ;
        //SqlCommand cmd = new SqlCommand();
        //cmd.CommandText = "select *  from house where houseCity=" + s;
        //SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);
        //DataTable dt = new DataTable();
        //da.Fill(dt);

        

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("houseInfo.aspx");
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        refresh();
    }
}