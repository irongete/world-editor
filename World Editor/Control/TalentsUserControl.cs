#region

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Windows.Forms;
using AntiBrouillard;
using DBCLib.Structures335;
using MDS.cBlp2;
using World_Editor.DBC;

#endregion

namespace World_Editor.Control
{
    public partial class TalentsUserControl : UserControl
    {
        private const int MAX_ROW = 11;
        private const int MAX_COLUMN = 4;

        private readonly Dictionary<string, Bitmap> _icons = new Dictionary<string, Bitmap>();
        private readonly Dictionary<string, Bitmap> _images = new Dictionary<string, Bitmap>();
        private Graphics _graphics;
        private List<TalentEntry> _listTalents = new List<TalentEntry>();
        private TalentEntry _selectedTalent;
        private TalentEntry _talentMouseDown;
        private TalentTabEntry _talentTab;

        public event TalentUserControlEventHandler TalentSelectedEvent;
        public event TalentUserControlEventHandler TalentAddedEvent;
        public event TalentUserControlEventHandler TalentDeletedEvent;
        public event TalentUserControlEventHandler ControlPaintTime;

        public TalentsUserControl()
        {
            InitializeComponent();
            if (!DesignMode)
            {
                InitializeImages();
            }
        }

        public void SetTalents(List<TalentEntry> talents, TalentTabEntry talentTab)
        {
            _listTalents = talents;
            RefreshSpellIcons(talents);
            _talentTab = talentTab;
            RefreshTalentBackground();

            panelIn.Refresh();
        }

        public void SelectTalent(TalentEntry talent)
        {
            _selectedTalent = _listTalents.Find(t => t.Id == talent.Id);
        }

        private void RefreshTalentBackground()
        {
            if (_images.ContainsKey("TalentBack"))
            {
                _images.Remove("TalentBack");
            }

            try
            {
                if (Stormlib.MPQFile.Exists("Interface\\TALENTFRAME\\" + _talentTab.InternalName + "-BottomLeft.blp") &&
                    Stormlib.MPQFile.Exists("Interface\\TALENTFRAME\\" + _talentTab.InternalName + "-BottomRight.blp") &&
                    Stormlib.MPQFile.Exists("Interface\\TALENTFRAME\\" + _talentTab.InternalName + "-TopLeft.blp") &&
                    Stormlib.MPQFile.Exists("Interface\\TALENTFRAME\\" + _talentTab.InternalName + "-TopRight.blp"))
                {
                    Blp2 talentBackBL = Blp2.FromStream(new Stormlib.MPQFile("Interface\\TALENTFRAME\\" + _talentTab.InternalName + "-BottomLeft.blp"));
                    Blp2 talentBackBR = Blp2.FromStream(new Stormlib.MPQFile("Interface\\TALENTFRAME\\" + _talentTab.InternalName + "-BottomRight.blp"));
                    Blp2 talentBackTL = Blp2.FromStream(new Stormlib.MPQFile("Interface\\TALENTFRAME\\" + _talentTab.InternalName + "-TopLeft.blp"));
                    Blp2 talentBackTR = Blp2.FromStream(new Stormlib.MPQFile("Interface\\TALENTFRAME\\" + _talentTab.InternalName + "-TopRight.blp"));

                    Bitmap backTalent = new Bitmap(320, 384);
                    using (Graphics gfx = Graphics.FromImage(backTalent))
                    {
                        gfx.DrawImageUnscaled(talentBackTL, 0, 0);
                        gfx.DrawImageUnscaled(talentBackTR, talentBackTL.Width, 0);
                        gfx.DrawImageUnscaled(talentBackBL, 0, talentBackTL.Height);
                        gfx.DrawImageUnscaled(talentBackBR, talentBackBL.Width, talentBackTL.Height);
                    }
                    _images.Add("TalentBack", backTalent);
                }
                else
                {
                    _images.Add("TalentBack", Blp2.FromFile("Ressources\\DefaultTalentBack.blp"));
                }

            }
            catch (Exception e)
            {
                Log.E(e);
                _images.Add("TalentBack", Blp2.FromFile("Ressources\\DefaultTalentBack.blp"));
            }
        }

        private void RefreshSpellIcons(IEnumerable<TalentEntry> talents)
        {
            _icons.Clear();
            foreach (TalentEntry t in talents)
            {
                UpdateTalentIcon(t);
            }
        }

