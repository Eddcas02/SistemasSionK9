using System;
using System.Data;
using MySql.Data.MySqlClient;
using SistemaSionF1.Controllers;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaSionF1
{
    public partial class CambiarContraseña : System.Web.UI.Page
    {
        Sentencia_proceso sn = new Sentencia_proceso();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void iniciarsesion_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index");
        }

        protected void cambiarcontra_Click(object sender, EventArgs e)
        {
            //Response.Redirect("Index");
            string correo2 = sn.compararcorreo(Correo.Text);
            if(Correo.Text == "")
            {
                String script = "alert('Debe ingresar el correo');";
                ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);
            }
            else if (correo2 == "" || correo2 == null)
            {
                String script = "alert('El correo no coincide con el registrado');";
                ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);
            }
            else
            {
                String script = "alert('Se ha enviado un enlace a su correo');";
                ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);
            }
        }

        protected void prueba_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index");
        }
    }
}