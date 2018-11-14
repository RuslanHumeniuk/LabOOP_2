using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using LabOp222.Models.Modes;

namespace LabOp222.Models.MediaFiles
{
    public abstract class MediaFile : MediaInfo
    {
        protected Mode mode = DefaultMode.GetInstance();

        public bool IsInGallery
        {
            get => Gallery != null;
        }

        public Gallery Gallery
        {
            get
            {
                foreach (var gallery in Gallery.Galleries)
                {                    
                    if (gallery.Files != null && gallery.Files.Contains(this))
                        return gallery;
                }
                return null;
            }
        }

        public override string GetInfo()
        {
            return base.GetInfo() + "\nGallery: " + (Gallery?.Title ?? "no one");
        }      

        public static List<MediaFile> GetMediaFilesByMode(Mode mode)
        {
            if (Photo.AllPhotos.Count < 1 && Video.AllVideos.Count < 1) return null;

            List<MediaFile> files = new List<MediaFile>();

            if(mode is Interfaces.IPhotoMode)
            {
                files.AddRange(Photo.GetPhotosByMode(mode as Interfaces.IPhotoMode) ?? new List<Photo>());
            }

            if(mode is Interfaces.IVideoMode)
            {
                files.AddRange(Video.GetVideosByMode(mode as Interfaces.IVideoMode) ?? new List<Video>());
            }

            return files.Count > 0 ? files : null;
        }
    }
}