        private void UpdateTalentIcon(TalentEntry t)
        {
            if (DBCStores.Spell.ContainsKey(t.RankId[0]) &&
                DBCStores.SpellIcon.ContainsKey(DBCStores.Spell[t.RankId[0]].SpellIconID) &&
                Stormlib.MPQFile.Exists(DBCStores.SpellIcon[DBCStores.Spell[t.RankId[0]].SpellIconID].IconPath +
                                        ".blp") &&
                !_icons.ContainsKey("SpellIcon." + t.Row + "." + t.Col))
            {
                Blp2 blpFile = Blp2.FromStream(new Stormlib.MPQFile(DBCStores.SpellIcon[DBCStores.Spell[t.RankId[0]].SpellIconID].IconPath + ".blp"));
                _icons.Add("SpellIcon." + t.Row + "." + t.Col, ResizeBitmap(blpFile, 40, 40));
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _graphics = panelIn.CreateGraphics();
            talentTabScroll.Maximum = panelIn.Height - panelOut.Height;
        }

        private void InitializeImages()
        {
            Blp2 blpFile = Blp2.FromFile("Ressources\\UI-TalentArrows.blp");
            _images.Add("TalentArrowsBottom", CropBitmap(blpFile, new Rectangle(0, 0, 32, 32)));
            _images.Add("TalentArrowsRight", CropBitmap(blpFile, new Rectangle(32, 0, 32, 32)));
            _images.Add("TalentArrowsLeft", RotateBitmap(CropBitmap(blpFile, new Rectangle(32, 0, 32, 32)), 180.0f));

            _images.Add("TalentRankBorder", Blp2.FromFile("Ressources\\TalentFrame-RankBorder.blp"));

            _images.Add("TalentIdBorder", Blp2.FromFile("Ressources\\TalentFrame-IdBorder.blp"));

            blpFile = Blp2.FromFile("Ressources\\UI-TalentBranches.blp");
            _images.Add("TalentBarH", CropBitmap(blpFile, new Rectangle(32, 0, 32, 32)));
            _images.Add("TalentBarHLittle", CropBitmap(blpFile, new Rectangle(32, 0, 32, 20)));
            _images.Add("TalentBarV", CropBitmap(blpFile, new Rectangle(64, 0, 32, 32)));
            _images.Add("TalentBarVLittle", CropBitmap(blpFile, new Rectangle(64, 0, 28, 32)));

            Bitmap bTmp = CropBitmap(blpFile, new Rectangle(128, 0, 32, 32));
            bTmp.RotateFlip(RotateFlipType.RotateNoneFlipX);
            _images.Add("TalentBarCR", bTmp);

            _images.Add("TalentBarCL", CropBitmap(blpFile, new Rectangle(128, 0, 32, 32)));

            _images.Add("SpellIconDefault", ResizeBitmap(Blp2.FromFile("Ressources\\DefaultTalentIcon.blp"), 45, 45));
        }

        private void talentTabScroll_Scroll(object sender, ScrollEventArgs e)
        {
            panelIn.Top = -talentTabScroll.Value;
        }

        private void panelIn_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (TalentEntry t in _listTalents)
            {
                if (IsInTalentEmplacement(e.X, e.Y, t.Row, t.Col))
                {
                    _talentMouseDown = t;
                    break;
                }
            }
        }

        private void panelIn_MouseUp(object sender, MouseEventArgs e)
        {
            for (uint i = 0; i < MAX_COLUMN; ++i)
            {
                for (uint j = 0; j < MAX_ROW; ++j)
                {
                    TalentEntry t = _listTalents.Find(talent => talent.Row == j && talent.Col == i);
                    if (t != null)
                    {
                        if (IsInTalentCrossButton(e.X, e.Y, t.Row, t.Col))
                        {
                            ProcessRemoveTalent(t);
                            return;
                        }

                        if (IsInTalentEmplacement(e.X, e.Y, t.Row, t.Col))
                        {
                            ProcessSelectTalent(t);
                            return;
                        }
                    }
                    else
                    {
                        if (IsInTalentEmplacement(e.X, e.Y, j, i))
                        {
                            if (_talentMouseDown != null)
                            {
                                ProcessMoveSelectedTalentTo(j, i);
                            }
                            else
                            {
                                ProcessAddNewTalent(j, i);
                            }
                            return;
                        }
                    }
                }
            }
        }

