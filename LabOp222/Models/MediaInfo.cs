using System;

namespace LabOp222.Models
{
    public abstract class MediaInfo
    {
        public readonly Guid Id;

        private string title;

        public string Title
        {
            get => this.title;
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    this.title = value;
                }
                else
                {
                    throw new ArgumentException("Title can not be null or empty!");
                }
            }
        }


        public MediaInfo()
        {
            this.Id = Guid.NewGuid();
            Title = GetType().Name + DateTime.Now.Millisecond;
        }

        public virtual string GetInfo()
        {
            return ToString();
        }

        public override string ToString()
        {
            return GetType().Name + ": " + Title;
        }

        public static void RemoveFromRepository<T>(Repository<T> repository, T obj) where T : MediaInfo
        {
            repository?.Remove(obj);
        }
    }
}