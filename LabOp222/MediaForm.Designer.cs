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
            this.TabPageStatic = new System.Windows.Forms.TabPage();
            this.RichTextBoxStaticPageResult = new System.Windows.Forms.RichTextBox();
            this.BtnStaticPageClear = new System.Windows.Forms.Button();
            this.LblStaticPageResult = new System.Windows.Forms.Label();
            this.BtnStaticPageGetFiles = new System.Windows.Forms.Button();
            this.BtnStaticPageGetVideos = new System.Windows.Forms.Button();
            this.BtnStaticPageGetPhotos = new System.Windows.Forms.Button();
            this.ComboBoxStaticPageMode = new System.Windows.Forms.ComboBox();
            this.LblStaticPageSelectMode = new System.Windows.Forms.Label();
            this.TabControlMain.SuspendLayout();
            this.TabPageCreate.SuspendLayout();
            this.GroupBoxCreatePageSelectWorkMode.SuspendLayout();
            this.GroupBoxCreatePageModeType.SuspendLayout();
            this.TabPageDelete.SuspendLayout();
            this.TabPageStatic.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControlMain
            // 
            this.TabControlMain.Controls.Add(this.TabPageCreate);
            this.TabControlMain.Controls.Add(this.TabPageDelete);
            this.TabControlMain.Controls.Add(this.TabPageStatic);
            this.TabControlMain.Location = new System.Drawing.Point(13, 14);
            this.TabControlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabControlMain.Name = "TabControlMain";
            this.TabControlMain.SelectedIndex = 0;
            this.TabControlMain.Size = new System.Drawing.Size(784, 338);
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
            this.TabPageCreate.Location = new System.Drawing.Point(4, 25);
            this.TabPageCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabPageCreate.Name = "TabPageCreate";
            this.TabPageCreate.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabPageCreate.Size = new System.Drawing.Size(776, 309);
            this.TabPageCreate.TabIndex = 0;
            this.TabPageCreate.Text = "Creating editing page";
            this.TabPageCreate.UseVisualStyleBackColor = true;
            // 
            // TextBoxCreatePageLower
            // 
            this.TextBoxCreatePageLower.Location = new System.Drawing.Point(283, 122);
            this.TextBoxCreatePageLower.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxCreatePageLower.Name = "TextBoxCreatePageLower";
            this.TextBoxCreatePageLower.Size = new System.Drawing.Size(165, 22);
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
            // GroupBoxCreatePageSelectWorkMode
            // 
            this.GroupBoxCreatePageSelectWorkMode.Controls.Add(this.RadioButtonCreatePageEditMode);
            this.GroupBoxCreatePageSelectWorkMode.Controls.Add(this.RadioButtonCreatePageCreateMode);
            this.GroupBoxCreatePageSelectWorkMode.Location = new System.Drawing.Point(11, 68);
            this.GroupBoxCreatePageSelectWorkMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupBoxCreatePageSelectWorkMode.Name = "GroupBoxCreatePageSelectWorkMode";
            this.GroupBoxCreatePageSelectWorkMode.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupBoxCreatePageSelectWorkMode.Size = new System.Drawing.Size(156, 82);
            this.GroupBoxCreatePageSelectWorkMode.TabIndex = 38;
            this.GroupBoxCreatePageSelectWorkMode.TabStop = false;
            this.GroupBoxCreatePageSelectWorkMode.Text = "Choose work mode";
            this.GroupBoxCreatePageSelectWorkMode.Visible = false;
            // 
            // RadioButtonCreatePageEditMode
            // 
            this.RadioButtonCreatePageEditMode.AutoSize = true;
            this.RadioButtonCreatePageEditMode.Location = new System.Drawing.Point(3, 53);
            this.RadioButtonCreatePageEditMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadioButtonCreatePageEditMode.Name = "RadioButtonCreatePageEditMode";
            this.RadioButtonCreatePageEditMode.Size = new System.Drawing.Size(111, 21);
            this.RadioButtonCreatePageEditMode.TabIndex = 1;
            this.RadioButtonCreatePageEditMode.TabStop = true;
            this.RadioButtonCreatePageEditMode.Text = "Editing mode";
            this.RadioButtonCreatePageEditMode.UseVisualStyleBackColor = true;
            this.RadioButtonCreatePageEditMode.CheckedChanged += new System.EventHandler(this.RadioButtonCreatePageCreateMode_CheckedChanged);
            // 
            // RadioButtonCreatePageCreateMode
            // 
            this.RadioButtonCreatePageCreateMode.AutoSize = true;
            this.RadioButtonCreatePageCreateMode.Location = new System.Drawing.Point(3, 26);
            this.RadioButtonCreatePageCreateMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadioButtonCreatePageCreateMode.Name = "RadioButtonCreatePageCreateMode";
            this.RadioButtonCreatePageCreateMode.Size = new System.Drawing.Size(121, 21);
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
            this.GroupBoxCreatePageModeType.Location = new System.Drawing.Point(11, 219);
            this.GroupBoxCreatePageModeType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupBoxCreatePageModeType.Name = "GroupBoxCreatePageModeType";
            this.GroupBoxCreatePageModeType.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.CheckBoxCreatePageVideoMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.CheckBoxCreatePagePhotoMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckBoxCreatePagePhotoMode.Name = "CheckBoxCreatePagePhotoMode";
            this.CheckBoxCreatePagePhotoMode.Size = new System.Drawing.Size(67, 21);
            this.CheckBoxCreatePagePhotoMode.TabIndex = 0;
            this.CheckBoxCreatePagePhotoMode.Text = "Photo";
            this.CheckBoxCreatePagePhotoMode.UseVisualStyleBackColor = true;
            // 
            // ComboBoxCreatePageEditObject
            // 
            this.ComboBoxCreatePageEditObject.FormattingEnabled = true;
            this.ComboBoxCreatePageEditObject.Location = new System.Drawing.Point(11, 180);
            this.ComboBoxCreatePageEditObject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxCreatePageEditObject.Name = "ComboBoxCreatePageEditObject";
            this.ComboBoxCreatePageEditObject.Size = new System.Drawing.Size(156, 24);
            this.ComboBoxCreatePageEditObject.TabIndex = 36;
            this.ComboBoxCreatePageEditObject.Visible = false;
            this.ComboBoxCreatePageEditObject.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCreatePageEditObject_SelectedIndexChanged);
            // 
            // LblCreatePageSelectEditObject
            // 
            this.LblCreatePageSelectEditObject.AutoSize = true;
            this.LblCreatePageSelectEditObject.Location = new System.Drawing.Point(11, 154);
            this.LblCreatePageSelectEditObject.Name = "LblCreatePageSelectEditObject";
            this.LblCreatePageSelectEditObject.Size = new System.Drawing.Size(86, 17);
            this.LblCreatePageSelectEditObject.TabIndex = 35;
            this.LblCreatePageSelectEditObject.Text = "Select mode";
            this.LblCreatePageSelectEditObject.Visible = false;
            // 
            // ComboBoxCreatePageSelectedObjects
            // 
            this.ComboBoxCreatePageSelectedObjects.FormattingEnabled = true;
            this.ComboBoxCreatePageSelectedObjects.Location = new System.Drawing.Point(600, 122);
            this.ComboBoxCreatePageSelectedObjects.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxCreatePageSelectedObjects.Name = "ComboBoxCreatePageSelectedObjects";
            this.ComboBoxCreatePageSelectedObjects.Size = new System.Drawing.Size(165, 24);
            this.ComboBoxCreatePageSelectedObjects.TabIndex = 34;
            this.ComboBoxCreatePageSelectedObjects.Visible = false;
            this.ComboBoxCreatePageSelectedObjects.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCreatePageSelectedObjects_SelectedIndexChanged);
            // 
            // LblCreatePageSelectedObject
            // 
            this.LblCreatePageSelectedObject.AutoSize = true;
            this.LblCreatePageSelectedObject.Location = new System.Drawing.Point(465, 122);
            this.LblCreatePageSelectedObject.Name = "LblCreatePageSelectedObject";
            this.LblCreatePageSelectedObject.Size = new System.Drawing.Size(112, 17);
            this.LblCreatePageSelectedObject.TabIndex = 33;
            this.LblCreatePageSelectedObject.Text = "Selected objects";
            this.LblCreatePageSelectedObject.Visible = false;
            // 
            // BtnCreatePageClear
            // 
            this.BtnCreatePageClear.Location = new System.Drawing.Point(283, 252);
            this.BtnCreatePageClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCreatePageClear.Name = "BtnCreatePageClear";
            this.BtnCreatePageClear.Size = new System.Drawing.Size(165, 37);
            this.BtnCreatePageClear.TabIndex = 32;
            this.BtnCreatePageClear.Text = "Clear fields";
            this.BtnCreatePageClear.UseVisualStyleBackColor = true;
            this.BtnCreatePageClear.Visible = false;
            this.BtnCreatePageClear.Click += new System.EventHandler(this.BtnCreatePageClear_Click);
            // 
            // BtnCreatePageSave
            // 
            this.BtnCreatePageSave.Location = new System.Drawing.Point(600, 252);
            this.BtnCreatePageSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCreatePageSave.Name = "BtnCreatePageSave";
            this.BtnCreatePageSave.Size = new System.Drawing.Size(167, 37);
            this.BtnCreatePageSave.TabIndex = 31;
            this.BtnCreatePageSave.Text = "Save";
            this.BtnCreatePageSave.UseVisualStyleBackColor = true;
            this.BtnCreatePageSave.Visible = false;
            this.BtnCreatePageSave.Click += new System.EventHandler(this.BtnCreatePageSave_Click);
            // 
            // ComboBoxCreatePageVideos
            // 
            this.ComboBoxCreatePageVideos.FormattingEnabled = true;
            this.ComboBoxCreatePageVideos.Location = new System.Drawing.Point(600, 82);
            this.ComboBoxCreatePageVideos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxCreatePageVideos.Name = "ComboBoxCreatePageVideos";
            this.ComboBoxCreatePageVideos.Size = new System.Drawing.Size(165, 24);
            this.ComboBoxCreatePageVideos.TabIndex = 30;
            this.ComboBoxCreatePageVideos.Visible = false;
            this.ComboBoxCreatePageVideos.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCreatePageVideos_SelectedIndexChanged);
            // 
            // LblCreatePageVideos
            // 
            this.LblCreatePageVideos.AutoSize = true;
            this.LblCreatePageVideos.Location = new System.Drawing.Point(465, 82);
            this.LblCreatePageVideos.Name = "LblCreatePageVideos";
            this.LblCreatePageVideos.Size = new System.Drawing.Size(61, 17);
            this.LblCreatePageVideos.TabIndex = 29;
            this.LblCreatePageVideos.Text = "All video";
            this.LblCreatePageVideos.Visible = false;
            // 
            // TextBoxCreatePageMiddle
            // 
            this.TextBoxCreatePageMiddle.Location = new System.Drawing.Point(283, 82);
            this.TextBoxCreatePageMiddle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxCreatePageMiddle.Name = "TextBoxCreatePageMiddle";
            this.TextBoxCreatePageMiddle.Size = new System.Drawing.Size(165, 22);
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
            this.ComboBoxCreatePagePhotos.Location = new System.Drawing.Point(600, 41);
            this.ComboBoxCreatePagePhotos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxCreatePagePhotos.Name = "ComboBoxCreatePagePhotos";
            this.ComboBoxCreatePagePhotos.Size = new System.Drawing.Size(165, 24);
            this.ComboBoxCreatePagePhotos.TabIndex = 26;
            this.ComboBoxCreatePagePhotos.Visible = false;
            this.ComboBoxCreatePagePhotos.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCreatePagePhotos_SelectedIndexChanged);
            // 
            // LblCreatePagePhotos
            // 
            this.LblCreatePagePhotos.AutoSize = true;
            this.LblCreatePagePhotos.Location = new System.Drawing.Point(465, 41);
            this.LblCreatePagePhotos.Name = "LblCreatePagePhotos";
            this.LblCreatePagePhotos.Size = new System.Drawing.Size(63, 17);
            this.LblCreatePagePhotos.TabIndex = 25;
            this.LblCreatePagePhotos.Text = "All photo";
            this.LblCreatePagePhotos.Visible = false;
            // 
            // TextBoxCreatePageTitle
            // 
            this.TextBoxCreatePageTitle.Location = new System.Drawing.Point(283, 41);
            this.TextBoxCreatePageTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxCreatePageTitle.Name = "TextBoxCreatePageTitle";
            this.TextBoxCreatePageTitle.Size = new System.Drawing.Size(165, 22);
            this.TextBoxCreatePageTitle.TabIndex = 24;
            this.TextBoxCreatePageTitle.Visible = false;
            // 
            // LblCreatePageTitle
            // 
            this.LblCreatePageTitle.AutoSize = true;
            this.LblCreatePageTitle.Location = new System.Drawing.Point(173, 39);
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
            "Gallery",
            "Mode"});
            this.ComboBoxCreatePageSelectClass.Location = new System.Drawing.Point(11, 38);
            this.ComboBoxCreatePageSelectClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxCreatePageSelectClass.Name = "ComboBoxCreatePageSelectClass";
            this.ComboBoxCreatePageSelectClass.Size = new System.Drawing.Size(156, 24);
            this.ComboBoxCreatePageSelectClass.TabIndex = 18;
            this.ComboBoxCreatePageSelectClass.SelectionChangeCommitted += new System.EventHandler(this.ComboBoxCreatePageSelectClass_SelectionChangeCommitted);
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
            this.TabPageDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabPageDelete.Name = "TabPageDelete";
            this.TabPageDelete.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabPageDelete.Size = new System.Drawing.Size(776, 309);
            this.TabPageDelete.TabIndex = 2;
            this.TabPageDelete.Text = "Deleting page";
            this.TabPageDelete.UseVisualStyleBackColor = true;
            // 
            // RichTextBoxDeletePageInfo
            // 
            this.RichTextBoxDeletePageInfo.Enabled = false;
            this.RichTextBoxDeletePageInfo.Location = new System.Drawing.Point(189, 31);
            this.RichTextBoxDeletePageInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RichTextBoxDeletePageInfo.Name = "RichTextBoxDeletePageInfo";
            this.RichTextBoxDeletePageInfo.Size = new System.Drawing.Size(581, 174);
            this.RichTextBoxDeletePageInfo.TabIndex = 34;
            this.RichTextBoxDeletePageInfo.Text = "";
            this.RichTextBoxDeletePageInfo.Visible = false;
            // 
            // BtnDeletePageCancel
            // 
            this.BtnDeletePageCancel.Location = new System.Drawing.Point(339, 222);
            this.BtnDeletePageCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDeletePageCancel.Name = "BtnDeletePageCancel";
            this.BtnDeletePageCancel.Size = new System.Drawing.Size(157, 37);
            this.BtnDeletePageCancel.TabIndex = 33;
            this.BtnDeletePageCancel.Text = "Cancel";
            this.BtnDeletePageCancel.UseVisualStyleBackColor = true;
            this.BtnDeletePageCancel.Visible = false;
            this.BtnDeletePageCancel.Click += new System.EventHandler(this.BtnDeletePageCancel_Click);
            // 
            // LblDeletePageInfo
            // 
            this.LblDeletePageInfo.AutoSize = true;
            this.LblDeletePageInfo.Location = new System.Drawing.Point(187, 10);
            this.LblDeletePageInfo.Name = "LblDeletePageInfo";
            this.LblDeletePageInfo.Size = new System.Drawing.Size(113, 17);
            this.LblDeletePageInfo.TabIndex = 32;
            this.LblDeletePageInfo.Text = "Info about object";
            this.LblDeletePageInfo.Visible = false;
            // 
            // BtnDeletePageDelete
            // 
            this.BtnDeletePageDelete.Location = new System.Drawing.Point(539, 222);
            this.BtnDeletePageDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDeletePageDelete.Name = "BtnDeletePageDelete";
            this.BtnDeletePageDelete.Size = new System.Drawing.Size(157, 37);
            this.BtnDeletePageDelete.TabIndex = 31;
            this.BtnDeletePageDelete.Text = "Delete";
            this.BtnDeletePageDelete.UseVisualStyleBackColor = true;
            this.BtnDeletePageDelete.Visible = false;
            this.BtnDeletePageDelete.Click += new System.EventHandler(this.BtnDeletePageDelete_Click);
            // 
            // ComboBoxDeletePageSelectObject
            // 
            this.ComboBoxDeletePageSelectObject.FormattingEnabled = true;
            this.ComboBoxDeletePageSelectObject.Location = new System.Drawing.Point(15, 95);
            this.ComboBoxDeletePageSelectObject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxDeletePageSelectObject.Name = "ComboBoxDeletePageSelectObject";
            this.ComboBoxDeletePageSelectObject.Size = new System.Drawing.Size(121, 24);
            this.ComboBoxDeletePageSelectObject.TabIndex = 20;
            this.ComboBoxDeletePageSelectObject.Visible = false;
            this.ComboBoxDeletePageSelectObject.SelectedValueChanged += new System.EventHandler(this.ComboBoxDeletePageSelectObject_SelectedValueChanged);
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
            this.ComboBoxDeletePageSelectClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxDeletePageSelectClass.Name = "ComboBoxDeletePageSelectClass";
            this.ComboBoxDeletePageSelectClass.Size = new System.Drawing.Size(121, 24);
            this.ComboBoxDeletePageSelectClass.TabIndex = 18;
            this.ComboBoxDeletePageSelectClass.SelectedValueChanged += new System.EventHandler(this.ComboBoxDeletePageSelectClass_SelectedValueChanged);
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
            // TabPageStatic
            // 
            this.TabPageStatic.Controls.Add(this.RichTextBoxStaticPageResult);
            this.TabPageStatic.Controls.Add(this.BtnStaticPageClear);
            this.TabPageStatic.Controls.Add(this.LblStaticPageResult);
            this.TabPageStatic.Controls.Add(this.BtnStaticPageGetFiles);
            this.TabPageStatic.Controls.Add(this.BtnStaticPageGetVideos);
            this.TabPageStatic.Controls.Add(this.BtnStaticPageGetPhotos);
            this.TabPageStatic.Controls.Add(this.ComboBoxStaticPageMode);
            this.TabPageStatic.Controls.Add(this.LblStaticPageSelectMode);
            this.TabPageStatic.Location = new System.Drawing.Point(4, 25);
            this.TabPageStatic.Name = "TabPageStatic";
            this.TabPageStatic.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageStatic.Size = new System.Drawing.Size(776, 309);
            this.TabPageStatic.TabIndex = 3;
            this.TabPageStatic.Text = "Static methods page";
            this.TabPageStatic.UseVisualStyleBackColor = true;
            // 
            // RichTextBoxStaticPageResult
            // 
            this.RichTextBoxStaticPageResult.Enabled = false;
            this.RichTextBoxStaticPageResult.Location = new System.Drawing.Point(216, 35);
            this.RichTextBoxStaticPageResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RichTextBoxStaticPageResult.Name = "RichTextBoxStaticPageResult";
            this.RichTextBoxStaticPageResult.Size = new System.Drawing.Size(554, 269);
            this.RichTextBoxStaticPageResult.TabIndex = 44;
            this.RichTextBoxStaticPageResult.Text = "";
            // 
            // BtnStaticPageClear
            // 
            this.BtnStaticPageClear.Location = new System.Drawing.Point(6, 267);
            this.BtnStaticPageClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnStaticPageClear.Name = "BtnStaticPageClear";
            this.BtnStaticPageClear.Size = new System.Drawing.Size(181, 37);
            this.BtnStaticPageClear.TabIndex = 43;
            this.BtnStaticPageClear.Text = "Clear";
            this.BtnStaticPageClear.UseVisualStyleBackColor = true;
            this.BtnStaticPageClear.Click += new System.EventHandler(this.BtnStaticPageClear_Click);
            // 
            // LblStaticPageResult
            // 
            this.LblStaticPageResult.AutoSize = true;
            this.LblStaticPageResult.Location = new System.Drawing.Point(213, 9);
            this.LblStaticPageResult.Name = "LblStaticPageResult";
            this.LblStaticPageResult.Size = new System.Drawing.Size(52, 17);
            this.LblStaticPageResult.TabIndex = 42;
            this.LblStaticPageResult.Text = "Result:";
            // 
            // BtnStaticPageGetFiles
            // 
            this.BtnStaticPageGetFiles.Location = new System.Drawing.Point(6, 133);
            this.BtnStaticPageGetFiles.Name = "BtnStaticPageGetFiles";
            this.BtnStaticPageGetFiles.Size = new System.Drawing.Size(181, 24);
            this.BtnStaticPageGetFiles.TabIndex = 41;
            this.BtnStaticPageGetFiles.Text = "Show all files with mode";
            this.BtnStaticPageGetFiles.UseVisualStyleBackColor = true;
            this.BtnStaticPageGetFiles.Click += new System.EventHandler(this.BtnStaticPageGetFiles_Click);
            // 
            // BtnStaticPageGetVideos
            // 
            this.BtnStaticPageGetVideos.Location = new System.Drawing.Point(6, 103);
            this.BtnStaticPageGetVideos.Name = "BtnStaticPageGetVideos";
            this.BtnStaticPageGetVideos.Size = new System.Drawing.Size(181, 24);
            this.BtnStaticPageGetVideos.TabIndex = 40;
            this.BtnStaticPageGetVideos.Text = "Show all video with mode";
            this.BtnStaticPageGetVideos.UseVisualStyleBackColor = true;
            this.BtnStaticPageGetVideos.Click += new System.EventHandler(this.BtnStaticPageGetVideos_Click);
            // 
            // BtnStaticPageGetPhotos
            // 
            this.BtnStaticPageGetPhotos.Location = new System.Drawing.Point(6, 73);
            this.BtnStaticPageGetPhotos.Name = "BtnStaticPageGetPhotos";
            this.BtnStaticPageGetPhotos.Size = new System.Drawing.Size(181, 24);
            this.BtnStaticPageGetPhotos.TabIndex = 39;
            this.BtnStaticPageGetPhotos.Text = "Show all photo with mode";
            this.BtnStaticPageGetPhotos.UseVisualStyleBackColor = true;
            this.BtnStaticPageGetPhotos.Click += new System.EventHandler(this.BtnStaticPageGetPhotos_Click);
            // 
            // ComboBoxStaticPageMode
            // 
            this.ComboBoxStaticPageMode.FormattingEnabled = true;
            this.ComboBoxStaticPageMode.Location = new System.Drawing.Point(6, 35);
            this.ComboBoxStaticPageMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxStaticPageMode.Name = "ComboBoxStaticPageMode";
            this.ComboBoxStaticPageMode.Size = new System.Drawing.Size(181, 24);
            this.ComboBoxStaticPageMode.TabIndex = 38;
            // 
            // LblStaticPageSelectMode
            // 
            this.LblStaticPageSelectMode.AutoSize = true;
            this.LblStaticPageSelectMode.Location = new System.Drawing.Point(6, 9);
            this.LblStaticPageSelectMode.Name = "LblStaticPageSelectMode";
            this.LblStaticPageSelectMode.Size = new System.Drawing.Size(86, 17);
            this.LblStaticPageSelectMode.TabIndex = 37;
            this.LblStaticPageSelectMode.Text = "Select mode";
            // 
            // MediaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 364);
            this.Controls.Add(this.TabControlMain);
            this.Margin = new System.Windows.Forms.Padding(4);
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
            this.TabPageStatic.ResumeLayout(false);
            this.TabPageStatic.PerformLayout();
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
        private System.Windows.Forms.TabPage TabPageStatic;
        private System.Windows.Forms.RichTextBox RichTextBoxStaticPageResult;
        private System.Windows.Forms.Button BtnStaticPageClear;
        private System.Windows.Forms.Label LblStaticPageResult;
        private System.Windows.Forms.Button BtnStaticPageGetFiles;
        private System.Windows.Forms.Button BtnStaticPageGetVideos;
        private System.Windows.Forms.Button BtnStaticPageGetPhotos;
        private System.Windows.Forms.ComboBox ComboBoxStaticPageMode;
        private System.Windows.Forms.Label LblStaticPageSelectMode;
    }
}

