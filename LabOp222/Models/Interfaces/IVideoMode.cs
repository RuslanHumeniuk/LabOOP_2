namespace LabOp222.Models.Interfaces
{
    public interface IVideoMode
    {
        string VideoMessage { get; set; }

        string RecordVideo();
    }
}