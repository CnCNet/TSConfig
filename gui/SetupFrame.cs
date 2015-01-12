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
            List<String> resolutions = screenres.ScreenResolutionOperations.getScreenResolutions(640, 400, 16);
            String resolution = DomainController.Instance().getCurrentGameRes();
            cmbResolution.DataSource = resolutions;
            if (resolutions.Contains(resolution))
                cmbResolution.SelectedIndex = resolutions.IndexOf(resolution);
            chkUnitActionLines.Checked = DomainController.Instance().getUnitActionLines();
            chkToolTips.Checked = DomainController.Instance().getTooltips();
            chkRepeat.Checked = DomainController.Instance().getMusicRepeat();
            chkShuffle.Checked = DomainController.Instance().getMusicShuffle();
            chkWindowed.Checked = DomainController.Instance().getWindowed();
            chkBackbuffer.Checked = DomainController.Instance().getBackbuffer();
            chkIntro.Checked = DomainController.Instance().getIntro();
            chkCD.Checked = DomainController.Instance().getCD();
            chkProcAffinity.Checked = DomainController.Instance().getProcAffinity();
            trbScoreVolume.Value = Convert.ToInt32(DomainController.Instance().getScoreVolume() * 20);
            trbVoiceVolume.Value = Convert.ToInt32(DomainController.Instance().getVoiceVolume() * 20);
            trbSoundVolume.Value = Convert.ToInt32(DomainController.Instance().getSoundVolume() * 20);

            if (GP_TSDDrawRadioButton.Checked) {
                chkWindowed.Enabled = false;
                chkWindowed.Checked = false;
            }

            GP_ddwrapperRadioButton.Checked = DomainController.Instance().getDDwrapperStatus();

            if (!GP_ddwrapperRadioButton.Checked && !GP_IEddrawRadioButton.Checked)
                GP_TSDDrawRadioButton.Checked = DomainController.Instance().getTSDDrawStatus();
            
            if (!GP_ddwrapperRadioButton.Checked && !GP_TSDDrawRadioButton.Checked)
                GP_IEddrawRadioButton.Checked = DomainController.Instance().getIEDDrawStatus();

           /* if (chkWindowed.Checked && !GP_TSDDrawRadioButton.Checked)
                MessageBox.Show("If TS-DDraw is not enabled then Windowed mode requires 16-bit color depth on your desktop", "Windowed mode info", MessageBoxButtons.OK, MessageBoxIcon.Information); */

            GP_DisabledRadioButton.Checked = !GP_ddwrapperRadioButton.Checked && !GP_IEddrawRadioButton.Checked && !GP_TSDDrawRadioButton.Checked;

            GP_NoVideoMemoryCheckBox.Checked = DomainController.Instance().getNoVideoMemory();
            GP_FakeVsyncCheckBox.Checked = DomainController.Instance().getFakeVsync();

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
            int width = 0;
            int height = 0;

            try
            {
                if (!cmbResolution.SelectedItem.ToString().Equals(String.Empty)
                    && cmbResolution.SelectedItem.ToString().Contains("x"))
                {
                    String[] resolution = cmbResolution.SelectedItem.ToString().Split(new char[] { 'x' });
                    if (resolution.Length == 2)
                    {
                        width = Convert.ToInt32(resolution[0]);
                        height = Convert.ToInt32(resolution[1]);
                    }
                }
            }
            catch
            {
                width = 800;
                height = 600;
            }

            if (width == 0 || height == 0)
            {
                MessageBox.Show("Error", "Error getting selected resolution!",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            Boolean unitActionLines = chkUnitActionLines.Checked;
            Boolean tooltips = chkToolTips.Checked;
            Boolean musicRepeat = chkRepeat.Checked;
            Boolean musicShuffle = chkShuffle.Checked;
            Boolean videoWindowed = chkWindowed.Checked;
            Boolean Backbuffer = chkBackbuffer.Checked;
            Boolean CD = chkCD.Checked;
            Boolean procAffinity = chkProcAffinity.Checked;
            Boolean Intro = chkIntro.Checked;
            Double musicVolume = Convert.ToDouble(trbScoreVolume.Value) / 20.0;
            Double voiceVolume = Convert.ToDouble(trbVoiceVolume.Value) / 20.0;
            Double soundVolume = Convert.ToDouble(trbSoundVolume.Value) / 20.0;

            bool _GP_TSDDraw = GP_TSDDrawRadioButton.Checked;
            bool _GP_IEddraw = GP_IEddrawRadioButton.Checked;
            bool _GP_ddwrapper = GP_ddwrapperRadioButton.Checked;
            bool _GP_NoVideoMemory = GP_NoVideoMemoryCheckBox.Checked;
            bool _GP_FakeVsync = GP_FakeVsyncCheckBox.Checked;

            return DomainController.Instance().saveSettings(width, height, unitActionLines, tooltips, videoWindowed, Backbuffer, Intro, CD, musicRepeat, musicShuffle, musicVolume, voiceVolume, soundVolume, _GP_IEddraw, _GP_ddwrapper, _GP_NoVideoMemory, _GP_FakeVsync, _GP_TSDDraw, procAffinity);
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

        private void trbVoiceVolume_ValueChanged(object sender, EventArgs e)
        {
            lblVoiceVolumeValue.Text = trbVoiceVolume.Value * 5 + "%";
        }

        private void trbSoundVolume_ValueChanged(object sender, EventArgs e)
        {
            lblSoundVolumeValue.Text = trbSoundVolume.Value * 5 + "%";
        }

        private void GP_ddwrapperRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            GP_NoVideoMemoryCheckBox.Enabled = (GP_FakeVsyncCheckBox.Enabled = GP_ddwrapperRadioButton.Checked);
        }

        private void lblWindowed_Click(object sender, EventArgs e)
        {
            chkWindowed.Checked = !chkWindowed.Checked;
            chkWindowed.Select();
        }

        private void GP_DisabledLabel_Click(object sender, EventArgs e)
        {
            GP_DisabledRadioButton.Select();
        }

        private void GP_TSDDrawLabel_Click(object sender, EventArgs e)
        {
            GP_TSDDrawRadioButton.Select();
        }

        private void GP_IEddrawLabel_Click(object sender, EventArgs e)
        {
            GP_IEddrawRadioButton.Select();
        }

        private void GP_ddwrapperLabel_Click(object sender, EventArgs e)
        {
            GP_ddwrapperRadioButton.Select();
        }

        private void GP_NoVideoMemoryLabel_Click(object sender, EventArgs e)
        {
            if (GP_ddwrapperRadioButton.Checked)
                GP_NoVideoMemoryCheckBox.Checked = !GP_NoVideoMemoryCheckBox.Checked;
            GP_NoVideoMemoryCheckBox.Select();
        }

        private void GP_FakeVsyncLabel_Click(object sender, EventArgs e)
        {
            if (GP_ddwrapperRadioButton.Checked)
                GP_FakeVsyncCheckBox.Checked = !GP_FakeVsyncCheckBox.Checked;
            GP_FakeVsyncCheckBox.Select();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



    }
}
