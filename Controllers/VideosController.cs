using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data.SqlClient;
using System.Data;
using MVCLaboratorio.Utilerias;
using MVCLaboratorio.Models;


namespace MVCLaboratorio.Controllers
{
    public class VideosController : Controller
    {
        //
        // GET: /Videos/

        public ActionResult Index()
        {
            return View();
        }

        

        public ActionResult LIIGabriel()
        {
            //obtener la informacion de los videos de la BD
            DataTable dtVideos;
            dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);
            List<Video> lstVideos = new List<Video>();
    
            //convertir el DataTable en una listas de video 
            foreach (DataRow item in dtVideos.Rows)
            {
                Video videoAux = new Video();
                videoAux.IdVideo = int.Parse(item["IdVideo"].ToString()); 
                videoAux.Nombre = item["Nombre"].ToString();
                videoAux.Url = item["Url"].ToString();
                videoAux.FechaPublicacion = DateTime.Parse(item["FechaPublicacion"].ToString());

                 lstVideos.Add(videoAux);
               
            }
            return View(lstVideos);
        }

    }
}
