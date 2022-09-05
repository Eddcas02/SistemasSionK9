using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaSionF1.Controllers;
namespace Login_Web
{
    public partial class CerrarSesion : System.Web.UI.Page
    {
        Sentencia sn = new Sentencia();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session.IsNewSession)
            {
               
            }
            else
            {
                sn.update("UPDATE gen_navegacion set estado = 0 where usuario  = '" + Session["sesion_usuario"] + "'");
                Session.Clear();
                Session.Abandon();
                Session.RemoveAll();
                Response.Redirect("../../Index.aspx");
            }
        }
    }
}