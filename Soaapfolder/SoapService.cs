using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Soapnet.Soaapfolder
{
    [ServiceContract]
    public interface ISoapService
    {
        [OperationContract]
        string Sum(int num1, int num2);
    }
    public class SoapService : ISoapService
    {
        
            public string Sum(int num1, int num2)
        {
            return $"Sum of two number is: {num1 + num2}";

        }
    }
}
