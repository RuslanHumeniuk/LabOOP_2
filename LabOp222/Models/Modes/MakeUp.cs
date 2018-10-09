using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using LabOp222.Models.Interfaces;

namespace LabOp222.Models.Modes
{
    internal class MakeUp : Mode, IPhotoMode, IVideoMode
    {
        private string photoMessage = "You look much better on this photo";
        private string videoMessage = "You look much better on this video!";

        private static MakeUp instance = null;

        private MakeUp() { }

        public static MakeUp GetInstance()
        {
            if (instance == null)
            {
                instance = new MakeUp();
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
        public string VideoMessage
        {
            get => videoMessage;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("VideoMessage can't be empty");
                else
                    videoMessage = value;
            }
        }

        public string TakeAPhoto()
        {
            return PhotoMessage;
        }
        public string RecordVideo()
        {
            return VideoMessage;
        }
    }
}