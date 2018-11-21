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
        private string photoMessage = "You have made a photo by default mode";
        [DataMember]
        private string videoMessage = "You have made a video by default mode";

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

        //public override string SerializeXml()
        //{
        //    XmlSerializer formatter = new XmlSerializer(this.GetType());
        //    using (FileStream fileStream = new FileStream(this.GetType().Name + ".xml", FileMode.Create))
        //    {
        //        formatter.Serialize(fileStream, instance);
        //    }
        //    return this + " is serialized";
        //}
        //public override string DeserializeXml()
        //{
        //    XmlSerializer formatter = new XmlSerializer(this.GetType());
        //    using (FileStream fileStream = new FileStream(this.GetType().Name + ".xml", FileMode.Open))
        //    {
        //        instance = formatter.Deserialize(fileStream) as DefaultMode;                               
        //        photoMessage = instance.photoMessage;
        //        videoMessage = instance.videoMessage;
        //        return instance + " is deserialized";
        //    }
        //}

        public override string SerializeJSON()
        {
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(this.GetType());
            using (FileStream stream = new FileStream(this.GetType().Name + ".json", FileMode.Create))
            {
                jsonSerializer.WriteObject(stream, GetInstance());
            }
            return "All objects of " + this.GetType().Name + " are serialized";
        }
    }
}