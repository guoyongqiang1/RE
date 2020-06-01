using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Application["chats"] != null)
                TextBox3.Text = Application["chats"].ToString();

        }
        protected void Application_Start(object sender, EventArgs e)
        {
            Application["chats"] = null;
            Application["chatnum"] = null;
        }
        protected void Application_End(object sender, EventArgs e)
        {
            Application["chats"] = null;
            Application["chatnum"] = null;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int num;
            if (TextBox1.Text != "" && TextBox2.Text != "")
            {
                Application.Lock();
                if (Application["chatnum"] == null)
                    num = 0;
                else
                    num = int.Parse(Application["chatnum"].ToString());
                if (num % 1 == 0)
                {
                    Application["chats"] = TextBox1.Text + "说：" + TextBox2.Text + "[" + DateTime.Now.ToString() + "].\n" + Application["chats"];

                }
                else
                    Application["chats"] = TextBox1.Text + "说：" + TextBox2.Text + ".\n" + Application["chats"];
                num++;
                object obj = num;
                Application["chatnum"] = obj;
                Application.UnLock();
                TextBox3.Text = Application["chats"].ToString();

            }
            else
                Response.Write("<script>alert('必须输入姓名和聊天内容')</script>");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "")
            {
                TextBox3.Text = Application["chats"].ToString();
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("主页面.aspx");
        }

    }
}