﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI.WebControls;
using System.Windows;
using SistemaSionF1.Controllers;

//Modificar las conexiones que dicen dbMarcaje y SIONSJ3 por las de producción que serían dbMarcaje y SION
//CREAR LOS SP DENTRO DE LA BD dbMarcaje
namespace SistemaSionF1.Controllers
{
    public class ControladorMarcaje
    {
        Conexion conexiongeneral = new Conexion();
        Bitacora bit = new Bitacora();
        string validacion;

        public string procedimientoEjecutar(TextBox nFechaInicial=null, DropDownList nEmpresa=null, DropDownList nFinca=null, string usuario = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(conexiongeneral.Conectar("dbMarcaje")))
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
                        bit.bitacoraRMarcaje("SP_TRANSFERENCIA_MARCAJE (" + nFechaInicial.Text+ ", " + nEmpresa.SelectedValue + ", " + nFinca.SelectedValue + ")", usuario);
                    //bit.bitacoraRMarcaje("SP_TRANSFERENCIA_MARCAJE (" + nFechaInicial.Text + ", " + Convert.ToInt32(nEmpresa.SelectedValue) + ", " + Convert.ToInt32(nFinca.SelectedValue) + ")");

                    return validacion = "1";
                    //Console.WriteLine("Proceso Realizado Con Exito");
                   
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Proceso Con Errores", "Proceso",MessageBoxButton.OK,MessageBoxImage.Error);
                    bit.bitacoraRMarcaje("Error al Ejecutar SP_TRANSFERENCIA_MARCAJE", usuario);
                    return validacion = "0";
                }

            }


        }     
}
}