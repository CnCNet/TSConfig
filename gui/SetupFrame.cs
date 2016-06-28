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
            List<String> resolutions;
            String resolution = DomainController.Instance().getCurrentGameRes();
            try
            {
                resolutions = screenres.ScreenResolutionOperations.getScreenResolutions(640, 400, 16);
            }
            catch (System.EntryPointNotFoundException)
            {
                MessageBox.Show("Unable to detect your monitor's display modes");
                resolutions = new List<String>() {resolution};
            }
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
            chkUseIntegrateMumble.Checked = DomainController.Instance().getIntegrateMumble();

            GP_ddwrapperRadioButton.Checked = DomainController.Instance().getDDwrapperStatus();

            if (!GP_ddwrapperRadioButton.Checked && !GP_IEddrawRadioButton.Checked && !GP_DxWndRadioButton.Checked)
                GP_TSDDrawRadioButton.Checked = DomainController.Instance().getTSDDrawStatus();

            if (!GP_ddwrapperRadioButton.Checked && !GP_TSDDrawRadioButton.Checked && !GP_DxWndRadioButton.Checked)
                chkWindowed.Enabled = true;
                GP_IEddrawRadioButton.Checked = DomainController.Instance().getIEDDrawStatus();

            if (!GP_ddwrapperRadioButton.Checked && !GP_TSDDrawRadioButton.Checked && !GP_IEddrawRadioButton.Checked)
                GP_DxWndRadioButton.Checked = DomainController.Instance().getDxWndStatus();

           /* if (chkWindowed.Checked && !GP_TSDDrawRadioButton.Checked)
                MessageBox.Show("If TS-DDraw is not enabled then Windowed mode requires 16-bit color depth on your desktop", "Windowed mode info", MessageBoxButtons.OK, MessageBoxIcon.Information); */

            GP_DisabledRadioButton.Checked = !GP_ddwrapperRadioButton.Checked && !GP_IEddrawRadioButton.Checked && !GP_TSDDrawRadioButton.Checked && !GP_DxWndRadioButton.Checked;

            if (GP_DisabledRadioButton.Checked)
                chkWindowed.Enabled = true;

            GP_NoVideoMemoryCheckBox.Checked = DomainController.Instance().getNoVideoMemory();
            GP_FakeVsyncCheckBox.Checked = DomainController.Instance().getFakeVsync();
            DirectDrawEmulationCheckBox.Checked = DomainController.Instance().getDirectDrawEmulation();
            GP_DxWndWindowBordersCheckBox.Checked = DomainController.Instance().getDxWndWindowFrame();
            GP_DxWndWindowedCheckBox.Checked = DomainController.Instance().getDxWndWindow();
            DxDirectDrawEmulationCheckBox.Checked = DomainController.Instance().getDxDirectDrawEmulation();
            DxEmulationComboBox.SelectedIndex = DomainController.Instance().getDxEmulationType();

            if (GP_DxWndRadioButton.Checked)
                GP_DxWndRadioButton.Checked = DomainController.Instance().getDxWndEnabled();

            if (GP_DxWndRadioButton.Checked)
            {
                chkWindowed.Enabled = false;
                chkWindowed.Checked = false;
            }

            if (GP_TSDDrawRadioButton.Checked)
            {
                chkWindowed.Enabled = false;
                chkWindowed.Checked = false;
            }

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
            int dragDistance = trbDragDistance.Value;
            Boolean OverrideColors = chkUseCustomColors.Checked;
            Boolean OnlyRightClickDeselect = chkUseOnlyRightClickDeselect.Checked;
            Boolean DisableAltTab = chkUseDisableAltTab.Checked;
            Boolean DisableEdgeScrolling = chkUseDisableEdgeScrolling.Checked;
            Boolean IntegrateMumble = chkUseIntegrateMumble.Checked;

            bool _GP_TSDDraw = GP_TSDDrawRadioButton.Checked;
            bool _GP_IEddraw = GP_IEddrawRadioButton.Checked;
            bool _GP_ddwrapper = GP_ddwrapperRadioButton.Checked;
            bool _GP_NoVideoMemory = GP_NoVideoMemoryCheckBox.Checked;
            bool _GP_FakeVsync = GP_FakeVsyncCheckBox.Checked;
            bool ddEmulation = DirectDrawEmulationCheckBox.Checked;
            bool _GP_DxWndEnabled = GP_DxWndRadioButton.Checked;
            bool _GP_dxwnd = GP_DxWndRadioButton.Checked;
            bool _GP_DxWndWindow = GP_DxWndWindowedCheckBox.Checked;
            bool _GP_DxWndWindowFrame = GP_DxWndWindowBordersCheckBox.Checked;
            bool dxDDEmulation = DxDirectDrawEmulationCheckBox.Checked;
            int dxEmulationType = DxEmulationComboBox.SelectedIndex;

            return DomainController.Instance().saveSettings(
                width,
                height,
                unitActionLines,
                tooltips,
                videoWindowed,
                Backbuffer,
                Intro,
                CD,
                musicRepeat,
                musicShuffle,
                musicVolume,
                voiceVolume,
                soundVolume,
                dragDistance,
                _GP_IEddraw,
                _GP_ddwrapper,
                _GP_NoVideoMemory,
                _GP_FakeVsync,
                ddEmulation,
                dxEmulationType,
                _GP_TSDDraw,
                _GP_dxwnd,
                _GP_DxWndEnabled,
                _GP_DxWndWindow,
                _GP_DxWndWindowFrame,
                dxDDEmulation,
                procAffinity,
                ColorOverrides,
                OverrideColors,
                OnlyRightClickDeselect,
                DisableAltTab,
                DisableEdgeScrolling,
                IntegrateMumble,
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

        private void GP_ddwrapperRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DirectDrawEmulationCheckBox.Enabled = GP_NoVideoMemoryCheckBox.Enabled = GP_FakeVsyncCheckBox.Enabled = GP_ddwrapperRadioButton.Checked;
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

        private void GP_DxWndLabel_Click(object sender, EventArgs e)
        {
            GP_DxWndRadioButton.Select();
        }

        private void GP_DxWndRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DxEmulationComboBox.Enabled = DxDirectDrawEmulationCheckBox.Enabled = GP_DxWndWindowedCheckBox.Enabled = GP_DxWndWindowBordersCheckBox.Enabled = GP_DxWndRadioButton.Checked;
            
            chkWindowed.Enabled = !GP_DxWndRadioButton.Checked;
            if (GP_DxWndRadioButton.Checked)
                chkWindowed.Checked = false;
        }


        private void GP_TSDDrawRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            chkWindowed.Enabled = !GP_TSDDrawRadioButton.Checked;
            if (GP_TSDDrawRadioButton.Checked)
                chkWindowed.Checked = false;
        }

        private void GP_DxWndWinowedLabel_Click(object sender, EventArgs e)
        {
            if (GP_DxWndRadioButton.Checked)
                GP_DxWndWindowedCheckBox.Checked = !GP_DxWndWindowedCheckBox.Checked;
            GP_DxWndWindowedCheckBox.Select();
        }

        private void GP_DxWndWindowBordersLabel_Click(object sender, EventArgs e)
        {
            if (GP_DxWndRadioButton.Checked)
                GP_DxWndWindowBordersCheckBox.Checked = !GP_DxWndWindowBordersCheckBox.Checked;
            GP_DxWndWindowBordersCheckBox.Select();
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
