using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace World_Editor.Database.Emulators
{
    public class Arcemu : ICore
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

        public ItemTemplate CreateItemTemplate(object[] data)
        {
            throw new NotImplementedException();
        }

        public string GetItemTemplate(uint from, uint to)
        {
            throw new NotImplementedException();
        }

        public string GetItemByName(string name)
        {
            throw new NotImplementedException();
        }

        public string GetItemById(string itemEntry)
        {
            throw new NotImplementedException();
        }
    }
}
