using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

public partial class MasterAdmin : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = Session["Username"].ToString();
    }
    protected void linkArtPho_Click(object sender, EventArgs e)
    {
        Session["Category"] = ((LinkButton)sender).Text;
        Response.Redirect("~\\User\\Books.aspx");
    }
    protected void linkLogout_Click(object sender, EventArgs e)
    {
        Session["Username"] = null;
        Response.Redirect("~//User//Home.aspx");
    }
    protected void linkChangepassword_Click(object sender, EventArgs e)
    {
        Response.Redirect("~//Admin//EditAccount.aspx");
    }
}
