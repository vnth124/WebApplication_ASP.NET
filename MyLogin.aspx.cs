using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class MyLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void ButtonLogin_Click1(object sender, EventArgs e)
        {
            string UserName = WebConfigurationManager.AppSettings["PFUserName"];
            string Password = WebConfigurationManager.AppSettings["PFPassword"];
            if (TextBoxEmail.Text == UserName && TextBoxPassword.Text == Password)
            {
                Session.Add("UserID", UserName);
                Response.Redirect("MyAdmin.aspx");
            }
            else
            {
                LabelMessage.Text = " !!! Please Enter Valid User Name and Password";
            }
        }
    }
}