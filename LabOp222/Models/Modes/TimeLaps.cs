using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using LabOp222.Models.Interfaces;

namespace LabOp222.Models.Modes
{
    internal class TimeLaps : MediaInfo, IVideoMode
    {
        private string videoMessage = "Cooool, this video in timelaps";

        public string VideoMessage
        {
            get => videoMessage;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("VideoMessage can't be empty");
                else
                    videoMessage = value;
            }
        }

        public string RecordVideo()
        {
            return VideoMessage;
        }
    }
}