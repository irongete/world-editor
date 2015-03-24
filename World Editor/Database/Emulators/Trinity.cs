using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace World_Editor.Database.Emulators
{
    public class Trinity : ICore
    {
        public string GetCreatureTemplate(uint entry)
        {
            throw new NotImplementedException();
        }

        public CreatureTemplate CreateCreatureTemplate(object[] data)
        {
            throw new NotImplementedException();
        }

        public string GetItemTemplate()
        {
            throw new NotImplementedException();
        }

        public string GetItemTemplate(uint from, uint to)
        {
            return @"SELECT entry, class, subclass, displayid, InventoryType, Material, sheath FROM `item_template` WHERE `entry` BETWEEN " + from + " AND " + to + ";";
        }

        public string GetItemByName(string name)
        {
            return @"SELECT entry, name_loc2 FROM `locales_item` WHERE `name_loc2` LIKE '%" + name + "%' LIMIT 40;";
        }
        public string GetItemById(string itemEntry)
        {
            return @"SELECT entry, name_loc2 FROM `locales_item` WHERE `entry` = '" + itemEntry + "';";
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
