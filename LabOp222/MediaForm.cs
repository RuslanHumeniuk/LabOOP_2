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
namespace LabOp222
{
    public partial class MediaForm : Form
    {
        List<MediaInfo> helpedList = new List<MediaInfo>();
        public MediaForm()
        {
            InitializeComponent();

            Photo firstPhoto = new Photo("First Ph");
            Photo secondPhoto = new Photo("Second Ph");

            Video firstVideo = new Video("First Vid");
            Video secondVideo = new Video("Second Vid");

            Gallery gallery = new Gallery("Main gallery");
            Gallery secondGallery = new Gallery("Second gallery");
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
            CPShowComboBoxes(Photo.AllPhotos.ToArray(), Video.AllVideos.ToArray(), helpedList);
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
                LblCreatePageLength.Text = lengthLabel;
                LblCreatePageLength.Visible = true;
            }
            else
                LblCreatePageLength.Visible = false;

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
                TextBoxCreatePageLengthOfVideo.Text = lengthTextBox;
                TextBoxCreatePageLengthOfVideo.Visible = true;
            }
            else TextBoxCreatePageLengthOfVideo.Visible = false;

        }
        private void CPShowComboBoxes(object[] upperSource, object[] lowerSource, List<Object> selectedObjects)
        {
            if (upperSource != null)
            {
                ComboBoxCreatePagePhotos.DataSource = upperSource;
                ComboBoxCreatePagePhotos.Visible = true;
            }
            else ComboBoxCreatePagePhotos.Visible = false;

            if (lowerSource != null)
            {
                ComboBoxCreatePageVideos.DataSource = lowerSource;
                ComboBoxCreatePageVideos.Visible = true;
            }
            else ComboBoxCreatePageVideos.Visible = false;

            if (selectedObjects != null)
            {
                ComboBoxCreatePageSelectedObjects.DataSource = selectedObjects;
                ComboBoxCreatePageSelectedObjects.Visible = true;
            }
            else ComboBoxCreatePageSelectedObjects.Visible = false;
        }
        private void CPShowButtons(bool clearBtn, bool saveBtn)
        {
            BtnCreatePageClear.Visible = clearBtn;
            BtnCreatePageSave.Visible = saveBtn;
        }

        private void ComboBoxCreatePageSelectClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TabControlMain.SelectedIndex == 0 && ComboBoxCreatePageSelectClass.SelectedIndex != -1)
            {
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
            if(TabControlMain.SelectedIndex == 0 && ComboBoxCreatePagePhotos.SelectedIndex != -1)
            {
                helpedList.Add(ComboBoxCreatePagePhotos.SelectedItem as Photo);
            }

        }

        private void ComboBoxCreatePageVideos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControlMain.SelectedIndex == 0 && ComboBoxCreatePageVideos.SelectedIndex != -1)
            {
                helpedList.Add(ComboBoxCreatePageVideos.SelectedItem as Video);
            }
        }

        private void ComboBoxCreatePageSelectedObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControlMain.SelectedIndex == 0 && ComboBoxCreatePageSelectedObjects.SelectedIndex != -1)
            {
                helpedList.RemoveAt(ComboBoxCreatePageSelectedObjects.SelectedIndex);
            }
        }

       

        private void BtnCreatePageClear_Click(object sender, EventArgs e)
        {
            TextBoxCreatePageLengthOfVideo.Clear();
            TextBoxCreatePageTitle.Clear();
            ComboBoxCreatePageSelectedObjects.DataSource = new List<Object>();
        }

        private void BtnCreatePageSave_Click(object sender, EventArgs e)
        {
            
        }


        #endregion

        #region Editing page

        #endregion

        #region Deleting page

        #endregion

       
    }
}
