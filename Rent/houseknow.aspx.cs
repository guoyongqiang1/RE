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
    public partial class houseknow : System.Web.UI.Page
    {
        protected void getKnow()
        {
            Panel p1 = new Panel();
            bigBox.Controls.Add(p1);
            p1.Style["float"] = "left";
            p1.Style["margin-top"] = "150px";
            p1.Style["margin-left"] = "165px";
            p1.Style["width"] = "115px";
            p1.Style["background-color"] = "aliceblue";
            p1.Style["display"] = "block";
            p1.Style["border-radius"] = "5px";
            //p1.Style[""] = "";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select * from know ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                HyperLink hk = new HyperLink();
                hk.Text = dt.Rows[i].ItemArray[1].ToString();
                hk.NavigateUrl = dt.Rows[i].ItemArray[3].ToString();
                hk.Style["margin-left"] = "25px";
                hk.Style["margin-top"] = "25px";
                hk.Style["font-size"] = "16px";
                hk.Style["color"] = "black";
                hk.Style["text-decoration"] = "none";
                //hk.Style[""] = "";
                p1.Controls.Add(hk);
            }



            SqlDataAdapter sda1 = new SqlDataAdapter("select * from know ", con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            for (int i = 0; i <= dt1.Rows.Count - 1; i++)
            {
                Panel p2 = new Panel();
                bigBox.Controls.Add(p2);
                p2.Style["float"] = "left";
                p2.Style["margin-top"] = "5px";
                p2.Style["margin-left"] = "229px";
                p2.Style["width"] = "607px";
                //p2.Style["background-color"] = "yellow";
                p2.Style["display"] = "block";

                Panel p3 = new Panel();
                bigBox.Controls.Add(p3);
                p3.Style["float"] = "left";
                p3.Style["margin-top"] = "23px";
                p3.Style["margin-left"] = "228px";
                p3.Style["width"] = "670px";
                //p3.Style["background-color"] = "pink";
                p3.Style["display"] = "block";
                p3.Style["height"] = "80px";
                p3.Style["overflow"] = "hidden";

                Panel p4 = new Panel();
                bigBox.Controls.Add(p4);
                p4.Style["float"] = "left";
                p4.Style["margin-top"] = "100px";
                p4.Style["margin-left"] = "-673px";
                p4.Style["width"] = "470px";
                //p4.Style["background-color"] = "green";
                p4.Style["display"] = "block";

                Panel p5 = new Panel();
                bigBox.Controls.Add(p5);
                p5.Style["float"] = "left";
                p5.Style["margin-top"] = "-147px";
                p5.Style["margin-left"] = "4px";
                p5.Style["width"] = "73px";
                p5.Style["heigth"] = "75px";
                p5.Style["display"] = "block";
                //p5.Style["position"] = "absoulute";

                HyperLink hk1 = new HyperLink();
                hk1.Text = dt1.Rows[i].ItemArray[0].ToString();
                hk1.NavigateUrl = dt1.Rows[i].ItemArray[3].ToString();

                hk1.Style["font-size"] = "28px";
                hk1.Style["color"] = "blueviolet";
                hk1.Style["text-decoration"] = "none";
                //hk.Style[""] = "";
                p2.Controls.Add(hk1);

                Label ab1 = new Label();
                ab1.Text = dt1.Rows[i].ItemArray[2].ToString();
                p3.Controls.Add(ab1);
                ab1.Style["font-size"] = "20px";
                ab1.Style["color"] = "black";


                Label ab2 = new Label();
                ab2.Text = dt1.Rows[i].ItemArray[1].ToString();
                p4.Controls.Add(ab2);
                ab2.Style["font-size"] = "15px";
                ab2.Style["color"] = "coral";

                Image im = new Image();
                im.ImageUrl = "picts/tu.jpg";
                p5.Controls.Add(im);
                im.Style["width"] = "200px";
                im.Style["height"] = "160px";
                im.Style.Add("padding-top","0px");

                Panel p6 = new Panel();

                p6.Controls.Add(p2);
                p6.Controls.Add(p3);
                p6.Controls.Add(p4);
                p6.Controls.Add(p5);
                this.Controls.Add(p6);



                //p6.Controls.Add(p5);
                p6.Style["width"] = "60%";
                p6.Style["height"] = "165px";
                p6.Style["background-color"] = "aliceblue";
                p6.Style["position"] = "relative";
                p6.Style["margin-top"] = "30px";
                p6.Style["margin-left"] = "400px";
                p6.Style["top"] = "58px";
                // p6.Style["border-color"] = "aliceblue";
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            getKnow();
        }
    }
}