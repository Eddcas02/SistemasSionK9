using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaSionF1.Controllers;
using System.Configuration;

namespace SistemaSionF1.Views.Sesion
{
    public partial class MarcajesOtraFecha : System.Web.UI.Page
    {
        ControladorLabores CL = new ControladorLabores();
        Conexion conexiongeneral = new Conexion();
        ClaseSesion css = new ClaseSesion();
        string abre;
        ControladorMarcaje CM = new ControladorMarcaje();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                abre = Session["sesion_usuario"].ToString();
                if (css.obtenertoken(abre) != "")
                {
                    if (!IsPostBack)
                    {
                        LLenarComboFincaL();
                    }

                }
                else
                {

                    Response.Redirect("../../Index.aspx");

                }

            }
            catch (Exception)
            {

                Response.Redirect("../../Index.aspx");
            }
        }

        protected void Procesar_Cick(object sender, EventArgs e)
        {
            try
            {
                if(FechaInicialL.Text == "" || FechaFinal.Text == "" || FincaL.SelectedValue == "0")
                {
                    String script = "alert('Complete los datos');";
                    ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);
                }
                else
                {
                    string val = CM.MarcajeParaOtraFecha(FechaInicialL, FechaFinal, FincaL, abre);

                    if (val == "1")
                    {
                        String script = "alert('Procesado con exito');";
                        ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);
                        FincaL.SelectedIndex = 0;
                    }
                    else
                    {
                        String script = "alert('Error al procesar ');";
                        ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);
                    }
                }
            }
            catch
            {

            }
        }

        public void LLenarComboFincaL()

        {
            using (SqlConnection sqlCon = new SqlConnection(conexiongeneral.Conectar("SION")))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT Codigo, Descripcion FROM UBICACION where codigo > 0 ORDER BY Codigo ASC";
                    SqlDataAdapter da = new SqlDataAdapter(query, sqlCon);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    FincaL.DataSource = ds;
                    FincaL.DataTextField = "Descripcion";
                    FincaL.DataValueField = "Codigo";
                    FincaL.DataBind();
                    FincaL.Items.Insert(0, new ListItem("[Selecciona una opcion]", "0"));
                }
                catch
                {

                }
            }
        }

    }
}