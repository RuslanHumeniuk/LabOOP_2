using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using LabOp222.Models.Modes;
using LabOp222.Models;
using LabOp222.Models.Interfaces;

namespace LabOp222.Models.MediaFiles
{
    public class Video : MediaFile
    {
        public static List<Video> AllVideos = new List<Video>();

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
        
        public IVideoMode Mode
        {
            get => mode as IVideoMode;
            set
            {
                if(value != null && value is IVideoMode)
                {
                    mode = value as Mode;
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
            System.Windows.Forms.MessageBox.Show("Video " + Title + " is desctructed");
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
    }
}