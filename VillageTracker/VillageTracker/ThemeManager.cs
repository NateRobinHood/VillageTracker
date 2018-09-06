using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageTracker
{
    public class ThemeManager
    {
        public static Font NpcCharacterNameFont(int size)
        {
            return new Font("Lucida Bright", size, FontStyle.Regular); //Monotype Corsiva
        }

        public static Font NpcCharacterInfoFont(int size)
        {
            return new Font("Arial", size, FontStyle.Italic);
        }

        public static Font NpcCharacterStatTitleFont(int size)
        {
            return new Font("Arial", size, FontStyle.Bold);
        }

        public static Font NpcCharacterTextFont(int size)
        {
            return new Font("Arial", size);
        }
    }
}
