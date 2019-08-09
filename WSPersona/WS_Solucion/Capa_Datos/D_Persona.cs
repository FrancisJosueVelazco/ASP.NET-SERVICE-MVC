using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Capa_Entidad;

namespace Capa_Datos
{
    public class D_Persona
    {
        public static List<E_Persona> ListarPersona()
        {
            Conexion c = new Conexion();
            SqlCommand cmd = new SqlCommand();
            List<E_Persona> lstPersona = new List<E_Persona>();
            try
            {
                cmd.Connection = c.cadena;
                cmd.Connection.Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "sp_Obtener";

                using(SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        E_Persona p = new E_Persona();
                       
                        p.codigo = Convert.ToInt32(lector["codigo"]);
                        p.nombres = lector["nombres"] as string ?? "";
                        p.apellidos = lector["apellidos"] as string ?? "";
                        p.edad= Convert.ToInt32(lector["edad"] );
                        p.fecha = Convert.ToDateTime(lector["fecha"]);

                        lstPersona.Add(p);
                    }
                }
            
            }
            catch (Exception e)
            {
                e.ToString();
            }
            finally
            {
                cmd.Dispose();
                c.cadena.Close();
            }
            return lstPersona;


        }

        public static E_Persona ListarxId(int id)
        {
            Conexion c = new Conexion();
            SqlCommand cmd = new SqlCommand();
            E_Persona p = new E_Persona();
            try
            {
                cmd.Connection = c.cadena;
                cmd.Connection.Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "sp_ListarxId";
                cmd.Parameters.AddWithValue("@codigo", id);

                using(SqlDataReader lector = cmd.ExecuteReader())
                {
                    lector.Read();
                    
                    p.codigo = Convert.ToInt32( lector["codigo"].ToString());
                    p.nombres = lector["nombres"] as string ?? "";
                    p.apellidos = lector["apellidos"] as string ?? "";
                    p.edad = Convert.ToInt32(lector["edad"] as string ?? "");
                    p.fecha = Convert.ToDateTime(lector["fecha"]);
                }
            }
            catch(Exception e)
            {
                e.ToString();
            }
            finally
            {
                cmd.Dispose();
                c.cadena.Close();
            }
            return p;
        }

        public static E_Respuesta RegistrarPersona(E_Persona p)
        {
            Conexion c = new Conexion();
            SqlCommand cmd = new SqlCommand();
            E_Respuesta response = new E_Respuesta();
            try
            {
                cmd.Connection = c.cadena;
                cmd.Connection.Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "sp_Registrar";

                cmd.Parameters.AddWithValue("@nombres", p.nombres);
                cmd.Parameters.AddWithValue("@apellidos", p.apellidos);
                cmd.Parameters.AddWithValue("@edad", p.edad);
                cmd.Parameters.AddWithValue("@fecha", p.fecha);

               using(SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        response.id =Convert.ToInt32( lector["id"]);
                        response.mensaje = lector["mensaje"].ToString();
                    }
                }
            }
            catch (Exception e)
            {
                e.ToString();
            }
            finally
            {
                cmd.Dispose();
                c.cadena.Close();
            }
            return response;
        }

        public static E_Respuesta ActualizarPersona(E_Persona p)
        {
            E_Respuesta response = new E_Respuesta();
            Conexion c = new Conexion();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = c.cadena;
                cmd.Connection.Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "sp_ActualizarPersona";
                cmd.Parameters.AddWithValue("@codigo", p.codigo);
                cmd.Parameters.AddWithValue("@nombres", p.nombres);
                cmd.Parameters.AddWithValue("@apellidos", p.apellidos);
                cmd.Parameters.AddWithValue("@edad", p.edad);
                cmd.Parameters.AddWithValue("@fecha", p.fecha);

               using(SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        response.id = Convert.ToInt32(lector["id"].ToString());
                        response.mensaje = lector["mensaje"].ToString();
                    }
                }
            }
            catch(Exception e)
            {
                e.ToString();
            }
            finally
            {
                cmd.Dispose();
                c.cadena.Close();
            }
            return response;

        }

        public static E_Respuesta EliminarPersona(E_Persona p)
        {
            E_Respuesta response = new E_Respuesta();
            Conexion c = new Conexion();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cmd.Connection = c.cadena;
                cmd.Connection.Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "sp_EliminarPersona";

                cmd.Parameters.AddWithValue("@codigo", p.codigo);

                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        response.id = Convert.ToInt32(lector["id"].ToString());
                        response.mensaje = lector["mensaje"].ToString();
                    }
                }
            }
            catch (Exception e)
            {
                e.ToString();
            }
            finally
            {
                cmd.Dispose();
                c.cadena.Close();
            }
            return response;

        }

    }
}
