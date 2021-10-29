using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["session1"] = "Session1 Data";
            Session["session2"] = "Session2 Data";
            Response.Write("Session 1 Data = " + Session[0].ToString());
            Response.Write("<br/>");
            Response.Write("Session 2 Data =" + Session[1].ToString());
            Response.Write("<br/>");
            Response.Write("Session 2 Data = " + Session["Session2"].ToString());


            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                using (SqlConnection Con = new SqlConnection(CS))
                {
                SqlCommand cmd = new SqlCommand("select * from tblemployee",Con);
                Con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Response.Write("<br/>");
                    Response.Write("Id= " + rdr[0].ToString()+"  " );
                    Response.Write("<br/>");
                    Response.Write("Name= " +rdr["Name"].ToString() + "");
                    Response.Write("<br/>");

                }

            }



        }
    }
}