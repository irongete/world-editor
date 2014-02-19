using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace World_Editor.Database
{
    public class CreatureTemplate
    {
        public long entry;
        public string name;
        public string subname;
        public int minlevel;
        public int maxlevel;
        public float mindmg;
        public float maxdmg;
        public int health;
        public int mana;
        public int[] modelids;

        public CreatureTemplate(long entry, string name, string subname, int minlevel, int maxlevel, float mindmg, float maxdmg, int health, int mana, int[] modelids)
        {
            this.entry = entry;
            this.name = name;
            this.subname = subname;
            this.minlevel = minlevel;
            this.maxlevel = maxlevel;
            this.mindmg = mindmg;
            this.maxdmg = maxdmg;
            this.health = health;
            this.mana = mana;
            this.modelids = modelids;
        }
    }

    public class ItemTemplate
    {
        public long Entry;
        public int Class;
        public int SubClass;
        public int DisplayId;
        public int Material;
        public int Sheath;
        public int InventoryType;

        public ItemTemplate(long Entry, int Class, int SubClass, int DisplayId, int Material,
            int Sheath, int InventoryType)
        {
            this.Entry = Entry;
            this.Class = Class;
            this.SubClass = SubClass;
            this.DisplayId = DisplayId;
            this.Material = Material;
            this.Sheath = Sheath;
            this.InventoryType = InventoryType;
        }
    }
}
