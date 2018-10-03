using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LabOp222.Models;
using LabOp222.Models.Modes;
using LabOp222.Models.Interfaces;

namespace LabOp222
{
    /*TODO:
     + * added selecting mode for photo\video
     - * change selectedIndexChanged on SelectedValueChanged in Create page
     * refactor
     * using modes
     + * hidding edit combo box when edit
     * comment it all
     * test
    */
    public partial class MediaForm : Form
    {
        List<MediaInfo> HelpedList = new List<MediaInfo>();
        MediaInfo[] Modes = new MediaInfo[] { new DefaultMode(), new MakeUp(), new Panorame(), new ProfessionalMode(), new TimeLaps() };
        MediaInfo[] PhotoModes = new MediaInfo[] { new DefaultMode(), new MakeUp(), new Panorame(), new ProfessionalMode() };
        MediaInfo[] VideoModes = new MediaInfo[] { new DefaultMode(), new MakeUp(), new ProfessionalMode(), new TimeLaps() };
        MediaInfo CurrentMediaFile = null;

        public MediaForm()
        {
            InitializeComponent();

            Photo firstPhoto = new Photo("First Ph") { Mode = PhotoModes[3] as IPhotoMode };
            Photo secondPhoto = new Photo("Second Ph");

            Video firstVideo = new Video("First Vid") { Mode = VideoModes[3] as IVideoMode };
            Video secondVideo = new Video("Second Vid");

            Gallery gallery = new Gallery("Main gallery");
            Gallery secondGallery = new Gallery("Second gallery");

            gallery.AddPhoto(firstPhoto);
            gallery.AddVideo(secondVideo);            
        }

        #region Creating page

        private void ChangeWorkMode(bool isCreateMode)
        {            
            if (isCreateMode)
            {
                CPHideEditMode();
                switch (ComboBoxCreatePageSelectClass.SelectedIndex)
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
                switch (ComboBoxCreatePageSelectClass.SelectedIndex)
                {
                    case 0:
                        {
                            CPUpdateComboBoxes(null, null, null, Photo.AllPhotos.ToArray());
                            break;
                        }
                    case 1:
                        {
                            CPUpdateComboBoxes(null, null, null, Video.AllVideos.ToArray());
                            break;
                        }
                    case 2:
                        {
                            CPUpdateComboBoxes(null, null, null, Gallery.Galleries.ToArray());
                            break;
                        }
                    case 3:
                        {
                            CPUpdateComboBoxes(null, null, null, Modes);
                            break;
                        }
                }                
            }
        }
        
        private void CPShowPhotoInfo(Photo photo)
        {
            CurrentMediaFile = photo;

            CPUpdateGroupBoxes(2, null);
            CPUpdateLabels(photo != null ? "Select photo" : null, "Title", null, null, "Select photo mode", null, null);
            CPUpdateTextBoxes(photo?.Title ?? String.Empty, null, null);
            CPUpdateComboBoxes(PhotoModes, null, null, photo != null ? Photo.AllPhotos.ToArray() : null);
            CPUpdateButtons(photo == null, true);      
            
            ComboBoxCreatePagePhotos.SelectedItem = photo?.Mode;
        }        
        private void CPShowVideoInfo(Video video)
        {
            CurrentMediaFile = video;

            CPUpdateGroupBoxes(2, null);
            CPUpdateLabels(video != null ? "Select video" : null, "Title", "Length of video", null, null, "Select video mode", null);
            CPUpdateTextBoxes(video?.Title ?? String.Empty, video?.Length.ToString() ?? String.Empty, null);
            CPUpdateComboBoxes(null, VideoModes, null, video != null ? Video.AllVideos.ToArray() : null);
            CPUpdateButtons(video == null, true);

            ComboBoxCreatePageVideos.SelectedItem = video?.Mode;
        }        
        private void CPShowGalleryInfo(Gallery gallery)
        {
            CurrentMediaFile = gallery;
            HelpedList = gallery?.Files ?? new List<MediaInfo>();
            CPUpdateGroupBoxes(2, null);
            CPUpdateLabels(gallery != null ? "Select gallery" : null, "Title", null, null, "All photo", "All video", "Selected files");
            CPUpdateTextBoxes(gallery?.Title ?? String.Empty, null, null);
            CPUpdateComboBoxes(Photo.AllPhotos.ToArray(), Video.AllVideos.ToArray(), HelpedList.ToArray(), gallery != null ? Gallery.Galleries.ToArray() : null);
            CPUpdateButtons(gallery == null, true);
        }        
        private void CPShowModeInfo(MediaInfo mode)
        {
            CurrentMediaFile = mode;
            bool isPhotoMode = mode is IPhotoMode;
            bool isVideoMode = mode is IVideoMode;

            CPUpdateButtons(false, mode != null);
            CPUpdateModeGroupBox(new bool[] { isPhotoMode, isVideoMode });
            CPUpdateLabels("Select mode", "Title", isPhotoMode ? "Photo message" : null, isVideoMode ? "Video message" : null, null, null, null);
            //TODO: user can not change mode title
            CPUpdateTextBoxes(mode?.GetType().Name, isPhotoMode ? (mode as IPhotoMode).PhotoMessage : null, isVideoMode ? (mode as IVideoMode).VideoMessage : null);
            CPUpdateComboBoxes(null, null, null, Modes);
        }

