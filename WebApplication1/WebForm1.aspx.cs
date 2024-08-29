using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridData();
        }
        private void GridData()
        {
            SqlConnection con = new SqlConnection("Data Source=SIVA;Initial Catalog=userDB;Integrated Security=True;Trusted_Connection=True");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from userdetails order by UID", con);
            DataSet ds=new DataSet();
            da.Fill(ds);
            grdData.DataSource = ds;
            Msg.Text = "";
        }
        protected void btnSubmit(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = SIVA; Initial Catalog = userDB; Integrated Security = True; Trusted_Connection = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into userDetails values ('"+username.Text+"','"+password.Text+"')", con);
            cmd.ExecuteNonQuery();
            username.Text = "";
            password.Text = "";
            GridData();
            Msg.Text = "Record Inserted";
            con.Close();
        }
        protected void btnClear(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = SIVA; Initial Catalog = userDB; Integrated Security = True; Trusted_Connection = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update userDetails set password='"+password.Text+"' where username='"+username.Text+"'", con);
            cmd.ExecuteNonQuery();
            username.Text = "";
            password.Text = "";
            GridData();
            Msg.Text = "Record Updated";
            con.Close();
        }
        //protected void LoginBtn(object sender, EventArgs e)
        //{
        //    if ((username.Text=="siva") && (password.Text == "123"))
        //    {
        //        Response.Redirect("someone.aspx");
        //    }
        //    else
        //    {
        //        Response.Redirect("fail.aspx");// msg.text="please enter valid username password";
         //                                        //msg.ForeColor=System.Drawing.Color.Red;
        //    }
        //}

    }
}