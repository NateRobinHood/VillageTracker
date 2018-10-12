using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageTracker.Data
{
    public class LocationData
    {
        private string m_LocationName = string.Empty;
        private Image m_BannerImage = new Bitmap(750, 120);

        public LocationData()
        {

        }

        public string LocationName
        {
            get
            {
                return m_LocationName;
            }
            set
            {
                if (m_LocationName != value)
                {
                    m_LocationName = value;
                }
            }
        }

        public Image BannerImage
        {
            get
            {
                return m_BannerImage;
            }
            set
            {
                m_BannerImage = value;
            }
        }
    }
}