        private void CPUpdateLabels(string editObjLbl, string titleLabel, string middleLbl, string lowerLbl, string photoLabel, string videoLabel, string selectedObjectLabel)
        {
            if (editObjLbl != null)
            {
                LblCreatePageSelectEditObject.Text = editObjLbl;
                LblCreatePageSelectEditObject.Visible = true;
            }
            else
                LblCreatePageSelectEditObject.Visible = false;

            if (titleLabel != null)
            {
                LblCreatePageTitle.Text = titleLabel;
                LblCreatePageTitle.Visible = true;
            }
            else
                LblCreatePageTitle.Visible = false;

            if (middleLbl != null)
            {
                LblCreatePageMiddle.Text = middleLbl;
                LblCreatePageMiddle.Visible = true;
            }
            else
                LblCreatePageMiddle.Visible = false;

            if (lowerLbl != null)
            {
                LblCreatePageLower.Text = lowerLbl;
                LblCreatePageLower.Visible = true;
            }
            else
                LblCreatePageLower.Visible = false;

            if (photoLabel != null)
            {
                LblCreatePagePhotos.Text = photoLabel;
                LblCreatePagePhotos.Visible = true;
            }
            else
                LblCreatePagePhotos.Visible = false;

            if (videoLabel != null)
            {
                LblCreatePageVideos.Text = videoLabel;
                LblCreatePageVideos.Visible = true;
            }
            else
                LblCreatePageVideos.Visible = false;

            if (selectedObjectLabel != null)
            {
                LblCreatePageSelectedObject.Text = selectedObjectLabel;
                LblCreatePageSelectedObject.Visible = true;
            }
            else LblCreatePageSelectedObject.Visible = false;
        }
        private void CPUpdateTextBoxes(string titleTextBox, string middleTextBox, string lowerTextBox)
        {
            if (titleTextBox != null)
            {
                TextBoxCreatePageTitle.Text = titleTextBox;
                TextBoxCreatePageTitle.Visible = true;
            }
            else TextBoxCreatePageTitle.Visible = false;

            if (middleTextBox != null)
            {
                TextBoxCreatePageMiddle.Text = middleTextBox;
                TextBoxCreatePageMiddle.Visible = true;
            }
            else TextBoxCreatePageMiddle.Visible = false;

            if (lowerTextBox != null)
            {
                TextBoxCreatePageLower.Text = lowerTextBox;
                TextBoxCreatePageLower.Visible = true;
            }
            else TextBoxCreatePageLower.Visible = false;

        }
        private void CPUpdateComboBoxes(object[] photos, object[] videos, MediaInfo[] selectedMediaFiles, MediaInfo[] objectsToEdit)
        {            
            if (photos != null)
            {
                ComboBoxCreatePagePhotos.DataSource = photos;
                ComboBoxCreatePagePhotos.SelectedIndex = -1;
                ComboBoxCreatePagePhotos.Visible = true;
            }
            else ComboBoxCreatePagePhotos.Visible = false;

            if (videos != null)
            {
                ComboBoxCreatePageVideos.DataSource = videos;      
                ComboBoxCreatePageVideos.SelectedIndex = -1;
                ComboBoxCreatePageVideos.Visible = true;
            }
            else ComboBoxCreatePageVideos.Visible = false;

            if (selectedMediaFiles != null)
            {
                ComboBoxCreatePageSelectedObjects.DataSource = selectedMediaFiles;
                ComboBoxCreatePageSelectedObjects.SelectedIndex = -1;                
                ComboBoxCreatePageSelectedObjects.Visible = true;
            }
            else ComboBoxCreatePageSelectedObjects.Visible = false;

            if (objectsToEdit != null)
            {
                ComboBoxCreatePageEditObject.DataSource = objectsToEdit;
                ComboBoxCreatePageEditObject.SelectedIndex = -1;
                ComboBoxCreatePageEditObject.Visible = true;
            }
            else ComboBoxCreatePageEditObject.Visible = false;
        }
        private void CPUpdateButtons(bool clearBtn, bool saveBtn)
        {
            BtnCreatePageClear.Visible = clearBtn;
            BtnCreatePageSave.Visible = saveBtn;
        }

