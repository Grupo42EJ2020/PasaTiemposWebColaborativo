using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace MVCLaboratorio.Utilerias
{
    public class BaseHelper
    {
        public static int ejecutarSentencia(String sentencia,
                           CommandType tipo,
                           List<SqlParameter> parametros = null)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            int filas;
            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                con.Open();
                comando.Connection = con;
                comando.CommandType = tipo;
                comando.CommandText = sentencia;

                if (parametros != null)
                {
                    comando.Parameters.AddRange(parametros.ToArray());
                }

                filas = comando.ExecuteNonQuery();
            } //try
            catch (Exception) { throw; }
            finally
            {
                con.Close();
            } //finally	
            return filas;
        } // funcion ejecutar sentencia  

        public static DataTable ejecutarConsulta(String sentencia,
                             CommandType tipo,
                             List<SqlParameter> parametros = null)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataAdapter adaptador = new SqlDataAdapter();
            DataTable datos = new DataTable();
            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                con.Open();
                comando.Connection = con;
                comando.CommandType = tipo;
                comando.CommandText = sentencia;
                adaptador.SelectCommand = comando;
                if (parametros != null)
                {
                    comando.Parameters.AddRange(parametros.ToArray());
                }

                adaptador.Fill(datos);
            } //try
            catch (Exception) { throw; }
            finally
            {
                con.Close();
            } //finally	
            return datos;
        } //ejecutarSentencia
    } //clase basehelper
}