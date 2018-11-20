using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOp222.Models.Interfaces.Serialization
{
    interface IXmlSerialization 
    {
        string SerializeXml();
        string DeserializeXml();
    }
}
