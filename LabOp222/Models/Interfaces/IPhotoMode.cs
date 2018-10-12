using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabOp222.Models.Interfaces
{
    public interface IPhotoMode
    {
        string PhotoMessage { get; set; }

        string TakeAPhoto();
    }
}