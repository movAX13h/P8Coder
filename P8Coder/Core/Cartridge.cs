using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace P8Coder.Core
{
    public class Cartridge
    {
        private string rawText = "";
        public string Filename { get; private set; }

        public int Version { get; private set; }
        public string Lua { get; private set; }
        public string Gfx { get; private set; }
        public string Gff { get; private set; }
        public string Map { get; private set; }
        public string Sfx { get; private set; }
        public string Music { get; private set; }

        public Bitmap MapSheet { get; private set; }
        public Bitmap SpriteSheet { get; private set; }
        public Bitmap[] Sprites { get; private set; }

        private DateTime lastChange;
        private Timer changePollTimer;

        private Action<Cartridge> onChangeCallback = null;
        public Action<Cartridge> OnChangeCallback 
        {
            set 
            { 
                onChangeCallback = value;
                changePollTimer.Stop();
                changePollTimer.Start();
            }
        }

        public Cartridge(string filename)
        {
            Filename = filename;

            // watch file changes (started when callback action is set)
            changePollTimer = new Timer();
            changePollTimer.Interval = 2000;
            changePollTimer.Tick += changePollTimer_Tick;
        }

        private void changePollTimer_Tick(object sender, EventArgs e)
        {
            if (File.Exists(Filename) && File.GetLastWriteTime(Filename) != lastChange)
            {
                if (onChangeCallback != null) onChangeCallback(this);
            }
        }

        public void Load()
        {
            if (String.IsNullOrWhiteSpace(Filename)) throw new Exception("No filename set!");
            if (!File.Exists(Filename)) throw new Exception("File does not exist: " + Filename);

            lastChange = File.GetLastWriteTime(Filename);

            setupFromText(File.ReadAllText(Filename));
        }

        private void setupFromText(string text)
        {
            rawText = text.Replace("\r", "");

            string[] lines = rawText.Trim().Split('\n');

            if (!readHeader(lines[0].Trim())) throw new Exception("Invalid file format! (1)");
            if (!readVersion(lines[1].Trim())) throw new Exception("Invalid file format! (2)");

            Gfx = "".PadRight(128 * 128, '0');
            Map = "".PadRight(128 * 32, '0');

            string[] sections = Regex.Split(rawText, "__(lua|gfx|gff|map|sfx|music)__");

            for(int i = 1; i < sections.Length; i += 2)
            {
                switch(sections[i])
                {
                    case "lua":
                        Lua = sections[i + 1].Trim();
                        break;

                    case "gfx":
                        Gfx = sections[i + 1].Replace("\n", "").Trim().PadRight(128*128, '0');                        
                        break;

                    case "gff":
                        break;

                    case "map":
                        Map = sections[i + 1].Replace("\n", "").Trim().PadRight(128*32, '0');
                        break;

                    case "sfx":
                        break;

                    case "music":
                        break;

                    default:
                        break;
                }
            }

            createSprites();
            createMapSprite();
        }

        private void createSprites()
        {
            if (SpriteSheet == null)
            {
                SpriteSheet = new Bitmap(128, 128, PixelFormat.Format8bppIndexed);
                applyPicoPalette(SpriteSheet);
            }

            var data = SpriteSheet.LockBits(new Rectangle(0, 0, SpriteSheet.Width, SpriteSheet.Height), ImageLockMode.WriteOnly, PixelFormat.Format8bppIndexed);

            var bytes = new byte[data.Height * data.Stride];
            Marshal.Copy(data.Scan0, bytes, 0, bytes.Length);

            for (int y = 0; y < 128; y++)
            {
                for (int x = 0; x < 128; x++)
                {
                    int id = x + y * data.Stride;
                    bytes[id] = Convert.ToByte(Gfx.Substring(id, 1), 16);
                }
            }
            Marshal.Copy(bytes, 0, data.Scan0, bytes.Length);

            SpriteSheet.UnlockBits(data);

            Sprites = new Bitmap[256];
            int i = 0;
            for (int y = 0; y < 16; y++)
            {
                for (int x = 0; x < 16; x++)
                {
                    Bitmap sprite = new Bitmap(8, 8);
                    var g = Graphics.FromImage(sprite);
                    g.DrawImage(SpriteSheet, new Rectangle(0, 0, 8, 8), new Rectangle(x * 8, y * 8, 8, 8), GraphicsUnit.Pixel);

                    Sprites[i] = sprite;
                    g.Dispose();
                    i++;
                }
            }
        }

        private void createMapSprite()
        {
            MapSheet = new Bitmap(128 * 8, 64 * 8);

            // pico-8 shares the lower half of gfx with map
            string ids = Map + Gfx.Substring(128 * 64); 
            int num = ids.Length / 2;

            var g = Graphics.FromImage(MapSheet);
            g.Clear(Color.Black);

            for (int i = 0; i < num; i++)
            {
                int x = 8 * (i % 128);
                int y = 8 * (i / 128);

                int id = 0;

                // the second half seems to have bytes reversed
                id = Convert.ToInt32(y >= 32 * 8 ? ids.Substring(i * 2 + 1, 1) + ids.Substring(i * 2, 1) : ids.Substring(i * 2, 2), 16);
                
                if (id == 0) g.FillRectangle(Brushes.Black, x,y, 8,8);
                else g.DrawImage(Sprites[id], x, y);
            }
            g.Dispose();
        }

        public void Dispose()
        {
            changePollTimer.Stop();
            SpriteSheet.Dispose();
            MapSheet.Dispose();
        }

        #region private helpers
        private void applyPicoPalette(Bitmap img)
        {
            var pal = img.Palette;
            for (int i = 0; i < pal.Entries.Length; i++)
            {
                pal.Entries[i] = i < 16 ? Device.Palette[i] : Color.Black;
            }

            img.Palette = pal;
        }

        private bool readHeader(string text)
        {
            return text == "pico-8 cartridge // http://www.pico-8.com";
        }

        private bool readVersion(string text)
        {
            //NOTE: version number changes with every release of pico-8 even if no change was made to the file format
            //      This means that we have no simple check to see if the file is compatible.

            string[] parts = text.Split(' ');
            if (parts.Length != 2) return false;

            int v = 0;
            if (!int.TryParse(parts[1], out v)) return false;
            Version = v;
            return true;
        }
        #endregion
    }
}
