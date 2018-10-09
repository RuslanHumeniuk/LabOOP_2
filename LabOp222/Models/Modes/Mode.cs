using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabOp222.Models.Modes
{
    internal abstract class Mode : MediaInfo
    {              
        public override string ToString()
        {
            return GetType().Name;
        }

        public override void Delete()
        {
            throw new NotImplementedException("User can not delete mode!");
        }
    }
}