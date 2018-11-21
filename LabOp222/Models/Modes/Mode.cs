using LabOp222.Models.Interfaces;
using LabOp222.Models.Interfaces.Serialization;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;

namespace LabOp222.Models.Modes
{
    [KnownType(typeof(DefaultMode))]
    [KnownType(typeof(Panorame))]
    [KnownType(typeof(MakeUp))]
    [KnownType(typeof(ProfessionalMode))]
    [KnownType(typeof(TimeLaps))]
    [KnownType(typeof(Mode))]
    [Serializable]
    [DataContract]
    [XmlRoot("Mode")]
    public abstract class Mode : /*IXmlSerialization*/  IJsonSerialization
    {
        [XmlIgnore]
        public static Mode[] AllModes = new Mode[] { DefaultMode.GetInstance(), MakeUp.GetInstance(), Panorame.GetInstance(), ProfessionalMode.GetInstance(), TimeLaps.GetInstance() };
        [XmlIgnore]
        public static IPhotoMode[] PhotoModes = new IPhotoMode[] { AllModes[0] as IPhotoMode, AllModes[1] as IPhotoMode, AllModes[2] as IPhotoMode, AllModes[3] as IPhotoMode };
        [XmlIgnore]
        public static IVideoMode[] VideoModes = new IVideoMode[] { AllModes[0] as IVideoMode, AllModes[1] as IVideoMode, AllModes[3] as IVideoMode, AllModes[4] as IVideoMode };        

        public Mode() { }

        ~Mode()
        {
            //SerializeXml();
            SerializeJSON();
        }

        public override string ToString()
        {
            return GetType().Name;
        }

        public override bool Equals(object obj)
        {
            return obj != null && obj.GetType().Equals(this.GetType());      
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        //public virtual string SerializeXml()
        //{
        //    XmlSerializer formatter = new XmlSerializer(this.GetType());
        //    using (FileStream fileStream = new FileStream(this.GetType().Name + ".xml", FileMode.Create)) 
        //    {
        //        formatter.Serialize(fileStream, this);
        //    }
        //    return this + " is serialized";
        //}

        //public virtual string DeserializeXml()
        //{
        //    XmlSerializer formatter = new XmlSerializer(this.GetType());
        //    using (FileStream fileStream = new FileStream(this.GetType().Name + ".xml", FileMode.Open)) 
        //    {
        //        Mode mode = formatter.Deserialize(fileStream) as Mode;
        //        return mode + " is deserialized";
        //    }
        //}

        public virtual string SerializeJSON()
        {
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(this.GetType());
            using (FileStream stream = new FileStream(this.GetType().Name + ".json", FileMode.Create))
            {
                jsonSerializer.WriteObject(stream, this);
            }
            return "All objects of " + this.GetType().Name + " are serialized";
        }

        public virtual string DeserializeJSON()
        {
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(this.GetType());
            using (FileStream fs = new FileStream(this.GetType().Name + ".json", FileMode.Open))
            {
                Mode deserializedMode = jsonSerializer.ReadObject(fs) as Mode;
                if (this is IPhotoMode)
                    (this as IPhotoMode).PhotoMessage = (deserializedMode as IPhotoMode).PhotoMessage;
                if (this is IVideoMode)
                    (this as IVideoMode).VideoMessage = (deserializedMode as IVideoMode).VideoMessage;
                return this.ToString() + " is deserialized!";
            }
        }
    }
}