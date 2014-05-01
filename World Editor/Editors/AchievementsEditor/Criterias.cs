using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace World_Editor.Editors.AchievementsEditor
{
    public static class Criterias
    {
        private static readonly Dictionary<uint, Criteria> criterias = new Dictionary<uint, Criteria>();
        private static bool _loaded = false;

        public static void Init()
        {
            if (_loaded)
                return;

            XmlSerializer deserializer = new XmlSerializer(typeof(List<Criteria>));
            TextReader textReader = new StreamReader(@".\Ressources\Criterias.xml");
            List<Criteria> listCriterias = (List<Criteria>)deserializer.Deserialize(textReader);
            textReader.Close();

            foreach (Criteria c in listCriterias)
                criterias.Add(c.TypeId, c);

            _loaded = true;
        }

        public static Dictionary<uint, Criteria> GetCriterias()
        {
            return criterias;
        }
    }

    public class Criteria
    {
        [XmlAttribute("Id")]
        public uint TypeId { get; set; }

        [XmlAttribute("Name")]
        public string TypeName { get; set; }

        public string ReqType0 { get; set; }
        public string ReqValue0 { get; set; }
        public string ReqType1 { get; set; }
        public string ReqValue1 { get; set; }
        public string ReqType2 { get; set; }
        public string ReqValue2 { get; set; }

        public override string ToString()
        {
            return TypeName;
        }
    }
}
