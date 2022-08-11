using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaSionF1.Views.Sesion
{
    public partial class MenuBarraMantenimientos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void MantenimientoVehiculos_Click(object sender, EventArgs e)
        {
            Response.Redirect("MantenimientoVehiculos.aspx");
        }

        protected void mantenimientoMoneda_Click(object sender, EventArgs e)
        {
            Response.Redirect("MantenimientoMoneda.aspx");
        }
    }
}