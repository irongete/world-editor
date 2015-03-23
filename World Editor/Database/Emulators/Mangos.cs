using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace World_Editor.Database.Emulators
{
    public class Mangos : ICore
    {
        public string GetCreatureTemplate(uint entry)
        {
            return @"SELECT * FROM `creature_template` WHERE `entry` = '" + entry + "';";
        }

        public string GetItemTemplate()
        {
            return @"SELECT entry, class, subclass, displayid, InventoryType, Material, sheath FROM `item_template`;";
        }

        public string GetItemTemplate(uint from, uint to)
        {
            return @"SELECT entry, class, subclass, displayid, InventoryType, Material, sheath FROM `item_template` WHERE `entry` BETWEEN " + from + " AND " + to + ";";
        }

        /*public string GetItemByName(string name)
        {
            return @"SELECT entry, name FROM `item_template` WHERE `name` LIKE '%" + name + "%' LIMIT 40;";
        }*/
        public string GetItemByName(string name)
        {
            return @"SELECT entry, name_loc2 FROM `locales_item` WHERE `name_loc2` LIKE '%" + name + "%' LIMIT 40;";
        }
        /*public string GetItemById(string itemEntry)
        {
            return @"SELECT entry, name FROM `item_template` WHERE `entry` = '" + itemEntry + "';";
        }*/
        public string GetItemById(string itemEntry)
        {
            return @"SELECT entry, name_loc2 FROM `locales_item` WHERE `entry` = '" + itemEntry + "';";
        }

        public CreatureTemplate CreateCreatureTemplate(object[] data)
        {
            long entry = long.Parse(data[0].ToString());
            string name = data[10].ToString();
            string subname = data[11].ToString();
            int minlevel = int.Parse(data[14].ToString());
            int maxlevel = int.Parse(data[15].ToString());
            float mindmg = float.Parse(data[24].ToString());
            float maxdmg = float.Parse(data[25].ToString());
            int[] modelids = new int[4];
            int health = int.Parse(data[17].ToString());
            int mana = int.Parse(data[18].ToString());

            for (int i = 0; i < modelids.Length; i++)
                modelids[i] = int.Parse(data[6 + i].ToString());

            CreatureTemplate ct = new CreatureTemplate(entry, name, subname, minlevel, maxlevel, mindmg, maxdmg, health, mana, modelids);

            return ct;
        }

        public ItemTemplate CreateItemTemplate(object[] data)
        {
            long Entry = long.Parse(data[0].ToString());
            int Class = int.Parse(data[1].ToString());
            int SubClass = int.Parse(data[2].ToString());
            int DisplayId = int.Parse(data[3].ToString());
            int InventoryType = int.Parse(data[4].ToString());
            int Material = int.Parse(data[5].ToString());
            int Sheath = int.Parse(data[6].ToString());

            ItemTemplate it = new ItemTemplate(Entry, Class, SubClass, DisplayId, Material, Sheath, InventoryType);

            return it;
        }
    }
}
