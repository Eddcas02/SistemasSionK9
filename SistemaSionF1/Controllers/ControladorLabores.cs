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
//CREAR LOS SP DENTRO DE LA BD SION
namespace SistemaSionF1.Controllers
{
    public class ControladorLabores
    {
        Conexion conexiongeneral = new Conexion();
        Bitacora bit = new Bitacora();

        public void procedimientoDeshabilita()
        {
            using (SqlConnection sqlCon = new SqlConnection(conexiongeneral.Conectar("SIONSJ3")))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SP_DISABLELABOR";
                    cmd.Connection = sqlCon;
                    sqlCon.Open();
                    cmd.ExecuteNonQuery();
                    //actualizaLabores();
                    bit.bitacoraValLabor("SP_DISABLELABOR (Labor Ingreso Deshabilitado)");
                    //MessageBox.Show("Trigger Deshabilitado Con Exito", "Proceso");
                }
                catch
                {
                    MessageBox.Show("No se pudo deshabilitar trigger", "Proceso", MessageBoxButton.OK, MessageBoxImage.Error);
                    bit.bitacoraRMarcaje("Error al Ejecutar SP_DISABLELABOR");
                }
            }
        }

        public void actualizaLabores(TextBox nFechaInicialL = null, TextBox nFechaFinal = null, DropDownList nFincaL = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(conexiongeneral.Conectar2()))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SP_ACTUALIZA_LABORES";
                    cmd.Parameters.Add("@fechai", SqlDbType.DateTime).Value = nFechaInicialL.Text;
                    cmd.Parameters.Add("@fechaf", SqlDbType.DateTime).Value = nFechaFinal.Text;
                    cmd.Parameters.Add("@finca", SqlDbType.Int).Value = nFincaL.SelectedValue;
                    cmd.Connection = sqlCon;
                    sqlCon.Open();
                    cmd.ExecuteNonQuery();
                    //procedimientoHabilita();
                    bit.bitacoraRMarcaje("SP_ACTUALIZA_LABORES (" + nFechaInicialL.Text + ", " + nFechaFinal.Text + ", " + nFincaL.SelectedValue + ")");
                    //MessageBox.Show("Proceso Realizado Con Exito", "Proceso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ejecutar Actualizar Labores", "Proceso", MessageBoxButton.OK, MessageBoxImage.Error);
                    bit.bitacoraRMarcaje("Error al Ejecutar SP_ACTUALIZA_LABORES");
                }
            }
        }

        public void procedimientoHabilita()
        {
            using (SqlConnection sqlCon = new SqlConnection(conexiongeneral.Conectar("SIONSJ3")))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SP_ENABLELABOR";
                    cmd.Connection = sqlCon;
                    sqlCon.Open();
                    cmd.ExecuteNonQuery();
                    bit.bitacoraValLabor("SP_ENABLELABOR (Labor Ingreso Habilitado)");
                    MessageBox.Show("Proceso Realizado Con Exito", "Proceso");
                }
                catch
                {
                    MessageBox.Show("No se pudo habilitar el trigger", "Proceso", MessageBoxButton.OK, MessageBoxImage.Error);
                    bit.bitacoraRMarcaje("Error al Ejecutar SP_ENABLELABOR");
                }
            }
        }
    }
}