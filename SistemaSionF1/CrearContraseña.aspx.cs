using System;
using System.Data;
using MySql.Data.MySqlClient;
using SistemaSionF1.Controllers;
using SistemaSionF1.Views.Procesos;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaSionF1
{
    public partial class CrearContraseña : System.Web.UI.Page
    {
        Sentencia_proceso sn = new Sentencia_proceso();
        encrip en = new encrip();
        bitacoragen bit = new bitacoragen();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void iniciarsesion_Click(object sender, EventArgs e)
        {
            string usuario = Session["sesion_usuario"] as string;
            string contraseña = sn.obtenercontraseña(en.Encrypt(ContraseñaAntigua.Text), usuario);
            if(ContraseñaAntigua.Text == "" || ContraseñaNueva.Text == "" || ContraseñaNueva2.Text == "")
            {
                String script = "alert('Complete todos los datos requeridos');";
                ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);
            }
            else if(contraseña == "" || contraseña == null)
            {
                String script = "alert('Contraseña actual incorrecta');";
                ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);
            }
            else if(ContraseñaNueva.Text != ContraseñaNueva2.Text)
            {
                String script = "alert('La contraseña nueva no coincide');";
                ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);
            }
            else
            {
                sn.actualizarcontraseña(en.Encrypt(ContraseñaNueva.Text), usuario);
                bit.bitacoraing(usuario, "Inicio de sesion");
                String script = "alert('Contraseña actualizada correctamente'); window.location.href= 'Index';";
                ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);
            }
        }

        protected void cambiarcontra_Click(object sender, EventArgs e)
        {

        }
    }
}