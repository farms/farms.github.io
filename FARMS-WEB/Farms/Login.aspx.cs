using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace FARMS_WEB
{
    public partial class Login : System.Web.UI.Page
    {
        private const string PAGINA_INICIAL = "Home";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                bool isAuthenticated = (System.Web.HttpContext.Current.User != null) && System.Web.HttpContext.Current.User.Identity.IsAuthenticated;
                if (isAuthenticated)
                {
                    FormsAuthentication.RedirectFromLoginPage("~/"+PAGINA_INICIAL, true);
                }
                else
                {
                    FormsAuthentication.SignOut();
                }
            }
        }

        protected void Login_Authenticate(object sender, AuthenticateEventArgs e)
        {

            if (Membership.ValidateUser(this.LoginControl.UserName, this.LoginControl.Password))
            {
                if (this.LoginControl.UserName == "admin" && this.LoginControl.Password == "admin")
                {
                    FormsAuthentication.RedirectFromLoginPage("~/"+PAGINA_INICIAL, true);
                }
            }
            else
            {

            }
        }

    }
}