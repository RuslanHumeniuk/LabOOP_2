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
                if (photos.Count < 1)
                    return null;
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
                if (videos.Count < 1)
                    return null;
                List<Video> videoList = new List<Video>();
                foreach (var videoGuid in photos)
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

        public Gallery() : base()
        {
            Galleries.Add(this);
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
            Photos.Add(photo);
        }
        public void AddVideo(Video video)
        {
            Videos.Add(video);
        }

    }
}