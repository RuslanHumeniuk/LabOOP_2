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
                    if (gallery.Photos.Contains(this))
                        return gallery;
                }
                return null;
            }            
        }

        public IPhotoMode Mode { get; set; }

        public Photo() : base()
        {
            Mode = new DefaultMode();
            AllPhotos.Add(this);
        }
        public Photo(string title) : this()
        {
            this.Title = title;
        }
        public Photo(Gallery gallery) : this()
        {
            gallery.AddPhoto(this);
        }
        public Photo(string title, Gallery gallery) : this(gallery)
        {
            this.Title = title;
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

        public override string GetInfo()
        {
            return base.GetInfo() + "\nGallery: " + (Gallery?.Title ?? "no one") + "\nCurrent mode: " + Mode?.GetType().Name ?? "unknown";
        }

        public static void Delete(int index)
        {
            if (index < 0 || index >= AllPhotos.Count)
                throw new ArgumentException(index + " is wrong index!");
            Photo photo = AllPhotos[index];
            photo.Delete();
        }
        public override void Delete()
        {
            AllPhotos.Remove(this);
            Gallery?.RemovePhotoFromGallery(this.Id);
        }
    }
}