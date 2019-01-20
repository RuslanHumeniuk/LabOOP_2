using LabOp222.Models.Interfaces;
using LabOp222.Models.Modes;

using System.Collections.Generic;

namespace LabOp222.Models.MediaFiles
{
    public class Photo : MediaFile
    {
        public IPhotoMode Mode
        {
            get => this.mode as IPhotoMode;
            set
            {
                if (value != null && value is IPhotoMode)
                {
                    this.mode = value as Mode;
                }
            }
        }

        public Photo() : base() { }
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

        public string TakeAPhoto()
        {
            if (Mode != null)
            {
                return Mode.TakeAPhoto();
            }
            else
            {
                return "Please select some mode!";
            }
        }

        public override string GetInfo()
        {
            return base.GetInfo() + "\nCurrent mode: " + Mode?.GetType().Name ?? "unknown";
        }

        public static IList<Photo> GetPhotosByMode(Repository<Photo> repository, IPhotoMode mode)
        {
            if (repository.MediaInfoObjects.Count < 1)
            {
                return null;
            }

            List<Photo> photos = new List<Photo>();
            foreach (var photo in repository.MediaInfoObjects)
            {
                if (photo.Mode == mode)
                {
                    photos.Add(photo);
                }
            }
            return photos.Count > 0 ? photos : null;
        }
    }
}