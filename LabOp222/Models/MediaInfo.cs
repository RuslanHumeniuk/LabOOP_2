using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using LabOp222.Models.Interfaces;

namespace LabOp222
{
    abstract internal class MediaInfo
    {        
        private string title;
        public string Title
        {
            get => title;
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                    title = value;
            }
        }

        public Guid Id { get; private set; }

        public MediaInfo()
        {
            Id = Guid.NewGuid();
            Title = new DateTime().ToUniversalTime().ToString();
        }

        public void ChangeTitle(string newTitle)
        {
            Title = newTitle;
        }

        public override string ToString()
        {
            return GetType().Name + ": " + Title;
        }

        public static void Delete(MediaInfo obj)
        {
            obj.Delete();
        }        

        public abstract void Delete();
    }
}