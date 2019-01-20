using LabOp222.Models.Interfaces;
using System;

namespace LabOp222.Models.Modes
{
    [Serializable]
    public abstract class Mode
    {     
        public static Mode[] AllModes = new Mode[] { DefaultMode.GetInstance(), MakeUp.GetInstance(), Panorame.GetInstance(), ProfessionalMode.GetInstance(), TimeLaps.GetInstance() };     
        public static IPhotoMode[] PhotoModes = new IPhotoMode[] { AllModes[0] as IPhotoMode, AllModes[1] as IPhotoMode, AllModes[2] as IPhotoMode, AllModes[3] as IPhotoMode };     
        public static IVideoMode[] VideoModes = new IVideoMode[] { AllModes[0] as IVideoMode, AllModes[1] as IVideoMode, AllModes[3] as IVideoMode, AllModes[4] as IVideoMode };
        public override string ToString()
        {
            return GetType().Name;
        }        
    }
}