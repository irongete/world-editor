using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace World_Editor.Model
{
    public class ProjectModel
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string WowDir { get; set; }
        public bool IsLast { get; set; }
        public string Host { get; set; }
        public string Database { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public int Core { get; set; }

        public override string ToString()
        {
            return Name + " - " + Path;
        }

    }
}