        //--------------------
        // DRAW TALENTS
        //--------------------
        private void panelIn_Paint(object sender, PaintEventArgs e)
        {
            if (DesignMode)
                return;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Bitmap bitmapTemp = new Bitmap(panelIn.Width, panelIn.Height);

            using (Graphics g = Graphics.FromImage(bitmapTemp))
            {
                DrawTalentTabBack(g);

                for (int i = _listTalents.Count - 1; i >= 0; i--)
                {
                    TalentEntry t = _listTalents[i];

                    int columnInPixels = 64 * (int)t.Col;
                    int rowInPixels = 60 * (int)t.Row;

                    DrawTalentSpellIcon(t, g, columnInPixels, rowInPixels);
                    DrawTalentRank(g, columnInPixels, rowInPixels, t);

                    if (DBCStores.Talent.ContainsKey(t.ReqTalent[0]))
                        DrawTalentRequiredArrow(t, g, columnInPixels, rowInPixels);

                    DrawTalentId(t, g);
                }
            }

            _graphics.DrawImage(bitmapTemp, 0, 0);
            bitmapTemp.Dispose();
            stopwatch.Stop();
            if (ControlPaintTime != null)
            {
                ControlPaintTime(new TalentUserControlEventArgs(stopwatch.ElapsedMilliseconds));
            }
        }

        private void DrawTalentTabBack(Graphics g)
        {
            g.DrawImageUnscaled(_images["TalentBack"], 0, talentTabScroll.Value);
        }

        private void DrawTalentSpellIcon(TalentEntry t, Graphics g, int columnInPixels, int rowInPixels)
        {
            if (_icons.ContainsKey("SpellIcon." + t.Row + "." + t.Col))
                g.DrawImageUnscaled(_icons["SpellIcon." + t.Row + "." + t.Col], 35 + columnInPixels, 20 + rowInPixels);
            else
                g.DrawImageUnscaled(_images["SpellIconDefault"], 35 + columnInPixels, 20 + rowInPixels);
        }

        private void DrawTalentRank(Graphics g, int columnInPixels, int rowInPixels, TalentEntry t)
        {
            g.DrawImageUnscaled(_images["TalentRankBorder"], 24 + 35 + columnInPixels, 26 + 20 + rowInPixels);
            g.DrawString(TalentRanks(t).ToString(),
                new Font("Arial", 8.0f, FontStyle.Regular, GraphicsUnit.Point), Brushes.White,
                35 + 35 + columnInPixels, 35 + 20 + rowInPixels);
            g.DrawImageUnscaled(_images["TalentRankBorder"], 26 + 35 + columnInPixels, 6 + rowInPixels);
            g.DrawString("X", new Font("Arial", 8.0f, FontStyle.Bold, GraphicsUnit.Point), Brushes.White,
                36 + 35 + columnInPixels, 20 - 5 + rowInPixels);
        }

