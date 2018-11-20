using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using LabOp222.Models.Modes;
using LabOp222.Models;
using LabOp222.Models.Interfaces;
using System.Xml.Serialization;
using System.IO;
using LabOp222.Models.Interfaces.Serialization;
using System.Threading;

namespace LabOp222.Models.MediaFiles
{
    [XmlRoot("Photo")]
    public class Photo : MediaFile, IXmlSerialization
    {
        [NonSerialized]
        [XmlIgnore]
        public static List<Photo> AllPhotos = new List<Photo>();

        [XmlIgnore]
        public IPhotoMode Mode
        {
            get => Modes.Mode.AllModes[modeIndex] as IPhotoMode;
            set
            {
                if (value != null && value is IPhotoMode)
                {
                    for (byte i = 0; i < Modes.Mode.AllModes.Length; i++)
                    {
                        if (Modes.Mode.AllModes[i].Equals(value))
                            modeIndex = i;
                    }
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
            System.Windows.Forms.MessageBox.Show(SerializeXml());
        }

        public string TakeAPhoto()
        {
            if (Mode != null)
                return Mode.TakeAPhoto();
            else return "Please select some mode!";
        }

        public override string GetInfo()
        {
            return base.GetInfo() + "\nCurrent mode: " + Mode?.GetType().Name ?? "unknown";
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

        public static List<Photo> GetPhotosByMode(IPhotoMode mode)
        {
            if (AllPhotos.Count < 1) return null;

            List<Photo> photos = new List<Photo>();
            foreach (var photo in AllPhotos)
            {
                if(photo.Mode == mode)
                {
                    photos.Add(photo);
                }
            }
            return photos.Count > 0 ? photos : null;
        }

        public string SerializeXml()
        {            
            XmlSerializer formatter = new XmlSerializer(AllPhotos.GetType());

            using (FileStream fileStream = new FileStream(this.GetType().Name + ".xml", FileMode.Create, FileAccess.ReadWrite))
            {
                formatter.Serialize(fileStream, AllPhotos);                
            }
            return this + " is serialized: " + this.Id;
        }

        public string DeserializeXml()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Photo[]));
            using (FileStream fileStream = new FileStream(this.GetType().Name + ".xml", FileMode.Open))
            {
                List<Photo> newPhoto = (formatter.Deserialize(fileStream) as Photo[]).ToList();
                AllPhotos = newPhoto.ToList();
                return AllPhotos.Count.ToString();
            }            
        }
    }
}