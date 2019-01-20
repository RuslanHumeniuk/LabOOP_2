using LabOp222.Models.MediaFiles;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabOp222.Models
{
    public class Gallery : MediaInfo, IEnumerable
    {
        private readonly IList<Photo> photos = new List<Photo>();
        private readonly IList<Video> videos = new List<Video>();

        public IList<Photo> Photos
        {
            get => this.photos;
            set
            {
                this.photos.Clear();
                foreach (var item in value)
                {
                    this.photos.Add(item);
                }
            }
        }
        public IList<Video> Videos
        {
            get => this.videos;
            set
            {
                this.videos.Clear();
                foreach (var item in value)
                {
                    this.videos.Add(item);
                }
            }
        }
        public IList<MediaFile> Files
        {
            get
            {
                if (this.videos.Count < 1 && this.photos.Count < 1)
                {
                    return new List<MediaFile>();
                }

                List<MediaFile> fileList = new List<MediaFile>();

                foreach (var item in Photos)
                {
                    fileList.Add(item);
                }
                foreach (var item in Videos)
                {
                    fileList.Add(item);
                }

                return fileList;
            }
            set
            {
                this.videos.Clear();
                this.photos.Clear();

                foreach (var item in value)
                {
                    if (item is Photo)
                    {
                        this.photos.Add(item as Photo);
                    }
                    else if (item is Video)
                    {
                        this.videos.Add(item as Video);
                    }
                }
            }
        }

        public Gallery(string title) : base()
        {
            Title = title;
        }
        public Gallery(MediaFile[] files) : base()
        {
            Files = files.ToList();
        }

        public void AddFile(MediaFile file)
        {
            if (file is Photo)
            {
                this.photos.Add(file as Photo);
            }
            else if (file is Video)
            {
                this.videos.Add(file as Video);
            }
        }

        public void RemoveMediaFileFromGallery(MediaFile file)
        {
            if (file is Photo)
            {
                this.photos.Remove(file as Photo);
            }
            else if (file is Video)
            {
                this.videos.Remove(file as Video);
            }
        }

        public void RemovePhotoFromGallery(Guid photoGuid)
        {
            foreach (var photo in this.photos)
            {
                if (photo.Id.Equals(photoGuid))
                {
                    this.photos.Remove(photo);
                    break;
                }
            }
        }
        public void RemoveVideoFromGallery(Guid videoGuid)
        {
            foreach (var video in this.videos)
            {
                if (video.Id.Equals(videoGuid))
                {
                    this.videos.Remove(video);
                    break;
                }
            }
        }

        public void RemovePhotoFromGallery(int index)
        {
            if (index < 0 || index >= this.photos.Count)
            {
                throw new ArgumentException(index + " is wrong photo index. ");
            }
            else
            {
                this.photos.RemoveAt(index);
            }
        }
        public void RemoveVideoFromGallery(int index)
        {
            if (index < 0 || index >= this.videos.Count)
            {
                throw new ArgumentException(index + " is wrong video index. ");
            }
            else
            {
                this.videos.RemoveAt(index);
            }
        }

        public override string GetInfo()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(base.GetInfo());
            stringBuilder.AppendLine("Count of photos: " + this.photos.Count + ", count of videos: " + this.videos.Count);
            stringBuilder.AppendLine("Inner files:");
            if (Files.Count > 0)
            {
                foreach (var mediaFile in this) //using of IENUMERABLE!
                {
                    stringBuilder.AppendLine(mediaFile.ToString());
                }
            }
            else
            {
                stringBuilder.Append("No one file!");
            }

            return stringBuilder.ToString();
        }

        public IEnumerator GetEnumerator()
        {
            return Files.GetEnumerator();
        }
    }
}