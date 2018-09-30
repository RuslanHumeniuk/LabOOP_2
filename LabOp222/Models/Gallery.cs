using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using LabOp222.Models;

namespace LabOp222.Models
{
    internal class Gallery : MediaInfo
    {
        public static List<Gallery> Galleries = new List<Gallery>();

        private List<Guid> photos = new List<Guid>();
        private List<Guid> videos = new List<Guid>();

        public List<Photo> Photos
        {
            get
            {
                List<Photo> photoSet = new List<Photo>();
                foreach (var photoGuid in photos)
                {
                    foreach (var photo in Photo.AllPhotos)
                    {
                        if (photoGuid.Equals(photo.Id))
                        {
                            photoSet.Add(photo);
                        }
                    }                    
                }
                return photoSet;
            }
            set
            {
                photos.Clear();
                foreach (var item in value)
                {
                    photos.Add(item.Id);
                }
            }
        }
        public List<Video> Videos
        {
            get
            {
                List<Video> videoList = new List<Video>();
                foreach (var videoGuid in videos)
                {
                    foreach (var video in Video.AllVideos)
                    {
                        if (videoGuid.Equals(video.Id))
                        {
                            videoList.Add(video);
                        }
                    }
                }
                return videoList;
            }
            set
            {
                videos.Clear();
                foreach (var item in value)
                {
                    videos.Add(item.Id);
                }
            }
        }

        public List<MediaInfo> Files
        {
            get
            {
                if (videos.Count < 1 && photos.Count < 1)
                    return null;

                List<MediaInfo> fileList = new List<MediaInfo>();

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
                videos.Clear();
                photos.Clear();

                foreach (var item in value)
                {
                    if (item is Photo)
                        photos.Add(item.Id);
                    else if (item is Video)
                        videos.Add(item.Id);
                }
            }
        }

        public Gallery() : base()
        {
            Galleries.Add(this);
        }
        public Gallery(string title) : this()
        {
            Title = title;
        }
        public Gallery(Photo[] photos) : this()
        {
            Photos = photos.ToList();
        }
        public Gallery(Video[] videos): this()
        {
            Videos = videos.ToList();
        }
        public Gallery(Video[] videos, Photo[] photos) : this(photos)
        {
            Videos = videos.ToList();
        }

        public void AddPhoto(Photo photo)
        {
            photos.Add(photo.Id);
        }
        public void AddVideo(Video video)
        {
            videos.Add(video.Id);
        }
       

        public void RemovePhotoFromGallery(Photo photo)
        {
            Photos.Remove(photo);
        }
        public void RemoveVideoFromGallery(Video video)
        {
            Videos.Remove(video);
        }

        public void RemovePhotoFromGallery(Guid photoGuid)
        {
            if (photos.Contains(photoGuid))
                photos.Remove(photoGuid);
            else
                throw new ArgumentException(this.Title + " does not contain photo with guid " + photoGuid);
        }
        public void RemoveVideoFromGallery(Guid videoGuid)
        {
            if (videos.Contains(videoGuid))
                videos.Remove(videoGuid);
            else
                throw new ArgumentException(this.Title + " does not contain video with guid " + videoGuid);
        }

        public void RemovePhotoFromGallery(int index)
        {
            if (index < 0 || index >= photos.Count)
                photos.RemoveAt(index);
            else
                throw new ArgumentException(index + " is wrong photo index. ");
        }
        public void RemoveVideoFromGallery(int index)
        {
            if (index < 0 || index >= videos.Count)
                videos.RemoveAt(index);
            else
                throw new ArgumentException(index + " is wrong video index. ");
        }

        public override string GetInfo()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(base.GetInfo());
            stringBuilder.AppendLine("Count of photos: " + photos.Count + ", count of videos: " + videos.Count);
            stringBuilder.AppendLine("Inner files:");
            List<MediaInfo> files = Files;
            if (files != null)
            {
                foreach (var item in Files)
                {
                    stringBuilder.AppendLine(item.ToString());
                }
            }
            else
                stringBuilder.Append("No one file!");
            return stringBuilder.ToString();
        }

        public static void Delete(int index)
        {
            if (index < 0 || index >= Galleries.Count)
                throw new ArgumentException(index + " is wrong index!");
            Gallery gallery = Galleries[index];
            gallery.Delete();
        }
        public override void Delete()
        {
            photos.Clear();
            videos.Clear();
            Galleries.Remove(this);
        }       
    }
}