using LabOp222.Models.Interfaces;

using System;

namespace LabOp222.Models.Modes
{
    [Serializable]
    public class ProfessionalMode : Mode, IVideoMode, IPhotoMode
    {
        private string photoMessage = "That's how proffesional photo has to be looking";
        private string videoMessage = "How did you do so proffesional video?";

        private static ProfessionalMode instance = null;

        private ProfessionalMode() { }

        public static ProfessionalMode GetInstance()
        {
            if (instance == null)
            {
                instance = new ProfessionalMode();
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