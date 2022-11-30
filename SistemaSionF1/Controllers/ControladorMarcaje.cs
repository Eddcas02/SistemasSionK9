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

        public string MarcajePorColaborador(TextBox nFechaInicial = null, DropDownList nEmpresa = null, DropDownList nFinca = null, Label nColaborador = null, string usuario = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(conexiongeneral.Conectar("dbMarcaje")))
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
                    bit.bitacoraRMarcaje("SP_TRANSFERENCIA_MARCAJE_COLABORADOR (" + nFechaInicial.Text + ", " + nEmpresa.SelectedValue + ", " + nFinca.SelectedValue + ", " + nColaborador.Text + ")", usuario);
                    //bit.bitacoraRMarcaje("SP_TRANSFERENCIA_MARCAJE (" + nFechaInicial.Text + ", " + Convert.ToInt32(nEmpresa.SelectedValue) + ", " + Convert.ToInt32(nFinca.SelectedValue) + ")");

                    //MessageBox.Show("Proceso Realizado Con Exito", "Proceso");

                    return validacion = "1";
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Proceso Con Errores", "Proceso", MessageBoxButton.OK, MessageBoxImage.Error);
                    bit.bitacoraRMarcaje("Error al Ejecutar SP_TRANSFERENCIA_MARCAJE_COLABORADOR", usuario);

                    return validacion = "0";
                }

            }


        }

        public string MarcajeParaOtraFecha(TextBox nFechaInicial = null, TextBox nFechaFinal = null, DropDownList nFinca = null, string usuario = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(conexiongeneral.Conectar("dbMarcaje")))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SP_MARCAJES_OTRA_FECHA";
                    cmd.Parameters.Add("@fecha1", SqlDbType.DateTime).Value = nFechaInicial.Text;
                    cmd.Parameters.Add("@fecha2", SqlDbType.DateTime).Value = nFechaFinal.Text;
                    cmd.Parameters.Add("@finca", SqlDbType.Int).Value = nFinca.SelectedValue;
                    cmd.Connection = sqlCon;
                    sqlCon.Open();
                    cmd.ExecuteNonQuery();
                    bit.bitacoraRMarcaje("SP_MARCAJES_OTRA_FECHA (" + nFechaInicial.Text + ", " + nFechaFinal.Text + ", " + nFinca.SelectedValue + ")", usuario);
                    //bit.bitacoraRMarcaje("SP_TRANSFERENCIA_MARCAJE (" + nFechaInicial.Text + ", " + Convert.ToInt32(nEmpresa.SelectedValue) + ", " + Convert.ToInt32(nFinca.SelectedValue) + ")");

                    return validacion = "1";
                    //Console.WriteLine("Proceso Realizado Con Exito");

                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Proceso Con Errores", "Proceso",MessageBoxButton.OK,MessageBoxImage.Error);
                    bit.bitacoraRMarcaje("Error al Ejecutar SP_MARCAJES_OTRA_FECHA", usuario);
                    return validacion = "0";
                }

            }


        }

        public string MaodificarMarcaje(TextBox nFechaInicial = null, DropDownList nEmpresa = null, DropDownList nFinca = null, Label nColaborador = null, Label nColaborador2 = null, TextBox entrada = null, TextBox salida = null, Label bio = null, string usuario = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(conexiongeneral.Conectar("dbMarcaje")))
            {

                try
                {
                    //SqlCommand cmd = new SqlCommand();
                    //cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.CommandText = "SP_TRANSFERENCIA_MARCAJE_COLABORADOR";
                    //cmd.Parameters.Add("@fechaAsistencia", SqlDbType.DateTime).Value = nFechaInicial.Text;
                    //cmd.Parameters.Add("@Empresa", SqlDbType.Int).Value = nEmpresa.SelectedValue;
                    //cmd.Parameters.Add("@finca", SqlDbType.Int).Value = nFinca.SelectedValue;
                    //cmd.Parameters.Add("@colaborador", SqlDbType.Int).Value = nColaborador.Text;
                    //cmd.Connection = sqlCon;
                    //sqlCon.Open();
                    //cmd.ExecuteNonQuery();
                    //bit.bitacoraRMarcaje("SP_TRANSFERENCIA_MARCAJE_COLABORADOR (" + nFechaInicial.Text + ", " + nEmpresa.SelectedValue + ", " + nFinca.SelectedValue + ", " + nColaborador.Text + ")", usuario);
                    string biometrico = "";
                    string query = "";
                    string query2 = "";

                    if (bio.Text == "" || bio.Text == null)
                    {
                        biometrico = obteneridbiometrico(nFinca.SelectedValue);
                    }
                    else
                    {
                        biometrico = bio.Text;
                    }





                    sqlCon.Open();

                    if (entrada.Text == "" || entrada.Text == null)
                    {

                    }
                    else
                    {
                        query = "INSERT INTO AttnInfo(Empcode,EntryDate,EntryTime,DeviceID) values('" + nColaborador.Text + "','" + nFechaInicial.Text.Replace("-", "") + "','" + entrada.Text + "','" + biometrico + "')";
                        SqlCommand myCommand = new SqlCommand(query, sqlCon);
                        myCommand.ExecuteNonQuery();
                        bit.bitacoraRMarcaje("INSERT INTO AttnInfo values('" + nColaborador + "','" + nFechaInicial.Text + "','" + entrada + "','15')", usuario);
                    }


                    if (salida.Text == "" || salida.Text == null)
                    {

                    }
                    else
                    {
                        query2 = "INSERT INTO AttnInfo(Empcode,EntryDate,EntryTime,DeviceID) values('" + nColaborador.Text + "','" + nFechaInicial.Text.Replace("-", "") + "','" + salida.Text + "','" + biometrico + "')";
                        SqlCommand my = new SqlCommand(query2, sqlCon);
                        my.ExecuteNonQuery();
                        bit.bitacoraRMarcaje("INSERT INTO AttnInfo values('" + nColaborador + "','" + nFechaInicial.Text + "','" + salida + "','15')", usuario);

                    }

                    //SqlDataReader reader = myCommand.ExecuteReader();
                    //SqlDataReader reader2 = myCommand2.ExecuteReader();

                    MarcajePorColaborador(nFechaInicial, nEmpresa, nFinca, nColaborador2, usuario);
                    return validacion = "1";
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Proceso Con Errores", "Proceso", MessageBoxButton.OK, MessageBoxImage.Error);
                    bit.bitacoraRMarcaje("Error al insertar marcaje", usuario);

                    return validacion = "0";
                }

            }


        }


        public DataTable reportebajas(string fechainicio, string fechafin, string empresa, string finca)
        {
            DataTable dt = new DataTable();

            using (SqlConnection sqlCon = new SqlConnection(conexiongeneral.Conectar("dbMarcaje")))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT A.Apellido1 AS PRIMER_APELLIDO, A.Apellido2 AS SEGUNDO_APELLIDO, A.Nombre1 AS PRIMER_NOMBRE, A.Nombre2 AS SEGUNDO_NOMBRE,B.CodigoColaboradorBiometrico AS CODIGO_COLABORADOR_BIOMETRICO, " +
                                   "A.[Cedula Numero] AS DPI, A.Empresa AS NO_EMPRESA, D.Descripcion AS NOMBRE_EMPRESA, A.Estado AS ESTADO_EMPLEADO, " +
                                   "A.[Fecha Baja Laboral] AS FECHA_BAJA_LABORAL, A.[Fecha Ingreso Laboral] AS FECHA_INGRESO, A.motivo_baja AS MOTIVO_BAJA, A.Puesto AS PUESTO, " +
                                   "B.Estado AS ESTADO_EQUIVALENCIA, B.IdFinca AS NO_FINCA, C.Descripcion AS NOMBRE_FINCA " +
                                   "FROM SION.[dbo].EMPLEADO A " +
                                   "INNER JOIN[dbMarcaje].[dbo].m_Equivalencia B ON B.dpi = A.[Cedula Numero] " +
                                   "INNER JOIN SION.[dbo].FINCA C ON C.Finca = B.IdFinca " +
                                   "INNER JOIN SION.[dbo].Empresa D ON D.Codigo = A.Empresa " +
                                   "WHERE A.[Fecha Baja Laboral] BETWEEN '" + fechainicio + "' AND '" + fechafin + "' " +
                                   "AND A.Estado IN(3) AND B.Estado = 0 AND A.Empresa = '" + empresa + "' AND B.IdFinca = '" + finca + "'" +
                                   "AND NOT EXISTS (SELECT E.Codigo FROM SION.[dbo].EMPLEADO E WHERE E.[Cedula Numero] = A.[Cedula Numero] AND E.Estado = 1)" +
                                   "ORDER BY A.Apellido1";
                    SqlCommand command = new SqlCommand(query, sqlCon);
                    SqlDataAdapter ds = new SqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }

        public string obteneridbiometrico(string finca)
        {

            using (SqlConnection sqlCon = new SqlConnection(conexiongeneral.Conectar("dbMarcaje")))
            {
                string camporesultante = "";
                try
                {
                    string consultaGraAsis = "SELECT top (1) [DeviceID] FROM [dbMarcaje].[dbo].[m_BiometricoFinca] where IdFinca = " + finca + "";
                    sqlCon.Open();
                    SqlCommand command = new SqlCommand(consultaGraAsis, sqlCon);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex)
                {
                    camporesultante = "0";
                    Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -");
                }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }

        }
    }
}