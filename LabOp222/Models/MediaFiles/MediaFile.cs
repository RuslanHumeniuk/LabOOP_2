using LabOp222.Models.Modes;
using System.Collections.Generic;

namespace LabOp222.Models.MediaFiles
{
    public abstract class MediaFile : MediaInfo
    {
        protected Mode mode = DefaultMode.GetInstance();

        public bool IsInGallery(Repository<Gallery> repository)
        {
            return GetGalleries(repository) != null;
        }
        public IList<Gallery> GetGalleries(Repository<Gallery> galleryRepository)
        {
            List<Gallery> galleries = new List<Gallery>();
            foreach (var gallery in galleryRepository.MediaInfoObjects)
            {
                if (gallery.Files != null && gallery.Files.Contains(this))
                {
                    galleries.Add(gallery);
                }
            }
            return galleries;
        }

        public static void RemoveFromAllGalleries(Repository<Gallery> galleryRepository, MediaFile file)
        {
            file.RemoveFromAllGalleries(galleryRepository);
        }
        public void RemoveFromAllGalleries(Repository<Gallery> galleryRepository)
        {
            foreach (var gallery in galleryRepository.MediaInfoObjects)
            {
                gallery.RemoveMediaFileFromGallery(this);
            }
        }

        public static IList<MediaFile> GetMediaFilesByMode(Mode mode, Repository<Photo> photoRepository = null, Repository<Video> videoRepository = null)
        {
            if ((photoRepository == null && videoRepository == null) ||
                (photoRepository?.MediaInfoObjects.Count < 1 && videoRepository?.MediaInfoObjects.Count < 1))
            {
                return null;
            }

            List<MediaFile> files = new List<MediaFile>();

            if (mode is Interfaces.IPhotoMode && photoRepository != null)
            {
                files.AddRange(Photo.GetPhotosByMode(photoRepository, mode as Interfaces.IPhotoMode) ?? new List<Photo>());
            }

            if (mode is Interfaces.IVideoMode && videoRepository != null)
            {
                files.AddRange(Video.GetVideosByMode(videoRepository, mode as Interfaces.IVideoMode) ?? new List<Video>());
            }

            return files.Count > 0 ? files : null;
        }
    }
}