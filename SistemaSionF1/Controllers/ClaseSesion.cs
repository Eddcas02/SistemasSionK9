using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaSionF1.Controllers
{
    public class ClaseSesion
    {
        Conexion conexiongeneral = new Conexion();



       
        public string obtenertoken(string usuario)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = " SELECT token FROM gen_navegacion where usuario  = '" + usuario+"' and estado  = 1";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }











    }
}