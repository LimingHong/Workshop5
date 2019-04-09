using System;

namespace Workshop5.App
{
    public partial class Service : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["validUser"] == null)
            {
                Response.Redirect("Default.aspx");
            }
        }
    }
}