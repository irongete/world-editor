using DBCLib.Structures335;
using MDS.cBlp2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using World_Editor.DBC;
using World_Editor.Stormlib;

namespace World_Editor.Editors.ProfessionEditor
{
    public partial class Icons : Form
    {
        public static int IconIdSelected { get; set; }
        private Graphics g;
        private Point iconSelect = new Point(0, 0);
        public static Icons m_professionIconsEditor;

        public Icons()
        {
            InitializeComponent();
            this.g = panelIcons.CreateGraphics();
        }

        private void Icons_Load(object sender, EventArgs e)
        {
            txtIconId.Text = "0";
        }

        private void panelIcons_Paint(object sender, PaintEventArgs e)
        {
            foreach (SpellIconEntry sie in DBCStores.SpellIcon.Records)
            {
                Bitmap _bitmapTemp = new Bitmap(panelIcons.Width, panelIcons.Height);
                using (Graphics g = Graphics.FromImage(_bitmapTemp))
                {
                    g.FillRectangle(new SolidBrush(SystemColors.Control), new System.Drawing.Rectangle(0, 0, 256, 256));
                    Bitmap icons = Blp2.FromStream(new MPQFile(sie.IconPath + ".blp"));
                    Console.WriteLine(sie.IconPath);
                    g.DrawImage(icons, 0, 0);
                    g.DrawImage(World_Editor.Properties.Resources.select_square_18_18, new Rectangle(18 * iconSelect.X, 18 * iconSelect.Y, 18, 18), new Rectangle(0, 0, 18, 18), GraphicsUnit.Pixel);
                }
                this.g.DrawImage(_bitmapTemp, 0, 0);
                _bitmapTemp.Dispose();
                _bitmapTemp = null;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool MouseIsDown = false;

        private void panelIcons_MouseDown(object sender, MouseEventArgs e)
        {
            MouseIsDown = true;
        }

        private void panelIcons_MouseUp(object sender, MouseEventArgs e)
        {
            MouseIsDown = false;
            for (int y = 0; y <= 13; ++y)
            {
                for (int x = 0; x <= 13; ++x)
                {
                    Rectangle rectIcon = new Rectangle(x * 18, y * 18, 18, 18);
                    if (rectIcon.Contains(e.Location))
                    {
                        txtIconId.Text = (x + 14 * y).ToString();
                        IconIdSelected = x + 14 * y;
                        iconSelect = new Point(x, y);

                        panelIcons_Paint(null, null);
                        return;
                    }
                }
            }
        }

        private void panelIcons_MouseMove(object sender, MouseEventArgs e)
        {
            if (!MouseIsDown)
                return;

            for (int y = 0; y <= 13; ++y)
            {
                for (int x = 0; x <= 13; ++x)
                {
                    Rectangle rectIcon = new Rectangle(x * 18, y * 18, 18, 18);
                    if (rectIcon.Contains(e.Location))
                    {
                        txtIconId.Text = (x + 14 * y).ToString();
                        iconSelect = new Point(x, y);
                        IconIdSelected = x + 14 * y;

                        panelIcons_Paint(null, null);
                        return;
                    }
                }
            }
        }
    }
}
