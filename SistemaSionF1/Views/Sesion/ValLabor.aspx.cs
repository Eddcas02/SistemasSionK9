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
    public partial class ValLabor : System.Web.UI.Page
    {
        ControladorLabores CL = new ControladorLabores();
        Conexion conexiongeneral = new Conexion();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LLenarComboFincaL();
            }
        }

        public void LLenarComboFincaL()

        {
            using (SqlConnection sqlCon = new SqlConnection(conexiongeneral.Conectar("SIONSJ3")))
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

        protected void Procesar_Cick(object sender, EventArgs e)
        {
            string val1, val2, val3;
            try
            {
                if (FechaInicialL.Text != "" && FechaFinal.Text != "0" && FincaL.SelectedValue != "0")
                {
                   val1= CL.procedimientoDeshabilita();
                  
                
                    if (val1 == "1") {
                        val2 = CL.actualizaLabores(FechaInicialL, FechaFinal, FincaL);

                        if (val2 == "1")
                        {
                            val3 = CL.procedimientoHabilita();
                            if (val3 == "1")
                            {
                                String script = "alert('Procesado con éxito');";
                                ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);

                            }
                            else {
                                String script = "alert('Error al habilitar');";
                                ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);
                            }
                        }
                        else {

                            String script = "alert('Error al procesar');";
                            ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);
                        }
                    }
                    else
                    {
                        String script = "alert('Error al deshabilitar ');";
                        ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);
                    }
              
                    //FechaInicialL.Text = "";
                    //FechaFinal.Text = "";
                    FincaL.SelectedIndex = 0;
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "error", "alert('Complete todos los campos');", true);
                }
            }
            catch
            {

            }

        }
    }
}