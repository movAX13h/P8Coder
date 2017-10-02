namespace P8Coder.Utils
{
    public class UserSettings : IniFile
    {
        public string Pico8exe;

        public bool Fullscreen = false;
        public bool Borderless = false;
        public bool PixelPerfect = true;
        public bool ShowFPS = false;
        public bool DarkEditor = false;

        public int Width = 512;
        public int Height = 512;

        public int SoundVolume = 256;
        public int MusicVolume = 256;

        public int Joystick = 0;

        public int ScreenshotScale = 3;
        public int GIFScale = 2;
        public int GIFDuration = 15;

        public UserSettings()
        {
            Pico8exe = Read("pico8");

            if (ReadNumber("Width") == 0) // upgrade from v1.0 to 1.1
            {
                Save(); // initial default values
                return;
            }

            Fullscreen = ReadNumber("Fullscreen") == 1;
            Borderless = ReadNumber("Borderless") == 1;
            PixelPerfect = ReadNumber("PixelPerfect") == 1;
            ShowFPS = ReadNumber("ShowFPS") == 1;
            DarkEditor = ReadNumber("DarkEditor") == 1;

            Width = ReadNumber("Width");
            Height = ReadNumber("Height");

            SoundVolume = ReadNumber("SoundVolume");
            MusicVolume = ReadNumber("MusicVolume");

            Joystick = ReadNumber("Joystick");

            ScreenshotScale = ReadNumber("ScreenshotScale");
            GIFScale = ReadNumber("GIFScale");
            GIFDuration = ReadNumber("GIFDuration");
        }

        public void Save()
        {
            Write("pico8", Pico8exe);

            Write("Fullscreen", Fullscreen ? 1 : 0);
            Write("Borderless", Borderless ? 1 : 0);
            Write("PixelPerfect", PixelPerfect ? 1 : 0);
            Write("ShowFPS", ShowFPS ? 1 : 0);
            Write("DarkEditor", DarkEditor ? 1 : 0);

            Write("Width", Width);
            Write("Height", Height);

            Write("SoundVolume", SoundVolume);
            Write("MusicVolume", MusicVolume);

            Write("Joystick", Joystick);

            Write("ScreenshotScale", ScreenshotScale);
            Write("GIFScale", GIFScale);
            Write("GIFDuration", GIFDuration);
        }

    }
}
