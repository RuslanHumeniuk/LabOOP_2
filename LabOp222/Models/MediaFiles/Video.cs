using LabOp222.Models.Interfaces;
using LabOp222.Models.Modes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace LabOp222.Models.MediaFiles
{
    [Serializable]
    public class Video : MediaFile, IBinarySerialization
    {
        private int length = 0;
        public int Length
        {
            get => this.length;
            set => length = value >= 0 ? value : throw new ArgumentException("Length shoud be non-negative");
        }
        private readonly bool isSerialize = true;

        public IVideoMode Mode
        {
            get => this.mode as IVideoMode;
            set
            {
                if (value != null && value is IVideoMode)
                {
                    this.mode = value as Mode;
                }
            }
        }

        public Video(bool isSerializable = true) : base()
        {
            isSerialize = isSerializable;
        }
        public Video(string title) : base()
        {
            Title = title;
        }
        public Video(IVideoMode mode) : base()
        {
            Mode = mode;
        }
        public Video(IVideoMode mode, string title) : this(mode)
        {
            Title = title;
        }

        ~Video()
        {
            if(isSerialize)
                Serialize();
        }

        public string RecordVideo()
        {
            return Mode?.RecordVideo();
        }

        public override string GetInfo()
        {
            return base.GetInfo() + ("\nCurrent mode: " + Mode?.GetType().Name ?? "unknown") + "\nLength of video: " + this.length;
        }

        public static IList<Video> GetVideosByMode(Repository<Video> repository, IVideoMode mode)
        {
            if (repository.MediaInfoObjects.Count < 1)
            {
                return null;
            }

            List<Video> videos = new List<Video>();
            foreach (var video in repository.MediaInfoObjects)
            {
                if (video.Mode == mode)
                {
                    videos.Add(video);
                }
            }
            return videos.Count > 0 ? videos : null;
        }

        public string Serialize()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream("Video" + GetHashCode() + ".dat", FileMode.Create))
            {
                formatter.Serialize(stream, this);
                return ToString() + " is serialized!";
            }
        }

        public Video[] Deserialize()
        {
            List<Video> videos = new List<Video>();
            BinaryFormatter formatter = new BinaryFormatter();
            foreach (var file in Directory.GetFiles(Environment.CurrentDirectory).Where(name => name.Contains("Video")))
            {
                using (FileStream stream = new FileStream(file, FileMode.Open))
                {
                    Video video = (Video)formatter.Deserialize(stream);
                    video.Mode = Modes.Mode.AllModes.First(mode => mode.ToString().Equals(video.Mode.ToString())) as IVideoMode;                    
                    videos.Add(video);
                }
            }
            foreach (var file in Directory.GetFiles(Environment.CurrentDirectory).Where(name => name.Contains("Video")))
            {
                File.Delete(file);
            }
            return videos.ToArray();
        }
    }
}