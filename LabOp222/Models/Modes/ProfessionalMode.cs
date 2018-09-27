using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using LabOp222.Models.Interfaces;

namespace LabOp222.Models.Modes
{
    internal class ProfessionalMode : MediaInfo, IVideoMode, IPhotoMode
    {
        private string photoMessage = "That's how proffesional photo has to be looking";
        private string videoMessage = "How did you do so proffesional video?";

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
        public override void Delete() { }
    }
}