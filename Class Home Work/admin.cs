using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Home_Work
{
    internal class admin
    {
        public bool IsSuperAdmin;
        public string Section;

        public admin(bool issuperAdmin, string section)
        {
            IsSuperAdmin = issuperAdmin;
            Section = section;

        }

        public string Return()
        {
            return $"{IsSuperAdmin} , {Section}";
        }
    }
}
