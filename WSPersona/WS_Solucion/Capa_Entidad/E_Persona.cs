using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

// REALIZAR UN CONTRATO DE DATOS CON EL SERVICIO (SERIALIZAR)

namespace Capa_Entidad
{
    // DATACONTRACT -> PARA UNA CLASE
    // DATAMEMBER -> PARA LOS ATRIBUTOS

    [DataContract]
   public class E_Persona
    {
        [DataMember]
        public int codigo { get; set; }
        [DataMember]
        public string nombres { get; set; }
        [DataMember]
        public string apellidos { get; set; }
        [DataMember]
        public int edad { get; set; }
        [DataMember]
        public DateTime fecha { get; set; }

    }
}
