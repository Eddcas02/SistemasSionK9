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

//Modificar las conexiones que dicen dbMarcajeQA y SIONSJ3 por las de producción que serían dbMarcaje y SION


namespace SistemaSionF1.Views.Sesion
{
    public partial class RMarcaje : System.Web.UI.Page
    {
        ControladorMarcaje CM = new ControladorMarcaje();
        Conexion conexiongeneral = new Conexion();
        ClaseSesion css = new ClaseSesion();
        string abre;
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                abre = Session["sesion_usuario"].ToString();
                if (css.obtenertoken(abre) != "")
                {


                    if (!IsPostBack)
                    {
                        LLenarComboEmpresa();
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

        //llenado de combobox Empresa
        public void LLenarComboEmpresa()

        {
            using (SqlConnection sqlCon = new SqlConnection(conexiongeneral.Conectar("SION")))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT Codigo, Nombre FROM EMPRESA";
                    SqlDataAdapter da = new SqlDataAdapter(query, sqlCon);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    Empresa.DataSource = ds;
                    Empresa.DataTextField = "Nombre";
                    Empresa.DataValueField = "Codigo";
                    Empresa.DataBind();
                    Empresa.Items.Insert(0, new ListItem("[Selecciona una opcion]", "0"));
                }
                catch
                {

                }
            }
        }

        //llenado de combobox Finca dependiendo la elección de la Empresa
        public void LlenarComboFinca(string codigo)
        {
            using (SqlConnection sqlCon = new SqlConnection(conexiongeneral.Conectar2()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT UE.IdFinca,UE.Descripcion,E.Codigo FROM [dbMarcaje].[dbo].[Ubicacion_Empresa] as UE INNER JOIN [SION].[dbo].[EMPRESA] as E ON UE.Empresa = E.Codigo where E.Codigo='" + codigo + "'";
                    SqlDataAdapter da = new SqlDataAdapter(query, sqlCon);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    Finca.DataSource = ds;
                    Finca.DataTextField = "Descripcion";
                    Finca.DataValueField = "IdFinca";
                    Finca.DataBind();
                    Finca.Items.Insert(0, new ListItem("[Selecciona una opcion]", "0"));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

            protected void Empresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarComboFinca(Empresa.SelectedValue);
        }

        protected void Procesar_Cick(object sender, EventArgs e)
        {
            try
            {
                if(FechaInicial.Text!="" && Empresa.SelectedValue!="0" && Finca.SelectedValue!="0")
                {
               string val = CM.procedimientoEjecutar(FechaInicial, Empresa, Finca, abre);

                    if (val=="1") {
                        String script = "alert('Procesado con exito');";
                        ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);
                        Finca.SelectedIndex = 0;
                        Empresa.SelectedIndex = 0;
                    }
                    else {
                        String script = "alert('Error al procesar ');";
                        ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);
                    }
                    //FechaInicial.Text = "";
                   
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