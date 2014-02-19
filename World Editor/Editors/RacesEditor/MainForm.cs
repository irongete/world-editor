using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace World_Editor.RacesEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static RacesEditor.MainForm m_racesEditor;
        public static RacesEditor.MainForm GetChildInstance()
        {
            if (m_racesEditor == null)
                m_racesEditor = new MainForm();

            return m_racesEditor;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_racesEditor = null;
        }


    }
}
