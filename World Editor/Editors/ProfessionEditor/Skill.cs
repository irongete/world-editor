using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBCLib.Structures335;
using World_Editor.DBC;

namespace World_Editor.ProfessionEditor
{
    public class Recipe
    {
        public override string ToString()
        {
            return spell.Id + ", " + spell.SpellName;
        }

        public Recipe(SpellEntry sp, SkillLineAbilityEntry ab)
        {
            ability = ab;
            spell = sp;
        }

        public SkillLineAbilityEntry ability;
        public SpellEntry spell;
    }

    public class Skill
    {

        public Skill()
        {
            opened = false;
        }

        public void load(uint entry)
        {
            if (isOpen)
            {
                clear();
            }

            opened = true;
            id = entry;

            // Infos de base

            Line = DBCStores.SkillLine[id];
            RaceClassInfo = DBCStores.SkillRaceClassInfo.Records.Where(srci => srci.SkillId == id).First();

            // Spells et Abilities

            foreach (var ability in DBCStores.SkillLineAbility.Records)
            {
                if (ability.SkillId == id)
                {
                    if (DBCStores.Spell[ability.SpellId].Effect[0] == 24) // recipe
                    {
                        Recipes.Add(ability.SpellId, new Recipe(DBCStores.Spell[ability.SpellId], ability));
                    }
                    else
                    {
                        Abilities.Add(ability.Id, ability);
                        Spells.Add(ability.SpellId, DBCStores.Spell[ability.SpellId]);
                    }
                }
            }
        }

        public bool isOpen { get { return opened; } }

        public void clear()
        {
            id = 0;

            Line = null;
            RaceClassInfo = null;
            Abilities.Clear();
            Spells.Clear();
            Recipes.Clear();

            opened = false;
        }

        private uint id;
        private bool opened;

        public SkillLineEntry Line;
        public SkillRaceClassInfoEntry RaceClassInfo;
        public Dictionary<uint, SkillLineAbilityEntry> Abilities = new Dictionary<uint, SkillLineAbilityEntry>();
        public Dictionary<uint, SpellEntry> Spells = new Dictionary<uint, SpellEntry>();
        public Dictionary<uint, Recipe> Recipes = new Dictionary<uint, Recipe>();
    }
}
