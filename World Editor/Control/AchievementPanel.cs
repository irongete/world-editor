using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using DBCLib.Structures335;
using MDS.cBlp2;
using World_Editor.DBC;

namespace World_Editor.Control
{
    public partial class AchievementPanel : Panel
    {
        //--------------------
        // ATTRIBUTES
        //--------------------
        private readonly Dictionary<string, Bitmap> _images = new Dictionary<string, Bitmap>();
        private Graphics _graphics;
        private AchievementEntry _achievement;
        private readonly StringFormat _defaultStringFormat = new StringFormat
                {
                    FormatFlags = StringFormatFlags.NoWrap,
                    Trimming = StringTrimming.EllipsisWord,
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };

        private uint _currentSpellIconId;

        //--------------------
        // CONSTRUCTORS
        //--------------------
        public AchievementPanel()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                InitializeImages();
            }
        }

        public AchievementPanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                InitializeImages();
            }
        }

        //--------------------
        // LIFE CYCLE
        //--------------------
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (_achievement != null)
            {
                UpdateAchievementSpellIcon(_achievement.Icon);

                DrawBackground();
                DrawSpellIcon();
                DrawAchievementName();
                DrawPoints();
            }

        }

        //--------------------
        // API
        //--------------------
        public void SetAchievement(AchievementEntry achievementEntry)
        {
            _graphics = CreateGraphics();
            _achievement = achievementEntry;

            UpdateAchievementSpellIcon(_achievement.Icon);
            Refresh();
        }

        //--------------------
        // PRIVATE METHODS
        //--------------------
        private void InitializeImages()
        {
            _images.Clear();
            _images.Add("Back", Blp2.FromFile("Ressources\\UI-Achievement-Alert-Background.blp"));
            _images.Add("IconFrame", Blp2.FromFile("Ressources\\UI-Achievement-IconFrame.blp"));
            _images.Add("Shield", CropBitmap(Blp2.FromFile("Ressources\\UI-Achievement-Shields.blp"), new Rectangle(0, 0, 64, 64)));
            _images.Add("ShieldNoPoints", CropBitmap(Blp2.FromFile("Ressources\\UI-Achievement-Shields-NoPoints.blp"), new Rectangle(0, 0, 64, 64)));
            _images.Add("SpellIconDefault", Blp2.FromFile("Ressources\\DefaultTalentIcon.blp"));
        }

        private void UpdateAchievementSpellIcon(uint iconId)
        {
            if (iconId != _currentSpellIconId)
            {
                _currentSpellIconId = iconId;
                if (_images.ContainsKey("SpellIcon"))
                {
                    _images.Remove("SpellIcon");
                }

                if (DBCStores.SpellIcon.ContainsKey(iconId) && Stormlib.MPQFile.Exists(DBCStores.SpellIcon[iconId].IconPath + ".blp"))
                {
                    _images.Add("SpellIcon", ResizeBitmap(Blp2.FromStream(new Stormlib.MPQFile(DBCStores.SpellIcon[iconId].IconPath + ".blp")), 50, 50));
                }
            }
        }

        private void DrawBackground()
        {
            _graphics.DrawImageUnscaled(_images["Back"], 0, -1);
        }

        private void DrawSpellIcon()
        {
            if (_images.ContainsKey("SpellIcon"))
            {
                _graphics.DrawImageUnscaled(_images["SpellIcon"], 10, 20);
            }
            else
            {
                _graphics.DrawImageUnscaled(_images["SpellIconDefault"], 5, 15);
            }
            _graphics.DrawImageUnscaled(_images["IconFrame"], 0, 8);
        }

        private void DrawAchievementName()
        {
            Font font = new Font("Arial", 8.5f, FontStyle.Bold, GraphicsUnit.Point);

            _graphics.DrawString(_achievement.Name, font, Brushes.Black, new Rectangle(86, 35, 155, 18), _defaultStringFormat);
            _graphics.DrawString(_achievement.Name, font, Brushes.White, new Rectangle(85, 34, 155, 18), _defaultStringFormat);
        }

        private void DrawPoints()
        {
            if (_achievement.Points == 0)
            {
                _graphics.DrawImageUnscaled(_images["ShieldNoPoints"], 241, 17);
            }
            else
            {
                String points = _achievement.Points.ToString(CultureInfo.InvariantCulture);
                Font font = new Font("Arial", 10f, FontStyle.Bold, GraphicsUnit.Point);

                _graphics.DrawImageUnscaled(_images["Shield"], 241, 17);
                _graphics.DrawString(points, font, Brushes.Black, new Rectangle(259, 38, 29, 17), _defaultStringFormat);
                _graphics.DrawString(points, font, Brushes.White, new Rectangle(258, 37, 29, 17), _defaultStringFormat);
            }
        }

        //--------------------
        // TOOLS
        //--------------------
        private static Bitmap CropBitmap(Image bitmap, Rectangle cropArea)
        {
            Bitmap bmpImage = new Bitmap(bitmap);
            Bitmap bmpCrop = bmpImage.Clone(cropArea, bmpImage.PixelFormat);

            return bmpCrop;
        }

        private static Bitmap ResizeBitmap(Image bitmap, uint x, uint y)
        {
            Bitmap b = new Bitmap((int)x, (int)y);
            Graphics graphic = Graphics.FromImage(b);
            graphic.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            graphic.DrawImage(bitmap, 0, 0, x, y);
            graphic.Dispose();

            return b;
        }
    }
}
