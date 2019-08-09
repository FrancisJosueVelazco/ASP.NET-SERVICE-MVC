using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Capa_Entidad;

// PARA LOS METODOS ES    [OperationContract]

namespace WSPersona
{
  
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        //DEFINIMOS EL METODO
        List<E_Persona> ListarPersona();

        [OperationContract]
        E_Persona ListarxId(int id);

        [OperationContract]
        E_Respuesta RegistrarPersona(E_Persona p);

        [OperationContract]
        E_Respuesta ActualizarPersona(E_Persona p);

        [OperationContract]
        E_Respuesta EliminarPersona(E_Persona p);


    }

}
