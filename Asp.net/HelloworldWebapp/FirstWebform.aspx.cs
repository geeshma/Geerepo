using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloworldWebapp
{
    public partial class FirstWebform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Greet(object sender, EventArgs e)
        {
            //get txtbox value
            string name = txtName.Text;
            //set
            lblmsg.Text = "Hello" + name;

        }
    }
}