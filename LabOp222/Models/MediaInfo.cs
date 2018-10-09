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

        public readonly Guid Id;

        public MediaInfo()
        {
            Id = Guid.NewGuid();
            Title = DateTime.Now.ToLocalTime().ToString();
        }

        ~MediaInfo()
        {
            System.Windows.Forms.MessageBox.Show( "MediaInfo " + title + " is desctructed");
        }

        public void ChangeTitle(string newTitle)
        {
            Title = newTitle;
        }

        public virtual string GetInfo()
        {
            return ToString();
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