        private void DrawTalentRequiredArrow(TalentEntry t, Graphics g, int columnInPixels, int rowInPixels)
        {
            TalentEntry reqTalent = DBCStores.Talent[t.ReqTalent[0]];

            long diffRow = (int)reqTalent.Row - t.Row;
            long diffCol = (int)reqTalent.Col - t.Col;

            // Talent 1 case au dessus
            if ((diffRow == -1) && (diffCol == 0))
            {
                g.DrawImageUnscaled(_images["TalentArrowsBottom"], 39 + columnInPixels, 8 + rowInPixels);
                g.DrawImageUnscaled(_images["TalentBarHLittle"], 38 + columnInPixels, 1 + rowInPixels);
            }
            // Talent 1 case à droite
            else if ((diffRow == 0) && (diffCol == 1))
            {
                g.DrawImageUnscaled(_images["TalentArrowsLeft"], 55 + columnInPixels, 24 + rowInPixels);
                g.DrawImageUnscaled(_images["TalentBarVLittle"], 73 + columnInPixels, 25 + rowInPixels);
            }
            // Talent 1 case à gauche
            else if ((diffRow == 0) && (diffCol == -1))
            {
                g.DrawImageUnscaled(_images["TalentArrowsRight"], 23 + columnInPixels, 24 + rowInPixels);
                g.DrawImageUnscaled(_images["TalentBarVLittle"], 8 + columnInPixels, 24 + rowInPixels);
            }
            // Talent 2 cases au dessus
            else if ((diffRow == -2) && (diffCol == 0))
            {
                g.DrawImageUnscaled(_images["TalentArrowsBottom"], 20 - 16 + 35 + columnInPixels,
                    20 - 12 + rowInPixels);
                g.DrawImageUnscaled(_images["TalentBarH"], 20 - 16 - 1 + 35 + columnInPixels,
                    20 - 12 - 18 + rowInPixels);
                g.DrawImageUnscaled(_images["TalentBarH"], 20 - 16 - 1 + 35 + columnInPixels,
                    20 - 12 - 18 - 32 + rowInPixels);
                g.DrawImageUnscaled(_images["TalentBarHLittle"], 20 - 16 - 1 + 35 + columnInPixels,
                    20 - 12 - 4 - 64 + rowInPixels);
            }
            // Talent 1 case en haut à droite
            else if ((diffRow == -1) && (diffCol == 1))
            {
                g.DrawImageUnscaled(_images["TalentArrowsBottom"], 39 + columnInPixels, 8 + rowInPixels);
                g.DrawImageUnscaled(_images["TalentBarH"], 38 + columnInPixels, -10 + rowInPixels);
                g.DrawImageUnscaled(_images["TalentBarCR"], 43 + columnInPixels, -35 + rowInPixels);
                g.DrawImageUnscaled(_images["TalentBarV"], 66 + columnInPixels, -35 + rowInPixels);
            }
            // Talent 1 case en haut à gauche
            else if ((diffRow == -1) && (diffCol == -1))
            {
                g.DrawImageUnscaled(_images["TalentArrowsBottom"], 39 + columnInPixels, 8 + rowInPixels);
                g.DrawImageUnscaled(_images["TalentBarH"], 38 + columnInPixels, -10 + rowInPixels);
                g.DrawImageUnscaled(_images["TalentBarCL"], 35 + columnInPixels, -35 + rowInPixels);
                g.DrawImageUnscaled(_images["TalentBarV"], 10 + columnInPixels, -35 + rowInPixels);
            }
            // Talent 3 cases au dessus
            else if ((diffRow == -3) && (diffCol == 0))
            {
                g.DrawImageUnscaled(_images["TalentArrowsBottom"], 39 + columnInPixels, 8 + rowInPixels);
                g.DrawImageUnscaled(_images["TalentBarH"], 38 + columnInPixels, -10 + rowInPixels);
                g.DrawImageUnscaled(_images["TalentBarH"], 38 + columnInPixels, -42 + rowInPixels);
                g.DrawImageUnscaled(_images["TalentBarH"], 38 + columnInPixels, -74 + rowInPixels);
                g.DrawImageUnscaled(_images["TalentBarH"], 38 + columnInPixels, -106 + rowInPixels);
                g.DrawImageUnscaled(_images["TalentBarHLittle"], 38 + columnInPixels, -120 + rowInPixels);
            }
        }

        private void DrawTalentId(TalentEntry t, Graphics g)
        {
            int columnInPixels = 64 * (int)t.Col;
            int rowInPixels = 60 * (int)t.Row;

            Brush brush = Brushes.White;
            if (_selectedTalent == t)
                brush = Brushes.Gold;

            float x = 43 + columnInPixels;
            float y = 55 + rowInPixels;

            if (t.Id > 999)
                x -= 9;
            else if (t.Id > 99)
                x -= 6;
            else if (t.Id > 9)
                x -= 3;

            g.DrawImageUnscaled(_images["TalentIdBorder"], 15 + columnInPixels, 45 + rowInPixels);
            g.DrawString(t.Id.ToString(), new Font("Arial", 7.5f, FontStyle.Regular, GraphicsUnit.Point), brush, x, y);
        }

        //--------------------
        // CLICK ACTIONS
        //--------------------
        private void ProcessSelectTalent(TalentEntry t)
        {
            _talentMouseDown = null;
            _selectedTalent = t;
            if (TalentSelectedEvent != null)
            {
                TalentSelectedEvent(new TalentUserControlEventArgs(t));
            }
        }

        private void ProcessRemoveTalent(TalentEntry t)
        {
            _talentMouseDown = null;

            DialogResult choix = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce talent de l'arbre ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);

            if (choix != DialogResult.OK)
                return;

            DBCStores.Talent.RemoveEntry(t.Id);

            if (TalentDeletedEvent != null)
            {
                TalentDeletedEvent(new TalentUserControlEventArgs(t));
            }
        }

        private void ProcessAddNewTalent(uint j, uint i)
        {
            if (_talentTab != null)
            {
                TalentEntry newTalent = new TalentEntry
                {
                    Id = DBCStores.Talent.MaxKey + 1,
                    TabId = _talentTab.Id,
                    Row = j,
                    Col = i,
                    RankId = new uint[] {0, 0, 0, 0, 0, 0, 0, 0, 0},
                    ReqTalent = new uint[] {0, 0, 0},
                    ReqRank = new uint[] {0, 0, 0},
                    AllowForPetFlags = new uint[] {0, 0},
                };
                DBCStores.Talent.AddEntry(newTalent.Id, newTalent);

                if (TalentAddedEvent != null)
                {
                    TalentAddedEvent(new TalentUserControlEventArgs(newTalent));
                }
            }
        }

