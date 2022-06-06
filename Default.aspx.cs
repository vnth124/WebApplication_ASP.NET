using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            MySettings Settings = (MySettings)Application["Settings"];
            //LabelDefaultPageText1.Text = Settings.DefaultPageText1;
            try
            {
                string Default = LabelDefaultPageText1.Text;

                if (Session["Default"]?.ToString() == "DefaultPageText1")
                {
                    Session.Remove("Default");
                    Session.Add("Default", "DefaultPageText2");
                    LabelDefaultPageText1.Text = Settings.DefaultPageText2;
                }
                else
                {
                    Session.Remove("Default");
                    Session.Add("Default", "DefaultPageText1");
                    LabelDefaultPageText1.Text = Settings.DefaultPageText1;

                }
            }
            catch (Exception)
            {

            }
        }
    }
}