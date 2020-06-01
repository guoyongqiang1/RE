using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Rent
{
    public partial class TuiChu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Users.userID == "" && Agent.agentTel == "" && Owner.ownerPhone == "" && Admin.adminID == "")
            {
                Response.Redirect("Login-ap.aspx");
            }
            else
            {
                Owner.ownerPhone = "";
                Agent.agentTel = "";
                Users.userID = "";
                Admin.adminID = "";
                Response.Redirect("houseInfo.aspx");
            }
        }
    }
}