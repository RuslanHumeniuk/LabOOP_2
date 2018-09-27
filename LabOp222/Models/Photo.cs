using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using LabOp222.Models.Modes;
using LabOp222.Models;
using LabOp222.Models.Interfaces;

namespace LabOp222.Models
{
    internal class Photo : MediaInfo
    {
        public static List<Photo> AllPhotos = new List<Photo>();

        //private byte[] bytesOfPhoto { get; set; }
        public IPhotoMode Mode { get; set; }

        public Photo() : base()
        {
            Mode = new DefaultMode();
            AllPhotos.Add(this);
        }
        public Photo(Gallery gallery) : this()
        {
            gallery.AddPhoto(this);
        }
        public Photo(IPhotoMode mode) : this()
        {
            Mode = mode;
        }
        public Photo(IPhotoMode mode, Gallery gallery) : this(gallery)
        {
            Mode = mode;
        }

        public string TakeAPhoto()
        {
            if (Mode != null)
                return Mode.TakeAPhoto();
            else return "Please select some mode!";
        }
    }
}