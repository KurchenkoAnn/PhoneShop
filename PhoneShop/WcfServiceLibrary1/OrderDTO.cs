using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WcfServiceLibrary1.Contracts;

namespace WcfServiceLibrary1
{
    [DataContract]
    public class OrderDTO
    {
        [DataMember]
       public int ID { get; set; }
        [DataMember]
        public UserDTO Customer { get; set; }
        [DataMember]
        public PhoneDTO Item { get; set; }
        [DataMember]
        public DateTime GetOrder { get; set; }

    }
}