        private void CPUpdateGroupBoxes(byte workMode, bool[] modes)
        {
            CPUpdateWorkGroupBox(workMode);
            CPUpdateModeGroupBox(modes);
        }
        private void CPUpdateWorkGroupBox(byte workMode)
        {
            GroupBoxCreatePageSelectWorkMode.Visible = workMode != 0;

            switch (workMode)
            {
                case 2:
                    {
                        GroupBoxCreatePageSelectWorkMode.Enabled = true;
                        break;
                    }
                case 1:
                    {
                        GroupBoxCreatePageSelectWorkMode.Enabled = false;                        
                        RadioButtonCreatePageEditMode.Checked = true;                        
                        break;
                    }
                case 0:
                    {
                        RadioButtonCreatePageCreateMode.Checked = false;
                        RadioButtonCreatePageEditMode.Checked = false;
                        break;
                    }
            }
        }
        private void CPUpdateModeGroupBox(bool[] modes)
        {
            if (modes != null)
            {
                GroupBoxCreatePageModeType.Visible = true;
                CheckBoxCreatePagePhotoMode.Checked = modes[0];
                CheckBoxCreatePageVideoMode.Checked = modes[1];
            }
            else
            {
                GroupBoxCreatePageModeType.Visible = false;
                CheckBoxCreatePagePhotoMode.Checked = false;
                CheckBoxCreatePageVideoMode.Checked = false;
            }
        }


        private void CPClearAndHideAll()
        {
            HelpedList = new List<MediaInfo>();
            CPHideEditMode();
            CPHideCreateMode();
            CPUpdateComboBoxes(null, null, null, null);
            CPUpdateTextBoxes(null, null, null);
            CPUpdateLabels(null, null, null, null, null, null, null);
        }

        private void CPClearFields()
        {
            switch (ComboBoxCreatePageSelectClass.SelectedIndex)
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
                TextBoxCreatePageTitle.Clear();
            }
            if (textBoxLength)
            {
                TextBoxCreatePageMiddle.Clear();
            }
            if (helpedList)
            {
                HelpedList = new List<MediaInfo>();
                CPUpdateComboBoxes(Photo.AllPhotos.ToArray(), Video.AllVideos.ToArray(), HelpedList.ToArray(), null);
            }
        }
        
        private void CPHideCreateMode()
        {
            CPUpdateLabels("Select obj", null, null, null, null, null, null);
            CPUpdateTextBoxes(null, null, null);
            CPUpdateButtons(false, false);

            ComboBoxCreatePagePhotos.Visible = false;
            ComboBoxCreatePageVideos.Visible = false;
            ComboBoxCreatePageSelectedObjects.Visible = false;
        }
        private void CPHideEditMode()
        {
            CPUpdateLabels(null, null, null, null, null, null, null);
            CPUpdateModeGroupBox(null);
            ComboBoxCreatePageEditObject.Visible = false;
        }        

        private void RadioButtonCreatePageCreateMode_CheckedChanged(object sender, EventArgs e)
        {
            ChangeWorkMode(RadioButtonCreatePageCreateMode.Checked);
        }


        private void ComboBoxCreatePageSelectClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TabControlMain.SelectedIndex == 0 && ComboBoxCreatePageSelectClass.SelectedIndex != -1)
            {
                CPClearAndHideAll();
                switch (ComboBoxCreatePageSelectClass.SelectedIndex)
                {
                    case 0:                        
                    case 1:
                    case 2:
                        {
                            CPUpdateWorkGroupBox(2);
                            TextBoxCreatePageTitle.Enabled = true;
                            break;
                        }
                    case 3:
                        {
                            CPUpdateWorkGroupBox(1);
                            ChangeWorkMode(false);
                            TextBoxCreatePageTitle.Enabled = false; //user can not change title of mode, because Title of some mode - is Name of its type
                            break;
                        }
                }
            }
        }
        
        private void ComboBoxCreatePageEditObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControlMain.SelectedIndex == 0 && ComboBoxCreatePageEditObject.SelectedIndex != -1 && ComboBoxCreatePageEditObject.Focused)
            {
                CPHideEditMode();
                MediaInfo obj = ComboBoxCreatePageEditObject.SelectedItem as MediaInfo;
                switch (ComboBoxCreatePageSelectClass.SelectedIndex)
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
                            CPShowModeInfo(obj);
                            break;
                        }
                }                
            }
        }

        private void ComboBoxCreatePagePhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TabControlMain.SelectedIndex == 0 && ComboBoxCreatePagePhotos.SelectedIndex != -1 && ComboBoxCreatePagePhotos.Focused)
            {
                if(ComboBoxCreatePageSelectClass.SelectedIndex == 2)
                {
                    if (!HelpedList.Contains(ComboBoxCreatePagePhotos.SelectedItem as Photo))
                        HelpedList.Add(ComboBoxCreatePagePhotos.SelectedItem as Photo);

                    CPUpdateComboBoxes(Photo.AllPhotos.ToArray(), Video.AllVideos.ToArray(), HelpedList.ToArray(), null);
                }                          
            }
        }
        private void ComboBoxCreatePageVideos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControlMain.SelectedIndex == 0 && ComboBoxCreatePageVideos.SelectedIndex != -1 && ComboBoxCreatePageVideos.Focused)
            {
                if (ComboBoxCreatePageSelectClass.SelectedIndex == 2)
                {
                    if (!HelpedList.Contains(ComboBoxCreatePageVideos.SelectedItem as Video))
                        HelpedList.Add(ComboBoxCreatePageVideos.SelectedItem as Video);

                    CPUpdateComboBoxes(Photo.AllPhotos.ToArray(), Video.AllVideos.ToArray(), HelpedList.ToArray(), null);
                }
            }
        }
        private void ComboBoxCreatePageSelectedObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControlMain.SelectedIndex == 0 && ComboBoxCreatePageSelectedObjects.SelectedIndex != -1 && ComboBoxCreatePageSelectedObjects.Focused)
            {
                if (HelpedList.Contains(ComboBoxCreatePageSelectedObjects.SelectedItem as MediaInfo))
                    HelpedList.Remove(ComboBoxCreatePageSelectedObjects.SelectedItem as MediaInfo);                      

                CPUpdateComboBoxes(Photo.AllPhotos.ToArray(), Video.AllVideos.ToArray(), HelpedList.ToArray(), null);
            }
        }       
        

        private void BtnCreatePageClear_Click(object sender, EventArgs e)
        {
            CPClearFields();
        }
        private void BtnCreatePageSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(CurrentMediaFile == null)
                {
                    MediaInfo newObj = null;

                    switch (ComboBoxCreatePageSelectClass.SelectedIndex)
                    {
                        case 0:
                            {
                                newObj = new Photo() { Title = TextBoxCreatePageTitle.Text, Mode = ComboBoxCreatePagePhotos.SelectedItem as IPhotoMode };
                                break;
                            }
                        case 1:
                            {
                                if (int.TryParse(TextBoxCreatePageMiddle.Text, out int length) && length >= 0)
                                {
                                    newObj = new Video() { Title = TextBoxCreatePageTitle.Text, Length = length, Mode = ComboBoxCreatePageVideos.SelectedItem as IVideoMode };
                                }
                                else throw new ArgumentException("Please input non-negative integer");

                                break;
                            }
                        case 2:
                            {
                                newObj = new Gallery(TextBoxCreatePageTitle.Text) { Files = HelpedList };
                                break;
                            }
                    }
                    MessageBox.Show(newObj.ToString() + " added");
                }
                else
                {
                    switch (ComboBoxCreatePageSelectClass.SelectedIndex)
                    {
                        case 0:
                            {
                                Photo currentPhoto = CurrentMediaFile as Photo;
                                currentPhoto.Title = TextBoxCreatePageTitle.Text;
                                currentPhoto.Mode = ComboBoxCreatePagePhotos.SelectedItem as IPhotoMode;
                                
                                break;
                            }
                        case 1:
                            {
                                if (int.TryParse(TextBoxCreatePageMiddle.Text, out int length) && length >= 0)
                                {
                                    Video currentVideo = CurrentMediaFile as Video;
                                    currentVideo.Title = TextBoxCreatePageTitle.Text;
                                    currentVideo.Length = length;
                                    currentVideo.Mode = ComboBoxCreatePageVideos.SelectedItem as IVideoMode;
                                }
                                else throw new ArgumentException("Please input non-negative integer");

                                break;
                            }
                        case 2:
                            {
                                Gallery currentGallery = CurrentMediaFile as Gallery;
                                currentGallery.Title = TextBoxCreatePageTitle.Text;
                                currentGallery.Files = HelpedList;                                
                                break;
                            }
                        case 3:
                            {
                                if(CurrentMediaFile is IPhotoMode)
                                {
                                    IPhotoMode mode = CurrentMediaFile as IPhotoMode;
                                    mode.PhotoMessage = TextBoxCreatePageMiddle.Text;
                                }
                                if(CurrentMediaFile is IVideoMode)
                                {
                                    IVideoMode mode = CurrentMediaFile as IVideoMode;
                                    mode.VideoMessage = TextBoxCreatePageLower.Text;
                                }
                                break;
                            }
                    }
                    MessageBox.Show(CurrentMediaFile.ToString() + " edited");                    
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
            if (TabControlMain.SelectedIndex == 1 && ComboBoxDeletePageSelectClass.SelectedItem != null && ComboBoxDeletePageSelectClass.Focused)
            {
                DPHideElements();
                switch (ComboBoxDeletePageSelectClass.SelectedIndex)
                {
                    case 0:
                        {
                            DPUpdateObjList(Photo.AllPhotos.ToArray());
                            break;
                        }
                    case 1:
                        {
                            DPUpdateObjList(Video.AllVideos.ToArray());
                            break;
                        }
                    case 2:
                        {
                            DPUpdateObjList(Gallery.Galleries.ToArray());
                            break;
                        }
                }
                DPUpdateLabels(true, false);
            }
        }
        private void ComboBoxDeletePageSelectObject_SelectedValueChanged(object sender, EventArgs e)
        {
            if(TabControlMain.SelectedIndex == 1 && ComboBoxDeletePageSelectObject.SelectedItem != null && ComboBoxDeletePageSelectObject.Focused)
            {
                DPShowButtons(true, true);
                DPUpdateLabels(true, true);
                DPUpdateInfoTextBox(ComboBoxDeletePageSelectObject.SelectedItem as MediaInfo);
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
            LblDeletePageObject.Visible = selectObjectLabel;
            LblDeletePageInfo.Visible = infoLabel;
        }
        private void DPUpdateObjList(MediaInfo[] array)
        {
            if (array != null)
            {
                ComboBoxDeletePageSelectObject.DataSource = array;
                ComboBoxDeletePageSelectObject.SelectedIndex = -1;
                ComboBoxDeletePageSelectObject.Visible = true;
            }
            else
            {
                ComboBoxDeletePageSelectObject.Visible = false;
                ComboBoxDeletePageSelectObject.DataSource = null;
            }
            
        }
        private void DPUpdateInfoTextBox(MediaInfo obj)
        {
            if (obj != null)
            {
                RichTextBoxDeletePageInfo.Text = obj.GetInfo();
                RichTextBoxDeletePageInfo.Visible = true;
            }
            else
            {
                RichTextBoxDeletePageInfo.Text = null;
                RichTextBoxDeletePageInfo.Visible = false;
            }          

        }
        private void DPShowButtons(bool cancelButton, bool deleteButton)
        {
            BtnDeletePageCancel.Visible = cancelButton;
            BtnDeletePageDelete.Visible = deleteButton;
        }

        private void BtnDeletePageCancel_Click(object sender, EventArgs e)
        {
            DPHideElements();
        }
        private void BtnDeletePageDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deleting", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MediaInfo obj = ComboBoxDeletePageSelectObject.SelectedItem as MediaInfo;
                obj.Delete();
                MessageBox.Show(obj.ToString() + " is deleted!");

                ComboBoxDeletePageSelectClass.SelectedItem = null;
                DPHideElements();
            }
            else
                MessageBox.Show("Okey");
        }

        #endregion

        private void TabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            CPClearAndHideAll();
            DPHideElements();
        }
        
    }
}
