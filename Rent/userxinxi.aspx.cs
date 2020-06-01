using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class userxinxi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label6.Text = Rent.CommDB.ID;
        Panel1.Visible = false;
        if (!Page.IsPostBack)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select * from users", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            this.GridView1.DataSource = dt;
            this.GridView1.DataKeyNames = new string[] { "userID" };
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
        cmd.CommandText = "delete from users where userID=@userID";
        cmd.Parameters.Add(new SqlParameter ("@userID",GridView1.DataKeys[e.RowIndex].Value.ToString()));
        cmd.ExecuteNonQuery();
        con.Close();
        GridView1.EditIndex = -1;

        SqlConnection con1 = new SqlConnection();
        con1.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
        con1.Open();

        SqlDataAdapter sda = new SqlDataAdapter("select * from users", con1);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        this.GridView1.DataSource = dt;
        this.GridView1.DataKeyNames = new string[] { "userID" };
        this.GridView1.DataBind();
        con1.Close();
    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        SqlConnection con1 = new SqlConnection();
        con1.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
        con1.Open();

        SqlDataAdapter sda = new SqlDataAdapter("select * from users", con1);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        this.GridView1.DataSource = dt;
        this.GridView1.DataKeyNames = new string[] { "userID" };
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
        cmd.CommandText = "update users set userID=@userID,userPwd=@userPwd" +
            ",userName=@userName,userAge=@userAge,userPhone=@userPhone where userID=@oldID";
        cmd.Parameters.Add(new SqlParameter ("@userID", ((TextBox)(GridView1.Rows[e.RowIndex].Cells[0].Controls[0])).Text));
        cmd.Parameters.Add(new SqlParameter("@userPwd", ((TextBox)(GridView1.Rows[e.RowIndex].Cells[1].Controls[0])).Text));
        cmd.Parameters.Add(new SqlParameter("@userName", ((TextBox)(GridView1.Rows[e.RowIndex].Cells[2].Controls[0])).Text));
        cmd.Parameters.Add(new SqlParameter("@userAge", int.Parse(((TextBox)(GridView1.Rows[e.RowIndex].Cells[3].Controls[0])).Text)));
        cmd.Parameters.Add(new SqlParameter("@userPhone", ((TextBox)(GridView1.Rows[e.RowIndex].Cells[4].Controls[0])).Text));
        cmd.Parameters.Add(new SqlParameter("@oldID", GridView1.DataKeys[e.RowIndex].Value.ToString()));
        cmd.ExecuteNonQuery();
        con.Close();
        GridView1.EditIndex = -1;

        SqlConnection con2 = new SqlConnection();
        con2.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
        con2.Open();

        SqlDataAdapter sda = new SqlDataAdapter("select * from users", con2);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        this.GridView1.DataSource = dt;
        this.GridView1.DataKeyNames = new string[] { "userID" };
        this.GridView1.DataBind();
        con2.Close();
    }

    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        SqlConnection con2 = new SqlConnection();
        con2.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
        con2.Open();

        SqlDataAdapter sda = new SqlDataAdapter("select * from users", con2);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        this.GridView1.DataSource = dt;
        this.GridView1.DataKeyNames = new string[] { "userID" };
        this.GridView1.DataBind();
        con2.Close();
    }
    public static int Num = 2;
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Num % 2 == 0)
        {
            Panel1.Visible = true;
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
        }
        else
        {
            Panel1.Visible = false;
        }
        Num++;
        //SqlConnection con = new SqlConnection();
        //con.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
        //con.Open();

        //SqlCommand cmd = new SqlCommand("insert into user values("+GridView1.Rows[]")");

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
            con.Open();

            SqlCommand cmd = new SqlCommand("insert into users values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "'," +int.Parse(TextBox5.Text) + ",'" + TextBox4.Text + "')", con);
            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('新用户添加成功')</script>");
            Panel1.Visible = false;

            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "server=127.0.0.1;database=Rent;uid=Rent;pwd=Rent";
            con1.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select * from users", con1);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            this.GridView1.DataSource = dt;
            this.GridView1.DataKeyNames = new string[] { "userID" };
            this.GridView1.DataBind();
            con1.Close();
        }
        catch
        {

        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("adminEditInfo.aspx");
    }
}