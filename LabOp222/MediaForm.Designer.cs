﻿namespace LabOp222
{
    partial class MediaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControlMain = new System.Windows.Forms.TabControl();
            this.TabPageCreate = new System.Windows.Forms.TabPage();
            this.ComboBoxCreatePageSelectedObjects = new System.Windows.Forms.ComboBox();
            this.LblCreatePageSelectedObject = new System.Windows.Forms.Label();
            this.BtnCreatePageClear = new System.Windows.Forms.Button();
            this.BtnCreatePageSave = new System.Windows.Forms.Button();
            this.ComboBoxCreatePageVideos = new System.Windows.Forms.ComboBox();
            this.LblCreatePageVideos = new System.Windows.Forms.Label();
            this.TextBoxCreatePageMiddle = new System.Windows.Forms.TextBox();
            this.LblCreatePageMiddle = new System.Windows.Forms.Label();
            this.ComboBoxCreatePagePhotos = new System.Windows.Forms.ComboBox();
            this.LblCreatePagePhotos = new System.Windows.Forms.Label();
            this.TextBoxCreatePageTitle = new System.Windows.Forms.TextBox();
            this.LblCreatePageTitle = new System.Windows.Forms.Label();
            this.ComboBoxCreatePageSelectClass = new System.Windows.Forms.ComboBox();
            this.LblCreatePageClass = new System.Windows.Forms.Label();
            this.TabPageDelete = new System.Windows.Forms.TabPage();
            this.RichTextBoxDeletePageInfo = new System.Windows.Forms.RichTextBox();
            this.BtnDeletePageCancel = new System.Windows.Forms.Button();
            this.LblDeletePageInfo = new System.Windows.Forms.Label();
            this.BtnDeletePageDelete = new System.Windows.Forms.Button();
            this.ComboBoxDeletePageSelectObject = new System.Windows.Forms.ComboBox();
            this.LblDeletePageObject = new System.Windows.Forms.Label();
            this.ComboBoxDeletePageSelectClass = new System.Windows.Forms.ComboBox();
            this.LblDeletePageClass = new System.Windows.Forms.Label();
            this.GroupBoxCreatePageModeType = new System.Windows.Forms.GroupBox();
            this.CheckBoxCreatePageVideoMode = new System.Windows.Forms.CheckBox();
            this.CheckBoxCreatePagePhotoMode = new System.Windows.Forms.CheckBox();
            this.ComboBoxCreatePageSelectObject = new System.Windows.Forms.ComboBox();
            this.LabelCreatePageSelectObject = new System.Windows.Forms.Label();
            this.GroupBoxCreatePageSelectWorkMode = new System.Windows.Forms.GroupBox();
            this.RadioButtonCreatePageCreateMode = new System.Windows.Forms.RadioButton();
            this.RadioButtonCreatePageEditMode = new System.Windows.Forms.RadioButton();
            this.TextBoxCreatePageLower = new System.Windows.Forms.TextBox();
            this.LblCreatePageLower = new System.Windows.Forms.Label();
            this.TabControlMain.SuspendLayout();
            this.TabPageCreate.SuspendLayout();
            this.TabPageDelete.SuspendLayout();
            this.GroupBoxCreatePageModeType.SuspendLayout();
            this.GroupBoxCreatePageSelectWorkMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControlMain
            // 
            this.TabControlMain.Controls.Add(this.TabPageCreate);
            this.TabControlMain.Controls.Add(this.TabPageDelete);
            this.TabControlMain.Location = new System.Drawing.Point(13, 13);
            this.TabControlMain.Name = "TabControlMain";
            this.TabControlMain.SelectedIndex = 0;
            this.TabControlMain.Size = new System.Drawing.Size(709, 339);
            this.TabControlMain.TabIndex = 0;
            // 
            // TabPageCreate
            // 
            this.TabPageCreate.Controls.Add(this.TextBoxCreatePageLower);
            this.TabPageCreate.Controls.Add(this.LblCreatePageLower);
            this.TabPageCreate.Controls.Add(this.GroupBoxCreatePageSelectWorkMode);
            this.TabPageCreate.Controls.Add(this.GroupBoxCreatePageModeType);
            this.TabPageCreate.Controls.Add(this.ComboBoxCreatePageSelectObject);
            this.TabPageCreate.Controls.Add(this.LabelCreatePageSelectObject);
            this.TabPageCreate.Controls.Add(this.ComboBoxCreatePageSelectedObjects);
            this.TabPageCreate.Controls.Add(this.LblCreatePageSelectedObject);
            this.TabPageCreate.Controls.Add(this.BtnCreatePageClear);
            this.TabPageCreate.Controls.Add(this.BtnCreatePageSave);
            this.TabPageCreate.Controls.Add(this.ComboBoxCreatePageVideos);
            this.TabPageCreate.Controls.Add(this.LblCreatePageVideos);
            this.TabPageCreate.Controls.Add(this.TextBoxCreatePageMiddle);
            this.TabPageCreate.Controls.Add(this.LblCreatePageMiddle);
            this.TabPageCreate.Controls.Add(this.ComboBoxCreatePagePhotos);
            this.TabPageCreate.Controls.Add(this.LblCreatePagePhotos);
            this.TabPageCreate.Controls.Add(this.TextBoxCreatePageTitle);
            this.TabPageCreate.Controls.Add(this.LblCreatePageTitle);
            this.TabPageCreate.Controls.Add(this.ComboBoxCreatePageSelectClass);
            this.TabPageCreate.Controls.Add(this.LblCreatePageClass);
            this.TabPageCreate.Location = new System.Drawing.Point(4, 25);
            this.TabPageCreate.Name = "TabPageCreate";
            this.TabPageCreate.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageCreate.Size = new System.Drawing.Size(701, 310);
            this.TabPageCreate.TabIndex = 0;
            this.TabPageCreate.Text = "Creating page";
            this.TabPageCreate.UseVisualStyleBackColor = true;
            // 
            // ComboBoxCreatePageSelectedObjects
            // 
            this.ComboBoxCreatePageSelectedObjects.FormattingEnabled = true;
            this.ComboBoxCreatePageSelectedObjects.Location = new System.Drawing.Point(553, 120);
            this.ComboBoxCreatePageSelectedObjects.Name = "ComboBoxCreatePageSelectedObjects";
            this.ComboBoxCreatePageSelectedObjects.Size = new System.Drawing.Size(139, 24);
            this.ComboBoxCreatePageSelectedObjects.TabIndex = 34;
            this.ComboBoxCreatePageSelectedObjects.Visible = false;
            this.ComboBoxCreatePageSelectedObjects.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCreatePageSelectedObjects_SelectedIndexChanged);
            // 
            // LblCreatePageSelectedObject
            // 
            this.LblCreatePageSelectedObject.AutoSize = true;
            this.LblCreatePageSelectedObject.Location = new System.Drawing.Point(435, 120);
            this.LblCreatePageSelectedObject.Name = "LblCreatePageSelectedObject";
            this.LblCreatePageSelectedObject.Size = new System.Drawing.Size(112, 17);
            this.LblCreatePageSelectedObject.TabIndex = 33;
            this.LblCreatePageSelectedObject.Text = "Selected objects";
            this.LblCreatePageSelectedObject.Visible = false;
            // 
            // BtnCreatePageClear
            // 
            this.BtnCreatePageClear.Location = new System.Drawing.Point(283, 254);
            this.BtnCreatePageClear.Name = "BtnCreatePageClear";
            this.BtnCreatePageClear.Size = new System.Drawing.Size(157, 37);
            this.BtnCreatePageClear.TabIndex = 32;
            this.BtnCreatePageClear.Text = "Clear fields";
            this.BtnCreatePageClear.UseVisualStyleBackColor = true;
            this.BtnCreatePageClear.Visible = false;
            this.BtnCreatePageClear.Click += new System.EventHandler(this.BtnCreatePageClear_Click);
            // 
            // BtnCreatePageSave
            // 
            this.BtnCreatePageSave.Location = new System.Drawing.Point(535, 254);
            this.BtnCreatePageSave.Name = "BtnCreatePageSave";
            this.BtnCreatePageSave.Size = new System.Drawing.Size(157, 37);
            this.BtnCreatePageSave.TabIndex = 31;
            this.BtnCreatePageSave.Text = "Save";
            this.BtnCreatePageSave.UseVisualStyleBackColor = true;
            this.BtnCreatePageSave.Visible = false;
            this.BtnCreatePageSave.Click += new System.EventHandler(this.BtnCreatePageSave_Click);
            // 
            // ComboBoxCreatePageVideos
            // 
            this.ComboBoxCreatePageVideos.FormattingEnabled = true;
            this.ComboBoxCreatePageVideos.Location = new System.Drawing.Point(553, 81);
            this.ComboBoxCreatePageVideos.Name = "ComboBoxCreatePageVideos";
            this.ComboBoxCreatePageVideos.Size = new System.Drawing.Size(139, 24);
            this.ComboBoxCreatePageVideos.TabIndex = 30;
            this.ComboBoxCreatePageVideos.Visible = false;
            this.ComboBoxCreatePageVideos.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCreatePageVideos_SelectedIndexChanged);
            // 
            // LblCreatePageVideos
            // 
            this.LblCreatePageVideos.AutoSize = true;
            this.LblCreatePageVideos.Location = new System.Drawing.Point(435, 81);
            this.LblCreatePageVideos.Name = "LblCreatePageVideos";
            this.LblCreatePageVideos.Size = new System.Drawing.Size(61, 17);
            this.LblCreatePageVideos.TabIndex = 29;
            this.LblCreatePageVideos.Text = "All video";
            this.LblCreatePageVideos.Visible = false;
            // 
            // TextBoxCreatePageMiddle
            // 
            this.TextBoxCreatePageMiddle.Location = new System.Drawing.Point(283, 83);
            this.TextBoxCreatePageMiddle.Name = "TextBoxCreatePageMiddle";
            this.TextBoxCreatePageMiddle.Size = new System.Drawing.Size(130, 22);
            this.TextBoxCreatePageMiddle.TabIndex = 28;
            this.TextBoxCreatePageMiddle.Visible = false;
            // 
            // LblCreatePageMiddle
            // 
            this.LblCreatePageMiddle.AutoSize = true;
            this.LblCreatePageMiddle.Location = new System.Drawing.Point(173, 82);
            this.LblCreatePageMiddle.Name = "LblCreatePageMiddle";
            this.LblCreatePageMiddle.Size = new System.Drawing.Size(53, 17);
            this.LblCreatePageMiddle.TabIndex = 27;
            this.LblCreatePageMiddle.Text = "Middle ";
            this.LblCreatePageMiddle.Visible = false;
            // 
            // ComboBoxCreatePagePhotos
            // 
            this.ComboBoxCreatePagePhotos.FormattingEnabled = true;
            this.ComboBoxCreatePagePhotos.Location = new System.Drawing.Point(553, 39);
            this.ComboBoxCreatePagePhotos.Name = "ComboBoxCreatePagePhotos";
            this.ComboBoxCreatePagePhotos.Size = new System.Drawing.Size(139, 24);
            this.ComboBoxCreatePagePhotos.TabIndex = 26;
            this.ComboBoxCreatePagePhotos.Visible = false;
            this.ComboBoxCreatePagePhotos.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCreatePagePhotos_SelectedIndexChanged);
            // 
            // LblCreatePagePhotos
            // 
            this.LblCreatePagePhotos.AutoSize = true;
            this.LblCreatePagePhotos.Location = new System.Drawing.Point(435, 39);
            this.LblCreatePagePhotos.Name = "LblCreatePagePhotos";
            this.LblCreatePagePhotos.Size = new System.Drawing.Size(63, 17);
            this.LblCreatePagePhotos.TabIndex = 25;
            this.LblCreatePagePhotos.Text = "All photo";
            this.LblCreatePagePhotos.Visible = false;
            // 
            // TextBoxCreatePageTitle
            // 
            this.TextBoxCreatePageTitle.Location = new System.Drawing.Point(283, 41);
            this.TextBoxCreatePageTitle.Name = "TextBoxCreatePageTitle";
            this.TextBoxCreatePageTitle.Size = new System.Drawing.Size(130, 22);
            this.TextBoxCreatePageTitle.TabIndex = 24;
            this.TextBoxCreatePageTitle.Visible = false;
            // 
            // LblCreatePageTitle
            // 
            this.LblCreatePageTitle.AutoSize = true;
            this.LblCreatePageTitle.Location = new System.Drawing.Point(173, 40);
            this.LblCreatePageTitle.Name = "LblCreatePageTitle";
            this.LblCreatePageTitle.Size = new System.Drawing.Size(35, 17);
            this.LblCreatePageTitle.TabIndex = 23;
            this.LblCreatePageTitle.Text = "Title";
            this.LblCreatePageTitle.Visible = false;
            // 
            // ComboBoxCreatePageSelectClass
            // 
            this.ComboBoxCreatePageSelectClass.FormattingEnabled = true;
            this.ComboBoxCreatePageSelectClass.Items.AddRange(new object[] {
            "Photo",
            "Video",
            "Gallery"});
            this.ComboBoxCreatePageSelectClass.Location = new System.Drawing.Point(11, 38);
            this.ComboBoxCreatePageSelectClass.Name = "ComboBoxCreatePageSelectClass";
            this.ComboBoxCreatePageSelectClass.Size = new System.Drawing.Size(156, 24);
            this.ComboBoxCreatePageSelectClass.TabIndex = 18;
            this.ComboBoxCreatePageSelectClass.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCreatePageSelectClass_SelectedIndexChanged);
            // 
            // LblCreatePageClass
            // 
            this.LblCreatePageClass.AutoSize = true;
            this.LblCreatePageClass.Location = new System.Drawing.Point(8, 17);
            this.LblCreatePageClass.Name = "LblCreatePageClass";
            this.LblCreatePageClass.Size = new System.Drawing.Size(83, 17);
            this.LblCreatePageClass.TabIndex = 17;
            this.LblCreatePageClass.Text = "Select class";
            // 
            // TabPageDelete
            // 
            this.TabPageDelete.Controls.Add(this.RichTextBoxDeletePageInfo);
            this.TabPageDelete.Controls.Add(this.BtnDeletePageCancel);
            this.TabPageDelete.Controls.Add(this.LblDeletePageInfo);
            this.TabPageDelete.Controls.Add(this.BtnDeletePageDelete);
            this.TabPageDelete.Controls.Add(this.ComboBoxDeletePageSelectObject);
            this.TabPageDelete.Controls.Add(this.LblDeletePageObject);
            this.TabPageDelete.Controls.Add(this.ComboBoxDeletePageSelectClass);
            this.TabPageDelete.Controls.Add(this.LblDeletePageClass);
            this.TabPageDelete.Location = new System.Drawing.Point(4, 25);
            this.TabPageDelete.Name = "TabPageDelete";
            this.TabPageDelete.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageDelete.Size = new System.Drawing.Size(701, 310);
            this.TabPageDelete.TabIndex = 2;
            this.TabPageDelete.Text = "Deleting page";
            this.TabPageDelete.UseVisualStyleBackColor = true;
            // 
            // RichTextBoxDeletePageInfo
            // 
            this.RichTextBoxDeletePageInfo.Location = new System.Drawing.Point(189, 31);
            this.RichTextBoxDeletePageInfo.Name = "RichTextBoxDeletePageInfo";
            this.RichTextBoxDeletePageInfo.Size = new System.Drawing.Size(506, 174);
            this.RichTextBoxDeletePageInfo.TabIndex = 34;
            this.RichTextBoxDeletePageInfo.Text = "";
            this.RichTextBoxDeletePageInfo.Visible = false;
            // 
            // BtnDeletePageCancel
            // 
            this.BtnDeletePageCancel.Location = new System.Drawing.Point(339, 221);
            this.BtnDeletePageCancel.Name = "BtnDeletePageCancel";
            this.BtnDeletePageCancel.Size = new System.Drawing.Size(157, 37);
            this.BtnDeletePageCancel.TabIndex = 33;
            this.BtnDeletePageCancel.Text = "Cancel";
            this.BtnDeletePageCancel.UseVisualStyleBackColor = true;
            this.BtnDeletePageCancel.Visible = false;
            // 
            // LblDeletePageInfo
            // 
            this.LblDeletePageInfo.AutoSize = true;
            this.LblDeletePageInfo.Location = new System.Drawing.Point(186, 10);
            this.LblDeletePageInfo.Name = "LblDeletePageInfo";
            this.LblDeletePageInfo.Size = new System.Drawing.Size(113, 17);
            this.LblDeletePageInfo.TabIndex = 32;
            this.LblDeletePageInfo.Text = "Info about object";
            this.LblDeletePageInfo.Visible = false;
            // 
            // BtnDeletePageDelete
            // 
            this.BtnDeletePageDelete.Location = new System.Drawing.Point(539, 221);
            this.BtnDeletePageDelete.Name = "BtnDeletePageDelete";
            this.BtnDeletePageDelete.Size = new System.Drawing.Size(157, 37);
            this.BtnDeletePageDelete.TabIndex = 31;
            this.BtnDeletePageDelete.Text = "Delete";
            this.BtnDeletePageDelete.UseVisualStyleBackColor = true;
            this.BtnDeletePageDelete.Visible = false;
            // 
            // ComboBoxDeletePageSelectObject
            // 
            this.ComboBoxDeletePageSelectObject.FormattingEnabled = true;
            this.ComboBoxDeletePageSelectObject.Location = new System.Drawing.Point(15, 95);
            this.ComboBoxDeletePageSelectObject.Name = "ComboBoxDeletePageSelectObject";
            this.ComboBoxDeletePageSelectObject.Size = new System.Drawing.Size(121, 24);
            this.ComboBoxDeletePageSelectObject.TabIndex = 20;
            this.ComboBoxDeletePageSelectObject.Visible = false;
            // 
            // LblDeletePageObject
            // 
            this.LblDeletePageObject.AutoSize = true;
            this.LblDeletePageObject.Location = new System.Drawing.Point(12, 74);
            this.LblDeletePageObject.Name = "LblDeletePageObject";
            this.LblDeletePageObject.Size = new System.Drawing.Size(89, 17);
            this.LblDeletePageObject.TabIndex = 19;
            this.LblDeletePageObject.Text = "Select object";
            this.LblDeletePageObject.Visible = false;
            // 
            // ComboBoxDeletePageSelectClass
            // 
            this.ComboBoxDeletePageSelectClass.FormattingEnabled = true;
            this.ComboBoxDeletePageSelectClass.Items.AddRange(new object[] {
            "Photo",
            "Video",
            "Gallery"});
            this.ComboBoxDeletePageSelectClass.Location = new System.Drawing.Point(15, 31);
            this.ComboBoxDeletePageSelectClass.Name = "ComboBoxDeletePageSelectClass";
            this.ComboBoxDeletePageSelectClass.Size = new System.Drawing.Size(121, 24);
            this.ComboBoxDeletePageSelectClass.TabIndex = 18;
            this.ComboBoxDeletePageSelectClass.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDeletePageSelectClass_SelectedIndexChanged);
            // 
            // LblDeletePageClass
            // 
            this.LblDeletePageClass.AutoSize = true;
            this.LblDeletePageClass.Location = new System.Drawing.Point(12, 10);
            this.LblDeletePageClass.Name = "LblDeletePageClass";
            this.LblDeletePageClass.Size = new System.Drawing.Size(83, 17);
            this.LblDeletePageClass.TabIndex = 17;
            this.LblDeletePageClass.Text = "Select class";
            // 
            // GroupBoxCreatePageModeType
            // 
            this.GroupBoxCreatePageModeType.Controls.Add(this.CheckBoxCreatePageVideoMode);
            this.GroupBoxCreatePageModeType.Controls.Add(this.CheckBoxCreatePagePhotoMode);
            this.GroupBoxCreatePageModeType.Enabled = false;
            this.GroupBoxCreatePageModeType.Location = new System.Drawing.Point(11, 219);
            this.GroupBoxCreatePageModeType.Name = "GroupBoxCreatePageModeType";
            this.GroupBoxCreatePageModeType.Size = new System.Drawing.Size(156, 75);
            this.GroupBoxCreatePageModeType.TabIndex = 37;
            this.GroupBoxCreatePageModeType.TabStop = false;
            this.GroupBoxCreatePageModeType.Text = "Mode\'s types";
            this.GroupBoxCreatePageModeType.Visible = false;
            // 
            // CheckBoxCreatePageVideoMode
            // 
            this.CheckBoxCreatePageVideoMode.AutoSize = true;
            this.CheckBoxCreatePageVideoMode.Location = new System.Drawing.Point(7, 49);
            this.CheckBoxCreatePageVideoMode.Name = "CheckBoxCreatePageVideoMode";
            this.CheckBoxCreatePageVideoMode.Size = new System.Drawing.Size(66, 21);
            this.CheckBoxCreatePageVideoMode.TabIndex = 1;
            this.CheckBoxCreatePageVideoMode.Text = "Video";
            this.CheckBoxCreatePageVideoMode.UseVisualStyleBackColor = true;
            // 
            // CheckBoxCreatePagePhotoMode
            // 
            this.CheckBoxCreatePagePhotoMode.AutoSize = true;
            this.CheckBoxCreatePagePhotoMode.Location = new System.Drawing.Point(7, 22);
            this.CheckBoxCreatePagePhotoMode.Name = "CheckBoxCreatePagePhotoMode";
            this.CheckBoxCreatePagePhotoMode.Size = new System.Drawing.Size(67, 21);
            this.CheckBoxCreatePagePhotoMode.TabIndex = 0;
            this.CheckBoxCreatePagePhotoMode.Text = "Photo";
            this.CheckBoxCreatePagePhotoMode.UseVisualStyleBackColor = true;
            // 
            // ComboBoxCreatePageSelectObject
            // 
            this.ComboBoxCreatePageSelectObject.FormattingEnabled = true;
            this.ComboBoxCreatePageSelectObject.Location = new System.Drawing.Point(11, 180);
            this.ComboBoxCreatePageSelectObject.Name = "ComboBoxCreatePageSelectObject";
            this.ComboBoxCreatePageSelectObject.Size = new System.Drawing.Size(156, 24);
            this.ComboBoxCreatePageSelectObject.TabIndex = 36;
            this.ComboBoxCreatePageSelectObject.Visible = false;
            // 
            // LabelCreatePageSelectObject
            // 
            this.LabelCreatePageSelectObject.AutoSize = true;
            this.LabelCreatePageSelectObject.Location = new System.Drawing.Point(11, 154);
            this.LabelCreatePageSelectObject.Name = "LabelCreatePageSelectObject";
            this.LabelCreatePageSelectObject.Size = new System.Drawing.Size(89, 17);
            this.LabelCreatePageSelectObject.TabIndex = 35;
            this.LabelCreatePageSelectObject.Text = "Select object";
            this.LabelCreatePageSelectObject.Visible = false;
            // 
            // GroupBoxCreatePageSelectWorkMode
            // 
            this.GroupBoxCreatePageSelectWorkMode.Controls.Add(this.RadioButtonCreatePageEditMode);
            this.GroupBoxCreatePageSelectWorkMode.Controls.Add(this.RadioButtonCreatePageCreateMode);
            this.GroupBoxCreatePageSelectWorkMode.Location = new System.Drawing.Point(11, 68);
            this.GroupBoxCreatePageSelectWorkMode.Name = "GroupBoxCreatePageSelectWorkMode";
            this.GroupBoxCreatePageSelectWorkMode.Size = new System.Drawing.Size(156, 83);
            this.GroupBoxCreatePageSelectWorkMode.TabIndex = 38;
            this.GroupBoxCreatePageSelectWorkMode.TabStop = false;
            this.GroupBoxCreatePageSelectWorkMode.Text = "Choose work mode";
            // 
            // RadioButtonCreatePageCreateMode
            // 
            this.RadioButtonCreatePageCreateMode.AutoSize = true;
            this.RadioButtonCreatePageCreateMode.Location = new System.Drawing.Point(3, 26);
            this.RadioButtonCreatePageCreateMode.Name = "RadioButtonCreatePageCreateMode";
            this.RadioButtonCreatePageCreateMode.Size = new System.Drawing.Size(121, 21);
            this.RadioButtonCreatePageCreateMode.TabIndex = 0;
            this.RadioButtonCreatePageCreateMode.TabStop = true;
            this.RadioButtonCreatePageCreateMode.Text = "Creating mode";
            this.RadioButtonCreatePageCreateMode.UseVisualStyleBackColor = true;
            this.RadioButtonCreatePageCreateMode.CheckedChanged += new System.EventHandler(this.RadioButtonCreatePageCreateMode_CheckedChanged);
            // 
            // RadioButtonCreatePageEditMode
            // 
            this.RadioButtonCreatePageEditMode.AutoSize = true;
            this.RadioButtonCreatePageEditMode.Location = new System.Drawing.Point(3, 53);
            this.RadioButtonCreatePageEditMode.Name = "RadioButtonCreatePageEditMode";
            this.RadioButtonCreatePageEditMode.Size = new System.Drawing.Size(111, 21);
            this.RadioButtonCreatePageEditMode.TabIndex = 1;
            this.RadioButtonCreatePageEditMode.TabStop = true;
            this.RadioButtonCreatePageEditMode.Text = "Editing mode";
            this.RadioButtonCreatePageEditMode.UseVisualStyleBackColor = true;
            this.RadioButtonCreatePageEditMode.CheckedChanged += new System.EventHandler(this.RadioButtonCreatePageCreateMode_CheckedChanged);
            // 
            // TextBoxCreatePageLower
            // 
            this.TextBoxCreatePageLower.Location = new System.Drawing.Point(283, 122);
            this.TextBoxCreatePageLower.Name = "TextBoxCreatePageLower";
            this.TextBoxCreatePageLower.Size = new System.Drawing.Size(130, 22);
            this.TextBoxCreatePageLower.TabIndex = 40;
            this.TextBoxCreatePageLower.Visible = false;
            // 
            // LblCreatePageLower
            // 
            this.LblCreatePageLower.AutoSize = true;
            this.LblCreatePageLower.Location = new System.Drawing.Point(173, 121);
            this.LblCreatePageLower.Name = "LblCreatePageLower";
            this.LblCreatePageLower.Size = new System.Drawing.Size(46, 17);
            this.LblCreatePageLower.TabIndex = 39;
            this.LblCreatePageLower.Text = "Lower";
            this.LblCreatePageLower.Visible = false;
            // 
            // MediaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 364);
            this.Controls.Add(this.TabControlMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MediaForm";
            this.Text = "Media form";
            this.TabControlMain.ResumeLayout(false);
            this.TabPageCreate.ResumeLayout(false);
            this.TabPageCreate.PerformLayout();
            this.TabPageDelete.ResumeLayout(false);
            this.TabPageDelete.PerformLayout();
            this.GroupBoxCreatePageModeType.ResumeLayout(false);
            this.GroupBoxCreatePageModeType.PerformLayout();
            this.GroupBoxCreatePageSelectWorkMode.ResumeLayout(false);
            this.GroupBoxCreatePageSelectWorkMode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlMain;
        private System.Windows.Forms.TabPage TabPageCreate;
        private System.Windows.Forms.TabPage TabPageDelete;
        private System.Windows.Forms.Button BtnCreatePageClear;
        private System.Windows.Forms.Button BtnCreatePageSave;
        private System.Windows.Forms.ComboBox ComboBoxCreatePageVideos;
        private System.Windows.Forms.Label LblCreatePageVideos;
        private System.Windows.Forms.TextBox TextBoxCreatePageMiddle;
        private System.Windows.Forms.Label LblCreatePageMiddle;
        private System.Windows.Forms.ComboBox ComboBoxCreatePagePhotos;
        private System.Windows.Forms.Label LblCreatePagePhotos;
        private System.Windows.Forms.TextBox TextBoxCreatePageTitle;
        private System.Windows.Forms.Label LblCreatePageTitle;
        private System.Windows.Forms.ComboBox ComboBoxCreatePageSelectClass;
        private System.Windows.Forms.Label LblCreatePageClass;
        private System.Windows.Forms.RichTextBox RichTextBoxDeletePageInfo;
        private System.Windows.Forms.Button BtnDeletePageCancel;
        private System.Windows.Forms.Label LblDeletePageInfo;
        private System.Windows.Forms.Button BtnDeletePageDelete;
        private System.Windows.Forms.ComboBox ComboBoxDeletePageSelectObject;
        private System.Windows.Forms.Label LblDeletePageObject;
        private System.Windows.Forms.ComboBox ComboBoxDeletePageSelectClass;
        private System.Windows.Forms.Label LblDeletePageClass;
        private System.Windows.Forms.ComboBox ComboBoxCreatePageSelectedObjects;
        private System.Windows.Forms.Label LblCreatePageSelectedObject;
        private System.Windows.Forms.TextBox TextBoxCreatePageLower;
        private System.Windows.Forms.Label LblCreatePageLower;
        private System.Windows.Forms.GroupBox GroupBoxCreatePageSelectWorkMode;
        private System.Windows.Forms.RadioButton RadioButtonCreatePageEditMode;
        private System.Windows.Forms.RadioButton RadioButtonCreatePageCreateMode;
        private System.Windows.Forms.GroupBox GroupBoxCreatePageModeType;
        private System.Windows.Forms.CheckBox CheckBoxCreatePageVideoMode;
        private System.Windows.Forms.CheckBox CheckBoxCreatePagePhotoMode;
        private System.Windows.Forms.ComboBox ComboBoxCreatePageSelectObject;
        private System.Windows.Forms.Label LabelCreatePageSelectObject;
    }
}
