using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class MyAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["UserID"]==null)
            {
                Response.Redirect("Default.aspx");
            }
            if (!IsPostBack)
            {
                MySettings Settings = (MySettings)Application["Settings"];
                TextBoxDefaultPageText1.Text = Settings.DefaultPageText1;
                TextBoxDefaultPageText2.Text = Settings.DefaultPageText2;
                TextBoxDefaultPageHeader.Text = Settings.DefaultPageHeaderText;
                TextBoxDefaultPageFooter.Text = Settings.DefaultPageFooterText;
            }

        }

        protected void ButtonSaveSettings_Click(object sender, EventArgs e)
        {
            MySettings Settings = (MySettings)Application["Settings"];
            Settings.DefaultPageText1 = TextBoxDefaultPageText1.Text;
            Settings.DefaultPageText2 = TextBoxDefaultPageText2.Text;
            Settings.DefaultPageHeaderText = TextBoxDefaultPageHeader.Text;
            Settings.DefaultPageFooterText = TextBoxDefaultPageFooter.Text;
            MyManager.SaveSettings(Server.MapPath("~/App_Data/Settings.xml"),Settings);
            Application["Settings"] = Settings;
        }
    }
}