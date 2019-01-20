namespace LabOp222.Models.Interfaces
{
    public interface IPhotoMode
    {
        string PhotoMessage { get; set; }

        string TakeAPhoto();
    }
}