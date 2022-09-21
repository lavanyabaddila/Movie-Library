using System;

namespace filmproject
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void valiadate(object sender, EventArgs e)

        {
            string Uname = txtUname.Text;
            string Pwd = txtPwd.Text;
            if (Uname == "lavanya" && Pwd == "12345")
            {

            }
            else
            {
                lblMsg.Text = "Invaild user";
            }
        }



        protected void txtUname_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Reset(object sender, EventArgs e)
        {
            txtUname.Text = " ";
            txtPwd.Text = " ";
        }
    }
}