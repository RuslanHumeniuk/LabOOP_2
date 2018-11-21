using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Xml.Serialization;
using LabOp222.Models.Interfaces;

namespace LabOp222.Models.Modes
{
    [DataContract]
    [Serializable]
    [XmlRoot("DefaultMode")]
    public class DefaultMode : Mode, IPhotoMode, IVideoMode
    {
        [DataMember]
        private string photoMessage;// = "You have made a photo by default mode";
        [DataMember]
        private string videoMessage;// = "You have made a video by default mode";

        [XmlIgnore]
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