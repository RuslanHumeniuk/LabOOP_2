namespace LabOp222
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
            this.TextBoxCreatePageLower = new System.Windows.Forms.TextBox();
            this.LblCreatePageLower = new System.Windows.Forms.Label();
            this.GroupBoxCreatePageSelectWorkMode = new System.Windows.Forms.GroupBox();
            this.RadioButtonCreatePageEditMode = new System.Windows.Forms.RadioButton();
            this.RadioButtonCreatePageCreateMode = new System.Windows.Forms.RadioButton();
            this.GroupBoxCreatePageModeType = new System.Windows.Forms.GroupBox();
            this.CheckBoxCreatePageVideoMode = new System.Windows.Forms.CheckBox();
            this.CheckBoxCreatePagePhotoMode = new System.Windows.Forms.CheckBox();
            this.ComboBoxCreatePageEditObject = new System.Windows.Forms.ComboBox();
            this.LblCreatePageSelectEditObject = new System.Windows.Forms.Label();
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
            this.TabControlMain.SuspendLayout();
            this.TabPageCreate.SuspendLayout();
            this.GroupBoxCreatePageSelectWorkMode.SuspendLayout();
            this.GroupBoxCreatePageModeType.SuspendLayout();
            this.TabPageDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControlMain
            // 
            this.TabControlMain.Controls.Add(this.TabPageCreate);
            this.TabControlMain.Controls.Add(this.TabPageDelete);
            this.TabControlMain.Location = new System.Drawing.Point(10, 11);
            this.TabControlMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TabControlMain.Name = "TabControlMain";
            this.TabControlMain.SelectedIndex = 0;
            this.TabControlMain.Size = new System.Drawing.Size(588, 275);
            this.TabControlMain.TabIndex = 0;
            this.TabControlMain.SelectedIndexChanged += new System.EventHandler(this.TabControlMain_SelectedIndexChanged);
            // 
            // TabPageCreate
            // 
            this.TabPageCreate.Controls.Add(this.TextBoxCreatePageLower);
            this.TabPageCreate.Controls.Add(this.LblCreatePageLower);
            this.TabPageCreate.Controls.Add(this.GroupBoxCreatePageSelectWorkMode);
            this.TabPageCreate.Controls.Add(this.GroupBoxCreatePageModeType);
            this.TabPageCreate.Controls.Add(this.ComboBoxCreatePageEditObject);
            this.TabPageCreate.Controls.Add(this.LblCreatePageSelectEditObject);
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
            this.TabPageCreate.Location = new System.Drawing.Point(4, 22);
            this.TabPageCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TabPageCreate.Name = "TabPageCreate";
            this.TabPageCreate.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TabPageCreate.Size = new System.Drawing.Size(580, 249);
            this.TabPageCreate.TabIndex = 0;
            this.TabPageCreate.Text = "Creating editing page";
            this.TabPageCreate.UseVisualStyleBackColor = true;
            // 
            // TextBoxCreatePageLower
            // 
            this.TextBoxCreatePageLower.Location = new System.Drawing.Point(212, 99);
            this.TextBoxCreatePageLower.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxCreatePageLower.Name = "TextBoxCreatePageLower";
            this.TextBoxCreatePageLower.Size = new System.Drawing.Size(125, 20);
            this.TextBoxCreatePageLower.TabIndex = 40;
            this.TextBoxCreatePageLower.Visible = false;
            // 
            // LblCreatePageLower
            // 
            this.LblCreatePageLower.AutoSize = true;
            this.LblCreatePageLower.Location = new System.Drawing.Point(130, 98);
            this.LblCreatePageLower.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCreatePageLower.Name = "LblCreatePageLower";
            this.LblCreatePageLower.Size = new System.Drawing.Size(36, 13);
            this.LblCreatePageLower.TabIndex = 39;
            this.LblCreatePageLower.Text = "Lower";
            this.LblCreatePageLower.Visible = false;
            // 
            // GroupBoxCreatePageSelectWorkMode
            // 
            this.GroupBoxCreatePageSelectWorkMode.Controls.Add(this.RadioButtonCreatePageEditMode);
            this.GroupBoxCreatePageSelectWorkMode.Controls.Add(this.RadioButtonCreatePageCreateMode);
            this.GroupBoxCreatePageSelectWorkMode.Location = new System.Drawing.Point(8, 55);
            this.GroupBoxCreatePageSelectWorkMode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupBoxCreatePageSelectWorkMode.Name = "GroupBoxCreatePageSelectWorkMode";
            this.GroupBoxCreatePageSelectWorkMode.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupBoxCreatePageSelectWorkMode.Size = new System.Drawing.Size(117, 67);
            this.GroupBoxCreatePageSelectWorkMode.TabIndex = 38;
            this.GroupBoxCreatePageSelectWorkMode.TabStop = false;
            this.GroupBoxCreatePageSelectWorkMode.Text = "Choose work mode";
            this.GroupBoxCreatePageSelectWorkMode.Visible = false;
            // 
            // RadioButtonCreatePageEditMode
            // 
            this.RadioButtonCreatePageEditMode.AutoSize = true;
            this.RadioButtonCreatePageEditMode.Location = new System.Drawing.Point(2, 43);
            this.RadioButtonCreatePageEditMode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadioButtonCreatePageEditMode.Name = "RadioButtonCreatePageEditMode";
            this.RadioButtonCreatePageEditMode.Size = new System.Drawing.Size(86, 17);
            this.RadioButtonCreatePageEditMode.TabIndex = 1;
            this.RadioButtonCreatePageEditMode.TabStop = true;
            this.RadioButtonCreatePageEditMode.Text = "Editing mode";
            this.RadioButtonCreatePageEditMode.UseVisualStyleBackColor = true;
            this.RadioButtonCreatePageEditMode.CheckedChanged += new System.EventHandler(this.RadioButtonCreatePageCreateMode_CheckedChanged);
            // 
            // RadioButtonCreatePageCreateMode
            // 
            this.RadioButtonCreatePageCreateMode.AutoSize = true;
            this.RadioButtonCreatePageCreateMode.Location = new System.Drawing.Point(2, 21);
            this.RadioButtonCreatePageCreateMode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadioButtonCreatePageCreateMode.Name = "RadioButtonCreatePageCreateMode";
            this.RadioButtonCreatePageCreateMode.Size = new System.Drawing.Size(93, 17);
            this.RadioButtonCreatePageCreateMode.TabIndex = 0;
            this.RadioButtonCreatePageCreateMode.TabStop = true;
            this.RadioButtonCreatePageCreateMode.Text = "Creating mode";
            this.RadioButtonCreatePageCreateMode.UseVisualStyleBackColor = true;
            this.RadioButtonCreatePageCreateMode.CheckedChanged += new System.EventHandler(this.RadioButtonCreatePageCreateMode_CheckedChanged);
            // 
            // GroupBoxCreatePageModeType
            // 
            this.GroupBoxCreatePageModeType.Controls.Add(this.CheckBoxCreatePageVideoMode);
            this.GroupBoxCreatePageModeType.Controls.Add(this.CheckBoxCreatePagePhotoMode);
            this.GroupBoxCreatePageModeType.Enabled = false;
            this.GroupBoxCreatePageModeType.Location = new System.Drawing.Point(8, 178);
            this.GroupBoxCreatePageModeType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupBoxCreatePageModeType.Name = "GroupBoxCreatePageModeType";
            this.GroupBoxCreatePageModeType.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupBoxCreatePageModeType.Size = new System.Drawing.Size(117, 61);
            this.GroupBoxCreatePageModeType.TabIndex = 37;
            this.GroupBoxCreatePageModeType.TabStop = false;
            this.GroupBoxCreatePageModeType.Text = "Mode\'s types";
            this.GroupBoxCreatePageModeType.Visible = false;
            // 
            // CheckBoxCreatePageVideoMode
            // 
            this.CheckBoxCreatePageVideoMode.AutoSize = true;
            this.CheckBoxCreatePageVideoMode.Location = new System.Drawing.Point(5, 40);
            this.CheckBoxCreatePageVideoMode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckBoxCreatePageVideoMode.Name = "CheckBoxCreatePageVideoMode";
            this.CheckBoxCreatePageVideoMode.Size = new System.Drawing.Size(53, 17);
            this.CheckBoxCreatePageVideoMode.TabIndex = 1;
            this.CheckBoxCreatePageVideoMode.Text = "Video";
            this.CheckBoxCreatePageVideoMode.UseVisualStyleBackColor = true;
            // 
            // CheckBoxCreatePagePhotoMode
            // 
            this.CheckBoxCreatePagePhotoMode.AutoSize = true;
            this.CheckBoxCreatePagePhotoMode.Location = new System.Drawing.Point(5, 18);
            this.CheckBoxCreatePagePhotoMode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckBoxCreatePagePhotoMode.Name = "CheckBoxCreatePagePhotoMode";
            this.CheckBoxCreatePagePhotoMode.Size = new System.Drawing.Size(54, 17);
            this.CheckBoxCreatePagePhotoMode.TabIndex = 0;
            this.CheckBoxCreatePagePhotoMode.Text = "Photo";
            this.CheckBoxCreatePagePhotoMode.UseVisualStyleBackColor = true;
            // 
            // ComboBoxCreatePageEditObject
            // 
            this.ComboBoxCreatePageEditObject.FormattingEnabled = true;
            this.ComboBoxCreatePageEditObject.Location = new System.Drawing.Point(8, 146);
            this.ComboBoxCreatePageEditObject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboBoxCreatePageEditObject.Name = "ComboBoxCreatePageEditObject";
            this.ComboBoxCreatePageEditObject.Size = new System.Drawing.Size(118, 21);
            this.ComboBoxCreatePageEditObject.TabIndex = 36;
            this.ComboBoxCreatePageEditObject.Visible = false;
            this.ComboBoxCreatePageEditObject.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCreatePageEditObject_SelectedIndexChanged);
            // 
            // LblCreatePageSelectEditObject
            // 
            this.LblCreatePageSelectEditObject.AutoSize = true;
            this.LblCreatePageSelectEditObject.Location = new System.Drawing.Point(8, 125);
            this.LblCreatePageSelectEditObject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCreatePageSelectEditObject.Name = "LblCreatePageSelectEditObject";
            this.LblCreatePageSelectEditObject.Size = new System.Drawing.Size(66, 13);
            this.LblCreatePageSelectEditObject.TabIndex = 35;
            this.LblCreatePageSelectEditObject.Text = "Select mode";
            this.LblCreatePageSelectEditObject.Visible = false;
            // 
            // ComboBoxCreatePageSelectedObjects
            // 
            this.ComboBoxCreatePageSelectedObjects.FormattingEnabled = true;
            this.ComboBoxCreatePageSelectedObjects.Location = new System.Drawing.Point(450, 99);
            this.ComboBoxCreatePageSelectedObjects.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboBoxCreatePageSelectedObjects.Name = "ComboBoxCreatePageSelectedObjects";
            this.ComboBoxCreatePageSelectedObjects.Size = new System.Drawing.Size(125, 21);
            this.ComboBoxCreatePageSelectedObjects.TabIndex = 34;
            this.ComboBoxCreatePageSelectedObjects.Visible = false;
            this.ComboBoxCreatePageSelectedObjects.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCreatePageSelectedObjects_SelectedIndexChanged);
            // 
            // LblCreatePageSelectedObject
            // 
            this.LblCreatePageSelectedObject.AutoSize = true;
            this.LblCreatePageSelectedObject.Location = new System.Drawing.Point(349, 99);
            this.LblCreatePageSelectedObject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCreatePageSelectedObject.Name = "LblCreatePageSelectedObject";
            this.LblCreatePageSelectedObject.Size = new System.Drawing.Size(86, 13);
            this.LblCreatePageSelectedObject.TabIndex = 33;
            this.LblCreatePageSelectedObject.Text = "Selected objects";
            this.LblCreatePageSelectedObject.Visible = false;
            // 
            // BtnCreatePageClear
            // 
            this.BtnCreatePageClear.Location = new System.Drawing.Point(212, 205);
            this.BtnCreatePageClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnCreatePageClear.Name = "BtnCreatePageClear";
            this.BtnCreatePageClear.Size = new System.Drawing.Size(124, 30);
            this.BtnCreatePageClear.TabIndex = 32;
            this.BtnCreatePageClear.Text = "Clear fields";
            this.BtnCreatePageClear.UseVisualStyleBackColor = true;
            this.BtnCreatePageClear.Visible = false;
            this.BtnCreatePageClear.Click += new System.EventHandler(this.BtnCreatePageClear_Click);
            // 
            // BtnCreatePageSave
            // 
            this.BtnCreatePageSave.Location = new System.Drawing.Point(450, 205);
            this.BtnCreatePageSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnCreatePageSave.Name = "BtnCreatePageSave";
            this.BtnCreatePageSave.Size = new System.Drawing.Size(125, 30);
            this.BtnCreatePageSave.TabIndex = 31;
            this.BtnCreatePageSave.Text = "Save";
            this.BtnCreatePageSave.UseVisualStyleBackColor = true;
            this.BtnCreatePageSave.Visible = false;
            this.BtnCreatePageSave.Click += new System.EventHandler(this.BtnCreatePageSave_Click);
            // 
            // ComboBoxCreatePageVideos
            // 
            this.ComboBoxCreatePageVideos.FormattingEnabled = true;
            this.ComboBoxCreatePageVideos.Location = new System.Drawing.Point(450, 67);
            this.ComboBoxCreatePageVideos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboBoxCreatePageVideos.Name = "ComboBoxCreatePageVideos";
            this.ComboBoxCreatePageVideos.Size = new System.Drawing.Size(125, 21);
            this.ComboBoxCreatePageVideos.TabIndex = 30;
            this.ComboBoxCreatePageVideos.Visible = false;
            this.ComboBoxCreatePageVideos.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCreatePageVideos_SelectedIndexChanged);
            // 
            // LblCreatePageVideos
            // 
            this.LblCreatePageVideos.AutoSize = true;
            this.LblCreatePageVideos.Location = new System.Drawing.Point(349, 67);
            this.LblCreatePageVideos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCreatePageVideos.Name = "LblCreatePageVideos";
            this.LblCreatePageVideos.Size = new System.Drawing.Size(47, 13);
            this.LblCreatePageVideos.TabIndex = 29;
            this.LblCreatePageVideos.Text = "All video";
            this.LblCreatePageVideos.Visible = false;
            // 
            // TextBoxCreatePageMiddle
            // 
            this.TextBoxCreatePageMiddle.Location = new System.Drawing.Point(212, 67);
            this.TextBoxCreatePageMiddle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxCreatePageMiddle.Name = "TextBoxCreatePageMiddle";
            this.TextBoxCreatePageMiddle.Size = new System.Drawing.Size(125, 20);
            this.TextBoxCreatePageMiddle.TabIndex = 28;
            this.TextBoxCreatePageMiddle.Visible = false;
            // 
            // LblCreatePageMiddle
            // 
            this.LblCreatePageMiddle.AutoSize = true;
            this.LblCreatePageMiddle.Location = new System.Drawing.Point(130, 67);
            this.LblCreatePageMiddle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCreatePageMiddle.Name = "LblCreatePageMiddle";
            this.LblCreatePageMiddle.Size = new System.Drawing.Size(41, 13);
            this.LblCreatePageMiddle.TabIndex = 27;
            this.LblCreatePageMiddle.Text = "Middle ";
            this.LblCreatePageMiddle.Visible = false;
            // 
            // ComboBoxCreatePagePhotos
            // 
            this.ComboBoxCreatePagePhotos.FormattingEnabled = true;
            this.ComboBoxCreatePagePhotos.Location = new System.Drawing.Point(450, 33);
            this.ComboBoxCreatePagePhotos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboBoxCreatePagePhotos.Name = "ComboBoxCreatePagePhotos";
            this.ComboBoxCreatePagePhotos.Size = new System.Drawing.Size(125, 21);
            this.ComboBoxCreatePagePhotos.TabIndex = 26;
            this.ComboBoxCreatePagePhotos.Visible = false;
            this.ComboBoxCreatePagePhotos.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCreatePagePhotos_SelectedIndexChanged);
            // 
            // LblCreatePagePhotos
            // 
            this.LblCreatePagePhotos.AutoSize = true;
            this.LblCreatePagePhotos.Location = new System.Drawing.Point(349, 33);
            this.LblCreatePagePhotos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCreatePagePhotos.Name = "LblCreatePagePhotos";
            this.LblCreatePagePhotos.Size = new System.Drawing.Size(48, 13);
            this.LblCreatePagePhotos.TabIndex = 25;
            this.LblCreatePagePhotos.Text = "All photo";
            this.LblCreatePagePhotos.Visible = false;
            // 
            // TextBoxCreatePageTitle
            // 
            this.TextBoxCreatePageTitle.Location = new System.Drawing.Point(212, 33);
            this.TextBoxCreatePageTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxCreatePageTitle.Name = "TextBoxCreatePageTitle";
            this.TextBoxCreatePageTitle.Size = new System.Drawing.Size(125, 20);
            this.TextBoxCreatePageTitle.TabIndex = 24;
            this.TextBoxCreatePageTitle.Visible = false;
            // 
            // LblCreatePageTitle
            // 
            this.LblCreatePageTitle.AutoSize = true;
            this.LblCreatePageTitle.Location = new System.Drawing.Point(130, 32);
            this.LblCreatePageTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCreatePageTitle.Name = "LblCreatePageTitle";
            this.LblCreatePageTitle.Size = new System.Drawing.Size(27, 13);
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
            "Gallery",
            "Mode"});
            this.ComboBoxCreatePageSelectClass.Location = new System.Drawing.Point(8, 31);
            this.ComboBoxCreatePageSelectClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboBoxCreatePageSelectClass.Name = "ComboBoxCreatePageSelectClass";
            this.ComboBoxCreatePageSelectClass.Size = new System.Drawing.Size(118, 21);
            this.ComboBoxCreatePageSelectClass.TabIndex = 18;
            this.ComboBoxCreatePageSelectClass.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCreatePageSelectClass_SelectedIndexChanged);
            // 
            // LblCreatePageClass
            // 
            this.LblCreatePageClass.AutoSize = true;
            this.LblCreatePageClass.Location = new System.Drawing.Point(6, 14);
            this.LblCreatePageClass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCreatePageClass.Name = "LblCreatePageClass";
            this.LblCreatePageClass.Size = new System.Drawing.Size(64, 13);
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
            this.TabPageDelete.Location = new System.Drawing.Point(4, 22);
            this.TabPageDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TabPageDelete.Name = "TabPageDelete";
            this.TabPageDelete.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TabPageDelete.Size = new System.Drawing.Size(580, 249);
            this.TabPageDelete.TabIndex = 2;
            this.TabPageDelete.Text = "Deleting page";
            this.TabPageDelete.UseVisualStyleBackColor = true;
            // 
            // RichTextBoxDeletePageInfo
            // 
            this.RichTextBoxDeletePageInfo.Enabled = false;
            this.RichTextBoxDeletePageInfo.Location = new System.Drawing.Point(142, 25);
            this.RichTextBoxDeletePageInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RichTextBoxDeletePageInfo.Name = "RichTextBoxDeletePageInfo";
            this.RichTextBoxDeletePageInfo.Size = new System.Drawing.Size(437, 142);
            this.RichTextBoxDeletePageInfo.TabIndex = 34;
            this.RichTextBoxDeletePageInfo.Text = "";
            this.RichTextBoxDeletePageInfo.Visible = false;
            // 
            // BtnDeletePageCancel
            // 
            this.BtnDeletePageCancel.Location = new System.Drawing.Point(254, 180);
            this.BtnDeletePageCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnDeletePageCancel.Name = "BtnDeletePageCancel";
            this.BtnDeletePageCancel.Size = new System.Drawing.Size(118, 30);
            this.BtnDeletePageCancel.TabIndex = 33;
            this.BtnDeletePageCancel.Text = "Cancel";
            this.BtnDeletePageCancel.UseVisualStyleBackColor = true;
            this.BtnDeletePageCancel.Visible = false;
            this.BtnDeletePageCancel.Click += new System.EventHandler(this.BtnDeletePageCancel_Click);
            // 
            // LblDeletePageInfo
            // 
            this.LblDeletePageInfo.AutoSize = true;
            this.LblDeletePageInfo.Location = new System.Drawing.Point(140, 8);
            this.LblDeletePageInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDeletePageInfo.Name = "LblDeletePageInfo";
            this.LblDeletePageInfo.Size = new System.Drawing.Size(87, 13);
            this.LblDeletePageInfo.TabIndex = 32;
            this.LblDeletePageInfo.Text = "Info about object";
            this.LblDeletePageInfo.Visible = false;
            // 
            // BtnDeletePageDelete
            // 
            this.BtnDeletePageDelete.Location = new System.Drawing.Point(404, 180);
            this.BtnDeletePageDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnDeletePageDelete.Name = "BtnDeletePageDelete";
            this.BtnDeletePageDelete.Size = new System.Drawing.Size(118, 30);
            this.BtnDeletePageDelete.TabIndex = 31;
            this.BtnDeletePageDelete.Text = "Delete";
            this.BtnDeletePageDelete.UseVisualStyleBackColor = true;
            this.BtnDeletePageDelete.Visible = false;
            this.BtnDeletePageDelete.Click += new System.EventHandler(this.BtnDeletePageDelete_Click);
            // 
            // ComboBoxDeletePageSelectObject
            // 
            this.ComboBoxDeletePageSelectObject.FormattingEnabled = true;
            this.ComboBoxDeletePageSelectObject.Location = new System.Drawing.Point(11, 77);
            this.ComboBoxDeletePageSelectObject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboBoxDeletePageSelectObject.Name = "ComboBoxDeletePageSelectObject";
            this.ComboBoxDeletePageSelectObject.Size = new System.Drawing.Size(92, 21);
            this.ComboBoxDeletePageSelectObject.TabIndex = 20;
            this.ComboBoxDeletePageSelectObject.Visible = false;
            this.ComboBoxDeletePageSelectObject.SelectedValueChanged += new System.EventHandler(this.ComboBoxDeletePageSelectObject_SelectedValueChanged);
            // 
            // LblDeletePageObject
            // 
            this.LblDeletePageObject.AutoSize = true;
            this.LblDeletePageObject.Location = new System.Drawing.Point(9, 60);
            this.LblDeletePageObject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDeletePageObject.Name = "LblDeletePageObject";
            this.LblDeletePageObject.Size = new System.Drawing.Size(69, 13);
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
            this.ComboBoxDeletePageSelectClass.Location = new System.Drawing.Point(11, 25);
            this.ComboBoxDeletePageSelectClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboBoxDeletePageSelectClass.Name = "ComboBoxDeletePageSelectClass";
            this.ComboBoxDeletePageSelectClass.Size = new System.Drawing.Size(92, 21);
            this.ComboBoxDeletePageSelectClass.TabIndex = 18;
            this.ComboBoxDeletePageSelectClass.SelectedValueChanged += new System.EventHandler(this.ComboBoxDeletePageSelectClass_SelectedValueChanged);
            // 
            // LblDeletePageClass
            // 
            this.LblDeletePageClass.AutoSize = true;
            this.LblDeletePageClass.Location = new System.Drawing.Point(9, 8);
            this.LblDeletePageClass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDeletePageClass.Name = "LblDeletePageClass";
            this.LblDeletePageClass.Size = new System.Drawing.Size(64, 13);
            this.LblDeletePageClass.TabIndex = 17;
            this.LblDeletePageClass.Text = "Select class";
            // 
            // MediaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 296);
            this.Controls.Add(this.TabControlMain);
            this.Name = "MediaForm";
            this.Text = "Media form";
            this.TabControlMain.ResumeLayout(false);
            this.TabPageCreate.ResumeLayout(false);
            this.TabPageCreate.PerformLayout();
            this.GroupBoxCreatePageSelectWorkMode.ResumeLayout(false);
            this.GroupBoxCreatePageSelectWorkMode.PerformLayout();
            this.GroupBoxCreatePageModeType.ResumeLayout(false);
            this.GroupBoxCreatePageModeType.PerformLayout();
            this.TabPageDelete.ResumeLayout(false);
            this.TabPageDelete.PerformLayout();
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
        private System.Windows.Forms.ComboBox ComboBoxCreatePageEditObject;
        private System.Windows.Forms.Label LblCreatePageSelectEditObject;
    }
}

