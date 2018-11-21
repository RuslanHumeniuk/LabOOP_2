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
    [XmlRoot("TimeLaps")]
    public class TimeLaps : Mode, IVideoMode
    {
        [DataMember]
        private string videoMessage = "Cooool, this video in timelaps";

        private static TimeLaps instance = null;

        private TimeLaps() {}

        public static TimeLaps GetInstance()
        {
            if (instance == null)
            {
                instance = new TimeLaps();
            }
            return instance;
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
        //        instance = formatter.Deserialize(fileStream) as TimeLaps;                
        //        videoMessage = instance.videoMessage;
        //        return instance + " is deserialized";
        //    }
        //}
    }
}