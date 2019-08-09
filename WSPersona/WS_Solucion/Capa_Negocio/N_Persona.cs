using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class N_Persona
    {
        public static List<E_Persona> listarPersona()
        {
            return Capa_Datos.D_Persona.ListarPersona();
        }

        public static E_Respuesta RegistrarPersona(E_Persona p)
        {
            return Capa_Datos.D_Persona.RegistrarPersona(p);
        }

        public static E_Persona ListarxId(int id)
        {
            return Capa_Datos.D_Persona.ListarxId(id);
        }

        public static E_Respuesta ActualizarPersona(E_Persona p)
        {
            return Capa_Datos.D_Persona.ActualizarPersona(p);
        }

        public static E_Respuesta EliminarPersona(E_Persona p)
        {
            return Capa_Datos.D_Persona.EliminarPersona(p);
        }
    }
}
