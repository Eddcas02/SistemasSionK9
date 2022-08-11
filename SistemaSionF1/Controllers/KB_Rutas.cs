using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaSionF1.Controllers
{
    public class KB_Rutas
    {
        public string rutaestaticaarchivoshallazgos()
        {
            string rutaestaticaarchivoshallazgos = @"C:\ARCHIVOS_SistemaSionF1LUPANA\SISTEMA_HALLAZGOS\Archivos\";
            return rutaestaticaarchivoshallazgos;
        }
        public string rutaestaticaarchivoscrm()
        {
            string rutaestaticaarchivoscrm = @"C:\ARCHIVOS_SistemaSionF1LUPANA\SISTEMA_CRM\ArchiverodeLeads\";
            return rutaestaticaarchivoscrm;
        }
        public string rutaexpedientes() {

            string rutaestaticaexpedientes = @"C:\ARCHIVOS_SistemaSionF1LUPANA\SISTEMA-EXPEDIENTES\Imagenes\pdfencab.png";
            return rutaestaticaexpedientes;


        }
    }
}