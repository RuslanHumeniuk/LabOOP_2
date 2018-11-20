using LabOp222.Models.Interfaces;
using System;
using System.Runtime.Serialization;

namespace LabOp222.Models.Modes
{
    [KnownType(typeof(DefaultMode))]
    [KnownType(typeof(Panorame))]
    [KnownType(typeof(MakeUp))]
    [KnownType(typeof(ProfessionalMode))]
    [KnownType(typeof(TimeLaps))]
    [KnownType(typeof(Mode))]
    [Serializable]
    [DataContract]
    public abstract class Mode
    {              
        public static Mode[] AllModes = new Mode[] { DefaultMode.GetInstance(), MakeUp.GetInstance(), Panorame.GetInstance(), ProfessionalMode.GetInstance(), TimeLaps.GetInstance() };
        public static IPhotoMode[] PhotoModes = new IPhotoMode[] { DefaultMode.GetInstance(), MakeUp.GetInstance(), Panorame.GetInstance(), ProfessionalMode.GetInstance() };
        public static IVideoMode[] VideoModes = new IVideoMode[] { DefaultMode.GetInstance(), MakeUp.GetInstance(), ProfessionalMode.GetInstance(), TimeLaps.GetInstance() };

        public Mode() { }

        public override string ToString()
        {
            return GetType().Name;
        }

        public override bool Equals(object obj)
        {
            return obj != null && obj.GetType().Equals(this.GetType());      
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}