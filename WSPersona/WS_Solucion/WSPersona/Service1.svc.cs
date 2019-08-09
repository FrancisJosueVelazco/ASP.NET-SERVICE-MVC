using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Capa_Negocio;
using Capa_Datos;
using Capa_Entidad;

namespace WSPersona
{
    // llamamos a los metodos de la capa negocio OK

    public class Service1 : IService1
    {// RECUERDA QUE LA INTERFAZ DEL SERVICIO DEBE TENER EL MISMO NOMBRE
     
        public  List<E_Persona> ListarPersona()
        {
            return Capa_Negocio.N_Persona.listarPersona();
        }
        public E_Persona ListarxId(int id)
        {
            return Capa_Negocio.N_Persona.ListarxId(id);
        }
        public E_Respuesta RegistrarPersona(E_Persona p)
        {
            return Capa_Negocio.N_Persona.RegistrarPersona(p);
        }
        public  E_Respuesta ActualizarPersona(E_Persona p)
        {
            return Capa_Negocio.N_Persona.ActualizarPersona(p);
        }
        public E_Respuesta EliminarPersona(E_Persona p)
        {
            return Capa_Negocio.N_Persona.EliminarPersona(p);
        }

        // POSICIONARCE EN SERVICE.SVC Y EJECUTAR F5 PARA EJECUTAR EL CLIENTE

        // PARA PODER CONSUMIR TU APP DE MANERA LOCAL TU SERVICIO DEBE ESTAR EN EJECUCION

    }
}
