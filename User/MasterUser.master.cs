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
using System.Data.SqlClient;
public partial class MasterPage : System.Web.UI.MasterPage
{
    static string s = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
    SqlConnection con = new SqlConnection(s);
    protected void Page_Load(object sender, EventArgs e)
    {
            if (Session["Username"] == null)
            {
                panelLogin.Visible = true;
                panelWelcome.Visible = false;
                linkLogout.Visible = false;
            }
            else
            {
                labelUsername.Text = Session["Username"].ToString();
                panelLogin.Visible = false;
                panelWelcome.Visible = true;
                linkLogout.Visible = true;
            }
    }
    protected void imageBtnLogin_Click(object sender, ImageClickEventArgs e)
    {
            SqlCommand login = new SqlCommand("select userstatus from login where username='" + textUsername.Text + "' and password='" + textPassword.Text + "'", con);
            con.Open();
            SqlDataReader rdr = login.ExecuteReader();
            rdr.Read();
            if (rdr.HasRows)
            {
                rdr.Close();
                string userstatus=login.ExecuteScalar().ToString();
                Session["Username"] = textUsername.Text;
                if (userstatus == "User")
                {
                    Response.Redirect("~//User//Home.aspx");
                }
                else
                {
                    Response.Redirect("~//Admin//Home.aspx");
                }
            }
            else
            {
                labelLoginError.Visible = true;
                textUsername.Text = "";
            }
            rdr.Close();
            con.Close();
        }
    protected void linkHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("~\\User\\Home.aspx");
    }
      protected void linkAboutus_Click(object sender, EventArgs e)
    {
        Response.Redirect("~\\User\\AboutUs.aspx");
    }
    protected void linkHelp_Click(object sender, EventArgs e)
    {
        Response.Redirect("~\\User\\Help.aspx");
    }
    protected void linkSignup_Click(object sender, EventArgs e)
    {
        Response.Redirect("~\\User\\SignUp.aspx");
    }
    protected void linkAdvancedsearch_Click(object sender, EventArgs e)
    {
        Response.Redirect("~\\User\\AdvancedSearch.aspx");
    }
    protected void linkArtPho_Click(object sender, EventArgs e)
    {
        Session["Category"] = ((LinkButton)sender).Text;
        Response.Redirect("~\\User\\Books.aspx");
    }
    protected void linkMyAccount_Click(object sender, EventArgs e)
    {
        if (Session["Username"] == null)
        {
            Response.Redirect("~\\User\\Login.aspx");
        }
        else
        {
 
        }
    }
    protected void linkMyOrders_Click(object sender, EventArgs e)
    {
        if (Session["Username"] == null)
        {
            Response.Redirect("~\\User\\Login.aspx");
        }
        else
        {

        }
    }
    protected void linkMyCart_Click(object sender, EventArgs e)
    {
        if (Session["Username"] == null)
        {
            Response.Redirect("~\\User\\Login.aspx");
        }
        else
        {

        }
    }

    protected void linkLogout_Click(object sender, EventArgs e)
    {
        Session["Username"] = null;
        Response.Redirect("~\\User\\Home.aspx");
    }
    protected void imageBtnSearch_Click(object sender, ImageClickEventArgs e)
    {
        if (textBookTitle.Text != "")
        {
            Session["BookName"] = textBookTitle.Text;
            Response.Redirect("~//User//BookDetails.aspx");
        }
        else
        {
            Label1.Visible = true;
            Response.Redirect("~//User//Home.aspx");
        }
    }
}
