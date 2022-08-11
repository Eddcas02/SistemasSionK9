﻿using System;
using SistemaSionF1.Controllers;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Drawing;
using Image = System.Web.UI.WebControls.Image;

namespace SistemaSionF1.Views.Procesos
{
    public partial class Busqueda : System.Web.UI.Page
    {
        Conexion conexiongeneral = new Conexion();
        Sentencia_proceso sn = new Sentencia_proceso();
        string usuario;
        protected void Page_Load(object sender, EventArgs e)
        {
           

            if (!IsPostBack)
            {
                 usuario = Session["sesion_usuario"] as string;
                string idusuario = sn.obteneridusuario(usuario);
                string tipousuario = sn.tipousuario(idusuario);
                Session["nivel_usuario"] = tipousuario;
                string categoria2 = sn.categoriausuario(idusuario);
                Session["categoria_usuario"] = categoria2;
                string subcategoria = sn.subcategoriausuario(idusuario);
                Session["subcategoria_usuario"] = subcategoria;
                string subcategorianombre = sn.subcategoriausuarionombre(idusuario);

                NombreCategoria.InnerText = Session["nombre_categoria"] as string;
                NombreSubcategoria.InnerText = Session["nombre_subcategoria"] as string;
                string idsubcategoria = Session["id_subcategoria"] as string;
                string categoria = Session["id_categoria"] as string;
                color.InnerText = categoria;
                string iddocumento = Session["id_documento"] as string;
                string nivelusuario = Session["nivel_usuario"] as string;
                string subcategoriausuario = Session["subcategoria_usuario"] as string;
                string categoriausuario = Session["categoria_usuario"] as string;

                if (subcategoriausuario == idsubcategoria)
                {
                    llenarcombonombrenivel3();
                    llenargridviewdocumentosnivel3();
                }
                else if (subcategorianombre != "Ninguna")
                {
                    if(nivelusuario == "1")
                    {
                        llenarcombonombrenivel1();
                        llenargridviewdocumentosnivel1();
                    }
                    else if(nivelusuario == "2")
                    {
                        llenarcombonombrenivel2();
                        llenargridviewdocumentosnivel2();
                    }
                    else if(nivelusuario == "3")
                    {
                        llenarcombonombrenivel3();
                        llenargridviewdocumentosnivel3();
                    }
                }

               
            }
        }

