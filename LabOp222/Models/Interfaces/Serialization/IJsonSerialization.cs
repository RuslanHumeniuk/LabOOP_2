using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOp222.Models.Interfaces.Serialization
{
    interface IJsonSerialization
    {
        string SerializeJSON();
        string DeserializeJSON();
    }
}
