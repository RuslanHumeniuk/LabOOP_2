using LabOp222.Models;
using LabOp222.Models.Interfaces;
using LabOp222.Models.MediaFiles;
using LabOp222.Models.Modes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LabOp222
{
    public partial class MediaForm : Form
    {
        #region Init region
        private List<MediaFile> HelpedList = new List<MediaFile>();
        private object objectToEdit = null;

        private readonly Repository<Video> VideoRepository = new Repository<Video>();
        private readonly Repository<Photo> PhotoRepository = new Repository<Photo>();
        private readonly Repository<Gallery> GalleryRepository = new Repository<Gallery>();

        public MediaForm()
        {
            InitializeComponent();

            Photo firstPhoto = new Photo("First Ph") { Mode = Mode.PhotoModes[3] };
            Photo secondPhoto = new Photo("Second Ph");

            this.PhotoRepository.Add(firstPhoto);
            this.PhotoRepository.Add(secondPhoto);

            Video firstVideo = new Video("First Vid") { Mode = Mode.VideoModes[3] };
            Video secondVideo = new Video("Second Vid");
            this.VideoRepository.Add(firstVideo);
            this.VideoRepository.Add(secondVideo);

            Gallery gallery = new Gallery("Main gallery");
            Gallery secondGallery = new Gallery("Second gallery");

            this.GalleryRepository.Add(gallery);
            this.GalleryRepository.Add(secondGallery);

            gallery.AddFile(firstPhoto);
            gallery.AddFile(secondVideo);

            this.ComboBoxStaticPageMode.DataSource = Mode.AllModes;
        }
        #endregion

        #region Creating page

        private void ChangeWorkMode(bool isCreateMode)
        {
            if (isCreateMode)
            {
                CPHideEditMode();
                switch (this.ComboBoxCreatePageSelectClass.SelectedIndex)
                {
                    case 0:
                        {
                            CPShowPhotoInfo(null);
                            break;
                        }
                    case 1:
                        {
                            CPShowVideoInfo(null);
                            break;
                        }
                    case 2:
                        {
                            CPShowGalleryInfo(null);
                            break;
                        }
                }
            }
            else
            {
                CPHideCreateMode();
                CPUpdateLabels("Select object", null, null, null, null, null, null);
                switch (this.ComboBoxCreatePageSelectClass.SelectedIndex)
                {
                    case 0:
                        {
                            CPUpdateComboBoxes(null, null, null, this.PhotoRepository.MediaInfoObjects.ToArray());
                            break;
                        }
                    case 1:
                        {
                            CPUpdateComboBoxes(null, null, null, this.VideoRepository.MediaInfoObjects.ToArray());
                            break;
                        }
                    case 2:
                        {
                            CPUpdateComboBoxes(null, null, null, this.GalleryRepository.MediaInfoObjects.ToArray());
                            break;
                        }
                    case 3:
                        {
                            CPUpdateComboBoxes(null, null, null, Mode.AllModes);
                            break;
                        }
                }
            }
        }

        private void CPShowPhotoInfo(Photo photo)
        {
            this.objectToEdit = photo;

            CPUpdateGroupBoxes(2, null);
            CPUpdateLabels(photo != null ? "Select photo" : null, "Title", null, null, "Select photo mode", null, null);
            CPUpdateTextBoxes(photo?.Title ?? String.Empty, null, null);
            CPUpdateComboBoxes(Mode.PhotoModes, null, null, photo != null ? this.PhotoRepository.MediaInfoObjects.ToArray() : null);
            CPUpdateButtons(photo == null, true);

            this.ComboBoxCreatePagePhotos.SelectedItem = photo?.Mode;
        }
        private void CPShowVideoInfo(Video video)
        {
            this.objectToEdit = video;

            CPUpdateGroupBoxes(2, null);
            CPUpdateLabels(video != null ? "Select video" : null, "Title", "Length of video", null, null, "Select video mode", null);
            CPUpdateTextBoxes(video?.Title ?? String.Empty, video?.Length.ToString() ?? String.Empty, null);
            CPUpdateComboBoxes(null, Mode.VideoModes, null, video != null ? this.VideoRepository.MediaInfoObjects.ToArray() : null);
            CPUpdateButtons(video == null, true);

            this.ComboBoxCreatePageVideos.SelectedItem = video?.Mode;
        }
        private void CPShowGalleryInfo(Gallery gallery)
        {
            this.objectToEdit = gallery;
            this.HelpedList = (gallery?.Files as List<MediaFile>) ?? new List<MediaFile>();
            CPUpdateGroupBoxes(2, null);
            CPUpdateLabels(gallery != null ? "Select gallery" : null, "Title", null, null, "All photo", "All video", "Selected files");
            CPUpdateTextBoxes(gallery?.Title ?? String.Empty, null, null);
            CPUpdateComboBoxes(this.PhotoRepository.MediaInfoObjects.ToArray(), this.VideoRepository.MediaInfoObjects.ToArray(), this.HelpedList.ToArray(), gallery != null ? this.GalleryRepository.MediaInfoObjects.ToArray() : null);
            CPUpdateButtons(gallery == null, true);
        }
        private void CPShowModeInfo(Mode mode)
        {
            this.objectToEdit = mode;
            bool isPhotoMode = mode is IPhotoMode;
            bool isVideoMode = mode is IVideoMode;

            CPUpdateButtons(false, mode != null);
            CPUpdateModeGroupBox(new bool[] { isPhotoMode, isVideoMode });
            CPUpdateLabels("Select mode", "Title", isPhotoMode ? "Photo message" : null, isVideoMode ? "Video message" : null, null, null, null);
            CPUpdateTextBoxes(mode?.GetType().Name, isPhotoMode ? (mode as IPhotoMode).PhotoMessage : null, isVideoMode ? (mode as IVideoMode).VideoMessage : null);
            CPUpdateComboBoxes(null, null, null, Mode.AllModes);
        }

        #region Update
        private void CPUpdateLabels(string editObjLbl, string titleLabel, string middleLbl, string lowerLbl, string photoLabel, string videoLabel, string selectedObjectLabel)
        {
            if (editObjLbl != null)
            {
                this.LblCreatePageSelectEditObject.Text = editObjLbl;
                this.LblCreatePageSelectEditObject.Visible = true;
            }
            else
            {
                this.LblCreatePageSelectEditObject.Visible = false;
            }

            if (titleLabel != null)
            {
                this.LblCreatePageTitle.Text = titleLabel;
                this.LblCreatePageTitle.Visible = true;
            }
            else
            {
                this.LblCreatePageTitle.Visible = false;
            }

            if (middleLbl != null)
            {
                this.LblCreatePageMiddle.Text = middleLbl;
                this.LblCreatePageMiddle.Visible = true;
            }
            else
            {
                this.LblCreatePageMiddle.Visible = false;
            }

            if (lowerLbl != null)
            {
                this.LblCreatePageLower.Text = lowerLbl;
                this.LblCreatePageLower.Visible = true;
            }
            else
            {
                this.LblCreatePageLower.Visible = false;
            }

            if (photoLabel != null)
            {
                this.LblCreatePagePhotos.Text = photoLabel;
                this.LblCreatePagePhotos.Visible = true;
            }
            else
            {
                this.LblCreatePagePhotos.Visible = false;
            }

            if (videoLabel != null)
            {
                this.LblCreatePageVideos.Text = videoLabel;
                this.LblCreatePageVideos.Visible = true;
            }
            else
            {
                this.LblCreatePageVideos.Visible = false;
            }

            if (selectedObjectLabel != null)
            {
                this.LblCreatePageSelectedObject.Text = selectedObjectLabel;
                this.LblCreatePageSelectedObject.Visible = true;
            }
            else
            {
                this.LblCreatePageSelectedObject.Visible = false;
            }
        }
        private void CPUpdateTextBoxes(string titleTextBox, string middleTextBox, string lowerTextBox)
        {
            if (titleTextBox != null)
            {
                this.TextBoxCreatePageTitle.Text = titleTextBox;
                this.TextBoxCreatePageTitle.Visible = true;
            }
            else
            {
                this.TextBoxCreatePageTitle.Visible = false;
            }

            if (middleTextBox != null)
            {
                this.TextBoxCreatePageMiddle.Text = middleTextBox;
                this.TextBoxCreatePageMiddle.Visible = true;
            }
            else
            {
                this.TextBoxCreatePageMiddle.Visible = false;
            }

            if (lowerTextBox != null)
            {
                this.TextBoxCreatePageLower.Text = lowerTextBox;
                this.TextBoxCreatePageLower.Visible = true;
            }
            else
            {
                this.TextBoxCreatePageLower.Visible = false;
            }
        }
        private void CPUpdateComboBoxes(object[] photos, object[] videos, MediaInfo[] selectedMediaFiles, object[] objectsToEdit)
        {
            if (photos != null)
            {
                this.ComboBoxCreatePagePhotos.DataSource = photos;
                this.ComboBoxCreatePagePhotos.SelectedIndex = -1;
                this.ComboBoxCreatePagePhotos.Visible = true;
            }
            else
            {
                this.ComboBoxCreatePagePhotos.Visible = false;
            }

            if (videos != null)
            {
                this.ComboBoxCreatePageVideos.DataSource = videos;
                this.ComboBoxCreatePageVideos.SelectedIndex = -1;
                this.ComboBoxCreatePageVideos.Visible = true;
            }
            else
            {
                this.ComboBoxCreatePageVideos.Visible = false;
            }

            if (selectedMediaFiles != null)
            {
                this.ComboBoxCreatePageSelectedObjects.DataSource = selectedMediaFiles;
                this.ComboBoxCreatePageSelectedObjects.SelectedIndex = -1;
                this.ComboBoxCreatePageSelectedObjects.Visible = true;
            }
            else
            {
                this.ComboBoxCreatePageSelectedObjects.Visible = false;
            }

            if (objectsToEdit != null)
            {
                this.ComboBoxCreatePageEditObject.DataSource = objectsToEdit;
                this.ComboBoxCreatePageEditObject.SelectedIndex = -1;
                this.ComboBoxCreatePageEditObject.Visible = true;
            }
            else
            {
                this.ComboBoxCreatePageEditObject.Visible = false;
            }
        }
        private void CPUpdateButtons(bool clearBtn, bool saveBtn)
        {
            this.BtnCreatePageClear.Visible = clearBtn;
            this.BtnCreatePageSave.Visible = saveBtn;
        }

        private void CPUpdateGroupBoxes(byte workMode, bool[] modes)
        {
            CPUpdateWorkGroupBox(workMode);
            CPUpdateModeGroupBox(modes);
        }
        private void CPUpdateWorkGroupBox(byte workMode)
        {
            this.GroupBoxCreatePageSelectWorkMode.Visible = workMode != 0;

            switch (workMode)
            {
                case 2:
                    {
                        this.GroupBoxCreatePageSelectWorkMode.Enabled = true;
                        break;
                    }
                case 1:
                    {
                        this.GroupBoxCreatePageSelectWorkMode.Enabled = false;
                        this.RadioButtonCreatePageEditMode.Checked = true;
                        break;
                    }
                case 0:
                    {
                        this.RadioButtonCreatePageCreateMode.Checked = false;
                        this.RadioButtonCreatePageEditMode.Checked = false;
                        break;
                    }
            }
        }
        private void CPUpdateModeGroupBox(bool[] modes)
        {
            if (modes != null)
            {
                this.GroupBoxCreatePageModeType.Visible = true;
                this.CheckBoxCreatePagePhotoMode.Checked = modes[0];
                this.CheckBoxCreatePageVideoMode.Checked = modes[1];
            }
            else
            {
                this.GroupBoxCreatePageModeType.Visible = false;
                this.CheckBoxCreatePagePhotoMode.Checked = false;
                this.CheckBoxCreatePageVideoMode.Checked = false;
            }
        }
        #endregion

        private void CPClearAndHideAll()
        {
            this.HelpedList = new List<MediaFile>();
            CPHideEditMode();
            CPHideCreateMode();
            CPUpdateComboBoxes(null, null, null, null);
            CPUpdateTextBoxes(null, null, null);
            CPUpdateLabels(null, null, null, null, null, null, null);
        }

        private void CPClearFields()
        {
            switch (this.ComboBoxCreatePageSelectClass.SelectedIndex)
            {
                case 0:
                    {
                        CPClearAllFields(true, false, false);
                        break;
                    }
                case 1:
                    {
                        CPClearAllFields(true, true, false);
                        break;
                    }
                case 2:
                    {
                        CPClearAllFields(true, true, true);
                        break;
                    }
            }
        }
        private void CPClearAllFields(bool textBoxTitle, bool textBoxLength, bool helpedList)
        {
            if (textBoxTitle)
            {
                this.TextBoxCreatePageTitle.Clear();
            }
            if (textBoxLength)
            {
                this.TextBoxCreatePageMiddle.Clear();
            }
            if (helpedList)
            {
                this.HelpedList = new List<MediaFile>();
                CPUpdateComboBoxes(this.PhotoRepository.MediaInfoObjects.ToArray(), this.VideoRepository.MediaInfoObjects.ToArray(), this.HelpedList.ToArray(), null);
            }
        }

        private void CPHideCreateMode()
        {
            CPUpdateLabels("Select obj", null, null, null, null, null, null);
            CPUpdateTextBoxes(null, null, null);
            CPUpdateButtons(false, false);

            this.ComboBoxCreatePagePhotos.Visible = false;
            this.ComboBoxCreatePageVideos.Visible = false;
            this.ComboBoxCreatePageSelectedObjects.Visible = false;
        }
        private void CPHideEditMode()
        {
            CPUpdateLabels(null, null, null, null, null, null, null);
            CPUpdateModeGroupBox(null);
            this.ComboBoxCreatePageEditObject.Visible = false;
        }

        private void RadioButtonCreatePageCreateMode_CheckedChanged(object sender, EventArgs e)
        {
            ChangeWorkMode(this.RadioButtonCreatePageCreateMode.Checked);
        }

        #region Combo boxes
        private void ComboBoxCreatePageSelectClass_SelectionChangeCommitted(object sender, EventArgs e)
        {

            if (this.TabControlMain.SelectedIndex == 0 && this.ComboBoxCreatePageSelectClass.SelectedIndex != -1)
            {
                CPClearAndHideAll();
                switch (this.ComboBoxCreatePageSelectClass.SelectedIndex)
                {
                    case 0:
                    case 1:
                    case 2:
                        {
                            CPUpdateWorkGroupBox(2);
                            this.TextBoxCreatePageTitle.Enabled = true;
                            break;
                        }
                    case 3:
                        {
                            CPUpdateWorkGroupBox(1);
                            ChangeWorkMode(false);
                            this.TextBoxCreatePageTitle.Enabled = false; //user can not change title of mode, because Title of some mode - is Name of its type
                            break;
                        }
                }
            }
        }

        private void ComboBoxCreatePageEditObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.TabControlMain.SelectedIndex == 0 && this.ComboBoxCreatePageEditObject.SelectedIndex != -1 && this.ComboBoxCreatePageEditObject.Focused)
            {
                CPHideEditMode();
                object obj = this.ComboBoxCreatePageEditObject.SelectedItem;
                switch (this.ComboBoxCreatePageSelectClass.SelectedIndex)
                {
                    case 0:
                        {
                            CPShowPhotoInfo(obj as Photo);
                            break;
                        }
                    case 1:
                        {
                            CPShowVideoInfo(obj as Video);
                            break;
                        }
                    case 2:
                        {
                            CPShowGalleryInfo(obj as Gallery);
                            break;
                        }
                    case 3:
                        {
                            CPShowModeInfo(obj as Mode);
                            break;
                        }
                }
            }
        }

        private void ComboBoxCreatePagePhotos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (this.TabControlMain.SelectedIndex == 0 && this.ComboBoxCreatePagePhotos.SelectedIndex != -1 && this.ComboBoxCreatePagePhotos.Focused)
            {
                if (this.ComboBoxCreatePageSelectClass.SelectedIndex == 2)
                {
                    if (!this.HelpedList.Contains(this.ComboBoxCreatePagePhotos.SelectedItem as Photo))
                    {
                        this.HelpedList.Add(this.ComboBoxCreatePagePhotos.SelectedItem as Photo);
                    }

                    CPUpdateComboBoxes(this.PhotoRepository.MediaInfoObjects.ToArray(), this.VideoRepository.MediaInfoObjects.ToArray(), this.HelpedList.ToArray(), this.GalleryRepository.MediaInfoObjects.ToArray());
                }
            }
        }
        private void ComboBoxCreatePageVideos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (this.TabControlMain.SelectedIndex == 0 && this.ComboBoxCreatePageVideos.SelectedIndex != -1 && this.ComboBoxCreatePageVideos.Focused)
            {
                if (this.ComboBoxCreatePageSelectClass.SelectedIndex == 2)
                {
                    if (!this.HelpedList.Contains(this.ComboBoxCreatePageVideos.SelectedItem as Video))
                    {
                        this.HelpedList.Add(this.ComboBoxCreatePageVideos.SelectedItem as Video);
                    }

                    CPUpdateComboBoxes(this.PhotoRepository.MediaInfoObjects.ToArray(), this.VideoRepository.MediaInfoObjects.ToArray(), this.HelpedList.ToArray(), this.GalleryRepository.MediaInfoObjects.ToArray());
                }
            }
        }
        private void ComboBoxCreatePageSelectedObjects_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (this.TabControlMain.SelectedIndex == 0 && this.ComboBoxCreatePageSelectedObjects.SelectedIndex != -1 && this.ComboBoxCreatePageSelectedObjects.Focused)
            {
                if (this.HelpedList.Contains(this.ComboBoxCreatePageSelectedObjects.SelectedItem as MediaInfo))
                {
                    this.HelpedList.Remove(this.ComboBoxCreatePageSelectedObjects.SelectedItem as MediaFile);
                }

                CPUpdateComboBoxes(this.PhotoRepository.MediaInfoObjects.ToArray(), this.VideoRepository.MediaInfoObjects.ToArray(), this.HelpedList.ToArray(), this.GalleryRepository.MediaInfoObjects.ToArray());
            }
        }
        #endregion

        private void BtnCreatePageClear_Click(object sender, EventArgs e)
        {
            CPClearFields();
        }
        private void BtnCreatePageSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.objectToEdit == null)
                {
                    MediaInfo newObj = null;

                    switch (this.ComboBoxCreatePageSelectClass.SelectedIndex)
                    {
                        case 0:
                            {
                                newObj = new Photo() { Title = this.TextBoxCreatePageTitle.Text, Mode = this.ComboBoxCreatePagePhotos.SelectedItem as IPhotoMode };
                                this.PhotoRepository.Add(newObj as Photo);
                                break;
                            }
                        case 1:
                            {
                                if (int.TryParse(this.TextBoxCreatePageMiddle.Text, out int length) && length >= 0)
                                {
                                    newObj = new Video() { Title = this.TextBoxCreatePageTitle.Text, Length = length, Mode = this.ComboBoxCreatePageVideos.SelectedItem as IVideoMode };
                                    this.VideoRepository.Add(newObj as Video);
                                }
                                else
                                {
                                    throw new ArgumentException("Please input non-negative integer");
                                }

                                break;
                            }
                        case 2:
                            {
                                newObj = new Gallery(this.TextBoxCreatePageTitle.Text) { Files = HelpedList };
                                this.GalleryRepository.Add(newObj as Gallery);
                                break;
                            }
                    }
                    MessageBox.Show(newObj.ToString() + " added");
                }
                else
                {
                    switch (this.ComboBoxCreatePageSelectClass.SelectedIndex)
                    {
                        case 0:
                            {
                                Photo currentPhoto = this.objectToEdit as Photo;
                                currentPhoto.Title = this.TextBoxCreatePageTitle.Text;
                                currentPhoto.Mode = this.ComboBoxCreatePagePhotos.SelectedItem as IPhotoMode;

                                break;
                            }
                        case 1:
                            {
                                if (int.TryParse(this.TextBoxCreatePageMiddle.Text, out int length) && length >= 0)
                                {
                                    Video currentVideo = this.objectToEdit as Video;
                                    currentVideo.Title = this.TextBoxCreatePageTitle.Text;
                                    currentVideo.Length = length;
                                    currentVideo.Mode = this.ComboBoxCreatePageVideos.SelectedItem as IVideoMode;
                                }
                                else
                                {
                                    throw new ArgumentException("Please input non-negative integer");
                                }

                                break;
                            }
                        case 2:
                            {
                                Gallery currentGallery = this.objectToEdit as Gallery;
                                currentGallery.Title = this.TextBoxCreatePageTitle.Text;
                                currentGallery.Files = this.HelpedList;
                                break;
                            }
                        case 3:
                            {
                                if (this.objectToEdit is IPhotoMode)
                                {
                                    IPhotoMode mode = this.objectToEdit as IPhotoMode;
                                    mode.PhotoMessage = this.TextBoxCreatePageMiddle.Text;
                                }
                                if (this.objectToEdit is IVideoMode)
                                {
                                    IVideoMode mode = this.objectToEdit as IVideoMode;
                                    mode.VideoMessage = this.TextBoxCreatePageLower.Text;
                                }
                                break;
                            }
                    }
                    MessageBox.Show(this.objectToEdit.ToString() + " edited");
                }

                CPClearAndHideAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Deleting page
        private void ComboBoxDeletePageSelectClass_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.TabControlMain.SelectedIndex == 1 && this.ComboBoxDeletePageSelectClass.SelectedItem != null && this.ComboBoxDeletePageSelectClass.Focused)
            {
                DPHideElements();
                switch (this.ComboBoxDeletePageSelectClass.SelectedIndex)
                {
                    case 0:
                        {
                            DPUpdateObjList(this.PhotoRepository.MediaInfoObjects.ToArray());
                            break;
                        }
                    case 1:
                        {
                            DPUpdateObjList(this.VideoRepository.MediaInfoObjects.ToArray());
                            break;
                        }
                    case 2:
                        {
                            DPUpdateObjList(this.GalleryRepository.MediaInfoObjects.ToArray());
                            break;
                        }
                }
                DPUpdateLabels(true, false);
            }
        }
        private void ComboBoxDeletePageSelectObject_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.TabControlMain.SelectedIndex == 1 && this.ComboBoxDeletePageSelectObject.SelectedItem != null && this.ComboBoxDeletePageSelectObject.Focused)
            {
                DPShowButtons(true, true);
                DPUpdateLabels(true, true);
                DPUpdateInfoTextBox(this.ComboBoxDeletePageSelectObject.SelectedItem as MediaInfo);
            }
        }

        private void DPHideElements()
        {
            DPShowButtons(false, false);
            DPUpdateInfoTextBox(null);
            DPUpdateObjList(null);
            DPUpdateLabels(false, false);
        }
        private void DPUpdateLabels(bool selectObjectLabel, bool infoLabel)
        {
            this.LblDeletePageObject.Visible = selectObjectLabel;
            this.LblDeletePageInfo.Visible = infoLabel;
        }
        private void DPUpdateObjList(MediaInfo[] array)
        {
            if (array != null)
            {
                this.ComboBoxDeletePageSelectObject.DataSource = array;
                this.ComboBoxDeletePageSelectObject.SelectedIndex = -1;
                this.ComboBoxDeletePageSelectObject.Visible = true;
            }
            else
            {
                this.ComboBoxDeletePageSelectObject.Visible = false;
                this.ComboBoxDeletePageSelectObject.DataSource = null;
            }

        }
        private void DPUpdateInfoTextBox(MediaInfo obj)
        {
            if (obj != null)
            {
                this.RichTextBoxDeletePageInfo.Text = obj.GetInfo();
                this.RichTextBoxDeletePageInfo.Visible = true;
            }
            else
            {
                this.RichTextBoxDeletePageInfo.Text = null;
                this.RichTextBoxDeletePageInfo.Visible = false;
            }

        }
        private void DPShowButtons(bool cancelButton, bool deleteButton)
        {
            this.BtnDeletePageCancel.Visible = cancelButton;
            this.BtnDeletePageDelete.Visible = deleteButton;
        }

        private void BtnDeletePageCancel_Click(object sender, EventArgs e)
        {
            DPHideElements();
        }
        private void BtnDeletePageDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deleting", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MediaInfo obj = this.ComboBoxDeletePageSelectObject.SelectedItem as MediaInfo;
                if (obj is Photo)
                {
                    MediaInfo.RemoveFromRepository<Photo>(this.PhotoRepository, obj as Photo);
                    MediaFile.RemoveFromAllGalleries(GalleryRepository, obj as Photo);
                }
                else if (obj is Video)
                {
                    MediaInfo.RemoveFromRepository<Video>(this.VideoRepository, obj as Video);
                    MediaFile.RemoveFromAllGalleries(GalleryRepository, obj as Video);
                }
                else if (obj is Gallery)
                {
                    MediaInfo.RemoveFromRepository<Gallery>(this.GalleryRepository, obj as Gallery);
                }

                MessageBox.Show(obj.ToString() + " is deleted!");

                this.ComboBoxDeletePageSelectClass.SelectedItem = null;
                DPHideElements();
            }
            else
            {
                MessageBox.Show("Okey");
            }
        }
        #endregion        

        #region Static page        
        private void BtnStaticPageGetPhotos_Click(object sender, EventArgs e)
        {
            if (this.ComboBoxStaticPageMode.SelectedItem != null)
            {
                var result = Photo.GetPhotosByMode(this.PhotoRepository, this.ComboBoxStaticPageMode.SelectedItem as IPhotoMode);
                if (result == null)
                {
                    this.RichTextBoxStaticPageResult.Text = "No one photo with this mode";
                    return;
                }
                StringBuilder stringBuilder = new StringBuilder();
                foreach (var photo in result)
                {
                    stringBuilder.AppendLine(photo.ToString());
                }
                this.RichTextBoxStaticPageResult.Text = stringBuilder.ToString();
            }
        }
        private void BtnStaticPageGetVideos_Click(object sender, EventArgs e)
        {
            if (this.ComboBoxStaticPageMode.SelectedItem != null)
            {
                var result = Video.GetVideosByMode(this.VideoRepository, this.ComboBoxStaticPageMode.SelectedItem as IVideoMode);
                if (result == null)
                {
                    this.RichTextBoxStaticPageResult.Text = "No one video with this mode";
                    return;
                }
                StringBuilder stringBuilder = new StringBuilder();
                foreach (var video in result)
                {
                    stringBuilder.AppendLine(video.ToString());
                }
                this.RichTextBoxStaticPageResult.Text = stringBuilder.ToString();
            }
        }
        private void BtnStaticPageGetFiles_Click(object sender, EventArgs e)
        {
            if (this.ComboBoxStaticPageMode.SelectedItem != null)
            {
                var result = MediaFile.GetMediaFilesByMode(this.ComboBoxStaticPageMode.SelectedItem as Mode, this.PhotoRepository, this.VideoRepository);
                if (result == null)
                {
                    this.RichTextBoxStaticPageResult.Text = "No one file with this mode";
                    return;
                }
                StringBuilder stringBuilder = new StringBuilder();
                foreach (var file in result)
                {
                    stringBuilder.AppendLine(file.ToString());
                }
                this.RichTextBoxStaticPageResult.Text = stringBuilder.ToString();
            }
        }

        private void BtnStaticPageClear_Click(object sender, EventArgs e)
        {
            this.RichTextBoxStaticPageResult.Clear();
        }
        #endregion

        private void TabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            CPClearAndHideAll();
            DPHideElements();
        }
    }
}