        public void llenarcombonombrenivel1()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    string idsubcategoria = Session["id_subcategoria"] as string;
                    string iddocumento = Session["id_documento"] as string;
                    sqlCon.Open();
                    string query = "SELECT idpro_registro, pro_nombredocumento FROM pro_registro WHERE idpro_subcategoria = '"+idsubcategoria+ "' AND idpro_tipodocumento = '"+iddocumento+"' AND idpro_estado = 1 AND idpro_tipousuario = 1 AND idpro_restriccion = 1 AND idpro_origen = 1";
                    MySqlDataAdapter myCommand = new MySqlDataAdapter(query, sqlCon);
                    DataSet ds = new DataSet();
                    myCommand.Fill(ds);
                    NombreDocumento.DataSource = ds;
                    NombreDocumento.DataTextField = "pro_nombredocumento";
                    NombreDocumento.DataValueField = "idpro_registro";
                    NombreDocumento.DataBind();
                    NombreDocumento.Items.Insert(0, new ListItem("[Seleccione opción]", "0"));
                }
                catch
                {

                }
            }
        }

        public void llenarcombonombrenivel2()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    string idsubcategoria = Session["id_subcategoria"] as string;
                    string iddocumento = Session["id_documento"] as string;
                    sqlCon.Open();
                    string query = "SELECT idpro_registro, pro_nombredocumento FROM pro_registro WHERE idpro_subcategoria = '" + idsubcategoria + "' AND idpro_tipodocumento = '" + iddocumento + "' AND idpro_estado IN (1,2) AND idpro_tipousuario IN (1,2) AND idpro_restriccion = 1 AND idpro_origen IN (1,2)";
                    MySqlDataAdapter myCommand = new MySqlDataAdapter(query, sqlCon);
                    DataSet ds = new DataSet();
                    myCommand.Fill(ds);
                    NombreDocumento.DataSource = ds;
                    NombreDocumento.DataTextField = "pro_nombredocumento";
                    NombreDocumento.DataValueField = "idpro_registro";
                    NombreDocumento.DataBind();
                    NombreDocumento.Items.Insert(0, new ListItem("[Seleccione opción]", "0"));
                }
                catch
                {

                }
            }
        }

        public void llenarcombonombrenivel3()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    string idsubcategoria = Session["id_subcategoria"] as string;
                    string iddocumento = Session["id_documento"] as string;
                    sqlCon.Open();
                    string query = "SELECT idpro_registro, pro_nombredocumento FROM pro_registro WHERE idpro_subcategoria = '" + idsubcategoria + "' AND idpro_tipodocumento = '" + iddocumento + "'";
                    MySqlDataAdapter myCommand = new MySqlDataAdapter(query, sqlCon);
                    DataSet ds = new DataSet();
                    myCommand.Fill(ds);
                    NombreDocumento.DataSource = ds;
                    NombreDocumento.DataTextField = "pro_nombredocumento";
                    NombreDocumento.DataValueField = "idpro_registro";
                    NombreDocumento.DataBind();
                    NombreDocumento.Items.Insert(0, new ListItem("[Seleccione opción]", "0"));
                }
                catch
                {

                }
            }
        }

        protected void documento_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gridViewDocumentos.PageIndex = e.NewPageIndex;
            string usuario = Session["sesion_usuario"] as string;


            string idusuario = sn.obteneridusuario(usuario);
            string idsubcategoria = Session["id_subcategoria"] as string;
            string categoria = Session["id_categoria"] as string;
            string nivelusuario = Session["nivel_usuario"] as string;
            string subcategoriausuario = Session["subcategoria_usuario"] as string;
            string categoriausuario = Session["categoria_usuario"] as string;
            string subcategorianombre = sn.subcategoriausuarionombre(idusuario);


            if (subcategoriausuario == idsubcategoria)
            {
                llenarcombonombrenivel3();
                llenargridviewdocumentosnivel3();
            }
            else if (subcategorianombre != "Ninguna")
            {
                if (nivelusuario == "1")
                {
                    llenarcombonombrenivel1();
                    llenargridviewdocumentosnivel1();
                }
                else if (nivelusuario == "2")
                {
                    llenarcombonombrenivel2();
                    llenargridviewdocumentosnivel2();
                }
                else if (nivelusuario == "3")
                {
                    llenarcombonombrenivel3();
                    llenargridviewdocumentosnivel3();
                }
            }
        }

        protected void OnSelectedIndexChangedDocumento(object sender, EventArgs e)
        {

            try
            {
                string id = Convert.ToString((gridViewDocumentos.SelectedRow.FindControl("lblid") as Label).Text);
                Session["iddocumentoselec"] = id;
                string documentoselec = sn.obtenerrutadocumento(id);

               

                string nombrearchivo = sn.nombrearchivo(id);
                string[] extension = nombrearchivo.Split('.');
                int tamaño = extension.Length;
                string tipo = extension[tamaño - 1];

                string FilePath = Server.MapPath(documentoselec);
             
                WebClient User = new WebClient();
                Byte[] FileBuffer = User.DownloadData(FilePath);
                if (FileBuffer != null)
                {
                    if (tipo.ToLower() == "pdf")
                    {
                        Session["iddocumentoselec"] = id;

                        mp1.Show();

                    }
                    else if (tipo.ToLower() == "tif" || tipo.ToLower() == "tiff")
                    {
                        Response.ContentType = "image/tiff";
                        Response.AddHeader("content-length", FileBuffer.Length.ToString());
                        Response.BinaryWrite(FileBuffer);
                    }
                    else if (tipo.ToLower() == "docx")
                    {
                        Response.ContentType = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
                        Response.AddHeader("content-length", FileBuffer.Length.ToString());
                        Response.BinaryWrite(FileBuffer);
                    }
                    else if (tipo.ToLower() == "xlsx" || tipo.ToLower() == "xls")
                    {

                        string attachment = "attachment; filename=" + extension[0] + ".xlsx";
                        Response.ClearContent();
                        Response.AddHeader("content-disposition", attachment);
                        Response.ContentType = "application/ms-excel";

                        Response.WriteFile(FilePath);

                        Response.End();
                        //Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                        //Response.AddHeader("content-length", FileBuffer.Length.ToString());


                        //Response.BinaryWrite(FileBuffer);
                    }
                    else if (tipo.ToLower() == "png")
                    {
                        Response.ContentType = "image/png";
                        Response.AddHeader("content-length", FileBuffer.Length.ToString());
                        Response.BinaryWrite(FileBuffer);
                    }
                    else if (tipo.ToLower() == "jpeg" || tipo.ToLower() == "jpg")
                    {
                        Response.ContentType = "image/jpeg";
                        Response.AddHeader("content-length", FileBuffer.Length.ToString());
                        Response.BinaryWrite(FileBuffer);
                    }
                }
            }
            catch
            {

            }
        }

        public void llenargridviewdocumentosnivel1()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    string subcategoria = Session["id_subcategoria"] as string;
                    string iddocumento = Session["id_documento"] as string;
                    sqlCon.Open();
                    string query = "SELECT A.idpro_registro AS Id, A.pro_codigo AS Codigo, B.pro_nombretipo AS TipoDocumento, A.pro_nombredocumento AS Nombre, A.pro_version AS Version, C.pro_estadonombre AS Estado, D.pro_origennombre AS Origen FROM pro_registro AS A INNER JOIN pro_tipodocumento AS B ON B.idpro_tipodocumento = A.idpro_tipodocumento INNER JOIN pro_estado AS C "
                                    + "ON C.idpro_estado = A.idpro_estado INNER JOIN pro_origen AS D ON D.idpro_origen = A.idpro_origen INNER JOIN pro_tipousuario AS E ON E.idpro_tipousuario = A.idpro_tipousuario INNER JOIN pro_categoria AS F ON F.idpro_categoria = A.idpro_categoria WHERE A.idpro_subcategoria = '"+ subcategoria + "' AND A.idpro_tipodocumento = '" + iddocumento + "' AND A.idpro_estado = 1 AND A.idpro_tipousuario = 1 AND A.idpro_restriccion = 1 AND A.idpro_origen = 1";
                    MySqlDataAdapter myCommand = new MySqlDataAdapter(query, sqlCon);
                    DataTable dt = new DataTable();
                    myCommand.Fill(dt);
                    gridViewDocumentos.DataSource = dt;
                    gridViewDocumentos.DataBind();
                }
                catch
                {

                }
            }
        }

        public void llenargridviewdocumentosnivel2()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    string subcategoria = Session["id_subcategoria"] as string;
                    string iddocumento = Session["id_documento"] as string;
                    sqlCon.Open();
                    string query = "SELECT A.idpro_registro AS Id, A.pro_codigo AS Codigo, B.pro_nombretipo AS TipoDocumento, A.pro_nombredocumento AS Nombre, A.pro_version AS Version, C.pro_estadonombre AS Estado, D.pro_origennombre AS Origen FROM pro_registro AS A INNER JOIN pro_tipodocumento AS B ON B.idpro_tipodocumento = A.idpro_tipodocumento INNER JOIN pro_estado AS C "
                                    + "ON C.idpro_estado = A.idpro_estado INNER JOIN pro_origen AS D ON D.idpro_origen = A.idpro_origen INNER JOIN pro_tipousuario AS E ON E.idpro_tipousuario = A.idpro_tipousuario INNER JOIN pro_categoria AS F ON F.idpro_categoria = A.idpro_categoria WHERE A.idpro_subcategoria = '" + subcategoria + "' AND A.idpro_tipodocumento = '" + iddocumento + "' AND A.idpro_estado IN (1,2) AND A.idpro_tipousuario IN (1,2) AND A.idpro_restriccion = 1 AND A.idpro_origen IN (1,2)";
                    MySqlDataAdapter myCommand = new MySqlDataAdapter(query, sqlCon);
                    DataTable dt = new DataTable();
                    myCommand.Fill(dt);
                    gridViewDocumentos.DataSource = dt;
                    gridViewDocumentos.DataBind();
                }
                catch
                {

                }
            }
        }

        public void llenargridviewdocumentosnivel3()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    string subcategoria = Session["id_subcategoria"] as string;
                    string iddocumento = Session["id_documento"] as string;
                    sqlCon.Open();
                    string query = "SELECT A.idpro_registro AS Id, A.pro_codigo AS Codigo, B.pro_nombretipo AS TipoDocumento, A.pro_nombredocumento AS Nombre, A.pro_version AS Version, A.pro_fechaaprobacion AS Fecha, C.pro_estadonombre AS Estado, D.pro_origennombre AS Origen, E.pro_nombreusuario AS Usuario, F.pro_nombre AS Categoria, G.pro_nombreres AS Restriccion, H.pro_nombre AS Subcategoria FROM pro_registro AS A"
                                    + " INNER JOIN pro_tipodocumento AS B ON B.idpro_tipodocumento = A.idpro_tipodocumento INNER JOIN pro_estado AS C ON C.idpro_estado = A.idpro_estado INNER JOIN pro_origen AS D ON D.idpro_origen = A.idpro_origen INNER JOIN pro_tipousuario AS E ON E.idpro_tipousuario = A.idpro_tipousuario INNER JOIN pro_categoria AS F"
                                    + " ON F.idpro_categoria = A.idpro_categoria INNER JOIN pro_restriccion AS G ON A.idpro_restriccion = G.idpro_restriccion INNER JOIN pro_subcategoria AS H ON H.idpro_subcategoria = A.idpro_subcategoria WHERE A.idpro_subcategoria = '"+ subcategoria + "' AND A.idpro_tipodocumento = '" + iddocumento + "'";
                    MySqlDataAdapter myCommand = new MySqlDataAdapter(query, sqlCon);
                    DataTable dt = new DataTable();
                    myCommand.Fill(dt);
                    gridViewDocumentos.DataSource = dt;
                    gridViewDocumentos.DataBind();
                }
                catch
                {

                }
            }
        }

        protected void Buscar_Click(object sender, EventArgs e)
        {
            if(NombreDocumento.SelectedValue == "0")
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "error", "alert('Debe seleccionar nombre de documento');", true);
            }
            else
            {
                llenargridviewdocumentosnombre();
            }
        }

        public void llenargridviewdocumentosnombre()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    string subcategoria = Session["id_subcategoria"] as string;

                    string nombredo = sn.nombredoc(subcategoria, NombreDocumento.SelectedValue);
                    sqlCon.Open();
                    string query = "SELECT A.idpro_registro AS Id, A.pro_codigo AS Codigo, B.pro_nombretipo AS TipoDocumento, A.pro_nombredocumento AS Nombre, A.pro_version AS Version, C.pro_estadonombre AS Estado, D.pro_origennombre AS Origen FROM pro_registro AS A INNER JOIN pro_tipodocumento AS B ON B.idpro_tipodocumento = A.idpro_tipodocumento INNER JOIN pro_estado AS C "
                                    + "ON C.idpro_estado = A.idpro_estado INNER JOIN pro_origen AS D ON D.idpro_origen = A.idpro_origen INNER JOIN pro_tipousuario AS E ON E.idpro_tipousuario = A.idpro_tipousuario INNER JOIN pro_categoria AS F ON F.idpro_categoria = A.idpro_categoria WHERE A.idpro_registro = '" + NombreDocumento.SelectedValue + "'";
                    MySqlDataAdapter myCommand = new MySqlDataAdapter(query, sqlCon);
                    DataTable dt = new DataTable();
                    myCommand.Fill(dt);
                    gridViewDocumentos.DataSource = dt;
                    gridViewDocumentos.DataBind();
                }
                catch
                {

                }
            }
        }

        protected void VerTodo_Click(object sender, EventArgs e)
        {
            string usuario = Session["sesion_usuario"] as string;
            string idusuario = sn.obteneridusuario(usuario);
            string idsubcategoria = Session["id_subcategoria"] as string;
            string categoria = Session["id_categoria"] as string;
            string nivelusuario = Session["nivel_usuario"] as string;
            string subcategoriausuario = Session["subcategoria_usuario"] as string;
            string categoriausuario = Session["categoria_usuario"] as string;
            string subcategorianombre = sn.subcategoriausuarionombre(idusuario);


            if (subcategoriausuario == idsubcategoria)
            {
                llenarcombonombrenivel3();
                llenargridviewdocumentosnivel3();
            }
            else if (subcategorianombre != "Ninguna")
            {
                if (nivelusuario == "1")
                {
                    llenarcombonombrenivel1();
                    llenargridviewdocumentosnivel1();
                }
                else if (nivelusuario == "2")
                {
                    llenarcombonombrenivel2();
                    llenargridviewdocumentosnivel2();
                }
                else if (nivelusuario == "3")
                {
                    llenarcombonombrenivel3();
                    llenargridviewdocumentosnivel3();
                }
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
          
        }

        protected void iddoc_Click(object sender, EventArgs e)
        {




            try {

                LinkButton btn = (LinkButton)sender;
                GridViewRow row = (GridViewRow)btn.NamingContainer;
                int i = Convert.ToInt32(row.RowIndex);

                string dato = Convert.ToString((row.FindControl("lblid") as Label).Text);
                Session["iddocumentoselec"] = dato;
                string documentoselec = sn.obtenerrutadocumento(dato);

                string FilePath = Server.MapPath(documentoselec);
                Session["path"] = FilePath;


                mp1.Show();
            }
            catch(Exception es) {

                Console.WriteLine(es.Message);
            }
        
           
        }

        protected void gridViewDocumentos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string id = Convert.ToString((gridViewDocumentos.SelectedRow.FindControl("lblid") as Label).Text);
            Session["iddocumentoselec"] = id;

        }

        protected void gridViewDocumentos_RowDataBound(object sender, GridViewRowEventArgs e)
        {
         

            DataTable permi = new DataTable();
            string[] datos = new string[100];
            int i = 0;
            int j = 0;
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                try {
                     LinkButton lkb = (LinkButton)e.Row.FindControl("iddocdown");
                    LinkButton lkb2 = (LinkButton)e.Row.FindControl("iddoc");
              
                    Image imagenver = (Image)e.Row.FindControl("imgver");
                    Image imgdescargar = (Image)e.Row.FindControl("imgdescarga");
                
                    Image img5 = (Image)e.Row.FindControl("imagenword"); 
                    Image img6 = (Image)e.Row.FindControl("imagenexcel");

                    

                    lkb.Visible = false;
                    lkb2.Visible = false;
                    imagenver.Visible = false;

                    imgdescargar.Visible = false;
                  
                    string iduser = sn.obteneridusuario(usuario);
                    permi = sn.permisosuser(iduser);

                    
                    string _iddocc = DataBinder.Eval(e.Row.DataItem, "id").ToString();

                    string nombrearchivo = sn.nombrearchivo(_iddocc);
                    string[] extension = nombrearchivo.Split('.');
                    int tamaño = extension.Length;
                    string tipo = extension[tamaño - 1];

                    foreach (DataRow row in permi.Rows) {
                     datos[i]= row["permiso"].ToString();

                      
                        i++;
                    }

                
                



                        if (tipo == "pdf")
                        {

                        //centramos el descargar
                        if (datos[0] == "1" && i == 1)
                        {

                            lkb.Visible = true;
                            imgdescargar.Visible = true;
                            imgdescargar.Attributes.Add("style", "display:block; margin:auto");
                            imgdescargar.ImageUrl = "../../Imagenes/filePdf.png";
                        }
                        //dos permisos
                        if (datos[0] == "1" && datos[1] == "2" && i == 2)
                        {
                            lkb.Visible = true;
                            lkb2.Visible = true;

                            imagenver.Visible = true;
                            imgdescargar.Visible = true;
                            imgdescargar.ImageUrl = "../../Imagenes/filePdf.png";

                        }
                        //centramos ver
                        if (datos[0] == "2" && i == 1)
                        {
                            lkb2.Visible = true;
                            imagenver.Visible = true;
                            imagenver.Attributes.Add("style", "display:block; margin:auto");
                          
                        }
                    }
                        if (tipo == "docx")
                        {

                        //centramos el descargar
                        if (datos[0] == "1" && i == 1)
                        {

                            lkb.Visible = true;
                            imgdescargar.Visible = true;
                            imgdescargar.Attributes.Add("style", "display:block; margin:auto");
                            imgdescargar.ImageUrl = "../../Imagenes/fileWord.png";
                        }
                        //dos permisos
                        if (datos[0] == "1" && datos[1] == "2" && i == 2)
                        {
                            lkb.Visible = true;
                            lkb2.Visible = true;

                            imagenver.Visible = true;
                            imgdescargar.Visible = true;
                            imgdescargar.ImageUrl = "../../Imagenes/fileWord.png";

                        }
                        //centramos ver
                        if (datos[0] == "2" && i == 1)
                        {
                            lkb2.Visible = true;
                            imagenver.Visible = true;
                            imagenver.Attributes.Add("style", "display:block; margin:auto");

                        }

                    }
                        if (tipo == "xlsx")
                        {


                        //centramos el descargar
                        if (datos[0] == "1" && i == 1)
                        {

                            lkb.Visible = true;
                            imgdescargar.Visible = true;
                            imgdescargar.Attributes.Add("style", "display:block; margin:auto");
                            imgdescargar.ImageUrl = "../../Imagenes/fileExcel.png";
                        }
                        //dos permisos
                        if (datos[0] == "1" && datos[1] == "2" && i == 2)
                        {
                            lkb.Visible = true;
                            lkb2.Visible = true;

                            imagenver.Visible = true;
                            imgdescargar.Visible = true;
                            imgdescargar.ImageUrl = "../../Imagenes/fileExcel.png";

                        }
                        //centramos ver
                        if (datos[0] == "2" && i == 1)
                        {
                            lkb2.Visible = true;
                            imagenver.Visible = true;
                            imagenver.Attributes.Add("style", "display:block; margin:auto");

                        }
                    }
                        if (tipo == "xls")
                        {

                        //centramos el descargar
                        if (datos[0] == "1" && i == 1)
                        {

                            lkb.Visible = true;
                            imgdescargar.Visible = true;
                            imgdescargar.Attributes.Add("style", "display:block; margin:auto");
                            imgdescargar.ImageUrl = "../../Imagenes/fileExcel.png";
                        }
                        //dos permisos
                        if (datos[0] == "1" && datos[1] == "2" && i == 2)
                        {
                            lkb.Visible = true;
                            lkb2.Visible = true;

                            imagenver.Visible = true;
                            imgdescargar.Visible = true;
                            imgdescargar.ImageUrl = "../../Imagenes/fileExcel.png";

                        }
                        //centramos ver
                        if (datos[0] == "2" && i == 1)
                        {
                            lkb2.Visible = true;
                            imagenver.Visible = true;
                            imagenver.Attributes.Add("style", "display:block; margin:auto");

                        }
                    }
                        if (tipo == "csv")
                        {

                        //centramos el descargar
                        if (datos[0] == "1" && i == 1)
                        {

                            lkb.Visible = true;
                            imgdescargar.Visible = true;
                            imgdescargar.Attributes.Add("style", "display:block; margin:auto");
                            imgdescargar.ImageUrl = "../../Imagenes/filePdf.png";
                        }
                        //dos permisos
                        if (datos[0] == "1" && datos[1] == "2" && i == 2)
                        {
                            lkb.Visible = true;
                            lkb2.Visible = true;

                            imagenver.Visible = true;
                            imgdescargar.Visible = true;
                            imgdescargar.ImageUrl = "../../Imagenes/filePdf.png";

                        }
                        //centramos ver
                        if (datos[0] == "2" && i == 1)
                        {
                            lkb2.Visible = true;
                            imagenver.Visible = true;
                            imagenver.Attributes.Add("style", "display:block; margin:auto");

                        }
                    }


                    




















                }
                catch (Exception es) {
                    Console.WriteLine(es.Message);
                }
              


            }

           
               
            
        }

        protected void iddocdown_Click(object sender, EventArgs e)
        {
            try
            {
                LinkButton btn = (LinkButton)sender;
                GridViewRow row = (GridViewRow)btn.NamingContainer;
                int i = Convert.ToInt32(row.RowIndex);

                string dato = Convert.ToString((row.FindControl("lblid") as Label).Text);
                string documentoselec = sn.obtenerrutadocumento(dato);



                string nombrearchivo = sn.nombrearchivo(dato);
                string[] extension = nombrearchivo.Split('.');
                int tamaño = extension.Length;
                string tipo = extension[tamaño - 1];

                string FilePath = Server.MapPath(documentoselec);
                WebClient User = new WebClient();
                Byte[] FileBuffer = User.DownloadData(FilePath);
                if (FileBuffer != null)
                {
                    if (tipo.ToLower() == "pdf")
                    {
                        string attachment = "attachment; filename=" + extension[0] + ".pdf";
                        Response.ClearContent();
                        Response.AddHeader("content-disposition", attachment);
                        Response.ContentType = "application/pdf";

                        Response.WriteFile(FilePath);

                        Response.End();

                    }
                    else if (tipo.ToLower() == "tif" || tipo.ToLower() == "tiff")
                    {
                        Response.ContentType = "image/tiff";
                        Response.AddHeader("content-length", FileBuffer.Length.ToString());
                        Response.BinaryWrite(FileBuffer);
                    }
                    else if (tipo.ToLower() == "docx")
                    {

                        string attachment = "attachment; filename=" + extension[0] + ".docx";
                        Response.ClearContent();
                        Response.AddHeader("content-disposition", attachment);
                        Response.ContentType = "application/ms-word";

                        Response.WriteFile(FilePath);

                        Response.End();
                        //Response.ContentType = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
                        //Response.AddHeader("content-length", FileBuffer.Length.ToString());
                        //Response.BinaryWrite(FileBuffer);
                    }
                    else if (tipo.ToLower() == "xlsx" || tipo.ToLower() == "xls")
                    {

                        string attachment = "attachment; filename=" + extension[0] + ".xlsx";
                        Response.ClearContent();
                        Response.AddHeader("content-disposition", attachment);
                        Response.ContentType = "application/ms-excel";

                        Response.WriteFile(FilePath);

                        Response.End();
                        //Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                        //Response.AddHeader("content-length", FileBuffer.Length.ToString());


                        //Response.BinaryWrite(FileBuffer);
                    }
                    else if (tipo.ToLower() == "png")
                    {
                        Response.ContentType = "image/png";
                        Response.AddHeader("content-length", FileBuffer.Length.ToString());
                        Response.BinaryWrite(FileBuffer);
                    }
                    else if (tipo.ToLower() == "jpeg" || tipo.ToLower() == "jpg")
                    {
                        Response.ContentType = "image/jpeg";
                        Response.AddHeader("content-length", FileBuffer.Length.ToString());
                        Response.BinaryWrite(FileBuffer);
                    }
                }
            }
            catch
            {

            }
        }
    }
}