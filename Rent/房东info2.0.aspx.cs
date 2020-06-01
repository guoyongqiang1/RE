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
    public partial class 房东info2__0 : System.Web.UI.Page
    {
        SqlConnection myconn = new SqlConnection();
        SqlCommand mycmd = new SqlCommand();
        string mystr = System.Configuration.ConfigurationManager.ConnectionStrings["myconnstring1"].ToString();
        private void yao()
        {
            string sqlstr = "select * from owner where ownerID='"+Rent.Owner.ownerID +"'";
            myconn = new SqlConnection(mystr);
            SqlDataAdapter sda = new SqlDataAdapter(sqlstr, myconn);
            DataSet myds = new DataSet();
            myconn.Open();
            sda.Fill(myds, "owner");
            this.GridView1.DataSource = myds;
            this.GridView1.DataSourceID = null;
            this.GridView1.DataKeyNames = new string[] { "ownerID" };
            this.GridView1.DataBind();
            myconn.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.yao();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //string ownerID = ((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls [0]).Text .ToString ();
            //string ownername = (GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).ToString();
            //string ownerphone = (GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).ToString();
            //string ownerpas = (GridView1.Rows[e.RowIndex].Cells[4].Controls[0]).ToString();
            myconn = new SqlConnection(mystr);
            string ownername = ((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text.ToString();
            string ownerphone = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text.ToString();
            string ownerpas = ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text.ToString();
            string sqlstr = "update owner set ownerName='" + ownername + "',ownerPhone='" + ownerphone + "',ownerPwd='" + ownerpas + "' where ownerID='"+Rent.Owner.ownerID+"';";
            mycmd = new SqlCommand(sqlstr, myconn);
            myconn.Open();
            mycmd.ExecuteNonQuery();
            myconn.Close();
            GridView1.EditIndex = -1;
            yao();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            yao();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

            GridView1.EditIndex = -1;
            yao();
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowState == (DataControlRowState.Edit | DataControlRowState.Alternate) || e.Row.RowState == DataControlRowState.Edit)
            {
                TextBox tbUpdate;
                for (int i = 0; i < e.Row.Cells.Count; i++)
                {
                    if (e.Row.Cells[i].Controls.Count != 0)
                    {
                        tbUpdate = e.Row.Cells[i].Controls[0] as TextBox;
                        if (i == 0)
                        {
                            if (tbUpdate != null)
                            {
                                tbUpdate.Width = Unit.Pixel(15);
                            }
                        }
                        else if (i == 1)
                        {
                            if (tbUpdate != null)
                            {
                                tbUpdate.Width = Unit.Pixel(70);
                            }
                        }
                        else if (i == 2)
                        {
                            if (tbUpdate != null)
                            {
                                tbUpdate.Width = Unit.Pixel(100);
                            }
                        }
                        else if (i == 3)
                        {
                            if (tbUpdate != null)
                            {
                                tbUpdate.Width = Unit.Pixel(70);
                            }
                        }
                    }
                }
            }
        }
    }
}