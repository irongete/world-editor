using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace World_Editor.ClassesEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static ClassesEditor.MainForm m_classesEditor;
        public static ClassesEditor.MainForm GetChildInstance()
        {
            if (m_classesEditor == null)
                m_classesEditor = new MainForm();

            return m_classesEditor;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_classesEditor = null;
        }
    }
}
