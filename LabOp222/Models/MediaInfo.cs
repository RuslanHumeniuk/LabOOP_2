using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

using LabOp222.Models.Interfaces.Serialization;
using LabOp222.Models.Interfaces;
using System.IO;
using System.Runtime.Serialization;

namespace LabOp222.Models
{
    [DataContract]    
    [XmlRoot("MediaInfo")]
    public abstract class MediaInfo
    {
        [DataMember]
        [XmlElement("ID")]
        public Guid Id;
        [DataMember]        
        private string title;
        
        public string Title
        {
            get => title;
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                    title = value;
                else
                    throw new ArgumentException("Title can not be null or empty!");
            }
        }
        

        public MediaInfo()
        {
            Id = Guid.NewGuid();
            Title = DateTime.Now.ToLocalTime().ToString();
        }

        ~MediaInfo()
        {
           // SerializeXml();
        }

        public virtual string GetInfo()
        {
            return ToString();
        }

        public override string ToString()
        {
            return GetType().Name + ": " + Title;
        }
        

        public static void Delete(MediaInfo obj)
        {
            obj.Delete();
        }        

        public abstract void Delete();

        //public string SerializeXml()
        //{
        //    XmlSerializer formatter = new XmlSerializer(this.GetType());

        //    using(FileStream fileStream = new FileStream(this.GetType().Name + ".xml", FileMode.OpenOrCreate))
        //    {
        //        formatter.Serialize(fileStream, this);
        //    }
        //    return this + " is serialized";
        //}

        //public string DeserializeXml()
        //{
        //    XmlSerializer formatter = new XmlSerializer(this.GetType());
        //    using (FileStream fileStream = new FileStream(this.GetType().Name + ".xml", FileMode.Open))
        //    {
        //        MediaInfo newMedia = formatter.Deserialize(fileStream) as MediaInfo;
        //        return newMedia + " is deserialized";
        //    }            
        //}        
    }
}