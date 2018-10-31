using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary1.Contracts
{
    [ServiceContract]
    public  interface IPhone
    {
        [OperationContract]
        List<PhoneDTO>GetPhone();
       


    }
}
