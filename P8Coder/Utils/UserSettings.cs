using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace P8Coder.Utils
{
    public class UserSettings : IniFile
    {
        public string Pico8exe;

        public UserSettings()
        {
            Pico8exe = Read("pico8", "settings");
        }

        public void Save()
        {
            Write("pico8", Pico8exe, "settings");
        }

    }
}
