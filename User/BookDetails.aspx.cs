using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
public partial class User_BookDetails : System.Web.UI.Page
{
    static string s = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
    SqlConnection con = new SqlConnection(s);
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter("Select title,author,publisher,price,year,fulldetails,authordetails,f_image from books where title='"+Session["BookName"].ToString()+"'",con);
        da.Fill(ds);
        Label8.Text = ds.Tables[0].Rows[0][0].ToString();
        Label9.Text = ds.Tables[0].Rows[0][1].ToString();
        Label10.Text = ds.Tables[0].Rows[0][2].ToString();
        Label11.Text = ds.Tables[0].Rows[0][3].ToString();
        Label12.Text = ds.Tables[0].Rows[0][4].ToString();
        Label13.Text = ds.Tables[0].Rows[0][5].ToString();
        Label14.Text = ds.Tables[0].Rows[0][6].ToString();
        Image1.ImageUrl = ds.Tables[0].Rows[0][7].ToString();
    }
}
