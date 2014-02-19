using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace World_Editor.MapsEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static MapsEditor.MainForm m_mapsEditor;
        public static MapsEditor.MainForm GetChildInstance()
        {
            if (m_mapsEditor == null)
                m_mapsEditor = new MainForm();

            return m_mapsEditor;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_mapsEditor = null;
        }


    }
}
