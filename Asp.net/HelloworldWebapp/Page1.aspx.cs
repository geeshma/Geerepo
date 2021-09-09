using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloworldWebapp
{
    public partial class Page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DoIt(object sender, EventArgs e)
        {
            //Query-string is a collection of key-value pairs
            //redirecting to page2
            string name = tb1.Text;
            Response.Redirect("Page2.aspx?uname="+name);
          
        }

      
    }
}