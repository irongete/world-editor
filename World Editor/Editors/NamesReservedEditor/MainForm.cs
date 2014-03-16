﻿using DBCLib.Structures335;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using World_Editor.DBC;

namespace World_Editor.NamesReservedEditor
{
    public partial class MainForm : Form
    {
        ResourceManager Loc = new ResourceManager("World_Editor.Editors.NamesReservedEditor.NamesReservedEditorLocal", System.Reflection.Assembly.GetExecutingAssembly());
        public MainForm()
        {
            InitializeComponent();
        }

        public static NamesReservedEditor.MainForm m_namesReservedEditor;
        public static NamesReservedEditor.MainForm GetChildInstance()
        {
            if (m_namesReservedEditor == null)
                m_namesReservedEditor = new MainForm();

            return m_namesReservedEditor;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                DBCStores.LoadNamesReservedFiles();
            }
            catch (Exception)
            {
                MessageBox.Show(Loc.GetString("LoadDbcError"));
                this.Close();
            }

            foreach (NamesReservedEntry entry in DBC.DBCStores.NamesReserved.Records)
            {
                lstNamesReserved.Items.Add(entry);
            }
            lstNamesReserved.Sorted = true;

            lstNamesReserved.SelectedIndex = lstNamesReserved.Items.Count - 1;
        }
    }
}
