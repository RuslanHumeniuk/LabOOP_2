using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabOp222.Models.Interfaces
{
    public interface IVideoMode
    {
        string VideoMessage { get; set; }

        string RecordVideo();
    }
}