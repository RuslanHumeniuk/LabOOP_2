using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabOp222.Models.Interfaces
{
    internal interface IPhotoMode
    {
        string PhotoMessage { get; set; }

        string TakeAPhoto();
    }
}