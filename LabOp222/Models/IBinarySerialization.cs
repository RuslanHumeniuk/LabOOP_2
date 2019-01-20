using LabOp222.Models.MediaFiles;

namespace LabOp222.Models
{
    interface IBinarySerialization
    {
        string Serialize();
        Video[] Deserialize();
    }
}
