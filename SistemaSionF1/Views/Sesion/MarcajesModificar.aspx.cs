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
    public partial class MarcajesModificar : System.Web.UI.Page
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
            if (FechaInicial.Text == "" || Empresa.SelectedValue == "0" || Finca.SelectedValue == "0")
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "error", "alert('Complete todos los campos');", true);
            }
            else
            {
                llenargridviewcolaboradores();
            }
        }

        public void llenargridviewcolaboradores()
        {
            using (SqlConnection sqlCon = new SqlConnection(conexiongeneral.Conectar("SION")))
            {
                try
                {
                    sqlCon.Open();
                    string query = "select res.IdEmpresa " +
                    ", res.IdColaborador " +
                    ",res.NombreCompleto " +
                    ",res.Fecha " +
                    ",res.Entrada " +
                    ",case when res.salida = res.Entrada then null else res.Salida end 'Salida' " +
                    ",res.Device " +
                    ",case when res.salida = res.Entrada then 'ASP' " +
                    "when res.Entrada is null then 'ASP' " +
                    "when res.Salida is null then 'ASP' " +
                    "when res.Observaciones = 'ASP' then 'Asistencia' " +
                    "else res.Observaciones end 'Observaciones' " +
                    ",case when res.salida = res.Entrada then 'ASP' " +
                    "when res.Entrada is null then 'ASP' " +
                    "when res.Salida is null then 'ASP' " +
                    "when res.Motivo = 'ASP' then 'Asist' " +
                    "else res.Motivo end 'Motivo' " +
                " from( " +
                    "select qb.IdEmpresa " +
                    ", qb.IdColaborador " +
                    ", qb.NombreCompleto " +
                    ", '" + FechaInicial.Text.Replace("-", "") + "' 'Fecha' " +
                    ", (select min(A.EntryTime) from dbMarcaje.dbo.AttnInfo A where A.EmpCode = QB.CodigoColaboradorBiometrico and A.EntryDate = '" + FechaInicial.Text.Replace("-", "") + "' and A.DeviceID in (Select BF.DeviceID from dbMarcaje.dbo.m_BiometricoFinca BF where BF.IdFinca in (1, 2, 3, 4, 5, 6, 7))) " +
                    "'Entrada' " +
                    ",(select max(A.EntryTime) from dbMarcaje.dbo.AttnInfo A where A.EmpCode = QB.CodigoColaboradorBiometrico and A.EntryDate = '" + FechaInicial.Text.Replace("-", "") + "' and A.DeviceID in (Select BF.DeviceID from dbMarcaje.dbo.m_BiometricoFinca BF where BF.IdFinca in(1, 2, 3, 4, 5, 6, 7))) " +
                    "'Salida' " +
                    ", (select Distinct(A.DeviceID) from dbMarcaje.dbo.AttnInfo A where A.EmpCode = QB.CodigoColaboradorBiometrico and A.EntryDate = '" + FechaInicial.Text.Replace("-", "") + "' " +
                    "AND A.EntryTime = (SELECT MIN(B.EntryTime) FROM dbMarcaje.dbo.AttnInfo B WHERE B.EntryDate = '" + FechaInicial.Text.Replace("-", "") + "' AND B.EmpCode = QB.CodigoColaboradorBiometrico)) 'Device' " +
                    ",dbMarcaje.dbo.FEvaluarAsistencia('" + FechaInicial.Text.Replace("-", "") + "', qb.CodigoColaboradorBiometrico, QB.DPI, '" + Finca.SelectedValue + "', 1) 'Observaciones' " +
                    ",dbMarcaje.dbo.FEvaluarAsistencia('" + FechaInicial.Text.Replace("-", "") + "', qb.CodigoColaboradorBiometrico, QB.Dpi, '" + Finca.SelectedValue + "', 0) 'Motivo' " +
                "from( " +
                    "select c.IdColaborador " +
                    ", c.NombreCompleto " +
                    ", c.Dpi " +
                    ", c.CodigoDepartamento " +
                    ", c.Estado " +
                    ", c.IdFinca " +
                    ", c.IdEmpresa " +
                    ", E.CodigoColaboradorBiometrico " +
                "from " +
                    "dbMarcaje.dbo.m_Colaborador C " +
                    "left outer join dbMarcaje.dbo.m_Equivalencia E " +
                    "on " +
                    "c.Dpi = E.dpi " +
                    "where " +
                    "c.IdFinca = '" + Finca.SelectedValue + "' " +
                    "and E.Estado = 0 " +
                    ")QB " +
                ")Res " +
                "where " +
                    "IdColaborador in ( " +
                    "select IdColaborador " +
                    "from " +
                    "dbMarcaje.dbo.m_Colaborador C " +
                    "inner join dbMarcaje.dbo.m_Equivalencia E " +
                    "on " +
                    "c.Dpi = E.dpi " +
                    "and E.Estado = 0 " +
                    //"inner join dbMarcaje.dbo.AttnInfo AI " +
                    //"on AI.EmpCode = E.CodigoColaboradorBiometrico " +
                    //"AND AI.EntryDate = '" + FechaInicial.Text.Replace("-", "") + "' " +
                "where " +
                    "IdEmpresa = '" + Empresa.SelectedValue + "' " +
                    ")";
                    SqlDataAdapter myCommand = new SqlDataAdapter(query, sqlCon);
                    DataTable dt = new DataTable();
                    myCommand.Fill(dt);
                    gridViewColaboradores.DataSource = dt;
                    gridViewColaboradores.DataBind();
                }
                catch
                {

                }
            }
        }

        protected void gridColaboradores_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gridViewColaboradores.EditIndex = -1;
            llenargridviewcolaboradores();
        }


        protected void gridColaboradores_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gridViewColaboradores.EditIndex = e.NewEditIndex;
            llenargridviewcolaboradores();
            //MaintainScrollPositionOnPostBack = true;
        }

        protected void gridColaboradores_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(conexiongeneral.Conectar("SION")))
                {
                    sqlCon.Open();
                    string query = "UPDATE gen_area SET codgenarea=@FirstName,codgensucursal=@Contact,gen_areanombre=@Contact2 WHERE codgenarea = @id";
                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                    sqlCmd.Parameters.AddWithValue("@FirstName", (gridViewColaboradores.Rows[e.RowIndex].FindControl("txtFirstName") as TextBox).Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Contact", (gridViewColaboradores.Rows[e.RowIndex].FindControl("txtContact") as TextBox).Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Contact2", (gridViewColaboradores.Rows[e.RowIndex].FindControl("txtContact2") as TextBox).Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@id", Convert.ToInt32(gridViewColaboradores.DataKeys[e.RowIndex].Value.ToString()));
                    sqlCmd.ExecuteNonQuery();
                    gridViewColaboradores.EditIndex = -1;
                    llenargridviewcolaboradores();
                }
            }
            catch
            {

            }
        }
    }
}