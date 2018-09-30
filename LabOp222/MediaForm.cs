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

namespace LabOp222
{
    public partial class MediaForm : Form
    {
        List<MediaInfo> HelpedList = new List<MediaInfo>();

        public MediaForm()
        {
            InitializeComponent();

            HelpedList = new List<MediaInfo>();

            Photo firstPhoto = new Photo("First Ph");
            Photo secondPhoto = new Photo("Second Ph");

            Video firstVideo = new Video("First Vid");
            Video secondVideo = new Video("Second Vid");

            Gallery gallery = new Gallery("Main gallery");
            Gallery secondGallery = new Gallery("Second gallery");

            gallery.AddPhoto(firstPhoto);
            gallery.AddVideo(secondVideo);

            RadioButtonCreatePageCreateMode.Checked = true;
        }

        #region Creating page

        private void CPShowPhotoInfo()
        {
            CPShowLabels("Title", null, null, null, null);
            CPShowTextBoxes(String.Empty, null);
            CPShowComboBoxes(null, null, null);
            CPShowButtons(true, true);
        }
        private void CPShowVideoInfo()
        {
            CPShowLabels("Title", "Length of video", null, null, null);
            CPShowTextBoxes(String.Empty, String.Empty);
            CPShowComboBoxes(null, null, null);
            CPShowButtons(true, true);
        }
        private void CPShowGalleryInfo()
        {
            CPShowLabels("Title", null, "All photo", "All video", "Seleted objects");
            CPShowTextBoxes(String.Empty, null);
            CPShowComboBoxes(Photo.AllPhotos.ToArray(), Video.AllVideos.ToArray(), HelpedList.ToArray());
            CPShowButtons(true, true);
        }

        private void CPShowLabels(string titleLabel, string lengthLabel, string photoLabel, string videoLabel, string selectedObjectLabel)
        {
            if (titleLabel != null)
            {
                LblCreatePageTitle.Text = titleLabel;
                LblCreatePageTitle.Visible = true;
            }
            else
                LblCreatePageTitle.Visible = false;

            if (lengthLabel != null)
            {
                LblCreatePageMiddle.Text = lengthLabel;
                LblCreatePageMiddle.Visible = true;
            }
            else
                LblCreatePageMiddle.Visible = false;

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
        private void CPShowTextBoxes(string titleTextBox, string lengthTextBox)
        {
            if (titleTextBox != null)
            {
                TextBoxCreatePageTitle.Text = titleTextBox;
                TextBoxCreatePageTitle.Visible = true;
            }
            else TextBoxCreatePageTitle.Visible = false;

            if (lengthTextBox != null)
            {
                TextBoxCreatePageMiddle.Text = lengthTextBox;
                TextBoxCreatePageMiddle.Visible = true;
            }
            else TextBoxCreatePageMiddle.Visible = false;

        }
        private void CPShowComboBoxes(object[] upperSource, object[] lowerSource, MediaInfo[] dataSource)
        {            
            if (upperSource != null)
            {
                ComboBoxCreatePagePhotos.DataSource = upperSource;
                ComboBoxCreatePagePhotos.SelectedIndex = -1;
                ComboBoxCreatePagePhotos.Visible = true;
            }
            else ComboBoxCreatePagePhotos.Visible = false;

            if (lowerSource != null)
            {
                ComboBoxCreatePageVideos.DataSource = lowerSource;      
                ComboBoxCreatePageVideos.SelectedIndex = -1;
                ComboBoxCreatePageVideos.Visible = true;
            }
            else ComboBoxCreatePageVideos.Visible = false;

            if (dataSource != null)
            {
                ComboBoxCreatePageSelectedObjects.DataSource = dataSource;
                ComboBoxCreatePageSelectedObjects.SelectedIndex = -1;                
                ComboBoxCreatePageSelectedObjects.Visible = true;
            }
            else ComboBoxCreatePageSelectedObjects.Visible = false;
        }
        private void CPShowButtons(bool clearBtn, bool saveBtn)
        {
            BtnCreatePageClear.Visible = clearBtn;
            BtnCreatePageSave.Visible = saveBtn;
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
                CPShowComboBoxes(Photo.AllPhotos.ToArray(), Video.AllVideos.ToArray(), HelpedList.ToArray());
            }
        }               

        private void ComboBoxCreatePageSelectClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TabControlMain.SelectedIndex == 0 && ComboBoxCreatePageSelectClass.SelectedIndex != -1)
            {
                HelpedList = new List<MediaInfo>();
                switch (ComboBoxCreatePageSelectClass.SelectedIndex)
                {
                    case 0:
                        {
                            CPShowPhotoInfo();
                            break;
                        }
                    case 1:
                        {
                            CPShowVideoInfo();
                            break;
                        }
                    case 2:
                        {
                            CPShowGalleryInfo();
                            break;
                        }
                }
            }
        }        

        private void ComboBoxCreatePagePhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TabControlMain.SelectedIndex == 0 && ComboBoxCreatePagePhotos.SelectedIndex != -1 && ComboBoxCreatePagePhotos.Focused)
            {
                if(!HelpedList.Contains(ComboBoxCreatePagePhotos.SelectedItem as Photo))
                    HelpedList.Add(ComboBoxCreatePagePhotos.SelectedItem as Photo);

                CPShowComboBoxes(Photo.AllPhotos.ToArray(), Video.AllVideos.ToArray(), HelpedList.ToArray());                
            }
        }
        private void ComboBoxCreatePageVideos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControlMain.SelectedIndex == 0 && ComboBoxCreatePageVideos.SelectedIndex != -1 && ComboBoxCreatePageVideos.Focused)
            {
                if (!HelpedList.Contains(ComboBoxCreatePageVideos.SelectedItem as Video))
                    HelpedList.Add(ComboBoxCreatePageVideos.SelectedItem as Video);

                CPShowComboBoxes(Photo.AllPhotos.ToArray(), Video.AllVideos.ToArray(), HelpedList.ToArray());                
            }
        }
        private void ComboBoxCreatePageSelectedObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControlMain.SelectedIndex == 0 && ComboBoxCreatePageSelectedObjects.SelectedIndex != -1 && ComboBoxCreatePageSelectedObjects.Focused)
            {
                if (HelpedList.Contains(ComboBoxCreatePageSelectedObjects.SelectedItem as MediaInfo))
                    HelpedList.Remove(ComboBoxCreatePageSelectedObjects.SelectedItem as MediaInfo);                      

                CPShowComboBoxes(Photo.AllPhotos.ToArray(), Video.AllVideos.ToArray(), HelpedList.ToArray());
            }
        }       
        
        private void BtnCreatePageClear_Click(object sender, EventArgs e)
        {
            CPClearFields();
        }
        private void BtnCreatePageSave_Click(object sender, EventArgs e)
        {
            MediaInfo newObj = null;

            try
            {
                switch (ComboBoxCreatePageSelectClass.SelectedIndex)
                {
                    case 0:
                        {
                            newObj = new Photo() { Title = TextBoxCreatePageTitle.Text };                            
                            break;
                        }
                    case 1:
                        {
                            if (int.TryParse(TextBoxCreatePageMiddle.Text, out int length) && length >= 0) 
                            {
                                newObj = new Video() { Title = TextBoxCreatePageTitle.Text, Length = length } ;                                
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
                CPClearFields();
                MessageBox.Show(newObj.ToString() + " added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void ChangeWorkMode(bool isCreateMode)
        {
            if (isCreateMode)
            {
                
            }
            else
            {

            }
        }

        private void RadioButtonCreatePageCreateMode_CheckedChanged(object sender, EventArgs e)
        {
            ChangeWorkMode(RadioButtonCreatePageCreateMode.Checked);
        }
        #endregion

        #region Editing page

        #endregion

        #region Deleting page

        //private void ComboBoxDeletePageSelectClass_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if(TabControlMain.SelectedIndex == 1 && ComboBoxDeletePageSelectClass.Sele ComboBoxDeletePageSelectClass.Focused)
        //}

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


        #endregion

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
    }
}
