using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace P8Coder.Utils
{
    public class IniFile
    {
        private string path;
        private string defaultSection = "settings";

        [DllImport("kernel32")]
        static extern long WritePrivateProfileString(string section, string key, string value, string filePath);

        [DllImport("kernel32")]
        static extern int GetPrivateProfileString(string section, string key, string defaultVal, StringBuilder retVal, int size, string filePath);

        public IniFile()
        {
            string exe = Assembly.GetExecutingAssembly().GetName().Name;
            path = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "/" + exe + ".ini";
        }

        public string Read(string key, string section = null)
        {
            var retVal = new StringBuilder(255);
            GetPrivateProfileString(section ?? defaultSection, key, "", retVal, 255, path);
            return retVal.ToString();
        }

        public int ReadNumber(string key, string section = null)
        {
            int value = 0;
            int.TryParse(Read(key, section), out value);
            return value;
        }

        public void Write(string key, string value, string section = null)
        {
            WritePrivateProfileString(section ?? defaultSection, key, value, path);
        }

        public void Write(string key, int value, string section = null)
        {
            WritePrivateProfileString(section ?? defaultSection, key, value.ToString(), path);
        }

        public void DeleteKey(string key, string section = null)
        {
            Write(key, null, section ?? defaultSection);
        }

        public void DeleteSection(string section = null)
        {
            Write(null, null, section ?? defaultSection);
        }

        public bool KeyExists(string key, string section = null)
        {
            return Read(key, section).Length > 0;
        }
    }
}
