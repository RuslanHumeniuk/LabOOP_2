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
    [XmlRoot("ProfessionalMode")]
    public class ProfessionalMode : Mode, IVideoMode, IPhotoMode
    {
        [DataMember]
        private string photoMessage = "That's how proffesional photo has to be looking";
        [DataMember]
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

        public override string SerializeJSON()
        {
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(this.GetType());
            using (FileStream stream = new FileStream(this.GetType().Name + ".json", FileMode.Create))
            {
                jsonSerializer.WriteObject(stream, GetInstance());
            }
            return "All objects of " + this.GetType().Name + " are serialized";
        }

        //    public override string SerializeXml()
        //    {
        //        XmlSerializer formatter = new XmlSerializer(this.GetType());
        //        using (FileStream fileStream = new FileStream(this.GetType().Name + ".xml", FileMode.Create))
        //        {
        //            formatter.Serialize(fileStream, instance);
        //        }
        //        return this + " is serialized";
        //    }
        //    public override string DeserializeXml()
        //    {
        //        XmlSerializer formatter = new XmlSerializer(this.GetType());
        //        using (FileStream fileStream = new FileStream(this.GetType().Name + ".xml", FileMode.Open))
        //        {
        //            instance = formatter.Deserialize(fileStream) as ProfessionalMode;
        //            photoMessage = instance.photoMessage;
        //            videoMessage = instance.videoMessage;
        //            return instance + " is deserialized";
        //        }
        //    }
        }
    }