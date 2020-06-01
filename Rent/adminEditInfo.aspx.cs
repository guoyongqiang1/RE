using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Rent
{
    public partial class adminEditInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedItem.Text == "租户")
            {
                Response.Redirect("userxinxi.aspx");
            }
            if (DropDownList1.SelectedItem.Text == "房东")
            {
                Response.Redirect("ownerEditInfo.aspx");
            }
            if (DropDownList1.SelectedItem.Text == "经纪人")
            {
                Response.Redirect("管理员管理.aspx");
            }
            if (DropDownList1.SelectedItem.Text == "添加知识")
            {
                Response.Redirect("adminKnow.aspx");
            }
        }
    }
}