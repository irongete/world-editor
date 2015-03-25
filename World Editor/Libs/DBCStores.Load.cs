using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace World_Editor.DBC
{
    public static partial class DBCStores
    {
        public static void LoadTitlesEditorFiles()
        {
            CharTitles.LoadData();
        }

        public static void LoadNamesReservedFiles()
        {
            NamesProfanity.LoadData();
            NamesReserved.LoadData();
        }

        public static void LoadProfessionEditorFiles()
        {
            Spell.LoadData();
            SkillLine.LoadData();
            SkillLineAbility.LoadData();
            SkillRaceClassInfo.LoadData();
            SpellFocusObject.LoadData();
            ChrRaces.LoadData();
            ChrClasses.LoadData();
        }

        public static void LoadFactionsEditorFiles()
        {
            ChrClasses.LoadData();
            ChrRaces.LoadData();
            Faction.LoadData();
            FactionGroup.LoadData();
            FactionTemplate.LoadData();
        }

        public static void LoadTalentsEditorFiles()
        {
            ChrClasses.LoadData();
            ChrRaces.LoadData();
            Spell.LoadData();
            SpellIcon.LoadData();
            Talent.LoadData();
            TalentTab.LoadData();
        }

        public static void LoadAchievementsEditor()
        {
            Achievement.LoadData();
            AchievementCategory.LoadData();
            AchievementCriteria.LoadData();
            Map.LoadData();
            SpellIcon.LoadData();
        }

        public static void LoadRacesEditorFiles()
        {
            ChrRaces.LoadData();
        }

        public static void LoadClassesEditorFiles()
        {
            ChrClasses.LoadData();
        }

        public static void LoadPOIsEditorFiles()
        {
            AreaPOI.LoadData();
            AreaTable.LoadData();
            DungeonMap.LoadData();
            Map.LoadData();
            WorldMapArea.LoadData();
            WorldMapOverlay.LoadData();
        }

        public static void LoadMapsEditorFiles()
        {
            WorldMapArea.LoadData();
            WorldMapOverlay.LoadData();
        }

        public static void LoadItemDbcGeneratorFiles()
        {
            Item.LoadData();
        }

        public static void LoadGameTipsEditorFiles()
        {
            GameTips.LoadData();
        }

        public static void LoadGemsEditorFiles()
        {
            Item.LoadData();
            GemProperties.LoadData();
            SpellItemEnchantment.LoadData();
        }

        public static void LoadRacesClassCombosEditorFiles()
        {
            CharBaseInfo.LoadData();
            ChrClasses.LoadData();
            ChrRaces.LoadData();
        }

        public static void LoadItemSetEditorFiles()
        {
            ItemSet.LoadData();
        }
    }
}
