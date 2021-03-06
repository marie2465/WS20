using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WS20.Model;

namespace WS20.Model
{
    [DataContract]
    class Services
    {
        [DataMember]
        public int pacient{ get; set; }
        [DataMember]
        public List<ServiceCode> services { get; set; }
    }
}
