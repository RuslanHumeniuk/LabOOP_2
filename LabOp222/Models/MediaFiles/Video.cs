using LabOp222.Models.Interfaces;
using LabOp222.Models.Modes;
using System;
using System.Collections.Generic;

namespace LabOp222.Models.MediaFiles
{
    public class Video : MediaFile
    {
        private int length = 0;
        public int Length
        {
            get => this.length;
            set
            {
                if (value >= 0)
                {
                    this.length = value;
                }
                else
                {
                    throw new ArgumentException("Length shoud be non-negative");
                }
            }
        }

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

        public Video() : base() { }
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

        public string RecordVideo()
        {
            if (Mode != null)
            {
                return Mode.RecordVideo();
            }
            else
            {
                return "Please select some mode";
            }
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
    }
}