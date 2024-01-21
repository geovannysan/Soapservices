using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using Soapnet.Models;

namespace Soapnet.interfaces
{
    [ServiceContract]

    public interface IServicess
    {
        [OperationContract]
        List<Users> ListarUsuarios();

        [OperationContract]
        
        List<Users> FiltrarUsuariosPorNombre(string nombre);

    }

    
}