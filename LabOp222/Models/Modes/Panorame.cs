using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using LabOp222.Models.Interfaces;

namespace LabOp222.Models.Modes
{
    public class Panorame : Mode, IPhotoMode
    {
        private string photoMessage = "Wow, this is a panorama";

        private static Panorame instance = null;

        private Panorame() { }

        public static Panorame GetInstance()
        {
            if (instance == null)
            {
                instance = new Panorame();
            }
            return instance;
        }

        public string PhotoMessage
        {
            get => photoMessage;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("PhotoMessage can't be empty");
                else
                    photoMessage = value;
            }
        }

        public string TakeAPhoto()
        {
            return PhotoMessage;
        }
    }
}