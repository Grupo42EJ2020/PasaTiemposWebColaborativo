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
    public class PersonaController : Controller
    {
        //
        // GET: /Persona/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AngelArre98()
        {
            return View();
        }

        public ActionResult Fernando_MG_0202()
        {
            return View();
        }


        public ActionResult RodVillarreal20() { 
        

        return View();
        }

        public ActionResult ErickMedellin()
        {
            return View();
        }

        public ActionResult AguilarCab() 
        {
            return View();
        }
        public ActionResult Keila()
        {
            return View();
        }
        public ActionResult IrvingDeLaGarza() 
        {
            return View();
        }


        public ActionResult DanyJobs()
        {
            return View();
        }


        public ActionResult Yarelilucio()
        {
            return View();
        }

        
        public ActionResult JoaquinFlores()   
            {
            return View();
        }

        public ActionResult Escamilla1010()

        {
            return View();
        }


        public ActionResult MauricioHdz17()
        {
            return View();
        }


        public ActionResult JuanPedraza44()
        {
            return View();
        }


        public ActionResult ArmandoMG0202()
        {
            return View();
        }

        public ActionResult LIIGabriel()

        {
            return View();
        }


        
        public ActionResult FaGoGo()
        {
            DataTable dtVideos;
            dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);

            List<Video> lstVideos = new List<Video>();

            foreach (DataRow item in dtVideos.Rows)
            {
                Video videoAux = new Video();
                videoAux.IdVideo = int.Parse(item["IdVideo"].ToString());
                videoAux.Nombre = item["Nombre"].ToString();
                videoAux.Url = item["Url"].ToString();
                videoAux.FechaPublicacion = DateTime.Parse(item["FechaPublicacion"].ToString());

                lstVideos.Add(videoAux);

            }

            return View();
        }




        public ActionResult StephannieMtz()

        {
            return View();
        }
        public ActionResult PaulinaAcevedo()

        {
            return View();
        }
        public ActionResult monicacevedo()
        {
            return View();
        }

        public ActionResult MaxNarro()
        {
            return View();
        }

        public ActionResult alondrasuarez()
        {
            return View();
        }
        public ActionResult Luis2023()
        {
            return View();
        }
        public ActionResult EliudGonzalez()
        {
            return View();
        }
        public ActionResult Francisco420()
        {
            return View();
        }
        public ActionResult GUSTAVOAZAEL()
        {
            return View();
        }
        public ActionResult zepedaaa()
        {
            return View();
        }

        public ActionResult alfonsso09()
        {
            return View();
        }

        public ActionResult ElCantiner0()
        {
            return View();
        }

        public ActionResult kattyaleal()
        {
            return View();
        }

        public ActionResult CristianGzz()
        {
            return View();
        }
        public ActionResult PacoYee6661()
        {
            return View();
        }

        public ActionResult tellezFlores()
        {
            return View();
        }

        public ActionResult YahirMtz()
        {
            return View();
        }


        public ActionResult Mariscalleal()
        {
            return View();
        }

        public ActionResult KarenCabrera()
        {
            return View();
        }


    }
}
