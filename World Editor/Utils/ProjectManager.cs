using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using World_Editor.Database;
using World_Editor.Model;

namespace World_Editor
{
    public static class ProjectManager
    {
        private static ProjectModel _projectModel;

        public static ProjectModel SelectedProject
        {
            get { return _projectModel; }
            set { _projectModel = value; }
        }
    }
}
