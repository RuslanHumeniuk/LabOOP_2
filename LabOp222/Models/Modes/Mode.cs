using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabOp222.Models.Modes
{
    internal abstract class Mode
    {              
        public override string ToString()
        {
            return GetType().Name;
        }        
    }
}