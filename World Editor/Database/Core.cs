using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace World_Editor.Database
{
    public interface Core
    {
        string GetCreatureTemplate(uint entry);

        string GetItemTemplate();
        string GetItemTemplate(uint from, uint to);

        CreatureTemplate CreateCreatureTemplate(object[] data);

        ItemTemplate CreateItemTemplate(object[] data);
    }
}
