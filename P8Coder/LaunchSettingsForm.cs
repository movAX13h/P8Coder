using System;
using System.Windows.Forms;
using P8Coder.Utils;

namespace P8Coder
{
    public partial class LaunchSettingsForm : Form
    {
        private UserSettings settings;

        public LaunchSettingsForm(UserSettings settings)
        {
            InitializeComponent();
            this.settings = settings;

            soundSlider.ValueChanged += SoundSliderValueChanged;
            musicSlider.ValueChanged += MusicSliderValueChanged;
            fillForm();
        }

        private void SoundSliderValueChanged(object sender, EventArgs e)
        {
            int percent = (int)Math.Round(100f * soundSlider.Value / 256f);
            soundLabel.Text = "sound: " + percent.ToString() + "%";
        }

        private void MusicSliderValueChanged(object sender, EventArgs e)
        {
            int percent = (int)Math.Round(100f * musicSlider.Value / 256f);
            musicLabel.Text = "music: " + percent.ToString() + "%";
        }

        private void fillForm()
        {
            fullscreenCheckbox.Checked = settings.Fullscreen;
            borderlessCheckbox.Checked = settings.Borderless;
            pixelPerfectCheckbox.Checked = settings.PixelPerfect;
            showFpsCheckbox.Checked = settings.ShowFPS;
            darkEditorCheckbox.Checked = settings.DarkEditor;

            widthInput.Value = settings.Width;
            heightInput.Value = settings.Height;

            soundSlider.Value = settings.SoundVolume;
            musicSlider.Value = settings.MusicVolume;

            joystickInput.Value = settings.Joystick;

            screenshotScaleInput.Value = settings.ScreenshotScale;
            gifScaleInput.Value = settings.GIFScale;
            gifDurationInput.Value = settings.GIFDuration;
        }

        private void storeSettings()
        {
            settings.Fullscreen = fullscreenCheckbox.Checked;
            settings.Borderless = borderlessCheckbox.Checked;
            settings.PixelPerfect = pixelPerfectCheckbox.Checked;
            settings.ShowFPS = showFpsCheckbox.Checked;
            settings.DarkEditor = darkEditorCheckbox.Checked;

            settings.Width = (int)widthInput.Value;
            settings.Height = (int)heightInput.Value;

            settings.SoundVolume = soundSlider.Value;
            settings.MusicVolume = musicSlider.Value;

            settings.Joystick = (int)joystickInput.Value;

            settings.ScreenshotScale = (int)screenshotScaleInput.Value;
            settings.GIFScale = (int)gifScaleInput.Value;
            settings.GIFDuration = (int)gifDurationInput.Value;

            settings.Save();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            storeSettings();
            Close();
        }
    }
}
