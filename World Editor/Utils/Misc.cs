using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace World_Editor
{
    public static class Misc
    {
        /// <summary>
        /// Permet de convertir une chaîne de caractères en uint.
        /// </summary>
        /// <param name="value">Chaîne de caractères à convertir en uint</param>
        /// <returns>Retourne la chaîne de caractères sous forme de uint si possible. Retourn 0 sinon.</returns>
        public static uint ParseToUInt(string value)
        {
            uint tmp;
            UInt32.TryParse(value, out tmp);
            return tmp;
        }

        /// <summary>
        /// Permet de convertir une chaîne de caractères en int.
        /// </summary>
        /// <param name="value">Chaîne de caractères à convertir en int</param>
        /// <returns>Retourne la chaîne de caractères sous forme de int si possible. Retourn 0 sinon.</returns>
        public static int ParseToInt(string value)
        {
            int tmp;
            Int32.TryParse(value, out tmp);
            return tmp;
        }

        /// <summary>
        /// Permet de convertir une chaîne de caractères en float.
        /// </summary>
        /// <param name="value">Chaîne de caractères à convertir en float</param>
        /// <returns>Retourne la chaîne de caractères sous forme de float si possible. Retourn 0.0f sinon.</returns>
        public static float ParseToFloat(string value)
        {
            float tmp;
            bool success = float.TryParse(value, NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.GetCultureInfo("fr-FR"), out tmp);
            if (!success)
                float.TryParse(value, NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out tmp);

            return tmp;
        }
    }
}
