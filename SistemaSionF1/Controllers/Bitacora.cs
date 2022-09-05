using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Linq;
using System.Web;

//CREAR LA TABLA BITACORA_MARCAJE EN LA BD SION

namespace SistemaSionF1.Controllers
{
    public class Bitacora
    {
        Conexion conexiongeneral = new Conexion();
        DateTime fechahora = DateTime.Now;
        public void bitacoraRMarcaje( string evento, string usuario)//agregar parametro usuario para la bitacora
        {
            //string area = obtenerarea(userr);
            string ultimobit = obtenerultimo("BITACORA_MARCAJE", "idRegistro");
            string insertbit = "INSERT INTO BITACORA_MARCAJE(idRegistro,FechaProceso,Usuario,AccionRealizada) VALUES ('" + ultimobit + "','"+fechahora+"','"+usuario+"','" + evento + "')";
            executesql(insertbit);

        }

        public void bitacoraValLabor(string evento , string usuario)//agregar parametro usuario para la bitacora
        {
            //string area = obtenerarea(userr);
            string ultimobit = obtenerultimo("BITACORA_MARCAJE", "idRegistro");
            string insertbit = "INSERT INTO BITACORA_MARCAJE(idRegistro,FechaProceso,Usuario,AccionRealizada) VALUES ('" + ultimobit + "','" + fechahora + "', '"+usuario+"','" + evento + "')";
            executesql(insertbit);

        }
        public string obtenerultimo(string tabla, string campo)
        {
            String camporesultante = "";
            using (SqlConnection sqlCon = new SqlConnection(conexiongeneral.Conectar("SION")))
            {
                try
                {
                    sqlCon.Open();
                    string sql = "SELECT MAX(" + campo + ")+1 FROM " + tabla + ";"; //SELECT MAX(idFuncion) FROM `funciones`     
                    SqlCommand command = new SqlCommand(sql, sqlCon);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                    //Console.WriteLine("El resultado es: " + camporesultante);
                    if (String.IsNullOrEmpty(camporesultante))
                        camporesultante = "1";
                }
                catch (Exception)
                {
                    Console.WriteLine(camporesultante);
                }
                return camporesultante;
            }
        }

        public void executesql(string sql)
        {
            using (SqlConnection sqlCon = new SqlConnection(conexiongeneral.Conectar("SION")))
            {

                try
                {
                    sqlCon.Open();
                    SqlCommand command = new SqlCommand(sql, sqlCon);
                    SqlDataReader reader = command.ExecuteReader();
                }
                catch (Exception ex) { 
                    Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

            }
        }

        //public string obtenerarea(string usuario) //cambiar conexion de BD para los usuarios
        //{
        //    String camporesultante = "";
        //    using (SqlConnection sqlCon = new SqlConnection(conexiongeneral.Conectar("SIONSJ3")))
        //    {
        //        try
        //        {
        //            sqlCon.Open();
        //            string sql = "SELECT codarea FROM general_usuarios WHERE usuario = '" + usuario + "'";
        //            SqlCommand command = new SqlCommand(sql, sqlCon);
        //            SqlDataReader reader = command.ExecuteReader();
        //            reader.Read();
        //            camporesultante = reader.GetValue(0).ToString();

        //        }
        //        catch (Exception)
        //        {
        //            Console.WriteLine(camporesultante);
        //        }
        //        return camporesultante;
        //    }

        //}
    }
}