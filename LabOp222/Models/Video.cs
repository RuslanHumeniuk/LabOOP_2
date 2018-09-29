﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using LabOp222.Models.Modes;
using LabOp222.Models;
using LabOp222.Models.Interfaces;

namespace LabOp222.Models
{
    internal class Video : MediaInfo
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

        public IVideoMode Mode { get; set; }

        public Video() : base()
        {
            Mode = new DefaultMode();
            AllVideos.Add(this);
        }
        public Video(string title) : this()
        {
            Title = title;
        }
        public Video(Gallery gallery) : this()
        {
            gallery.Videos.Add(this);
        }
        public Video(Gallery gallery, string title) : this(gallery)
        {
            Title = title;
        }
        public Video(IVideoMode mode) : this()
        {
            Mode = mode;
        }
        public Video(IVideoMode mode, Gallery gallery) : this(gallery)
        {
            Mode = mode;
        }

        public string RecordVideo()
        {
            if (Mode != null)
            {
                return Mode.RecordVideo();
            }
            else return "Please select some mode";
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
        }
    }
}