namespace gui
{
    partial class SetupFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupFrame));
            this.cmbResolution = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chkUnitActionLines = new System.Windows.Forms.CheckBox();
            this.lblUnitActionLines = new System.Windows.Forms.Label();
            this.chkToolTips = new System.Windows.Forms.CheckBox();
            this.lblToolTips = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRepeat = new System.Windows.Forms.Label();
            this.chkRepeat = new System.Windows.Forms.CheckBox();
            this.chkShuffle = new System.Windows.Forms.CheckBox();
            this.lblShuffle = new System.Windows.Forms.Label();
            this.line1 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.trbScoreVolume = new System.Windows.Forms.TrackBar();
            this.lblScoreVolume = new System.Windows.Forms.Label();
            this.lblScoreVolumeValue = new System.Windows.Forms.Label();
            this.trbVoiceVolume = new System.Windows.Forms.TrackBar();
            this.lblVoiceVolume = new System.Windows.Forms.Label();
            this.lblVoiceVolumeValue = new System.Windows.Forms.Label();
            this.trbSoundVolume = new System.Windows.Forms.TrackBar();
            this.lblSoundVolume = new System.Windows.Forms.Label();
            this.lblSoundVolumeValue = new System.Windows.Forms.Label();
            this.Line2 = new System.Windows.Forms.Label();
            this.GraphicPatchLabel = new System.Windows.Forms.Label();
            this.GP_DisabledLabel = new System.Windows.Forms.Label();
            this.GP_IEddrawLabel = new System.Windows.Forms.Label();
            this.GP_ddwrapperLabel = new System.Windows.Forms.Label();
            this.GP_DisabledRadioButton = new System.Windows.Forms.RadioButton();
            this.GP_IEddrawRadioButton = new System.Windows.Forms.RadioButton();
            this.GP_ddwrapperRadioButton = new System.Windows.Forms.RadioButton();
            this.GP_NoVideoMemoryCheckBox = new System.Windows.Forms.CheckBox();
            this.GP_NoVideoMemoryLabel = new System.Windows.Forms.Label();
            this.GP_FakeVsyncCheckBox = new System.Windows.Forms.CheckBox();
            this.GP_FakeVsyncLabel = new System.Windows.Forms.Label();
            this.GP_TSDDrawRadioButton = new System.Windows.Forms.RadioButton();
            this.GP_TSDDrawLabel = new System.Windows.Forms.Label();
            this.chkWindowed = new System.Windows.Forms.CheckBox();
            this.lblWindowed = new System.Windows.Forms.Label();
            this.lblVideo = new System.Windows.Forms.Label();
            this.lblBackbuffer = new System.Windows.Forms.Label();
            this.chkBackbuffer = new System.Windows.Forms.CheckBox();
            this.chkIntro = new System.Windows.Forms.CheckBox();
            this.lblIntro = new System.Windows.Forms.Label();
            this.chkCD = new System.Windows.Forms.CheckBox();
            this.lblCD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trbScoreVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbVoiceVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSoundVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbResolution
            // 
            this.cmbResolution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResolution.FormattingEnabled = true;
            this.cmbResolution.Location = new System.Drawing.Point(152, 28);
            this.cmbResolution.Name = "cmbResolution";
            this.cmbResolution.Size = new System.Drawing.Size(94, 21);
            this.cmbResolution.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Screen resolution:";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.Location = new System.Drawing.Point(12, 306);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 43;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(212, 306);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 45;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Game Options";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // chkUnitActionLines
            // 
            this.chkUnitActionLines.AutoSize = true;
            this.chkUnitActionLines.Location = new System.Drawing.Point(404, 30);
            this.chkUnitActionLines.Name = "chkUnitActionLines";
            this.chkUnitActionLines.Size = new System.Drawing.Size(29, 17);
            this.chkUnitActionLines.TabIndex = 10;
            this.chkUnitActionLines.Text = " ";
            this.chkUnitActionLines.UseVisualStyleBackColor = true;
            // 
            // lblUnitActionLines
            // 
            this.lblUnitActionLines.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnitActionLines.Location = new System.Drawing.Point(274, 30);
            this.lblUnitActionLines.Name = "lblUnitActionLines";
            this.lblUnitActionLines.Size = new System.Drawing.Size(157, 39);
            this.lblUnitActionLines.TabIndex = 9;
            this.lblUnitActionLines.Text = "Show target lines:";
            this.lblUnitActionLines.Click += new System.EventHandler(this.lblUnitActionLines_Click);
            this.lblUnitActionLines.DoubleClick += new System.EventHandler(this.lblUnitActionLines_Click);
            // 
            // chkToolTips
            // 
            this.chkToolTips.AutoSize = true;
            this.chkToolTips.Location = new System.Drawing.Point(404, 52);
            this.chkToolTips.Name = "chkToolTips";
            this.chkToolTips.Size = new System.Drawing.Size(29, 17);
            this.chkToolTips.TabIndex = 12;
            this.chkToolTips.Text = " ";
            this.chkToolTips.UseVisualStyleBackColor = true;
            // 
            // lblToolTips
            // 
            this.lblToolTips.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToolTips.Location = new System.Drawing.Point(274, 53);
            this.lblToolTips.Name = "lblToolTips";
            this.lblToolTips.Size = new System.Drawing.Size(157, 16);
            this.lblToolTips.TabIndex = 11;
            this.lblToolTips.Text = "Show tooltips:";
            this.lblToolTips.Click += new System.EventHandler(this.lblToolTips_Click);
            this.lblToolTips.DoubleClick += new System.EventHandler(this.lblToolTips_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Sound";
            // 
            // lblRepeat
            // 
            this.lblRepeat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRepeat.Location = new System.Drawing.Point(22, 152);
            this.lblRepeat.Name = "lblRepeat";
            this.lblRepeat.Size = new System.Drawing.Size(92, 14);
            this.lblRepeat.TabIndex = 17;
            this.lblRepeat.Text = "Repeat music:";
            this.lblRepeat.Click += new System.EventHandler(this.lblRepeat_Click);
            this.lblRepeat.DoubleClick += new System.EventHandler(this.lblRepeat_Click);
            // 
            // chkRepeat
            // 
            this.chkRepeat.AutoSize = true;
            this.chkRepeat.Location = new System.Drawing.Point(152, 151);
            this.chkRepeat.Name = "chkRepeat";
            this.chkRepeat.Size = new System.Drawing.Size(29, 17);
            this.chkRepeat.TabIndex = 18;
            this.chkRepeat.Text = " ";
            this.chkRepeat.UseVisualStyleBackColor = true;
            // 
            // chkShuffle
            // 
            this.chkShuffle.AutoSize = true;
            this.chkShuffle.Location = new System.Drawing.Point(152, 173);
            this.chkShuffle.Name = "chkShuffle";
            this.chkShuffle.Size = new System.Drawing.Size(29, 17);
            this.chkShuffle.TabIndex = 20;
            this.chkShuffle.Text = " ";
            this.chkShuffle.UseVisualStyleBackColor = true;
            // 
            // lblShuffle
            // 
            this.lblShuffle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShuffle.Location = new System.Drawing.Point(22, 173);
            this.lblShuffle.Name = "lblShuffle";
            this.lblShuffle.Size = new System.Drawing.Size(75, 15);
            this.lblShuffle.TabIndex = 19;
            this.lblShuffle.Text = "Shuffle music:";
            this.lblShuffle.Click += new System.EventHandler(this.lblShuffle_Click);
            this.lblShuffle.DoubleClick += new System.EventHandler(this.lblShuffle_Click);
            // 
            // line1
            // 
            this.line1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line1.Location = new System.Drawing.Point(15, 112);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(393, 3);
            this.line1.TabIndex = 15;
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApply.Location = new System.Drawing.Point(113, 306);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 44;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // trbScoreVolume
            // 
            this.trbScoreVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trbScoreVolume.AutoSize = false;
            this.trbScoreVolume.Location = new System.Drawing.Point(144, 191);
            this.trbScoreVolume.Maximum = 20;
            this.trbScoreVolume.Name = "trbScoreVolume";
            this.trbScoreVolume.Size = new System.Drawing.Size(77, 27);
            this.trbScoreVolume.TabIndex = 22;
            this.trbScoreVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbScoreVolume.ValueChanged += new System.EventHandler(this.trbScoreVolume_ValueChanged);
            // 
            // lblScoreVolume
            // 
            this.lblScoreVolume.AutoSize = true;
            this.lblScoreVolume.Location = new System.Drawing.Point(22, 196);
            this.lblScoreVolume.Name = "lblScoreVolume";
            this.lblScoreVolume.Size = new System.Drawing.Size(75, 13);
            this.lblScoreVolume.TabIndex = 21;
            this.lblScoreVolume.Text = "Music volume:";
            // 
            // lblScoreVolumeValue
            // 
            this.lblScoreVolumeValue.AutoSize = true;
            this.lblScoreVolumeValue.Location = new System.Drawing.Point(219, 191);
            this.lblScoreVolumeValue.Name = "lblScoreVolumeValue";
            this.lblScoreVolumeValue.Size = new System.Drawing.Size(27, 13);
            this.lblScoreVolumeValue.TabIndex = 23;
            this.lblScoreVolumeValue.Text = "30%";
            // 
            // trbVoiceVolume
            // 
            this.trbVoiceVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trbVoiceVolume.AutoSize = false;
            this.trbVoiceVolume.Location = new System.Drawing.Point(144, 219);
            this.trbVoiceVolume.Maximum = 20;
            this.trbVoiceVolume.Name = "trbVoiceVolume";
            this.trbVoiceVolume.Size = new System.Drawing.Size(77, 27);
            this.trbVoiceVolume.TabIndex = 25;
            this.trbVoiceVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbVoiceVolume.ValueChanged += new System.EventHandler(this.trbVoiceVolume_ValueChanged);
            // 
            // lblVoiceVolume
            // 
            this.lblVoiceVolume.AutoSize = true;
            this.lblVoiceVolume.Location = new System.Drawing.Point(22, 224);
            this.lblVoiceVolume.Name = "lblVoiceVolume";
            this.lblVoiceVolume.Size = new System.Drawing.Size(79, 13);
            this.lblVoiceVolume.TabIndex = 24;
            this.lblVoiceVolume.Text = "Voices volume:";
            // 
            // lblVoiceVolumeValue
            // 
            this.lblVoiceVolumeValue.AutoSize = true;
            this.lblVoiceVolumeValue.Location = new System.Drawing.Point(219, 221);
            this.lblVoiceVolumeValue.Name = "lblVoiceVolumeValue";
            this.lblVoiceVolumeValue.Size = new System.Drawing.Size(27, 13);
            this.lblVoiceVolumeValue.TabIndex = 26;
            this.lblVoiceVolumeValue.Text = "30%";
            // 
            // trbSoundVolume
            // 
            this.trbSoundVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trbSoundVolume.AutoSize = false;
            this.trbSoundVolume.Location = new System.Drawing.Point(144, 247);
            this.trbSoundVolume.Maximum = 20;
            this.trbSoundVolume.Name = "trbSoundVolume";
            this.trbSoundVolume.Size = new System.Drawing.Size(77, 27);
            this.trbSoundVolume.TabIndex = 28;
            this.trbSoundVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbSoundVolume.ValueChanged += new System.EventHandler(this.trbSoundVolume_ValueChanged);
            // 
            // lblSoundVolume
            // 
            this.lblSoundVolume.AutoSize = true;
            this.lblSoundVolume.Location = new System.Drawing.Point(22, 252);
            this.lblSoundVolume.Name = "lblSoundVolume";
            this.lblSoundVolume.Size = new System.Drawing.Size(78, 13);
            this.lblSoundVolume.TabIndex = 27;
            this.lblSoundVolume.Text = "Sound volume:";
            // 
            // lblSoundVolumeValue
            // 
            this.lblSoundVolumeValue.AutoSize = true;
            this.lblSoundVolumeValue.Location = new System.Drawing.Point(219, 249);
            this.lblSoundVolumeValue.Name = "lblSoundVolumeValue";
            this.lblSoundVolumeValue.Size = new System.Drawing.Size(27, 13);
            this.lblSoundVolumeValue.TabIndex = 29;
            this.lblSoundVolumeValue.Text = "30%";
            // 
            // Line2
            // 
            this.Line2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Line2.Location = new System.Drawing.Point(252, 40);
            this.Line2.Name = "Line2";
            this.Line2.Size = new System.Drawing.Size(3, 250);
            this.Line2.TabIndex = 7;
            // 
            // GraphicPatchLabel
            // 
            this.GraphicPatchLabel.AutoSize = true;
            this.GraphicPatchLabel.Location = new System.Drawing.Point(261, 128);
            this.GraphicPatchLabel.Name = "GraphicPatchLabel";
            this.GraphicPatchLabel.Size = new System.Drawing.Size(56, 13);
            this.GraphicPatchLabel.TabIndex = 30;
            this.GraphicPatchLabel.Text = "Rendering";
            // 
            // GP_DisabledLabel
            // 
            this.GP_DisabledLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GP_DisabledLabel.Location = new System.Drawing.Point(274, 153);
            this.GP_DisabledLabel.Name = "GP_DisabledLabel";
            this.GP_DisabledLabel.Size = new System.Drawing.Size(157, 19);
            this.GP_DisabledLabel.TabIndex = 31;
            this.GP_DisabledLabel.Text = "Default:";
            this.GP_DisabledLabel.Click += new System.EventHandler(this.GP_DisabledLabel_Click);
            this.GP_DisabledLabel.DoubleClick += new System.EventHandler(this.GP_DisabledLabel_Click);
            // 
            // GP_IEddrawLabel
            // 
            this.GP_IEddrawLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GP_IEddrawLabel.Location = new System.Drawing.Point(274, 200);
            this.GP_IEddrawLabel.Name = "GP_IEddrawLabel";
            this.GP_IEddrawLabel.Size = new System.Drawing.Size(157, 13);
            this.GP_IEddrawLabel.TabIndex = 35;
            this.GP_IEddrawLabel.Text = "IE-ddraw:";
            this.GP_IEddrawLabel.Click += new System.EventHandler(this.GP_IEddrawLabel_Click);
            this.GP_IEddrawLabel.DoubleClick += new System.EventHandler(this.GP_IEddrawLabel_Click);
            // 
            // GP_ddwrapperLabel
            // 
            this.GP_ddwrapperLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GP_ddwrapperLabel.Location = new System.Drawing.Point(274, 222);
            this.GP_ddwrapperLabel.Name = "GP_ddwrapperLabel";
            this.GP_ddwrapperLabel.Size = new System.Drawing.Size(157, 15);
            this.GP_ddwrapperLabel.TabIndex = 37;
            this.GP_ddwrapperLabel.Text = "ddwrapper:";
            this.GP_ddwrapperLabel.Click += new System.EventHandler(this.GP_ddwrapperLabel_Click);
            this.GP_ddwrapperLabel.DoubleClick += new System.EventHandler(this.GP_ddwrapperLabel_Click);
            // 
            // GP_DisabledRadioButton
            // 
            this.GP_DisabledRadioButton.AutoSize = true;
            this.GP_DisabledRadioButton.Location = new System.Drawing.Point(404, 153);
            this.GP_DisabledRadioButton.Name = "GP_DisabledRadioButton";
            this.GP_DisabledRadioButton.Size = new System.Drawing.Size(14, 13);
            this.GP_DisabledRadioButton.TabIndex = 32;
            this.GP_DisabledRadioButton.TabStop = true;
            this.GP_DisabledRadioButton.UseVisualStyleBackColor = true;
            // 
            // GP_IEddrawRadioButton
            // 
            this.GP_IEddrawRadioButton.AutoSize = true;
            this.GP_IEddrawRadioButton.Location = new System.Drawing.Point(404, 200);
            this.GP_IEddrawRadioButton.Name = "GP_IEddrawRadioButton";
            this.GP_IEddrawRadioButton.Size = new System.Drawing.Size(14, 13);
            this.GP_IEddrawRadioButton.TabIndex = 36;
            this.GP_IEddrawRadioButton.TabStop = true;
            this.GP_IEddrawRadioButton.UseVisualStyleBackColor = true;
            // 
            // GP_ddwrapperRadioButton
            // 
            this.GP_ddwrapperRadioButton.AutoSize = true;
            this.GP_ddwrapperRadioButton.Location = new System.Drawing.Point(404, 222);
            this.GP_ddwrapperRadioButton.Name = "GP_ddwrapperRadioButton";
            this.GP_ddwrapperRadioButton.Size = new System.Drawing.Size(14, 13);
            this.GP_ddwrapperRadioButton.TabIndex = 38;
            this.GP_ddwrapperRadioButton.TabStop = true;
            this.GP_ddwrapperRadioButton.UseVisualStyleBackColor = true;
            this.GP_ddwrapperRadioButton.CheckedChanged += new System.EventHandler(this.GP_ddwrapperRadioButton_CheckedChanged);
            // 
            // GP_NoVideoMemoryCheckBox
            // 
            this.GP_NoVideoMemoryCheckBox.AutoSize = true;
            this.GP_NoVideoMemoryCheckBox.Enabled = false;
            this.GP_NoVideoMemoryCheckBox.Location = new System.Drawing.Point(404, 243);
            this.GP_NoVideoMemoryCheckBox.Name = "GP_NoVideoMemoryCheckBox";
            this.GP_NoVideoMemoryCheckBox.Size = new System.Drawing.Size(29, 17);
            this.GP_NoVideoMemoryCheckBox.TabIndex = 40;
            this.GP_NoVideoMemoryCheckBox.Text = " ";
            this.GP_NoVideoMemoryCheckBox.UseVisualStyleBackColor = true;
            // 
            // GP_NoVideoMemoryLabel
            // 
            this.GP_NoVideoMemoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GP_NoVideoMemoryLabel.Location = new System.Drawing.Point(274, 244);
            this.GP_NoVideoMemoryLabel.Name = "GP_NoVideoMemoryLabel";
            this.GP_NoVideoMemoryLabel.Size = new System.Drawing.Size(159, 18);
            this.GP_NoVideoMemoryLabel.TabIndex = 39;
            this.GP_NoVideoMemoryLabel.Text = "No Video Memory:";
            this.GP_NoVideoMemoryLabel.Click += new System.EventHandler(this.GP_NoVideoMemoryLabel_Click);
            this.GP_NoVideoMemoryLabel.DoubleClick += new System.EventHandler(this.GP_NoVideoMemoryLabel_Click);
            // 
            // GP_FakeVsyncCheckBox
            // 
            this.GP_FakeVsyncCheckBox.AutoSize = true;
            this.GP_FakeVsyncCheckBox.Enabled = false;
            this.GP_FakeVsyncCheckBox.Location = new System.Drawing.Point(404, 265);
            this.GP_FakeVsyncCheckBox.Name = "GP_FakeVsyncCheckBox";
            this.GP_FakeVsyncCheckBox.Size = new System.Drawing.Size(29, 17);
            this.GP_FakeVsyncCheckBox.TabIndex = 42;
            this.GP_FakeVsyncCheckBox.Text = " ";
            this.GP_FakeVsyncCheckBox.UseVisualStyleBackColor = true;
            // 
            // GP_FakeVsyncLabel
            // 
            this.GP_FakeVsyncLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GP_FakeVsyncLabel.Location = new System.Drawing.Point(274, 266);
            this.GP_FakeVsyncLabel.Name = "GP_FakeVsyncLabel";
            this.GP_FakeVsyncLabel.Size = new System.Drawing.Size(157, 16);
            this.GP_FakeVsyncLabel.TabIndex = 41;
            this.GP_FakeVsyncLabel.Text = "Fake Vsync:";
            this.GP_FakeVsyncLabel.Click += new System.EventHandler(this.GP_FakeVsyncLabel_Click);
            // 
            // GP_TSDDrawRadioButton
            // 
            this.GP_TSDDrawRadioButton.AutoSize = true;
            this.GP_TSDDrawRadioButton.Location = new System.Drawing.Point(404, 175);
            this.GP_TSDDrawRadioButton.Name = "GP_TSDDrawRadioButton";
            this.GP_TSDDrawRadioButton.Size = new System.Drawing.Size(14, 13);
            this.GP_TSDDrawRadioButton.TabIndex = 34;
            this.GP_TSDDrawRadioButton.TabStop = true;
            this.GP_TSDDrawRadioButton.UseVisualStyleBackColor = true;
            // 
            // GP_TSDDrawLabel
            // 
            this.GP_TSDDrawLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GP_TSDDrawLabel.Location = new System.Drawing.Point(274, 175);
            this.GP_TSDDrawLabel.Name = "GP_TSDDrawLabel";
            this.GP_TSDDrawLabel.Size = new System.Drawing.Size(157, 15);
            this.GP_TSDDrawLabel.TabIndex = 33;
            this.GP_TSDDrawLabel.Text = "TS-DDraw:";
            this.GP_TSDDrawLabel.Click += new System.EventHandler(this.GP_TSDDrawLabel_Click);
            this.GP_TSDDrawLabel.DoubleClick += new System.EventHandler(this.GP_TSDDrawLabel_Click);
            // 
            // chkWindowed
            // 
            this.chkWindowed.AutoSize = true;
            this.chkWindowed.Location = new System.Drawing.Point(152, 54);
            this.chkWindowed.Name = "chkWindowed";
            this.chkWindowed.Size = new System.Drawing.Size(29, 17);
            this.chkWindowed.TabIndex = 4;
            this.chkWindowed.Text = " ";
            this.chkWindowed.UseVisualStyleBackColor = true;
            // 
            // lblWindowed
            // 
            this.lblWindowed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWindowed.Location = new System.Drawing.Point(22, 56);
            this.lblWindowed.Name = "lblWindowed";
            this.lblWindowed.Size = new System.Drawing.Size(145, 14);
            this.lblWindowed.TabIndex = 3;
            this.lblWindowed.Text = "Windowed Mode:";
            this.lblWindowed.Click += new System.EventHandler(this.lblWindowed_Click);
            this.lblWindowed.DoubleClick += new System.EventHandler(this.lblWindowed_Click);
            // 
            // lblVideo
            // 
            this.lblVideo.AutoSize = true;
            this.lblVideo.Location = new System.Drawing.Point(9, 10);
            this.lblVideo.Name = "lblVideo";
            this.lblVideo.Size = new System.Drawing.Size(34, 13);
            this.lblVideo.TabIndex = 0;
            this.lblVideo.Text = "Video";
            // 
            // lblBackbuffer
            // 
            this.lblBackbuffer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBackbuffer.Location = new System.Drawing.Point(22, 77);
            this.lblBackbuffer.Name = "lblBackbuffer";
            this.lblBackbuffer.Size = new System.Drawing.Size(145, 14);
            this.lblBackbuffer.TabIndex = 5;
            this.lblBackbuffer.Text = "Graphics Patch:";
            this.lblBackbuffer.Click += new System.EventHandler(this.lblBackbuffer_Click);
            this.lblBackbuffer.DoubleClick += new System.EventHandler(this.lblBackbuffer_Click);
            // 
            // chkBackbuffer
            // 
            this.chkBackbuffer.AutoSize = true;
            this.chkBackbuffer.Location = new System.Drawing.Point(152, 77);
            this.chkBackbuffer.Name = "chkBackbuffer";
            this.chkBackbuffer.Size = new System.Drawing.Size(29, 17);
            this.chkBackbuffer.TabIndex = 6;
            this.chkBackbuffer.Text = " ";
            this.chkBackbuffer.UseVisualStyleBackColor = true;
            // 
            // chkIntro
            // 
            this.chkIntro.AutoSize = true;
            this.chkIntro.Location = new System.Drawing.Point(404, 72);
            this.chkIntro.Name = "chkIntro";
            this.chkIntro.Size = new System.Drawing.Size(29, 17);
            this.chkIntro.TabIndex = 14;
            this.chkIntro.Text = " ";
            this.chkIntro.UseVisualStyleBackColor = true;
            // 
            // lblIntro
            // 
            this.lblIntro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIntro.Location = new System.Drawing.Point(274, 72);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(157, 14);
            this.lblIntro.TabIndex = 13;
            this.lblIntro.Text = "Play Intro:";
            this.lblIntro.Click += new System.EventHandler(this.lblIntro_Click);
            this.lblIntro.DoubleClick += new System.EventHandler(this.lblIntro_Click);
            // 
            // chkCD
            // 
            this.chkCD.AutoSize = true;
            this.chkCD.Location = new System.Drawing.Point(404, 92);
            this.chkCD.Name = "chkCD";
            this.chkCD.Size = new System.Drawing.Size(29, 17);
            this.chkCD.TabIndex = 47;
            this.chkCD.Text = " ";
            this.chkCD.UseVisualStyleBackColor = true;
            // 
            // lblCD
            // 
            this.lblCD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCD.Location = new System.Drawing.Point(274, 92);
            this.lblCD.Name = "lblCD";
            this.lblCD.Size = new System.Drawing.Size(157, 14);
            this.lblCD.TabIndex = 46;
            this.lblCD.Text = "No CD:";
            // 
            // SetupFrame
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(432, 341);
            this.Controls.Add(this.chkCD);
            this.Controls.Add(this.lblCD);
            this.Controls.Add(this.chkIntro);
            this.Controls.Add(this.lblIntro);
            this.Controls.Add(this.chkBackbuffer);
            this.Controls.Add(this.lblBackbuffer);
            this.Controls.Add(this.lblVideo);
            this.Controls.Add(this.chkWindowed);
            this.Controls.Add(this.lblWindowed);
            this.Controls.Add(this.GP_TSDDrawRadioButton);
            this.Controls.Add(this.GP_TSDDrawLabel);
            this.Controls.Add(this.GP_FakeVsyncCheckBox);
            this.Controls.Add(this.GP_FakeVsyncLabel);
            this.Controls.Add(this.GP_NoVideoMemoryCheckBox);
            this.Controls.Add(this.GP_NoVideoMemoryLabel);
            this.Controls.Add(this.GP_ddwrapperRadioButton);
            this.Controls.Add(this.GP_IEddrawRadioButton);
            this.Controls.Add(this.GP_DisabledRadioButton);
            this.Controls.Add(this.GP_ddwrapperLabel);
            this.Controls.Add(this.GP_IEddrawLabel);
            this.Controls.Add(this.GP_DisabledLabel);
            this.Controls.Add(this.GraphicPatchLabel);
            this.Controls.Add(this.Line2);
            this.Controls.Add(this.lblSoundVolumeValue);
            this.Controls.Add(this.lblVoiceVolumeValue);
            this.Controls.Add(this.lblScoreVolumeValue);
            this.Controls.Add(this.lblSoundVolume);
            this.Controls.Add(this.trbSoundVolume);
            this.Controls.Add(this.lblVoiceVolume);
            this.Controls.Add(this.trbVoiceVolume);
            this.Controls.Add(this.lblScoreVolume);
            this.Controls.Add(this.trbScoreVolume);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.chkShuffle);
            this.Controls.Add(this.lblShuffle);
            this.Controls.Add(this.chkRepeat);
            this.Controls.Add(this.lblRepeat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkToolTips);
            this.Controls.Add(this.lblToolTips);
            this.Controls.Add(this.chkUnitActionLines);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbResolution);
            this.Controls.Add(this.lblUnitActionLines);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SetupFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tiberian Sun Config";
            this.Load += new System.EventHandler(this.SetupFrame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trbScoreVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbVoiceVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSoundVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbResolution;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkUnitActionLines;
        private System.Windows.Forms.Label lblUnitActionLines;
        private System.Windows.Forms.CheckBox chkToolTips;
        private System.Windows.Forms.Label lblToolTips;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRepeat;
        private System.Windows.Forms.CheckBox chkRepeat;
        private System.Windows.Forms.CheckBox chkShuffle;
        private System.Windows.Forms.Label lblShuffle;
        private System.Windows.Forms.Label line1;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TrackBar trbScoreVolume;
        private System.Windows.Forms.Label lblScoreVolume;
        private System.Windows.Forms.Label lblScoreVolumeValue;
        private System.Windows.Forms.TrackBar trbVoiceVolume;
        private System.Windows.Forms.Label lblVoiceVolume;
        private System.Windows.Forms.Label lblVoiceVolumeValue;
        private System.Windows.Forms.TrackBar trbSoundVolume;
        private System.Windows.Forms.Label lblSoundVolume;
        private System.Windows.Forms.Label lblSoundVolumeValue;
        private System.Windows.Forms.Label Line2;
        private System.Windows.Forms.Label GraphicPatchLabel;
        private System.Windows.Forms.Label GP_DisabledLabel;
        private System.Windows.Forms.Label GP_IEddrawLabel;
        private System.Windows.Forms.Label GP_ddwrapperLabel;
        private System.Windows.Forms.RadioButton GP_DisabledRadioButton;
        private System.Windows.Forms.RadioButton GP_IEddrawRadioButton;
        private System.Windows.Forms.RadioButton GP_ddwrapperRadioButton;
        private System.Windows.Forms.CheckBox GP_NoVideoMemoryCheckBox;
        private System.Windows.Forms.Label GP_NoVideoMemoryLabel;
        private System.Windows.Forms.CheckBox GP_FakeVsyncCheckBox;
        private System.Windows.Forms.Label GP_FakeVsyncLabel;
        private System.Windows.Forms.RadioButton GP_TSDDrawRadioButton;
        private System.Windows.Forms.Label GP_TSDDrawLabel;
        private System.Windows.Forms.CheckBox chkWindowed;
        private System.Windows.Forms.Label lblWindowed;
        private System.Windows.Forms.Label lblVideo;
        private System.Windows.Forms.Label lblBackbuffer;
        private System.Windows.Forms.CheckBox chkBackbuffer;
        private System.Windows.Forms.CheckBox chkIntro;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.CheckBox chkCD;
        private System.Windows.Forms.Label lblCD;
    }
}

