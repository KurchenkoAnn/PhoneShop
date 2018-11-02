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
    public class PhoneDTO 
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Model { get; set; }
        [DataMember]
        public string Producer { get; set; }
        [DataMember]
        public int Price { get; set; }
    }
}
