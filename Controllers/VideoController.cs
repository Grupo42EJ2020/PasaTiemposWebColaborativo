﻿using System;
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
    public class VideoController : Controller
    {
        //
        // GET: /Video/

        public ActionResult Index()
        {
            return View();
        }

        //Muestra la lista de Videos
        public ActionResult LIIGabriel()
        {
            //obtener la info de los videos de la BD
            DataTable dtVideos;
            dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);

            List<Video> lstVideos = new List<Video>();

            //convertir el DataTable a una lista de videos List<Video>
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

        //Metodo para borrar un video
        public ActionResult LIIGabrielDelete(int id)
        {
            //obtener los datos del video para mostrarlo al usuario antes de borrarlo
            DataTable dtVideo;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorID", CommandType.StoredProcedure, parametros);

            //convertir el dtVideo a un objeto Video
            Video datosVideo = new Video();

            if (dtVideo.Rows.Count > 0) //si lo encontro
            {
                datosVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                datosVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                datosVideo.Url = dtVideo.Rows[0]["Url"].ToString();
                datosVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());

                return View(datosVideo);
            }
            else
            { //no lo encontro 
                return View("Error");
            }
        }

        [HttpPost]
        public ActionResult LIIGabrielDelete(int id, FormCollection datos)
        {
            //realizar el delete del registro
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            BaseHelper.ejecutarSentencia("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);

            return RedirectToAction("LIIGabriel");
        }

        public ActionResult LIIGabrielDetails(int id) {
            //obtener la info del video
            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@IdVideo",id ));
            DataTable dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorID", CommandType.StoredProcedure, parametros);

            Video infoVideo = new Video();

            if (dtVideo.Rows.Count > 0) //lo encontro
            {
                infoVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                infoVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                infoVideo.Url = dtVideo.Rows[0]["Url"].ToString();
                infoVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());

                return View(infoVideo);
            }
            else {  //no lo encontro 
                return View("Error");    
            }
        }

        public ActionResult LIIGabrielEdit(int id ) {
            //obtener la info del video
            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@IdVideo", id));
            DataTable dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorID", CommandType.StoredProcedure, parametros);

            Video infoVideo = new Video();

            if (dtVideo.Rows.Count > 0) //lo encontro
            {
                infoVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                infoVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                infoVideo.Url = dtVideo.Rows[0]["Url"].ToString();
                infoVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());

                return View(infoVideo);
            }
            else
            {  //no lo encontro 
                return View("Error");
            }
        }


        [HttpPost]
        public ActionResult LIIGabrielEdit(int id) {

            return View();
        }



        //Metodo de alfonsso09
        public ActionResult alfonsso09()
        {
            //obtener la info de los videos de la BD
            DataTable dtVideos;
            dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);

            List<Video> lstVideos = new List<Video>();

            //convertir el DataTable a una lista de videos List<Video>
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

        //metodo borrar un video alfonsso09
        public ActionResult alfonsso09Delete(int id)
        {
            //obtener los datos del video para mostrarlo al usuario antes de borrarlo
            DataTable dtVideo;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorID", CommandType.StoredProcedure, parametros);

            //convertir el dtVideo a un objeto Video
            Video datosVideo = new Video();

            if (dtVideo.Rows.Count > 0) //si lo encontro
            {
                datosVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                datosVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                datosVideo.Url = dtVideo.Rows[0]["Url"].ToString();
                datosVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());

                return View(datosVideo);
            }
            else
            { //no lo encontro 
                return View("Error");
            }

        }

        [HttpPost]
        public ActionResult alfonsso09Delete(int id, FormCollection datos)
        {
            //realizar el delete del registro
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            BaseHelper.ejecutarSentencia("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);

            return RedirectToAction("alfonsso09");
        }

        public ActionResult AngelArre98()
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

            return View(lstVideos);
        }

        public ActionResult ArmandoMG0202()
        {
            //obtener la info de los videos de la BD
            DataTable dtVideos;
            dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);

            List<Video> lstVideos = new List<Video>();

            //convertir el DataTable a una lista de videos List<Video>

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
        //Metodo para borrar un video
        public ActionResult ArmandoMG0202Delete(int id)
        {
            //obtener los datos del video para mostrarlo al usuario antes de borrarlo
            DataTable dtVideo;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorID", CommandType.StoredProcedure, parametros);

            //convertir el dtVideo a un objeto Video
            Video datosVideo = new Video();

            if (dtVideo.Rows.Count > 0) //si lo encontro
            {
                datosVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                datosVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                datosVideo.Url = dtVideo.Rows[0]["Url"].ToString();
                datosVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());

                return View(datosVideo);
            }
            else
            { //no lo encontro 
                return View("Error");
            }
        }

        [HttpPost]
        public ActionResult ArmandoMG0202Delete(int id, FormCollection datos)
        {
            //realizar el delete del registro
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            BaseHelper.ejecutarSentencia("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);

            return RedirectToAction("ArmandoMG0202");
        }
        public ActionResult Fernando_MG_0202()
        {
            //obtener la info de los videos de la BD
            DataTable dtVideos;
            dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);

            List<Video> lstVideos = new List<Video>();

            //convertir el DataTable a una lista de videos List<Video>
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
        //Metodo para borrar un video
        public ActionResult Fernando_MG_0202Delete(int id)
        {
            //obtener los datos del video para mostrarlo al usuario antes de borrarlo
            DataTable dtVideo;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorID", CommandType.StoredProcedure, parametros);

            //convertir el dtVideo a un objeto Video
            Video datosVideo = new Video();

            if (dtVideo.Rows.Count > 0) //si lo encontro
            {
                datosVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                datosVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                datosVideo.Url = dtVideo.Rows[0]["Url"].ToString();
                datosVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());

                return View(datosVideo);
            }
            else
            { //no lo encontro 
                return View("Error");
            }
        }

        [HttpPost]
        public ActionResult Fernando_MG_0202Delete(int id, FormCollection datos)
        {
            //realizar el delete del registro
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            BaseHelper.ejecutarSentencia("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);

            return RedirectToAction("Fernando_MG_0202");
        }

        public ActionResult DanyJobs()
        {
            //obtener la info de los videos de la BD
            DataTable dtVideos;
            dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);

            List<Video> lstVideos = new List<Video>();

            //convertir el DataTable a una lista de videos List<Video>
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

        //Metodo para borrar un video
        public ActionResult DanyJobsDelete(int id)
        {
            //obtener los datos del video para mostrarlo al usuario antes de borrarlo
            DataTable dtVideo;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorID", CommandType.StoredProcedure, parametros);

            //convertir el dtVideo a un objeto Video
            Video datosVideo = new Video();

            if (dtVideo.Rows.Count > 0) //si lo encontro
            {
                datosVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                datosVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                datosVideo.Url = dtVideo.Rows[0]["Url"].ToString();
                datosVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());

                return View(datosVideo);
            }
            else
            { //no lo encontro 
                return View("Error");
            }
        }

        [HttpPost]
        public ActionResult DanyJobsDelete(int id, FormCollection datos)
        {
            //realizar el delete del registro
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            BaseHelper.ejecutarSentencia("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);

            return RedirectToAction("DanyJobs");
        }
        public ActionResult DanyJobsCreate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DanyJobsCreate(string Nombre, string Url, DateTime FechaPublicacion)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@Nombre", Nombre));
            parametros.Add(new SqlParameter("@Url", Url));
            parametros.Add(new SqlParameter("@FechaPublicacion", FechaPublicacion));
            BaseHelper.ejecutarSentencia("sp_Video_Insertar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("DanyJobs");
        }

        public ActionResult IrvingDeLaGarza()
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

            return View(lstVideos);
        }

        //Metodo para borrar un video
        public ActionResult IrvingDeLaGarzaDelete(int id)
        {
            //obtener los datos del video para mostrarlo al usuario antes de borrarlo
            DataTable dtVideo;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorID", CommandType.StoredProcedure, parametros);

            //convertir el dtVideo a un objeto Video
            Video datosVideo = new Video();

            if (dtVideo.Rows.Count > 0) //si lo encontro
            {
                datosVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                datosVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                datosVideo.Url = dtVideo.Rows[0]["Url"].ToString();
                datosVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());

                return View(datosVideo);
            }
            else
            { //no lo encontro 
                return View("Error");
            }
        }
        [HttpPost]
        public ActionResult IrvingDeLaGarzaDelete(int id, FormCollection datos)
        {
            //realizar el delete del registro
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            BaseHelper.ejecutarSentencia("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);

            return RedirectToAction("IrvingDeLaGarza");
        }



        //Mio
        public ActionResult Francisco420()
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

            return View(lstVideos);
        }

        //Borrar video
        public ActionResult Francisco420Delete(int id)
        {
            //obtener los datos del video para mostrarlo al usuario antes de borrarlo
            DataTable dtVideo;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorID", CommandType.StoredProcedure, parametros);

            //convertir el dtVideo a un objeto Video
            Video datosVideo = new Video();
            if (dtVideo.Rows.Count > 0) //si lo encontró
            {
                datosVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                datosVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                datosVideo.Url = dtVideo.Rows[0]["Url"].ToString();
                datosVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());
                return View(datosVideo);
            }
            else
            { //no lo encontró
                return View("Error");
            }
        }
        [HttpPost]
        public ActionResult Francisco420Delete(int id, FormCollection datos)
        {
            //realizar el delete del registro
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            BaseHelper.ejecutarSentencia("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("Francisco420");
        }


        //Controlador de Cristian

        public ActionResult CristianGzz()
        {
            //obtener la info de los videos de la BD
            DataTable dtVideos;
            dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);

            List<Video> lstVideos = new List<Video>();

            //convertir el DataTable a una lista de videos List<Video>
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
        //Metodo para borrar un video
        public ActionResult CristianGzzDelete(int id)
        {
            //obtener los datos del video para mostrarlo al usuario antes de borrarlo
            DataTable dtVideo;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorID", CommandType.StoredProcedure, parametros);

            //convertir el dtVideo a un objeto Video
            Video datosVideo = new Video();

            if (dtVideo.Rows.Count > 0) //si lo encontro
            {
                datosVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                datosVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                datosVideo.Url = dtVideo.Rows[0]["Url"].ToString();
                datosVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());

                return View(datosVideo);
            }
            else
            { //no lo encontro 
                return View("Error");
            }
        }

        [HttpPost]
        public ActionResult CristianGzzDelete(int id, FormCollection datos)
        {
            //realizar el delete del registro
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            BaseHelper.ejecutarSentencia("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);

            return RedirectToAction("CristianGzz");
        }

        //Controlador de Mauricio

        public ActionResult MauricioHdz17()
        {
            //Traer la información de la BD
            DataTable dtVideos;
            dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);

            List<Video> lstVideos = new List<Video>();
            //Ciclo para recorrer el arreglo
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




        public ActionResult MauricioHdz17Delete(int id)
        {
            //obtiene los datos del video para mostrarlo antes de eliminarlo
            DataTable dtVideo;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);
            //convertir un dtVideo a un objeto video
            Video datosVideo = new Video();
            if (dtVideo.Rows.Count > 0)//encontro
            {
                datosVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                datosVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                datosVideo.Url = dtVideo.Rows[0]["Url"].ToString();
                datosVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());
                return View(datosVideo);
            }
            else //no lo encontro
            {
                return View("Error");
            }

        }
        [HttpPost]
        public ActionResult MauricioHdz17Delete(int id, FormCollection datos)
        {
            //realizar delete del registro
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            BaseHelper.ejecutarConsulta("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);

            return RedirectToAction("MauricioHdz17");
        }


        //muestra mi lista FaGoGo
        public ActionResult FaGoGo()
        {
            DataTable dtVideos;
            dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);
            List<Video> lstVideos = new List<Video>();

            foreach (DataRow item in dtVideos.Rows)
            {
                Video videoAux = new Video();
                videoAux.IdVideo = int.Parse(item["idVideo"].ToString());
                videoAux.Nombre = item["Nombre"].ToString();
                videoAux.Url = item["Url"].ToString();
                videoAux.FechaPublicacion = DateTime.Parse(item["FechaPublicacion"].ToString());

                lstVideos.Add(videoAux);
            }
            return View(lstVideos);

        }

        //borrar
        public ActionResult FaGoGoDelete(int id)
        {
            DataTable dtVideo;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorID", CommandType.StoredProcedure, parametros);

            //convertir el dtVideo a un objeto Video
            Video datosVideo = new Video();

            if (dtVideo.Rows.Count > 0) //si lo encontro
            {
                datosVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                datosVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                datosVideo.Url = dtVideo.Rows[0]["Url"].ToString();
                datosVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());

                return View(datosVideo);
            }
            else
            { //no lo encontro 
                return View("Error");
            }
        }
        [HttpPost]
        public ActionResult FaGoGoDelete(int id, FormCollection datos)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            BaseHelper.ejecutarSentencia("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("FaGoGo");
        }
        //detalles 
        public ActionResult FaGoGoDetails(int id)
        {

            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@IdVideo", id));
            DataTable dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorID", CommandType.StoredProcedure, parametros);

            Video infoVideo = new Video();

            if (dtVideo.Rows.Count > 0)
            {
                infoVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                infoVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                infoVideo.Url = dtVideo.Rows[0]["Url"].ToString();
                infoVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());

                return View(infoVideo);
            }
            else
            {
                return View("Error");
            }
        }
        //Editar
        public ActionResult FaGoGoEdit(int id)
        {

            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@IdVideo", id));
            DataTable dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorID", CommandType.StoredProcedure, parametros);

            Video infoVideo = new Video();

            if (dtVideo.Rows.Count > 0)
            {
                infoVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                infoVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                infoVideo.Url = dtVideo.Rows[0]["Url"].ToString();
                infoVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());

                return View(infoVideo);
            }
            else
            {
                return View("Error");
            }
        }


        [HttpPost]
        public ActionResult FaGoGoEdit(int id)
        {

            return View();
        }

        //muestra la lista de video

        public ActionResult StephannieMtz()
        {
            DataTable dtVideos;
            dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);
            List<Video> lstVideos = new List<Video>();

            foreach (DataRow item in dtVideos.Rows)
            {
                Video videoAux = new Video();
                videoAux.IdVideo = int.Parse(item["idVideo"].ToString());
                videoAux.Nombre = item["Nombre"].ToString();
                videoAux.Url = item["Url"].ToString();
                videoAux.FechaPublicacion = DateTime.Parse(item["FechaPublicacion"].ToString());
                lstVideos.Add(videoAux);
            }
            return View(lstVideos);
        }
        //metodo para borrar un video
        public ActionResult LIIStephannieDelete(int id)
        {
            //obtiene los datos del video para mostrarlo antes de eliminarlo
            DataTable dtVideo;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);
            //convertir un dtVideo a un objeto video
            Video datosVideo = new Video();
            if (dtVideo.Rows.Count > 0)//encontro
            {
                datosVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                datosVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                datosVideo.Url = dtVideo.Rows[0]["Url"].ToString();
                datosVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());
                return View(datosVideo);
            }
            else //no lo encontro
            {
                return View("Error");
            }

        }
        [HttpPost]
        public ActionResult LIIStephannieDelete(int id, FormCollection datos)
        {
            //realizar delete del registro
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            BaseHelper.ejecutarConsulta("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);

            return RedirectToAction("StephannieMtz");
        }


        public ActionResult KeilaAlejandra()
        {
            //Obtener la informacion de  los Videos de la BD
            DataTable dtVideos;
            dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);

            List<Video> lstVideos = new List<Video>();
            //Convertir el DataTable a una lista de Videos
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

        //metodo para borrar un video

        public ActionResult KeilaAlejandraDelete(int id)
        {

            //Obtener los datos del video para mostrarlo al usuario antes de borrarlo
            DataTable dtVideo;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorID", CommandType.StoredProcedure, parametros);

            //convertir el dtvideo a un objeto video

            Video datoVideos = new Video();

            if (dtVideo.Rows.Count > 0)//si lo encontro
            {
                datoVideos.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                datoVideos.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                datoVideos.Url = dtVideo.Rows[0]["Url"].ToString();
                datoVideos.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());

                return View(datoVideos);
            }
            else // no lo encontro
            {
                return View("Error");
            }
        }
        [HttpPost]
        public ActionResult KeilaAlejandraDelete(int id, FormCollection datos)
        {
            //realizar el delete del registro
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            BaseHelper.ejecutarSentencia("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);

            return RedirectToAction("KeilaAlejandra");
        }



        public ActionResult ErickMedellin()
        {
            //obtener la info de los videos de la BD
            DataTable dtVideos;
            dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);

            List<Video> lstVideos = new List<Video>();
            //convertir el DataTable a una lista de videos List<Video>
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
        //Metodo para borrar un video
        public ActionResult ErickMedellinDelete(int id)
        {
            //Obtener los datos del video que se desea eliminar
            DataTable dtVideo;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorID", CommandType.StoredProcedure, parametros);

            //Convertir el dtVideo a un objeto Video
            Video datosVideo = new Video();

            if (dtVideo.Rows.Count > 0) //Si lo encontro
            {
                datosVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                datosVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                datosVideo.Url = dtVideo.Rows[0]["Url"].ToString();
                datosVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());

                return View(datosVideo);
            }
            else //Si no lo encontro
            {
                return View("Error");
            }
        }

        [HttpPost]
        public ActionResult ErickMedellinDelete(int id, FormCollection datos)
        {
            //Realizar el delete del registro
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            BaseHelper.ejecutarSentencia("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);

            return RedirectToAction("ErickMedellin");
        }

        public ActionResult JoaquinFlores()
        {
            DataTable dtVideos;
            dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);
            List<Video> lstVideos = new List<Video>();


            foreach (DataRow item in dtVideos.Rows)
            {
                Video videoAux = new Video();
                videoAux.IdVideo = int.Parse(item["idVideo"].ToString());
                videoAux.Nombre = item["Nombre"].ToString();
                videoAux.Url = item["Url"].ToString();
                videoAux.FechaPublicacion = DateTime.Parse(item["FechaPublicacion"].ToString());
                lstVideos.Add(videoAux);
            }
            return View(lstVideos);
        }

        //Metodo para borrar un video
        public ActionResult JoaquinFloresDelete(int id)
        {
            //obtener los datos del video para mostrarlo al usuario antes de borrarlo
            DataTable dtVideo;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorID", CommandType.StoredProcedure, parametros);

            //convertir el dtVideo a un objeto Video
            Video datosVideo = new Video();

            if (dtVideo.Rows.Count > 0) //si lo encontro
            {
                datosVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                datosVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                datosVideo.Url = dtVideo.Rows[0]["Url"].ToString();
                datosVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());

                return View(datosVideo);
            }
            else
            { //no lo encontro 
                return View("Error");
            }

        }

        [HttpPost]
        public ActionResult JoaquinFloresDelete(int id, FormCollection datos)
        {
            //realizar el delete del registro
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            BaseHelper.ejecutarSentencia("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);

            return RedirectToAction("JoaquinFlores");
        }


        public ActionResult PaulinaAcevedo()
        {
            DataTable dtVideos;
            dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);
            List<Video> lstVideos = new List<Video>();

            foreach (DataRow item in dtVideos.Rows)
            {
                Video videoAux = new Video();
                videoAux.IdVideo = int.Parse(item["idVideo"].ToString());
                videoAux.Nombre = item["Nombre"].ToString();
                videoAux.Url = item["Url"].ToString();
                videoAux.FechaPublicacion = DateTime.Parse(item["FechaPublicacion"].ToString());
                lstVideos.Add(videoAux);
            }
            return View(lstVideos);
        }
        //Metodo para borrar un video
        public ActionResult PaulinaAcevedoDelete(int id)
        {
            //obtener los datos del video para mostrarlo al usuario antes de borrarlo
            DataTable dtVideo;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorID", CommandType.StoredProcedure, parametros);

            //convertir el dtVideo a un objeto Video
            Video datosVideo = new Video();

            if (dtVideo.Rows.Count > 0) //si lo encontro
            {
                datosVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                datosVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                datosVideo.Url = dtVideo.Rows[0]["Url"].ToString();
                datosVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());

                return View(datosVideo);
            }
            else
            { //no lo encontro 
                return View("Error");
            }


        }

        [HttpPost]
        public ActionResult PaulinaAcevedoDelete(int id, FormCollection datos)
        {
            //realizar el delete del registro
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            BaseHelper.ejecutarSentencia("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);

            return RedirectToAction("PaulinaAcevedo");
        }




        public ActionResult Yarelilucio()
        {
            //obtener info de videos de la base de datos 
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
            return View(lstVideos);

        }
        //metodo yareli
        public ActionResult YarelilucioDelete(int id)
        {
            DataTable dtVideo;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorID", CommandType.StoredProcedure, parametros);

            Video datosvideo = new Video();
            if (dtVideo.Rows.Count > 0)
            {
                datosvideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                datosvideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                datosvideo.Url = dtVideo.Rows[0]["Url"].ToString();
                datosvideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());

                return View(datosvideo);
            }
            else
            {
                //no lo encontro
                return View("Error");
            }
        }

        [HttpPost]
        public ActionResult YarelilucioDelete(int id, FormCollection datos)
        {
            //realizar el delete
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            BaseHelper.ejecutarSentencia("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("Yarelilucio");
        }


        public ActionResult Escamilla1010()
        {
            //Obtener la informacion de Videos
            DataTable dtVideos;
            dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);

            List<Video> lstVideos = new List<Video>();

            //Convertir DataTable a List
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

        //Alerta pata borrar video Escamilla

        public ActionResult Escamilla1010Delete(int id)
        {
            //Obtener datos del video antes de borrarlo
            DataTable dtVideo;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorID", CommandType.StoredProcedure, parametros);

            //Convertir el Dtvideo a Video
            Video datosVideo = new Video();

            if (dtVideo.Rows.Count > 0) //Lo encuentra si es mayor a 0
            {
                datosVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                datosVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                datosVideo.Url = dtVideo.Rows[0]["Url"].ToString();
                datosVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());

                return View(datosVideo);
            }
            else //Si no es mayor a 0
            {
                return View("Error");
            }
        }

        [HttpPost]
        public ActionResult Escamilla1010Delete(int id, FormCollection datos)
        {
            //Borrar el registro
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            BaseHelper.ejecutarSentencia("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);

            return RedirectToAction("Escamilla1010");
        }



        public ActionResult zepedaaa()
        {
            DataTable dtVideos;
            dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);
            List<Video> lstVideos = new List<Video>();

            foreach (DataRow item in dtVideos.Rows)
            {
                Video videoAux = new Video();
                videoAux.IdVideo = int.Parse(item["idVideo"].ToString());
                videoAux.Nombre = item["Nombre"].ToString();
                videoAux.Url = item["Url"].ToString();
                videoAux.FechaPublicacion = DateTime.Parse(item["FechaPublicacion"].ToString());
                lstVideos.Add(videoAux);
            }
            return View(lstVideos);
        }


        public ActionResult AguilarCab()
        {
            //Obtener la informacion de los videos de la base de datos
            DataTable dtVideos;
            dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);
            List<Video> lstVideos = new List<Video>();
            //convertir el DataTable a lista de videos 
            foreach (DataRow item in dtVideos.Rows)
            {
                Video videoAux = new Video();
                videoAux.IdVideo = int.Parse(item["idVideo"].ToString());
                videoAux.Nombre = item["Nombre"].ToString();
                videoAux.Url = item["Url"].ToString();
                videoAux.FechaPublicacion = DateTime.Parse(item["FechaPublicacion"].ToString());
                lstVideos.Add(videoAux);
            }
            return View(lstVideos);
        }

        //Metodo para borrar un video
        public ActionResult AguilarCabDelete(int id) 
        {
            //Datos del video para el usuario antes de borrarlo
            DataTable dtVideo;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorID", CommandType.StoredProcedure,parametros);
            
            //Convertir dtVideo en objeto
            Video datosVideo = new Video();

            if (dtVideo.Rows.Count > 0)//si lo encuentra
            {
                datosVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                datosVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                datosVideo.Url = dtVideo.Rows[0]["Url"].ToString();
                datosVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());

                return View(datosVideo);
            }
            else //si no lo encuentra
            {
              return View("Error");
            }       
        }

        [HttpPost]
        public ActionResult AguilarCabDelete(int id, FormCollection datos)
        {
            //realizar el delete del registro
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            BaseHelper.ejecutarSentencia("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);

            return RedirectToAction("AguilarCab");
        }

        //tellezFloresBegin
        public ActionResult tellezFlores()
        {
            DataTable dtVideos;
            dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);
            List<Video> lstVideos = new List<Video>();

            // Convertir DataTable en lista de videos
            foreach (DataRow item in dtVideos.Rows)
            {
                Video videoAux = new Video();
                videoAux.IdVideo = int.Parse(item["idVideo"].ToString());
                videoAux.Nombre = item["Nombre"].ToString();
                videoAux.Url = item["Url"].ToString();
                videoAux.FechaPublicacion = DateTime.Parse(item["FechaPublicacion"].ToString());
                lstVideos.Add(videoAux);
            }
            return View(lstVideos);
        }
        public ActionResult tellezFloresDelete(int id)
        {
            //se obtienen los datos del video antes de ser eliminado
            DataTable dtVideo;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);

            //convertir un dtVideo a un objeto video
            Video datosVideo = new Video();

            //si encuentra
            if (dtVideo.Rows.Count > 0)
            {
                datosVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                datosVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                datosVideo.Url = dtVideo.Rows[0]["Url"].ToString();
                datosVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());
                return View(datosVideo);
            }
            else //sino lo encuentra
            {
                return View("Error");
            }

        }

        [HttpPost]
        public ActionResult tellezFloresDelete(int id, FormCollection datos)
        {
            //se realiza delete del registro
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            BaseHelper.ejecutarConsulta("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);

            return RedirectToAction("tellezFlores");
        }
        //tellezFloresEnd

        public ActionResult MaxNarro()
        {
            //obtener info de videos de la base de datos 
            DataTable dtVideos;
            dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);
            List<Video> lstVideos = new List<Video>();

            foreach (DataRow item in dtVideos.Rows)
            {
                Video videoAux = new Video();
                videoAux.IdVideo = int.Parse(item["idVideo"].ToString());
                videoAux.Nombre = item["Nombre"].ToString();
                videoAux.Url = item["Url"].ToString();
                videoAux.FechaPublicacion = DateTime.Parse(item["FechaPublicacion"].ToString());
                lstVideos.Add(videoAux);
            }
              return View(lstVideos);
        }

            public ActionResult MaxNarroDelete(int id)
        {
            //se obtienen los datos del video antes de ser eliminado
            DataTable dtVideo;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);

            //convertir un dtVideo a un objeto video
            Video datosVideo = new Video();

            //si encuentra
            if (dtVideo.Rows.Count > 0)
            {
                datosVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                datosVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                datosVideo.Url = dtVideo.Rows[0]["Url"].ToString();
                datosVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());
                return View(datosVideo);
            }
            else //sino lo encuentra
            {
                return View("Error");
            }

        }

        [HttpPost]
        public ActionResult MaxNarroDelete(int id, FormCollection datos)
        {
            //se realiza delete del registro
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            BaseHelper.ejecutarConsulta("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);

            return RedirectToAction("MaxNarro");
        }

   
          
       

        public ActionResult YahirMtz()
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
            return View(lstVideos);

        }


        public ActionResult monicacevedo()
        {
            DataTable dtVideos;
            dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);
            List<Video> lstVideos = new List<Video>();

            foreach (DataRow item in dtVideos.Rows)
            {
                Video videoAux = new Video();
                videoAux.IdVideo = int.Parse(item["idVideo"].ToString());
                videoAux.Nombre = item["Nombre"].ToString();
                videoAux.Url = item["Url"].ToString();
                videoAux.FechaPublicacion = DateTime.Parse(item["FechaPublicacion"].ToString());
                lstVideos.Add(videoAux);
            }

            return View(lstVideos);


        }

        public ActionResult kattyaleal()
        {
            DataTable dtVideos;
            dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);
            List<Video> lstVideos = new List<Video>();

            foreach (DataRow item in dtVideos.Rows)
            {
                Video videoAux = new Video();
                videoAux.IdVideo = int.Parse(item["idVideo"].ToString());
                videoAux.Nombre = item["Nombre"].ToString();
                videoAux.Url = item["Url"].ToString();
                videoAux.FechaPublicacion = DateTime.Parse(item["FechaPublicacion"].ToString());
                lstVideos.Add(videoAux);
            }
            return View(lstVideos);
        }
        //Metodo para borrar un video kattyaleal
        public ActionResult kattyalealDelete(int id)
        {
            //obtener los datos del video para mostrarlo al usuario antes de borrarlo
            DataTable dtVideo;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorID", CommandType.StoredProcedure, parametros);

            //convertir el dtVideo a un objeto Video
            Video datosVideo = new Video();

            if (dtVideo.Rows.Count > 0) //si lo encontro
            {
                datosVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                datosVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                datosVideo.Url = dtVideo.Rows[0]["Url"].ToString();
                datosVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());

                return View(datosVideo);
            }
            else
            { //no lo encontro 
                return View("Error");
            }
        }

        [HttpPost]
        public ActionResult kattyalealDelete(int id, FormCollection datos)
        {
            //realizar el delete del registro
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            BaseHelper.ejecutarSentencia("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);

            return RedirectToAction("kattyaleal");
        }


        //Ver videos ElCantiner0
        public ActionResult ElCantiner0()
        {
            DataTable dtVideos;
            dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);
            List<Video> lstVideos = new List<Video>();

            foreach (DataRow item in dtVideos.Rows)
            {
                Video videoAux = new Video();
                videoAux.IdVideo = int.Parse(item["idVideo"].ToString());
                videoAux.Nombre = item["Nombre"].ToString();
                videoAux.Url = item["Url"].ToString();
                videoAux.FechaPublicacion = DateTime.Parse(item["FechaPublicacion"].ToString());
                lstVideos.Add(videoAux);
            }
            return View(lstVideos);
        }

        //Borrar videos ElCantiner0
        public ActionResult ElCantiner0Delete(int id) 
        {
            //Obtener datos, mostrar y decidir si elimina
            DataTable dtVideo;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorID", CommandType.StoredProcedure, parametros);

            //convertir el data video a objeto video
            Video datosVideo = new Video();
            if (dtVideo.Rows.Count > 0)//encontrado
            {
                datosVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                datosVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                datosVideo.Url = dtVideo.Rows[0]["Url"].ToString();
                datosVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());

                return View(datosVideo);
            }
            else
            {

                return View("Error");
            }//no encontrado

            
        }

        [HttpPost]//boton borrar
        public ActionResult ElCantiner0Delete(int id, FormCollection datos)
        {
            //activar boton con delete de registro
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            BaseHelper.ejecutarSentencia("sp_Eliminar_Video", CommandType.StoredProcedure, parametros);

            return RedirectToAction("ElCantiner0");
        }

        public ActionResult PacoYee6661Delete(int id)
        {
            //vista preliminar
            DataTable dtVideo;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorID", CommandType.StoredProcedure, parametros);

            //convertir datos a objetos
            Video datosVideo = new Video();

            if (dtVideo.Rows.Count > 0) //found
            {
                datosVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                datosVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                datosVideo.Url = dtVideo.Rows[0]["Url"].ToString();
                datosVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());

                return View(datosVideo);
            }
            else
            { //not found
                return View("Error");
            }


        }
        [HttpPost]
        public ActionResult PacoYee6661Delete(int id, FormCollection datos)
        {
            //delete
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            BaseHelper.ejecutarSentencia("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);

            return RedirectToAction("LIIGabriel");
        }


        public ActionResult PacoYee6661()
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
            return View(lstVideos);
        }

        public ActionResult Mariscalleal()
        {
            DataTable dtVideos;
            dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);
            List<Video> lstVideos = new List<Video>();

            foreach (DataRow item in dtVideos.Rows)
            {
                Video videoAux = new Video();
                videoAux.IdVideo = int.Parse(item["idVideo"].ToString());
                videoAux.Nombre = item["Nombre"].ToString();
                videoAux.Url = item["Url"].ToString();
                videoAux.FechaPublicacion = DateTime.Parse(item["FechaPublicacion"].ToString());
                lstVideos.Add(videoAux);
            }
            return View(lstVideos);
        }

        public ActionResult alondrasuarez()
        {
            DataTable dtVideos;
            dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);
            List<Video> lstVideos = new List<Video>();

            foreach (DataRow item in dtVideos.Rows)
            {
                Video videoAux = new Video();
                videoAux.IdVideo = int.Parse(item["idVideo"].ToString());
                videoAux.Nombre = item["Nombre"].ToString();
                videoAux.Url = item["Url"].ToString();
                videoAux.FechaPublicacion = DateTime.Parse(item["FechaPublicacion"].ToString());
                lstVideos.Add(videoAux);
            }
            return View(lstVideos);
        }
        public ActionResult alondrasuarezDelete(int id)
        {
            DataTable dtVideo;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", id));

            dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorID", CommandType.StoredProcedure, parametros);

            Video datosVideo = new Video();

            if (dtVideo.Rows.Count > 0)
            {
                datosVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                datosVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                datosVideo.Url = dtVideo.Rows[0]["Url"].ToString();
                datosVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());

                return View(datosVideo);
            }
            else
            { //not found
                return View("Error");
            }

        }

            [HttpPost]
            public ActionResult alondrasuarezDelete(int id, FormCollection datos) {

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            BaseHelper.ejecutarSentencia("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);

            return RedirectToAction("alondrasuarez");
                
            }
        //GUSTAVO
        //Metodo que muestra Lista de videos 
            public ActionResult GUSTAVOAZAEL()
            {
                //OBTENER LA INFORMACION DE LOS VIDEOS DE LA BD
                DataTable dtVideos;
                dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);

                List<Video> lstVideos = new List<Video>(); 
                //Convertir el data table a una lista de videos  List<Video>
                foreach (DataRow item in dtVideos.Rows)
                {
                    Video videoAux = new Video();

                    videoAux.IdVideo = int.Parse(item["idVideo"].ToString());
                    videoAux.Nombre = item["Nombre"].ToString();
                    videoAux.Url = item["Url"].ToString();
                    videoAux.FechaPublicacion = DateTime.Parse(item["FechaPublicacion"].ToString());

                    lstVideos.Add(videoAux);   
                }

                return View(lstVideos);
            }
        //Metodo que borra un video
            public ActionResult GustavoAzaelDelete(int id)
            {
                //Obtener datos del video. ¿Esta seguro de borrar el video n?
                DataTable dtVideo;
                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("@idVideo", id));

                dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorID", CommandType.StoredProcedure, parametros);
               //convertir el dtVideo a un objeto Video
                Video datosVideo = new Video();
                if (dtVideo.Rows.Count > 0)  //si lo encontro
                {
                    datosVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                    datosVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                    datosVideo.Url = dtVideo.Rows[0]["URL"].ToString();
                    datosVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());
                    return View(datosVideo);
                }
                else{ //no lo encontro
                    return View("Error");
                }

                
            }
        [HttpPost]
            public ActionResult GustavoAzaelDelete(int id, FormCollection datos) {
            //realizar el delete del registro
                List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo",id));
            BaseHelper.ejecutarSentencia("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("GustavoAzael");
            }

        //Muestra la lista de videos
        public ActionResult KarenCabrera()
        {
            //Obtener la info de los videos
            DataTable dtVideos;
            dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);

            List<Video> lstVideos = new List<Video>();
            //Convertir el datatable en una lista de videos 
            foreach (DataRow item in dtVideos.Rows)
            {
                Video videoAux = new Video();

                videoAux.IdVideo = int.Parse(item["idVideo"].ToString());
                videoAux.Nombre = item["Nombre"].ToString();
                videoAux.Url = item["Url"].ToString();
                videoAux.FechaPublicacion = DateTime.Parse(item["FechaPublicacion"].ToString());

                lstVideos.Add(videoAux);
            }
           return View(lstVideos);
            }

        //Borrar un video 
        public ActionResult KarenCabreraDelete(int id)
        {
            //Obtener datos del video.
            DataTable dtVideo;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", id));

            dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorID", CommandType.StoredProcedure, parametros);
            //Convertir el dtVideo a un objeto Video
            Video datosVideo = new Video();
            if (dtVideo.Rows.Count > 0)  //si lo encontro
            {
                datosVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                datosVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                datosVideo.Url = dtVideo.Rows[0]["URL"].ToString();
                datosVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());
                return View(datosVideo);
            }
            else
            { //no lo encontro
                return View("Error");
            }
        }
        [HttpPost]
        public ActionResult KarenCabreraDelete(int id, FormCollection datos)
        {
            //realizar el delete del registro
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));
            BaseHelper.ejecutarSentencia("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("KarenCabrera");
        }

        //Controlador de Rodolfo

        public ActionResult RodVillarreal20()
        {
            //Traer la información de la Base de Datos
            DataTable dtVideos;
            dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);

            List<Video> lstVideos = new List<Video>();
            //Ciclo para recorrer el arreglo
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


        //Metodo para borrar un videoo
        public ActionResult RodVillarreal20Delete(int id)
        {
            //obtener los datos del video para mostrarlo al usuario antes de borrarlo
            DataTable dtVideo;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorID", CommandType.StoredProcedure, parametros);

            //convertir el dtVideo a un objeto Video
            Video datosVideo = new Video();

            if (dtVideo.Rows.Count > 0) //si lo encontro
            {
                datosVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                datosVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                datosVideo.Url = dtVideo.Rows[0]["Url"].ToString();
                datosVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());

                return View(datosVideo);
            }
            else
            { //no lo encontro 
                return View("Error");
            }
        }

        [HttpPost]
        public ActionResult RodVillarreal20Delete(int id, FormCollection datos)
        {
            //Realizar Delete del registro
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            BaseHelper.ejecutarSentencia("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);

            return RedirectToAction("RodVillarreal20");
        }







        //Metodo de JuanPedraza44
        public ActionResult JuanPedraza44()
        {
            //obtener la info de los videos de la BD
            DataTable dtVideos;
            dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);

            List<Video> lstVideos = new List<Video>();

            //convertir el DataTable a una lista de videos List<Video>
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

        //metodo borrar un video JuanPedraza44
        public ActionResult JuanPedraza44Delete(int id)
        {
            //obtener los datos del video para mostrarlo al usuario antes de borrarlo
            DataTable dtVideo;
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorID", CommandType.StoredProcedure, parametros);

            //convertir el dtVideo a un objeto Video
            Video datosVideo = new Video();

            if (dtVideo.Rows.Count > 0) //si lo encontro
            {
                datosVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                datosVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                datosVideo.Url = dtVideo.Rows[0]["Url"].ToString();
                datosVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());

                return View(datosVideo);
            }
            else
            { //no lo encontro 
                return View("Error");
            }

        }

        [HttpPost]
        public ActionResult JuanPedraza44Delete(int id, FormCollection datos)
        {
            //realizar el delete del registro
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", id));

            BaseHelper.ejecutarSentencia("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);

            return RedirectToAction("JuanPedraza44");
        }
    }

    }

    





    

    