        private void ProcessMoveSelectedTalentTo(uint j, uint i)
        {
            if (_icons.ContainsKey("SpellIcon." + _talentMouseDown.Row + "." + _talentMouseDown.Col) &&
                (_talentMouseDown.Row != j || _talentMouseDown.Col != i))
            {
                AddOrReplaceIcon(j, i, _icons["SpellIcon." + _talentMouseDown.Row + "." + _talentMouseDown.Col]);
                RemoveIcon(_talentMouseDown.Row, _talentMouseDown.Col);
            }
            _talentMouseDown.Row = j;
            _talentMouseDown.Col = i;
            panelIn.Refresh();
            _talentMouseDown = null;
        }

        //--------------------
        // TOOLS
        //--------------------
        private static bool IsInTalentEmplacement(int x, int y, uint row, uint col)
        {
            return (x > 35 + 64*col) && (x < 35 + 35 + 64*col) &&
                   (y > 20 + 60*row) && (y < 35 + 20 + 60*row);
        }

        private static bool IsInTalentCrossButton(int x, int y, uint row, uint col)
        {
            return (x > 37 + 35 + 64*col) && (x < 47 + 35 + 64*col) &&
                   (y > 16 + 60*row) && (y < 25 + 60*row);
        }

        private void AddOrReplaceIcon(uint row, uint col, Bitmap icon)
        {
            string key = "SpellIcon." + row + "." + col;
            if (_icons.ContainsKey(key))
                _icons[key] = icon;
            else
                _icons.Add(key, icon);
        }

        private bool RemoveIcon(uint row, uint col)
        {
            string key = "SpellIcon." + row + "." + col;

            return _icons.Remove(key);
        }

        private static uint TalentRanks(TalentEntry t)
        {
            for (uint i = 0; i < 6; ++i)
                if (t.RankId[i] == 0)
                    return i;

            return 0;
        }

        private static Bitmap ResizeBitmap(Image bitmap, uint x, uint y)
        {
            Bitmap b = new Bitmap((int) x, (int) y);
            Graphics graphic = Graphics.FromImage(b);
            graphic.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphic.DrawImage(bitmap, 0, 0, x, y);
            graphic.Dispose();

            return b;
        }

        private static Bitmap CropBitmap(Image bitmap, Rectangle cropArea)
        {
            Bitmap bmpImage = new Bitmap(bitmap);
            Bitmap bmpCrop = bmpImage.Clone(cropArea, bmpImage.PixelFormat);

            return bmpCrop;
        }

        private static Bitmap RotateBitmap(Image bitmap, float angle)
        {
            Bitmap returnBitmap = new Bitmap(bitmap.Width, bitmap.Height);
            Graphics g = Graphics.FromImage(returnBitmap);
            g.TranslateTransform((float) bitmap.Width/2, (float) bitmap.Height/2);
            g.RotateTransform(angle);
            g.TranslateTransform(-(float) bitmap.Width/2, -(float) bitmap.Height/2);
            g.DrawImage(bitmap, new Point(0, 0));

            return returnBitmap;
        }
    }


    //--------------------
    // EVENTS STUFF
    //--------------------
    public delegate void TalentUserControlEventHandler(TalentUserControlEventArgs talentArgs);

    public class TalentUserControlEventArgs : EventArgs
    {
        private readonly uint _col;
        private readonly uint _row;
        private readonly long _time;
        private readonly TalentEntry _talent;

        public TalentUserControlEventArgs(TalentEntry talent)
        {
            _talent = talent;
        }

        public TalentUserControlEventArgs(uint r, uint c)
        {
            _row = r;
            _col = c;
        }

        public TalentUserControlEventArgs(TalentEntry talent, uint r, uint c)
        {
            _talent = talent;
            _row = r;
            _col = c;
        }

        public TalentUserControlEventArgs(long time)
        {
            _time = time;
        }

        public TalentEntry GetTalent()
        {
            return _talent;
        }

        public uint GetColumn()
        {
            return _col;
        }

        public uint GetRow()
        {
            return _row;
        }

        public long GetTime()
        {
            return _time;
        }
    }
}