using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class MyLayout : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                MySettings Settings = (MySettings)Application["Settings"];
                LabelHeader.Text = Settings.DefaultPageHeaderText;
                LabelFooter.Text = Settings.DefaultPageFooterText;
                LabelCounter.Text = " | You Are Visitor No : " + Application["Counter"].ToString();


            }
            catch (Exception)
            {

            }
        }

        protected void BtnHome(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Mylogin.aspx");
        }

        

        protected void BtnContact_Click(object sender, EventArgs e)
        {
            Response.Redirect("Contact.aspx");
        }
    }
}