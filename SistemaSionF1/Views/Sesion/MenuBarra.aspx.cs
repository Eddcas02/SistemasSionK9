﻿using System;
using SistemaSionF1.Controllers;
using SistemaSionF1.Models;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.DirectoryServices;


namespace Login_Web
{
    public partial class Control : System.Web.UI.Page
    {
        Conexion conn = new Conexion();
        Sentencia sn = new Sentencia();
        Logica lg = new Logica();
        Sentencia_seguridad sns = new Sentencia_seguridad();
        ClaseSesion css = new ClaseSesion();
        string abre;
        protected void Page_Load(object sender, EventArgs e)
        {
           
            
            try
            {
                if (Session.IsNewSession)
                {
                    Session.Clear();
                    Session.Abandon();
                    Session.RemoveAll();
                    ScriptManager.RegisterStartupScript(this, GetType(), "error", "alert('Favor ingresar su Usuario y Contraseña');", true);
                    Response.Redirect("MenuBarra.aspx");
                }

                else
                {
                    try
                    {
                        nombreuser.InnerText = Session["Nombre"].ToString();
    


                        abre = Session["sesion_usuario"].ToString();
                        if (css.obtenertoken(abre) != "")
                        {

                            string resultado = abre.Substring(0, 1);
                            string mayus = resultado.ToUpper();
                            abreuser.InnerText = mayus;
                            Button3.Visible = false;
                            //icono.Visible = false;    
                            DataSet ds1 = sns.conultaareaapp(sns.obteneridusuario(abre));
                            RepetirAreas.DataSource = ds1;
                            RepetirAreas.DataBind();
                        }
                        else {
                            Response.Redirect("../../Index.aspx");
                        }

                    }
                    catch (Exception err)
                    {
                     
                        Response.Redirect("../../Index.aspx");
                    }
                }
            }
            catch (Exception err)
            {
                Console.WriteLine("Sesion expirada: " + err.Message);
                Response.Redirect("../../Index.aspx");
            }
        }

        internal void Show()
        {
            throw new NotImplementedException();
        }
        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            //string area;
            
            Repeater r = e.Item.FindControl("repetirapp") as Repeater;
            Label area = (Label)e.Item.FindControl("lblarea");
            DataSet ds2 = sns.consultaappnombre(sns.obteneridusuario(abre), area.Text);
            if (r != null)
            {
                r.DataSource= ds2;
                r.DataBind();
            }
        }

        protected void btnredirigir_Click(object sender, EventArgs e)
        {



            string idc;
            LinkButton btn = (LinkButton)sender;
            RepeaterItem item = (RepeaterItem)btn.NamingContainer;

            idc = ((Label)item.FindControl("idapp")).Text;

            string url = sns.url(idc);
            string texto = abre;
            if (idc == "20")
            {
                Response.Redirect(url + "?codigo=" + Encriptar(texto));

            }
            else
            {
                Response.Redirect(url);

            }



        }
        protected void cerrarsession_Click(object sender, EventArgs e)
        {
            if (Session.IsNewSession)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "error", "alert('Entra If');", true);
            }
            else
            {
                Session.Clear();
                Session.Abandon();
                Session.RemoveAll();
                Response.Redirect("Login.aspx");
            }
        }

        protected void tickets_Click(object sender, EventArgs e)
        {
            Response.Redirect("Tickets.aspx");
        } 
        protected void inicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }

        protected void estadoPatrimonial_Click(object sender, EventArgs e)
        {
            Response.Redirect("EP_InformacionGeneral.aspx");
        }

        protected void areaAdministrativa_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuBarraMantenimientos.aspx");
        }

        protected void seguridad_Click(object sender, EventArgs e)
        {
            Response.Redirect("MantenimientoAreas.aspx");
        }


        public static string Encriptar(string _cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }

    }
}