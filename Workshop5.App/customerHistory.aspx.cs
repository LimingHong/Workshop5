using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TravelExpertsClassLib;

namespace Workshop5.App
{
    public partial class customerHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtTotal.Text = CustomerHistoryDB.totHist(105).ToString("c");
        }

        protected void txtTotal_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}