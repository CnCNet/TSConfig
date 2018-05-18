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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.soundPage = new System.Windows.Forms.TabPage();
            this.lblRepeat = new System.Windows.Forms.Label();
            this.chkRepeat = new System.Windows.Forms.CheckBox();
            this.lblShuffle = new System.Windows.Forms.Label();
            this.chkShuffle = new System.Windows.Forms.CheckBox();
            this.trbScoreVolume = new System.Windows.Forms.TrackBar();
            this.lblScoreVolume = new System.Windows.Forms.Label();
            this.trbVoiceVolume = new System.Windows.Forms.TrackBar();
            this.lblVoiceVolume = new System.Windows.Forms.Label();
            this.trbSoundVolume = new System.Windows.Forms.TrackBar();
            this.lblSoundVolume = new System.Windows.Forms.Label();
            this.lblScoreVolumeValue = new System.Windows.Forms.Label();
            this.lblVoiceVolumeValue = new System.Windows.Forms.Label();
            this.lblSoundVolumeValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gameOptionsPage = new System.Windows.Forms.TabPage();
            this.lblUnitActionLines = new System.Windows.Forms.Label();
            this.chkUnitActionLines = new System.Windows.Forms.CheckBox();
            this.lblToolTips = new System.Windows.Forms.Label();
            this.chkToolTips = new System.Windows.Forms.CheckBox();
            this.lblIntro = new System.Windows.Forms.Label();
            this.chkIntro = new System.Windows.Forms.CheckBox();
            this.lblCD = new System.Windows.Forms.Label();
            this.chkCD = new System.Windows.Forms.CheckBox();
            this.lblProcAffinity = new System.Windows.Forms.Label();
            this.chkProcAffinity = new System.Windows.Forms.CheckBox();
            this.lblUseDragDistance = new System.Windows.Forms.Label();
            this.lblUseCustomColors = new System.Windows.Forms.Label();
            this.chkUseCustomColors = new System.Windows.Forms.CheckBox();
            this.lblUseOnlyRightClickDeselect = new System.Windows.Forms.Label();
            this.chkUseOnlyRightClickDeselect = new System.Windows.Forms.CheckBox();
            this.lblDisable = new System.Windows.Forms.Label();
            this.btnColorSchemeEditor = new System.Windows.Forms.Button();
            this.trbDragDistance = new System.Windows.Forms.TrackBar();
            this.lblDragDistanceValue = new System.Windows.Forms.Label();
            this.lblUseDisableAltTab = new System.Windows.Forms.Label();
            this.chkUseDisableAltTab = new System.Windows.Forms.CheckBox();
            this.lblUseDisableEdgeScrolling = new System.Windows.Forms.Label();
            this.chkUseDisableEdgeScrolling = new System.Windows.Forms.CheckBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.chkBackbuffer = new System.Windows.Forms.CheckBox();
            this.lblBackbuffer = new System.Windows.Forms.Label();
            this.soundPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbScoreVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbVoiceVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSoundVolume)).BeginInit();
            this.gameOptionsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbDragDistance)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.Location = new System.Drawing.Point(12, 331);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(222, 331);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApply.Location = new System.Drawing.Point(119, 331);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // soundPage
            // 
            this.soundPage.Controls.Add(this.label3);
            this.soundPage.Controls.Add(this.lblSoundVolumeValue);
            this.soundPage.Controls.Add(this.lblVoiceVolumeValue);
            this.soundPage.Controls.Add(this.lblScoreVolumeValue);
            this.soundPage.Controls.Add(this.lblSoundVolume);
            this.soundPage.Controls.Add(this.trbSoundVolume);
            this.soundPage.Controls.Add(this.lblVoiceVolume);
            this.soundPage.Controls.Add(this.trbVoiceVolume);
            this.soundPage.Controls.Add(this.lblScoreVolume);
            this.soundPage.Controls.Add(this.trbScoreVolume);
            this.soundPage.Controls.Add(this.chkShuffle);
            this.soundPage.Controls.Add(this.lblShuffle);
            this.soundPage.Controls.Add(this.chkRepeat);
            this.soundPage.Controls.Add(this.lblRepeat);
            this.soundPage.Location = new System.Drawing.Point(4, 22);
            this.soundPage.Name = "soundPage";
            this.soundPage.Size = new System.Drawing.Size(293, 293);
            this.soundPage.TabIndex = 2;
            this.soundPage.Text = "Sound";
            this.soundPage.UseVisualStyleBackColor = true;
            // 
            // lblRepeat
            // 
            this.lblRepeat.Location = new System.Drawing.Point(16, 25);
            this.lblRepeat.Name = "lblRepeat";
            this.lblRepeat.Size = new System.Drawing.Size(78, 13);
            this.lblRepeat.TabIndex = 9;
            this.lblRepeat.Text = "Repeat music:";
            // 
            // chkRepeat
            // 
            this.chkRepeat.AutoSize = true;
            this.chkRepeat.Location = new System.Drawing.Point(146, 24);
            this.chkRepeat.Name = "chkRepeat";
            this.chkRepeat.Size = new System.Drawing.Size(29, 17);
            this.chkRepeat.TabIndex = 0;
            this.chkRepeat.Text = " ";
            this.chkRepeat.UseVisualStyleBackColor = true;
            // 
            // lblShuffle
            // 
            this.lblShuffle.Location = new System.Drawing.Point(16, 46);
            this.lblShuffle.Name = "lblShuffle";
            this.lblShuffle.Size = new System.Drawing.Size(78, 13);
            this.lblShuffle.TabIndex = 8;
            this.lblShuffle.Text = "Shuffle music:";
            // 
            // chkShuffle
            // 
            this.chkShuffle.AutoSize = true;
            this.chkShuffle.Location = new System.Drawing.Point(146, 46);
            this.chkShuffle.Name = "chkShuffle";
            this.chkShuffle.Size = new System.Drawing.Size(29, 17);
            this.chkShuffle.TabIndex = 1;
            this.chkShuffle.Text = " ";
            this.chkShuffle.UseVisualStyleBackColor = true;
            // 
            // trbScoreVolume
            // 
            this.trbScoreVolume.AutoSize = false;
            this.trbScoreVolume.Location = new System.Drawing.Point(138, 64);
            this.trbScoreVolume.Maximum = 20;
            this.trbScoreVolume.Name = "trbScoreVolume";
            this.trbScoreVolume.Size = new System.Drawing.Size(121, 27);
            this.trbScoreVolume.TabIndex = 2;
            this.trbScoreVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbScoreVolume.Value = 18;
            this.trbScoreVolume.ValueChanged += new System.EventHandler(this.trbScoreVolume_ValueChanged);
            // 
            // lblScoreVolume
            // 
            this.lblScoreVolume.AutoSize = true;
            this.lblScoreVolume.Location = new System.Drawing.Point(16, 69);
            this.lblScoreVolume.Name = "lblScoreVolume";
            this.lblScoreVolume.Size = new System.Drawing.Size(75, 13);
            this.lblScoreVolume.TabIndex = 7;
            this.lblScoreVolume.Text = "Music volume:";
            // 
            // trbVoiceVolume
            // 
            this.trbVoiceVolume.AutoSize = false;
            this.trbVoiceVolume.Location = new System.Drawing.Point(138, 92);
            this.trbVoiceVolume.Maximum = 20;
            this.trbVoiceVolume.Name = "trbVoiceVolume";
            this.trbVoiceVolume.Size = new System.Drawing.Size(121, 27);
            this.trbVoiceVolume.TabIndex = 3;
            this.trbVoiceVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbVoiceVolume.Value = 18;
            this.trbVoiceVolume.ValueChanged += new System.EventHandler(this.trbVoiceVolume_ValueChanged);
            // 
            // lblVoiceVolume
            // 
            this.lblVoiceVolume.AutoSize = true;
            this.lblVoiceVolume.Location = new System.Drawing.Point(16, 97);
            this.lblVoiceVolume.Name = "lblVoiceVolume";
            this.lblVoiceVolume.Size = new System.Drawing.Size(79, 13);
            this.lblVoiceVolume.TabIndex = 6;
            this.lblVoiceVolume.Text = "Voices volume:";
            // 
            // trbSoundVolume
            // 
            this.trbSoundVolume.AutoSize = false;
            this.trbSoundVolume.Location = new System.Drawing.Point(138, 120);
            this.trbSoundVolume.Maximum = 20;
            this.trbSoundVolume.Name = "trbSoundVolume";
            this.trbSoundVolume.Size = new System.Drawing.Size(121, 27);
            this.trbSoundVolume.TabIndex = 4;
            this.trbSoundVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbSoundVolume.Value = 18;
            this.trbSoundVolume.ValueChanged += new System.EventHandler(this.trbSoundVolume_ValueChanged);
            // 
            // lblSoundVolume
            // 
            this.lblSoundVolume.AutoSize = true;
            this.lblSoundVolume.Location = new System.Drawing.Point(16, 125);
            this.lblSoundVolume.Name = "lblSoundVolume";
            this.lblSoundVolume.Size = new System.Drawing.Size(78, 13);
            this.lblSoundVolume.TabIndex = 5;
            this.lblSoundVolume.Text = "Sound volume:";
            // 
            // lblScoreVolumeValue
            // 
            this.lblScoreVolumeValue.AutoSize = true;
            this.lblScoreVolumeValue.Location = new System.Drawing.Point(265, 69);
            this.lblScoreVolumeValue.Name = "lblScoreVolumeValue";
            this.lblScoreVolumeValue.Size = new System.Drawing.Size(27, 13);
            this.lblScoreVolumeValue.TabIndex = 37;
            this.lblScoreVolumeValue.Text = "30%";
            // 
            // lblVoiceVolumeValue
            // 
            this.lblVoiceVolumeValue.AutoSize = true;
            this.lblVoiceVolumeValue.Location = new System.Drawing.Point(265, 97);
            this.lblVoiceVolumeValue.Name = "lblVoiceVolumeValue";
            this.lblVoiceVolumeValue.Size = new System.Drawing.Size(27, 13);
            this.lblVoiceVolumeValue.TabIndex = 40;
            this.lblVoiceVolumeValue.Text = "30%";
            // 
            // lblSoundVolumeValue
            // 
            this.lblSoundVolumeValue.AutoSize = true;
            this.lblSoundVolumeValue.Location = new System.Drawing.Point(265, 125);
            this.lblSoundVolumeValue.Name = "lblSoundVolumeValue";
            this.lblSoundVolumeValue.Size = new System.Drawing.Size(27, 13);
            this.lblSoundVolumeValue.TabIndex = 43;
            this.lblSoundVolumeValue.Text = "30%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, -17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Sound";
            // 
            // gameOptionsPage
            // 
            this.gameOptionsPage.Controls.Add(this.chkBackbuffer);
            this.gameOptionsPage.Controls.Add(this.lblBackbuffer);
            this.gameOptionsPage.Controls.Add(this.chkUseDisableEdgeScrolling);
            this.gameOptionsPage.Controls.Add(this.lblUseDisableEdgeScrolling);
            this.gameOptionsPage.Controls.Add(this.chkUseDisableAltTab);
            this.gameOptionsPage.Controls.Add(this.lblUseDisableAltTab);
            this.gameOptionsPage.Controls.Add(this.lblDragDistanceValue);
            this.gameOptionsPage.Controls.Add(this.trbDragDistance);
            this.gameOptionsPage.Controls.Add(this.btnColorSchemeEditor);
            this.gameOptionsPage.Controls.Add(this.lblDisable);
            this.gameOptionsPage.Controls.Add(this.chkUseOnlyRightClickDeselect);
            this.gameOptionsPage.Controls.Add(this.lblUseOnlyRightClickDeselect);
            this.gameOptionsPage.Controls.Add(this.chkUseCustomColors);
            this.gameOptionsPage.Controls.Add(this.lblUseCustomColors);
            this.gameOptionsPage.Controls.Add(this.lblUseDragDistance);
            this.gameOptionsPage.Controls.Add(this.chkProcAffinity);
            this.gameOptionsPage.Controls.Add(this.lblProcAffinity);
            this.gameOptionsPage.Controls.Add(this.chkCD);
            this.gameOptionsPage.Controls.Add(this.lblCD);
            this.gameOptionsPage.Controls.Add(this.chkIntro);
            this.gameOptionsPage.Controls.Add(this.lblIntro);
            this.gameOptionsPage.Controls.Add(this.chkToolTips);
            this.gameOptionsPage.Controls.Add(this.lblToolTips);
            this.gameOptionsPage.Controls.Add(this.chkUnitActionLines);
            this.gameOptionsPage.Controls.Add(this.lblUnitActionLines);
            this.gameOptionsPage.Location = new System.Drawing.Point(4, 22);
            this.gameOptionsPage.Name = "gameOptionsPage";
            this.gameOptionsPage.Padding = new System.Windows.Forms.Padding(3);
            this.gameOptionsPage.Size = new System.Drawing.Size(293, 293);
            this.gameOptionsPage.TabIndex = 1;
            this.gameOptionsPage.Text = "Options";
            this.gameOptionsPage.UseVisualStyleBackColor = true;
            // 
            // lblUnitActionLines
            // 
            this.lblUnitActionLines.Location = new System.Drawing.Point(16, 25);
            this.lblUnitActionLines.Name = "lblUnitActionLines";
            this.lblUnitActionLines.Size = new System.Drawing.Size(143, 14);
            this.lblUnitActionLines.TabIndex = 12;
            this.lblUnitActionLines.Text = "Show target lines:";
            // 
            // chkUnitActionLines
            // 
            this.chkUnitActionLines.AutoSize = true;
            this.chkUnitActionLines.Location = new System.Drawing.Point(158, 24);
            this.chkUnitActionLines.Name = "chkUnitActionLines";
            this.chkUnitActionLines.Size = new System.Drawing.Size(29, 17);
            this.chkUnitActionLines.TabIndex = 0;
            this.chkUnitActionLines.Text = " ";
            this.chkUnitActionLines.UseVisualStyleBackColor = true;
            // 
            // lblToolTips
            // 
            this.lblToolTips.Location = new System.Drawing.Point(16, 45);
            this.lblToolTips.Name = "lblToolTips";
            this.lblToolTips.Size = new System.Drawing.Size(143, 14);
            this.lblToolTips.TabIndex = 11;
            this.lblToolTips.Text = "Show tooltips:";
            // 
            // chkToolTips
            // 
            this.chkToolTips.AutoSize = true;
            this.chkToolTips.Location = new System.Drawing.Point(158, 45);
            this.chkToolTips.Name = "chkToolTips";
            this.chkToolTips.Size = new System.Drawing.Size(29, 17);
            this.chkToolTips.TabIndex = 1;
            this.chkToolTips.Text = " ";
            this.chkToolTips.UseVisualStyleBackColor = true;
            // 
            // lblIntro
            // 
            this.lblIntro.Location = new System.Drawing.Point(16, 65);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(143, 14);
            this.lblIntro.TabIndex = 10;
            this.lblIntro.Text = "Play Intro:";
            // 
            // chkIntro
            // 
            this.chkIntro.AutoSize = true;
            this.chkIntro.Location = new System.Drawing.Point(158, 65);
            this.chkIntro.Name = "chkIntro";
            this.chkIntro.Size = new System.Drawing.Size(29, 17);
            this.chkIntro.TabIndex = 2;
            this.chkIntro.Text = " ";
            this.chkIntro.UseVisualStyleBackColor = true;
            // 
            // lblCD
            // 
            this.lblCD.Location = new System.Drawing.Point(16, 85);
            this.lblCD.Name = "lblCD";
            this.lblCD.Size = new System.Drawing.Size(143, 14);
            this.lblCD.TabIndex = 9;
            this.lblCD.Text = "No CD:";
            // 
            // chkCD
            // 
            this.chkCD.AutoSize = true;
            this.chkCD.Location = new System.Drawing.Point(158, 85);
            this.chkCD.Name = "chkCD";
            this.chkCD.Size = new System.Drawing.Size(29, 17);
            this.chkCD.TabIndex = 3;
            this.chkCD.Text = " ";
            this.chkCD.UseVisualStyleBackColor = true;
            // 
            // lblProcAffinity
            // 
            this.lblProcAffinity.Location = new System.Drawing.Point(16, 105);
            this.lblProcAffinity.Name = "lblProcAffinity";
            this.lblProcAffinity.Size = new System.Drawing.Size(143, 14);
            this.lblProcAffinity.TabIndex = 8;
            this.lblProcAffinity.Text = "Single Processor Affinity:";
            // 
            // chkProcAffinity
            // 
            this.chkProcAffinity.AutoSize = true;
            this.chkProcAffinity.Location = new System.Drawing.Point(158, 105);
            this.chkProcAffinity.Name = "chkProcAffinity";
            this.chkProcAffinity.Size = new System.Drawing.Size(29, 17);
            this.chkProcAffinity.TabIndex = 4;
            this.chkProcAffinity.Text = " ";
            this.chkProcAffinity.UseVisualStyleBackColor = true;
            // 
            // lblUseDragDistance
            // 
            this.lblUseDragDistance.Location = new System.Drawing.Point(16, 146);
            this.lblUseDragDistance.Name = "lblUseDragDistance";
            this.lblUseDragDistance.Size = new System.Drawing.Size(145, 14);
            this.lblUseDragDistance.TabIndex = 68;
            this.lblUseDragDistance.Text = "Drag Distance:";
            // 
            // lblUseCustomColors
            // 
            this.lblUseCustomColors.Location = new System.Drawing.Point(16, 125);
            this.lblUseCustomColors.Name = "lblUseCustomColors";
            this.lblUseCustomColors.Size = new System.Drawing.Size(145, 14);
            this.lblUseCustomColors.TabIndex = 71;
            this.lblUseCustomColors.Text = "Use Custom Colors:";
            // 
            // chkUseCustomColors
            // 
            this.chkUseCustomColors.Location = new System.Drawing.Point(158, 124);
            this.chkUseCustomColors.Name = "chkUseCustomColors";
            this.chkUseCustomColors.Size = new System.Drawing.Size(29, 17);
            this.chkUseCustomColors.TabIndex = 69;
            this.chkUseCustomColors.Text = " ";
            this.chkUseCustomColors.UseVisualStyleBackColor = true;
            // 
            // lblUseOnlyRightClickDeselect
            // 
            this.lblUseOnlyRightClickDeselect.Location = new System.Drawing.Point(16, 174);
            this.lblUseOnlyRightClickDeselect.Name = "lblUseOnlyRightClickDeselect";
            this.lblUseOnlyRightClickDeselect.Size = new System.Drawing.Size(145, 14);
            this.lblUseOnlyRightClickDeselect.TabIndex = 73;
            this.lblUseOnlyRightClickDeselect.Text = "Force Right-Click De-Select:";
            this.lblUseOnlyRightClickDeselect.Visible = false;
            // 
            // chkUseOnlyRightClickDeselect
            // 
            this.chkUseOnlyRightClickDeselect.Location = new System.Drawing.Point(158, 171);
            this.chkUseOnlyRightClickDeselect.Name = "chkUseOnlyRightClickDeselect";
            this.chkUseOnlyRightClickDeselect.Size = new System.Drawing.Size(29, 17);
            this.chkUseOnlyRightClickDeselect.TabIndex = 72;
            this.chkUseOnlyRightClickDeselect.Text = " ";
            this.chkUseOnlyRightClickDeselect.UseVisualStyleBackColor = true;
            this.chkUseOnlyRightClickDeselect.Visible = false;
            // 
            // lblDisable
            // 
            this.lblDisable.Location = new System.Drawing.Point(16, 194);
            this.lblDisable.Name = "lblDisable";
            this.lblDisable.Size = new System.Drawing.Size(145, 14);
            this.lblDisable.TabIndex = 75;
            this.lblDisable.Text = "Disable:";
            // 
            // btnColorSchemeEditor
            // 
            this.btnColorSchemeEditor.Location = new System.Drawing.Point(181, 119);
            this.btnColorSchemeEditor.Name = "btnColorSchemeEditor";
            this.btnColorSchemeEditor.Size = new System.Drawing.Size(76, 22);
            this.btnColorSchemeEditor.TabIndex = 76;
            this.btnColorSchemeEditor.Text = "Edit Colors";
            this.btnColorSchemeEditor.Click += new System.EventHandler(this.btnColorSchemeEditor_Click);
            // 
            // trbDragDistance
            // 
            this.trbDragDistance.AutoSize = false;
            this.trbDragDistance.Location = new System.Drawing.Point(136, 144);
            this.trbDragDistance.Maximum = 32;
            this.trbDragDistance.Name = "trbDragDistance";
            this.trbDragDistance.Size = new System.Drawing.Size(121, 27);
            this.trbDragDistance.TabIndex = 77;
            this.trbDragDistance.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbDragDistance.Value = 4;
            this.trbDragDistance.ValueChanged += new System.EventHandler(this.trbDragDistance_ValueChanged);
            // 
            // lblDragDistanceValue
            // 
            this.lblDragDistanceValue.AutoSize = true;
            this.lblDragDistanceValue.Location = new System.Drawing.Point(263, 149);
            this.lblDragDistanceValue.Name = "lblDragDistanceValue";
            this.lblDragDistanceValue.Size = new System.Drawing.Size(13, 13);
            this.lblDragDistanceValue.TabIndex = 78;
            this.lblDragDistanceValue.Text = "4";
            // 
            // lblUseDisableAltTab
            // 
            this.lblUseDisableAltTab.Location = new System.Drawing.Point(16, 208);
            this.lblUseDisableAltTab.Name = "lblUseDisableAltTab";
            this.lblUseDisableAltTab.Size = new System.Drawing.Size(145, 14);
            this.lblUseDisableAltTab.TabIndex = 79;
            this.lblUseDisableAltTab.Text = "Alt+Tab, WinKey, Ctrl+Esc.";
            // 
            // chkUseDisableAltTab
            // 
            this.chkUseDisableAltTab.Location = new System.Drawing.Point(158, 207);
            this.chkUseDisableAltTab.Name = "chkUseDisableAltTab";
            this.chkUseDisableAltTab.Size = new System.Drawing.Size(29, 17);
            this.chkUseDisableAltTab.TabIndex = 74;
            this.chkUseDisableAltTab.Text = " ";
            this.chkUseDisableAltTab.UseVisualStyleBackColor = true;
            // 
            // lblUseDisableEdgeScrolling
            // 
            this.lblUseDisableEdgeScrolling.Location = new System.Drawing.Point(16, 233);
            this.lblUseDisableEdgeScrolling.Name = "lblUseDisableEdgeScrolling";
            this.lblUseDisableEdgeScrolling.Size = new System.Drawing.Size(145, 14);
            this.lblUseDisableEdgeScrolling.TabIndex = 81;
            this.lblUseDisableEdgeScrolling.Text = "Disable Edge Scrolling:";
            // 
            // chkUseDisableEdgeScrolling
            // 
            this.chkUseDisableEdgeScrolling.Location = new System.Drawing.Point(158, 233);
            this.chkUseDisableEdgeScrolling.Name = "chkUseDisableEdgeScrolling";
            this.chkUseDisableEdgeScrolling.Size = new System.Drawing.Size(29, 17);
            this.chkUseDisableEdgeScrolling.TabIndex = 80;
            this.chkUseDisableEdgeScrolling.Text = " ";
            this.chkUseDisableEdgeScrolling.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.gameOptionsPage);
            this.tabControl.Controls.Add(this.soundPage);
            this.tabControl.Location = new System.Drawing.Point(3, 6);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(301, 319);
            this.tabControl.TabIndex = 0;
            // 
            // chkBackbuffer
            // 
            this.chkBackbuffer.AutoSize = true;
            this.chkBackbuffer.Location = new System.Drawing.Point(158, 257);
            this.chkBackbuffer.Name = "chkBackbuffer";
            this.chkBackbuffer.Size = new System.Drawing.Size(29, 17);
            this.chkBackbuffer.TabIndex = 82;
            this.chkBackbuffer.Text = " ";
            this.chkBackbuffer.UseVisualStyleBackColor = true;
            // 
            // lblBackbuffer
            // 
            this.lblBackbuffer.Location = new System.Drawing.Point(16, 258);
            this.lblBackbuffer.Name = "lblBackbuffer";
            this.lblBackbuffer.Size = new System.Drawing.Size(92, 16);
            this.lblBackbuffer.TabIndex = 83;
            this.lblBackbuffer.Text = "Graphics Patch:";
            // 
            // SetupFrame
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(309, 366);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SetupFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tiberian Sun Config";
            this.Load += new System.EventHandler(this.SetupFrame_Load);
            this.soundPage.ResumeLayout(false);
            this.soundPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbScoreVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbVoiceVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSoundVolume)).EndInit();
            this.gameOptionsPage.ResumeLayout(false);
            this.gameOptionsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbDragDistance)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TabPage soundPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSoundVolumeValue;
        private System.Windows.Forms.Label lblVoiceVolumeValue;
        private System.Windows.Forms.Label lblScoreVolumeValue;
        private System.Windows.Forms.Label lblSoundVolume;
        private System.Windows.Forms.TrackBar trbSoundVolume;
        private System.Windows.Forms.Label lblVoiceVolume;
        private System.Windows.Forms.TrackBar trbVoiceVolume;
        private System.Windows.Forms.Label lblScoreVolume;
        private System.Windows.Forms.TrackBar trbScoreVolume;
        private System.Windows.Forms.CheckBox chkShuffle;
        private System.Windows.Forms.Label lblShuffle;
        private System.Windows.Forms.CheckBox chkRepeat;
        private System.Windows.Forms.Label lblRepeat;
        private System.Windows.Forms.TabPage gameOptionsPage;
        private System.Windows.Forms.CheckBox chkUseDisableEdgeScrolling;
        private System.Windows.Forms.Label lblUseDisableEdgeScrolling;
        private System.Windows.Forms.CheckBox chkUseDisableAltTab;
        private System.Windows.Forms.Label lblUseDisableAltTab;
        private System.Windows.Forms.Label lblDragDistanceValue;
        private System.Windows.Forms.TrackBar trbDragDistance;
        private System.Windows.Forms.Button btnColorSchemeEditor;
        private System.Windows.Forms.Label lblDisable;
        private System.Windows.Forms.CheckBox chkUseOnlyRightClickDeselect;
        private System.Windows.Forms.Label lblUseOnlyRightClickDeselect;
        private System.Windows.Forms.CheckBox chkUseCustomColors;
        private System.Windows.Forms.Label lblUseCustomColors;
        private System.Windows.Forms.Label lblUseDragDistance;
        private System.Windows.Forms.CheckBox chkProcAffinity;
        private System.Windows.Forms.Label lblProcAffinity;
        private System.Windows.Forms.CheckBox chkCD;
        private System.Windows.Forms.Label lblCD;
        private System.Windows.Forms.CheckBox chkIntro;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.CheckBox chkToolTips;
        private System.Windows.Forms.Label lblToolTips;
        private System.Windows.Forms.CheckBox chkUnitActionLines;
        private System.Windows.Forms.Label lblUnitActionLines;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.CheckBox chkBackbuffer;
        private System.Windows.Forms.Label lblBackbuffer;
    }
}

