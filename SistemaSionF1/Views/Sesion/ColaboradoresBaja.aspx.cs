using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using SistemaSionF1.Controllers;
using Microsoft.Reporting.WebForms;

namespace SistemaSionF1.Views.Sesion
{
    public partial class ColaboradoresBaja : System.Web.UI.Page
    {
        ControladorMarcaje CM = new ControladorMarcaje();
        Conexion conexiongeneral = new Conexion();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LLenarComboEmpresa();
            }
        }

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
            ReporteDocumentos.Reset();
            ReportDataSource fuente = new ReportDataSource("ColaboradoresBajaActivos", obtenerdatos());

            ReporteDocumentos.LocalReport.DataSources.Add(fuente);
            ReporteDocumentos.LocalReport.ReportPath = "Views/Sesion/Reportes/ReporteDeBaja.rdlc";
            ReporteDocumentos.LocalReport.Refresh();
        }

        private DataTable obtenerdatos()
        {
            DataTable dt = new DataTable();
            dt = CM.reportebajas(FechaInicial.Text.Replace("-",""), FechaFinal.Text.Replace("-",""), Empresa.SelectedValue, Finca.SelectedValue);

            return dt;
        }
    }
}