using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI.WebControls;
using System.Windows;
using SistemaSionF1.Controllers;

//Modificar las conexiones que dicen dbMarcajeQA y SIONSJ3 por las de producción que serían dbMarcaje y SION
//CREAR LOS SP DENTRO DE LA BD dbMarcaje
namespace SistemaSionF1.Controllers
{
    public class ControladorMarcaje
    {
        Conexion conexiongeneral = new Conexion();
        Bitacora bit = new Bitacora();
        public void procedimientoEjecutar(TextBox nFechaInicial=null, DropDownList nEmpresa=null, DropDownList nFinca=null)
        {
            using (SqlConnection sqlCon = new SqlConnection(conexiongeneral.Conectar("dbMarcajeQA")))
            {

                try
                {
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SP_TRANSFERENCIA_MARCAJE";
                        cmd.Parameters.Add("@fechaAsistencia", SqlDbType.DateTime).Value = nFechaInicial.Text;
                        cmd.Parameters.Add("@Empresa", SqlDbType.Int).Value = nEmpresa.SelectedValue;
                        cmd.Parameters.Add("@finca", SqlDbType.Int).Value = nFinca.SelectedValue;
                        cmd.Connection = sqlCon;
                        sqlCon.Open();
                        cmd.ExecuteNonQuery();
                        bit.bitacoraRMarcaje("SP_TRANSFERENCIA_MARCAJE (" + nFechaInicial.Text+ ", " + nEmpresa.SelectedValue + ", " + nFinca.SelectedValue + ")");
                    //bit.bitacoraRMarcaje("SP_TRANSFERENCIA_MARCAJE (" + nFechaInicial.Text + ", " + Convert.ToInt32(nEmpresa.SelectedValue) + ", " + Convert.ToInt32(nFinca.SelectedValue) + ")");

                    MessageBox.Show("Proceso Realizado Con Exito","Proceso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Proceso Con Errores", "Proceso",MessageBoxButton.OK,MessageBoxImage.Error);
                    bit.bitacoraRMarcaje("Error al Ejecutar SP_TRANSFERENCIA_MARCAJE");
                }

            }


        }

        public void MarcajePorColaborador(TextBox nFechaInicial = null, DropDownList nEmpresa = null, DropDownList nFinca = null, Label nColaborador = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(conexiongeneral.Conectar("dbMarcajeQA")))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SP_TRANSFERENCIA_MARCAJE_COLABORADOR";
                    cmd.Parameters.Add("@fechaAsistencia", SqlDbType.DateTime).Value = nFechaInicial.Text;
                    cmd.Parameters.Add("@Empresa", SqlDbType.Int).Value = nEmpresa.SelectedValue;
                    cmd.Parameters.Add("@finca", SqlDbType.Int).Value = nFinca.SelectedValue;
                    cmd.Parameters.Add("@colaborador", SqlDbType.Int).Value = nColaborador.Text;
                    cmd.Connection = sqlCon;
                    sqlCon.Open();
                    cmd.ExecuteNonQuery();
                    bit.bitacoraRMarcaje("SP_TRANSFERENCIA_MARCAJE_COLABORADOR (" + nFechaInicial.Text + ", " + nEmpresa.SelectedValue + ", " + nFinca.SelectedValue + ", "+nColaborador.Text+")");
                    //bit.bitacoraRMarcaje("SP_TRANSFERENCIA_MARCAJE (" + nFechaInicial.Text + ", " + Convert.ToInt32(nEmpresa.SelectedValue) + ", " + Convert.ToInt32(nFinca.SelectedValue) + ")");

                    MessageBox.Show("Proceso Realizado Con Exito", "Proceso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Proceso Con Errores", "Proceso", MessageBoxButton.OK, MessageBoxImage.Error);
                    bit.bitacoraRMarcaje("Error al Ejecutar SP_TRANSFERENCIA_MARCAJE_COLABORADOR");
                }

            }


        }


        public DataTable reportebajas(string fechainicio, string fechafin, string empresa, string finca)
        {
            DataTable dt = new DataTable();

            using (SqlConnection sqlCon = new SqlConnection(conexiongeneral.Conectar("dbMarcajeQA")))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT A.Apellido1 AS PRIMER_APELLIDO, A.Apellido2 AS SEGUNDO_APELLIDO, A.Nombre1 AS PRIMER_NOMBRE, A.Nombre2 AS SEGUNDO_NOMBRE, " +
                                   "A.[Cedula Numero] AS DPI, A.Empresa AS NO_EMPRESA, D.Descripcion AS NOMBRE_EMPRESA, A.Estado AS ESTADO_EMPLEADO, " +
                                   "A.[Fecha Baja Laboral] AS FECHA_BAJA_LABORAL, A.[Fecha Ingreso Laboral] AS FECHA_INGRESO, A.motivo_baja AS MOTIVO_BAJA, A.Puesto AS PUESTO, " +
                                   "B.Estado AS ESTADO_EQUIVALENCIA, B.IdFinca AS NO_FINCA, C.Descripcion AS NOMBRE_FINCA " +
                                   "FROM SION.[dbo].EMPLEADO A " +
                                   "INNER JOIN[dbMarcaje].[dbo].m_Equivalencia B ON B.dpi = A.[Cedula Numero] " +
                                   "INNER JOIN SION.[dbo].FINCA C ON C.Finca = B.IdFinca " +
                                   "INNER JOIN SION.[dbo].Empresa D ON D.Codigo = A.Empresa " +
                                   "WHERE((A.[Fecha Baja Laboral] IS NULL) OR(A.[Fecha Baja Laboral] BETWEEN '"+fechainicio+"' AND '"+fechafin+"')) " +
                                   "AND A.Estado IN(4,3) AND B.Estado = 0 AND A.Empresa = '"+empresa+"' AND B.IdFinca = '"+finca+"'";
                    SqlCommand command = new SqlCommand(query, sqlCon);
                    SqlDataAdapter ds = new SqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }
    }
}