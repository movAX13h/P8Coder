using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace P8Coder.Core
{
    public class Function
    {
        public bool Enabled = true;
        public string Name;
        public string Code;

        public Function(string name, string code)
        {
            Name = name;
            Code = code;
        }

        public override string ToString()
        {
            return Name;
        }

        public XElement ToXElement()
        {
            return new XElement("function", 
                new XAttribute("name", Name == null ? "unnamed" : Name),
                new XAttribute("enabled", Enabled ? 1 : 0),
                Code);
        }

        public bool FromXElement(XElement xfunc)
        {
            Name = (string)xfunc.Attribute("name");
            Enabled = (int)xfunc.Attribute("enabled") == 1;
            Code = (string)xfunc;
            return true;
        }
    }
}
