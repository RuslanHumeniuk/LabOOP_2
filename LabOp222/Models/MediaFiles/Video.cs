using System;
using System.Collections.Generic;

using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

using LabOp222.Models.Modes;
using LabOp222.Models;
using LabOp222.Models.Interfaces;
using LabOp222.Models.Interfaces.Serialization;
using System.Threading;
using System.Xml.Serialization;

namespace LabOp222.Models.MediaFiles
{
    [DataContract]
    [Serializable]
    public class Video : MediaFile, IJsonSerialization
    {
        public static List<Video> AllVideos = new List<Video>();

        [DataMember]
        private int length = 0;        
        public int Length
        {
            get => length;
            set
            {                
                if (value >= 0)
                    length = value;
                else
                    throw new ArgumentException("Length shoud be non-negative");
            }
        }

        [XmlIgnore]
        public IVideoMode Mode
        {
            get => Modes.Mode.AllModes[modeIndex] as IVideoMode;
            set
            {
                if(value != null && value is IVideoMode)
                {
                    for (byte i = 0; i < Modes.Mode.AllModes.Length; i++)
                    {
                        if (Modes.Mode.AllModes[i].Equals(value))
                            modeIndex = i;
                    }
                }
            }
        }

        public Video() : base()
        {
            AllVideos.Add(this);
        }
        public Video(string title) : this()
        {
            Title = title;
        }
        public Video(IVideoMode mode) : this()
        {
            Mode = mode;
        }
        public Video(IVideoMode mode, string title) : this(mode)
        {
            Title = title;
        }

        ~Video()
        {
            SerializeJSON();            
        }

        public string RecordVideo()
        {
            if (Mode != null)
            {
                return Mode.RecordVideo();
            }
            else return "Please select some mode";
        }

        public override string GetInfo()
        {
            return base.GetInfo() + ("\nCurrent mode: " + Mode?.GetType().Name ?? "unknown") + "\nLength of video: " + length;
        }

        public static void Delete(int index)
        {
            if (index < 0 || index >= AllVideos.Count)
                throw new ArgumentException(index + " is wrong index!");
            Video video = AllVideos[index];
            video.Delete();
        }
        public override void Delete()
        {
            AllVideos.Remove(this);
            Gallery?.RemoveVideoFromGallery(this.Id);
        }

        public static List<Video> GetVideosByMode(IVideoMode mode)
        {
            if (AllVideos.Count < 1) return null;

            List<Video> videos = new List<Video>();
            foreach (var video in AllVideos)
            {
                if(video.Mode.Equals(mode))
                {
                    videos.Add(video);
                }
            }
            return videos.Count > 0 ? videos : null;
        }

        public string SerializeJSON()
        {
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Video[]));
            using (FileStream stream = new FileStream(this.GetType().Name + ".json", FileMode.Create))
            {
                jsonSerializer.WriteObject(stream, AllVideos.ToArray());
            }
            return "All objects of " + this.GetType().Name + " are serialized";
        }

        public string DeserializeJSON()
        {
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Video[]));
            using (FileStream fs = new FileStream(this.GetType().Name + ".json", FileMode.Open))
            {                
                AllVideos = new List<Video>(jsonSerializer.ReadObject(fs) as Video[]);
                return AllVideos.Count.ToString() + (AllVideos.Count > 1 ? " objects are deserialized" : (AllVideos.Count == 1 ? " object is deserialized" : " - nothing to deserialize!"));
            }
        }

        public override string SerializeXml()
        {
            XmlSerializer formatter = new XmlSerializer(AllVideos.GetType());

            using (FileStream fileStream = new FileStream(this.GetType().Name + ".xml", FileMode.Create, FileAccess.ReadWrite))
            {
                formatter.Serialize(fileStream, AllVideos);
            }
            return this + " is serialized: " + this.Id;
        }

        public override string DeserializeXml()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Video[]));
            using (FileStream fileStream = new FileStream(this.GetType().Name + ".xml", FileMode.Open))
            {
                AllVideos = new List<Video>(formatter.Deserialize(fileStream) as Video[]);                
                return AllVideos.Count.ToString();
            }
        }
    }
}