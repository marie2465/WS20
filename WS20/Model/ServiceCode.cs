using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WS20.Model
{
    [DataContract]
    class ServiceCode
    {
        [DataMember]
        public int Value { get; set; }
    }
}
