using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using tsconfig.domain;

using tsconfig.domain.constants;

namespace gui
{
    public partial class SetupFrame : Form
    {
        public SetupFrame()
        {
            InitializeComponent();
        }

        private void SetupFrame_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            loadSettings();
        }

        private void loadSettings()
        {
            chkUnitActionLines.Checked = DomainController.Instance().getUnitActionLines();
            chkToolTips.Checked = DomainController.Instance().getTooltips();
            chkRepeat.Checked = DomainController.Instance().getMusicRepeat();
            chkShuffle.Checked = DomainController.Instance().getMusicShuffle();
            chkBackbuffer.Checked = DomainController.Instance().getBackbuffer();
            chkIntro.Checked = DomainController.Instance().getIntro();
            chkCD.Checked = DomainController.Instance().getCD();
            chkProcAffinity.Checked = DomainController.Instance().getProcAffinity();
            try
            {
                trbScoreVolume.Value = Convert.ToInt32(DomainController.Instance().getScoreVolume() * 20);
                trbVoiceVolume.Value = Convert.ToInt32(DomainController.Instance().getVoiceVolume() * 20);
                trbSoundVolume.Value = Convert.ToInt32(DomainController.Instance().getSoundVolume() * 20);
                trbDragDistance.Value = DomainController.Instance().getDragDistance();
            }
            catch
            {
            }
            chkUseCustomColors.Checked = DomainController.Instance().getOverrideColors();
            ColorOverrides = DomainController.Instance().getColorOverrides();
            TextBackgroundColor = DomainController.Instance().getTextBackgroundColor();
            chkUseOnlyRightClickDeselect.Checked = DomainController.Instance().getOnlyRightClickDeselect();
            chkUseDisableAltTab.Checked = DomainController.Instance().getDisableAltTab();
            chkUseDisableEdgeScrolling.Checked = DomainController.Instance().getDisableEdgeScrolling();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (saveSettings())
                Environment.Exit(0);
        }


        private void btnApply_Click(object sender, EventArgs e)
        {
            saveSettings();
            loadSettings();
        }

        private Boolean saveSettings()
        {
            Boolean unitActionLines = chkUnitActionLines.Checked;
            Boolean tooltips = chkToolTips.Checked;
            Boolean musicRepeat = chkRepeat.Checked;
            Boolean musicShuffle = chkShuffle.Checked;
            Boolean Backbuffer = chkBackbuffer.Checked;
            Boolean CD = chkCD.Checked;
            Boolean procAffinity = chkProcAffinity.Checked;
            Boolean Intro = chkIntro.Checked;
            Double musicVolume = Convert.ToDouble(trbScoreVolume.Value) / 20.0;
            Double voiceVolume = Convert.ToDouble(trbVoiceVolume.Value) / 20.0;
            Double soundVolume = Convert.ToDouble(trbSoundVolume.Value) / 20.0;
            int dragDistance = trbDragDistance.Value;
            Boolean OverrideColors = chkUseCustomColors.Checked;
            Boolean OnlyRightClickDeselect = chkUseOnlyRightClickDeselect.Checked;
            Boolean DisableAltTab = chkUseDisableAltTab.Checked;
            Boolean DisableEdgeScrolling = chkUseDisableEdgeScrolling.Checked;

            return DomainController.Instance().saveSettings(
                unitActionLines,
                tooltips,
                Backbuffer,
                Intro,
                CD,
                musicRepeat,
                musicShuffle,
                musicVolume,
                voiceVolume,
                soundVolume,
                dragDistance,
                procAffinity,
                ColorOverrides,
                OverrideColors,
                OnlyRightClickDeselect,
                DisableAltTab,
                DisableEdgeScrolling,
                TextBackgroundColor);
        }

        private void lblUnitActionLines_Click(object sender, EventArgs e)
        {
            chkUnitActionLines.Checked = !chkUnitActionLines.Checked;
            chkUnitActionLines.Select();
        }

        private void lblToolTips_Click(object sender, EventArgs e)
        {
            chkToolTips.Checked = !chkToolTips.Checked;
            chkToolTips.Select();
        }

        private void lblRepeat_Click(object sender, EventArgs e)
        {
            chkRepeat.Checked = !chkRepeat.Checked;
            chkRepeat.Select();
        }

        private void lblShuffle_Click(object sender, EventArgs e)
        {
            chkShuffle.Checked = !chkShuffle.Checked;
            chkShuffle.Select();
        }

        private void lblIntro_Click(object sender, EventArgs e)
        {
            chkIntro.Checked = !chkIntro.Checked;
            chkIntro.Select();
        }

        private void lblBackbuffer_Click(object sender, EventArgs e)
        {
            chkBackbuffer.Checked = !chkBackbuffer.Checked;
            chkBackbuffer.Select();
        }

        private void trbScoreVolume_ValueChanged(object sender, EventArgs e)
        {
            lblScoreVolumeValue.Text = trbScoreVolume.Value * 5 + "%";
        }

        private void trbDragDistance_ValueChanged(object sender, EventArgs e)
        {
            lblDragDistanceValue.Text = String.Format("{0}", trbDragDistance.Value);
        }

        private void trbVoiceVolume_ValueChanged(object sender, EventArgs e)
        {
            lblVoiceVolumeValue.Text = trbVoiceVolume.Value * 5 + "%";
        }

        private void trbSoundVolume_ValueChanged(object sender, EventArgs e)
        {
            lblSoundVolumeValue.Text = trbSoundVolume.Value * 5 + "%";
        }

        private void lblUseCustomColors_Click(object sender, EventArgs e)
        {
          chkUseCustomColors.Checked = !chkUseCustomColors.Checked;
          chkUseCustomColors.Select();
        }
        private int TextBackgroundColor = 0; // = 12 for black
        private WWColor[] ColorOverrides = new WWColor[8];
        private void btnColorSchemeEditor_Click(object sender, EventArgs e)
        {
            ColorSchemeEditor d = new ColorSchemeEditor();
            for (int i = 0; i < ColorOverrides.Length; i++)
                if (ColorOverrides[i] != null)
                    d.Colors[i].WWColor = ColorOverrides[i];

            if (TextBackgroundColor == 12)
                d.BkgColor.Checked = true;


            d.ShowDialog();
            if (DialogResult.OK == d.DialogResult)
            {
                for (int i = 0; i < ColorOverrides.Length; i++)
                    ColorOverrides[i] = d.Colors[i].WWColor;
                if (d.BkgColor.Checked)
                    TextBackgroundColor = 12;
            }
        }
    }
}
