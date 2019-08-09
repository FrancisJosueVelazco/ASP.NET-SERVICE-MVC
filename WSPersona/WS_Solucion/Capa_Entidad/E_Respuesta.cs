using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Capa_Entidad
{
    [DataContract]
    public class E_Respuesta
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string mensaje { get; set; }

    }
}
