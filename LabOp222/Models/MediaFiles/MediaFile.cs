using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

using LabOp222.Models.Modes;

namespace LabOp222.Models.MediaFiles
{
    [KnownType(typeof(Mode))]
    [XmlRoot("MediaFile")]
    [DataContract]
    public abstract class MediaFile : MediaInfo
    {
        [DataMember]
        [XmlElement("Mode_Index")]
        public byte modeIndex = 0;

        public MediaFile() : base() { }

        [XmlIgnore]
        public bool IsInGallery
        {
            get => Gallery != null;
        }
              
        [XmlIgnore]
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