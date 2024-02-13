using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using Soapnet.Models;
using Soapnet.Services;

namespace Soapnet.Soaapfolder
{
    [ServiceContract(Namespace = "http://Microsoft.ServiceModel.Samples")]
    public interface ISoapService
    {
        [OperationContract]
        string Sum(int num1, int num2);
        [OperationContract]
        Task<Root> Pokemon(int num);
    }
    public class SoapService : ISoapService
    {
        public string Sum(int num1, int num2)
        {
            return $"Sum of two number is: {num1 + num2}";
        }
        public async Task<Root> Pokemon(int num)
        {
            HttpClient httpClient = new HttpClient();
            var nuevo = new CONSULTASPOKEDEX(httpClient);
            var resultado = await nuevo.Obtenerlista(num);
            
            return resultado;
        }
    }
}
