using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ejer3.Morosos.Entidades.Modelos
{
    [DataContract]
    public class TransactionResult
    {
        [DataMember]
        public bool IsOk { get; set; }
        [DataMember]
        public string Error { get; set; }
        [DataMember]
        public int Id { get; set; }

    }
}
