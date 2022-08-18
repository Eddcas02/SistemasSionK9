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
        string validar, validar2, validar3;
        public string procedimientoDeshabilita()
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
                    return validar = "1";
                }
                catch
                {
                  
                    bit.bitacoraRMarcaje("Error al Ejecutar SP_DISABLELABOR");
                    return validar = "0";
                }
            }
        }

        public string actualizaLabores(TextBox nFechaInicialL = null, TextBox nFechaFinal = null, DropDownList nFincaL = null)
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
                    return validar2 = "1";
                }
                catch (Exception ex)
                {
                   
                    bit.bitacoraRMarcaje("Error al Ejecutar SP_ACTUALIZA_LABORES");
                    return validar = "0";
                }
            }
        }

        public string procedimientoHabilita()
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
                    return validar3 = "1";
                }
                catch
                {
                  
                    bit.bitacoraRMarcaje("Error al Ejecutar SP_ENABLELABOR");
                    return validar3 = "0";
                }
            }
        }
    }
}