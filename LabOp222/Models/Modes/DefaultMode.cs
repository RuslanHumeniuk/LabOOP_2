using LabOp222.Models.Interfaces;

using System;

namespace LabOp222.Models.Modes
{
    [Serializable]
    public class DefaultMode : Mode, IPhotoMode, IVideoMode
    {
        private string photoMessage = "You have made a photo by default mode";
        private string videoMessage = "You have made a video by default mode";

        private static DefaultMode instance = null;

        private DefaultMode() { }

        public static DefaultMode GetInstance()
        {
            if(instance == null)
            {
                instance = new DefaultMode();
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