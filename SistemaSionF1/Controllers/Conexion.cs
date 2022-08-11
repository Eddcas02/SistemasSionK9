using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaSionF1.Controllers
{
    public class Conexion
    {
        protected MySqlDataAdapter AdaptadorDatos;
        protected MySqlDataReader reader;
        protected DataSet data;

        public string cadenadeconexiongeneral()
        {
            //string connectionString = @"Server=127.0.0.1;Database=bdgestor;Uid=root;";
            string connectionString = @"Server=35.87.163.89;Database=dbgestor;Uid=Ecasasola;Pwd=PasT3stG$;";
            //string connectionString = @"Server=10.60.81.5;Database=bdSistemaSionF1lupana;Uid=User4pDes@rrollo;Pwd=BDK0ntr@PG1;";
            //string connectionString = @"Server=127.0.0.1;Database=dbgestor;Uid=root;Pwd=;";
            return connectionString;
        }
        public string Conectar(string b)
        {
            string connectionString = "Data Source=srv_gsion;Initial Catalog=" + b + ";Persist Security Info = False;User ID=sa;Password=AdminBanabat2011;";
            return connectionString;
        }

        public string Conectar2()
        {
            string connectionString = "Data Source = srv_gsion; Initial Catalog = SIONSJ3; Persist Security Info = False; User ID = sa; Password = AdminBanabat2011;";
            return connectionString;
        }

        public void conectar(string query)
        {
            using (MySqlConnection connection = new MySqlConnection(cadenadeconexiongeneral()))
            {
                try
                {
                    connection.Open();
                    //string insertData = "insert into pruebadatos values ('" + TextBox1.Text + "', '" + TextBox2.Text + "')";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    Console.Write("realizado");
                    connection.Close();

                }
                catch (Exception ex)
                {
                    Console.Write("no realizado" + ex);
                }
                finally { desconectar(); }

            }
        }

        public MySqlConnection conectar()
        {


            MySqlConnection conn = new MySqlConnection(cadenadeconexiongeneral());
            try
            {
                conn.Open();
                Console.WriteLine("se realizo");
                //  conn.Close();



            }
            catch (MySqlException ex)
            {
                Console.WriteLine("No se pudo realizar la conexion", ex);
            }
            finally
            {
                desconectar();
                KillSleepingConnections(5);
            }
            return conn;
        }

        public void conectar2()
        {
            using (MySqlConnection connection = new MySqlConnection(cadenadeconexiongeneral()))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM gen_usuario;";
                    //string insertData = "insert into pruebadatos values ('" + TextBox1.Text + "', '" + TextBox2.Text + "')";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    Console.Write("realizado");
                    connection.Close();

                }
                catch (Exception ex)
                {
                    Console.Write("no realizado" + ex);
                }

            }

        }

        public DataSet Data
        {
            set { data = value; }
            get { return data; }
        }

        public MySqlDataReader DataReader
        {
            set { reader = value; }
            get { return reader; }
        }

        public MySqlConnection desconectar()
        {
            MySqlConnection conn = new MySqlConnection(cadenadeconexiongeneral());
            try
            {
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return conn;
        }
        public void desconexion(MySqlConnection conn)
        {
            try
            {
                conn.Close();
            }
            catch
            {
                Console.WriteLine("No Conectó");
            }
        }
        public int KillSleepingConnections(int iMinSecondsToExpire)
        {
            string strSQL = "show processlist";
            System.Collections.ArrayList m_ProcessesToKill = new ArrayList();

            MySqlConnection myConn = new MySqlConnection(cadenadeconexiongeneral());
            MySqlCommand myCmd = new MySqlCommand(strSQL, myConn);
            MySqlDataReader MyReader = null;

            try
            {
                myConn.Open();

                // Get a list of processes to kill.
                MyReader = myCmd.ExecuteReader();
                while (MyReader.Read())
                {
                    // Find all processes sleeping with a timeout value higher than our threshold.
                    int iPID = Convert.ToInt32(MyReader["Id"].ToString());
                    string strState = MyReader["Command"].ToString();
                    int iTime = Convert.ToInt32(MyReader["Time"].ToString());

                    if (strState == "Sleep" && iTime >= iMinSecondsToExpire && iPID > 0)
                    {
                        // This connection is sitting around doing nothing. Kill it.
                        m_ProcessesToKill.Add(iPID);
                    }
                }

                MyReader.Close();

                foreach (int aPID in m_ProcessesToKill)
                {
                    strSQL = "kill " + aPID;
                    myCmd.CommandText = strSQL;
                    myCmd.ExecuteNonQuery();
                }
            }
            catch (Exception excep)
            {
                Console.WriteLine(excep);
            }
            finally
            {
                if (MyReader != null && !MyReader.IsClosed)
                {
                    MyReader.Close();
                }

                if (myConn != null && myConn.State == System.Data.ConnectionState.Open)
                {
                    myConn.Close();
                }
            }

            return m_ProcessesToKill.Count;
        }

    }
}