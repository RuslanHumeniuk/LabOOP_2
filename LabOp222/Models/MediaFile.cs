using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using LabOp222.Models.Modes;

namespace LabOp222.Models
{
    internal abstract class MediaFile : MediaInfo
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
    }
}