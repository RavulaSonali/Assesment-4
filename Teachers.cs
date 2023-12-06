using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_4
{
    public class Teachers
    {
        string name, section;
        public string Name { get { return name; } set { name = value; } }
        public string Section { get { return section; } set { section = value; } }
        public Teachers(string name, string section)
        {
            this.Name = name;
            this.Section = section;
        }
    }
}

