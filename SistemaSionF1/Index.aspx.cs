﻿using System;
using SistemaSionF1.Models;
using SistemaSionF1.Controllers;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;

using SistemaSionF1.Views.Procesos;


namespace SistemaSionF1
{
    public partial class Index : System.Web.UI.Page
    {
            string nombre,usuario,correo;
        Sentencia sn = new Sentencia();
        Logica lg = new Logica();
        encrip en = new encrip();
        claseComprobadora ccp = new claseComprobadora();
        bitacoragen bit = new bitacoragen();
        Sentencia_proceso sp = new Sentencia_proceso();
        
        protected void Page_Load(object sender, EventArgs e)
        {

          
        }
   
        protected void iniciarsesion_Click(object sender, EventArgs e)
        {
            string user, contra;

            //if (AuthenticateUser(IdUser.Value, PSUser.Value))
            //{
            //    ScriptManager.RegisterStartupScript(this, GetType(), "error", "alert('Si Se Autentifica el Usuario');", true);
            //    Session["sesion_usuario"] = IdUser.Value;
            //    Session["Nombre"] = nombre;
            //    Session["Correo"] = correo;
            //    ScriptManager.RegisterStartupScript(this, GetType(), "error", "alert('Correo: " + Session["Correo"] + "');", true);


            //    //usuario = sn.verificacionUsuario(IdUser.Value);

            //    //if (usuario == "")
            //    //{
            //    //    string sig = lg.siguiente("gen_usuario", "codgenusuario");
            //    //    sn.crearUsuario(sig, "1", IdUser.Value, "@guadapulana.com.gt", "1", "1");
            //    //}

            //    // Response.Redirect("Views/Sesion/Inicio.aspx");

            //    ////if (sn.consultarbd("gen_usuario") == true)
            //    ////{
            //    ////    Response.Redirect("Views/Sesion/MenuBarra.aspx");
            //    ////    //Response.Redirect("Views/Sesion/MenuBarra.aspx");
            //    ////}
            //    ////else
            //    ////{
            //    ////    Response.Write("Sin conexion");
            //    ////    Response.Redirect("Views/PaginaDeError/Error404.aspx");
            //    ////}
            //    Response.Redirect("Views/Sesion/MenuBarra.aspx");


            //}
            //else
            //{
            //    ScriptManager.RegisterStartupScript(this, GetType(), "error", "alert('No se puede autenticar con las credenciales proporcionadas');", true);
            //}

            if (IdUser.Text != "") {

                if (PSUser.Text != "")
                {

                    usuario = sn.usuariosi(IdUser.Text);

                    if (usuario != "")
                    {

                        Session["sesion_usuario"] = IdUser.Text;

                        contra = sn.pass(usuario);
                        if (contra == en.Encrypt(PSUser.Text)) {

                            Session["Nombre"] = sn.nombreuser(IdUser.Text); ;
                            
                            //Response.Redirect("Views/MDIPrincipal/PrincipalMaster.aspx");
                            string bitacora = sp.obtenerbitacora(IdUser.Text);

                            if(bitacora == "" || bitacora == null)
                            {
                                Response.Redirect("CrearContraseña");
                            }
                            else
                            {
                                string randomstring = ccp.cadenarandom();
                                string token = ccp.Encrypt(randomstring);
                                bit.bitacoraing(IdUser.Text, "Inicio de sesion");
                                sn.Insertar("INSERT INTO gen_navegacion ( token,usuario,estado) VALUES ('" + token + "','" + IdUser.Text + "' , 1)");
                                PSUser.Text = "";
                                IdUser.Text = "";
                                Response.Redirect("Views/Sesion/MenuBarra.aspx");
                            }
                        }
                        else
                        {

                            //usuario o contraseña equivocado
                         
                            bit.bitacoraing(IdUser.Text, "Contraseña equivocada");
                            PSUser.Text = "";
                            IdUser.Text = "";
                            String script = "alert('usuario o contraseña equivocados ');";
                            ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);
                        }
                    }
                    else {

                        //usuario o contraseña equivocado
                        bit.bitacoraing(IdUser.Text, "Usuario equivocado");
                        String script = "alert('usuario o contraseña equivocados ');";
                        ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);

                    }
                   

                }
                else {
                    //escribir contrasenia
                    //lblerror.Text = "Escriba la contraseña";
                    //lblerror.Visible = true;
                    String script = "alert('Escriba la contraseña ');";
                    ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);

                }
            }
            else
            { //escribir usuario
                String script = "alert('Escriba el usuario');";
                ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);

            }

           
           
        }

        private bool AuthenticateUser(string userName, string password)
        {
            bool ret = false;
            try
            {
                SearchResultCollection results;
                DirectorySearcher dsearch = null;
                DirectoryEntry de = new DirectoryEntry("LDAP://micoope.local", userName, password);

                dsearch = new DirectorySearcher(de);
                dsearch.PropertiesToLoad.Add("name");
                dsearch.PropertiesToLoad.Add("mail");

                dsearch.Filter = "(&(objectCategory=User)(samaccountname=" + userName + "))";
                //  dsearch.Filter = "(&(objectClass=user)(|(sn=Smith)(givenName=John)))";
                results = dsearch.FindAll();

                foreach (SearchResult sr in results)
                {
                    if ((sr.Properties["name"].Count > 0))
                    {
                        nombre = (sr.Properties["name"][0].ToString());
                        //ScriptManager.RegisterStartupScript(this, GetType(), "error", "alert('"+ (sr.Properties["givenname"][0].ToString()) +"');", true);
                    }
                    if ((sr.Properties["sn"].Count > 0))
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "error", "alert('" + (sr.Properties["sn"][0].ToString()) + "');", true);
                    }

                    ret = true;
                }
            }
            catch
            {
                ret = false;
            }
            return ret;
        }

        private static string GetProperty(SearchResult searchResult,string PropertyName)
        {
            if (searchResult.Properties.Contains(PropertyName))
            {
                return searchResult.Properties[PropertyName][0].ToString();
            }
            else
            {
                return string.Empty;
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void cambiarcontra_Click(object sender, EventArgs e)
        {
            Response.Redirect("CambiarContraseña");
        }
    }
}