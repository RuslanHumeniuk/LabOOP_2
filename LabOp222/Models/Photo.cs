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

        private IPhotoMode mode = new DefaultMode();
        public IPhotoMode Mode
        {
            get => mode;
            set
            {
                if(value != null && value is IPhotoMode)
                {
                    mode = value;
                }
            }
        }

        public Photo() : base()
        {            
            AllPhotos.Add(this);
        }
        public Photo(string title) : this()
        {
            Title = title;
        }
        public Photo(IPhotoMode mode) : this()
        {
            Mode = mode;
        }
        public Photo(string title, IPhotoMode mode) : this(mode)
        {
            Title = title;
        }

        ~Photo()
        {
            System.Windows.Forms.MessageBox.Show("Photo " + Title + " is desctructed");
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