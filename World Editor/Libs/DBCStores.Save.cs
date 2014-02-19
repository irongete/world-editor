using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace World_Editor.DBC
{
    public static partial class DBCStores
    {
        public static void SaveTitlesEditorFiles()
        {
            CharTitles.SaveDBC();
        }

        public static void SaveFactionsEditorFiles()
        {
            Faction.SaveDBC();
            FactionGroup.SaveDBC();
            FactionTemplate.SaveDBC();
        }

        public static void SaveProfessionEditorFiles()
        {
            Spell.SaveDBC();
            SkillLine.SaveDBC();
            SkillLineAbility.SaveDBC();
            SkillRaceClassInfo.SaveDBC();
            SpellFocusObject.SaveDBC();
        }

        public static void SaveTalentsEditorFiles()
        {
            Talent.SaveDBC();
            TalentTab.SaveDBC();
        }

        public static void SaveAchievementsEditor()
        {
            Achievement.SaveDBC();
            AchievementCategory.SaveDBC();
            AchievementCriteria.SaveDBC();
        }

        public static void SaveRacesEditorFiles()
        {
            ChrRaces.SaveDBC();
        }

        public static void SavePOIsEditorFiles()
        {
            AreaPOI.SaveDBC();
        }

        public static void SaveClassesEditorFiles()
        {
            ChrClasses.SaveDBC();
        }

        public static void SaveMapsEditorFiles()
        {
            WorldMapArea.SaveDBC();
            WorldMapOverlay.SaveDBC();
        }

        public static void SaveItemDbcGeneratorFiles()
        {
            Item.SaveDBC();
        }

        public static void SaveGameTipsEditorFiles()
        {
            GameTips.SaveDBC();
        }
    }
}
