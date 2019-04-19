using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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

        [XmlIgnore]
        public bool HasBannerImage
        {
            get
            {
                return (m_BannerImage != null);
            }
        }

        [XmlIgnore]
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

        [Browsable(false)]
        [XmlElement(ElementName = "BannerImage", DataType = "hexBinary")]
        public byte[] BannerImageSerialized
        {
            get
            {
                if (!HasBannerImage)
                    return null;
                using (MemoryStream ms = new MemoryStream())
                {
                    BannerImage.Save(ms, ImageFormat.Bmp);
                    return ms.ToArray();
                }
            }
            set
            {
                if (value == null)
                {
                    BannerImage = null;
                }
                else
                {
                    ImageConverter converted = new ImageConverter();
                    Image convertedImage = (Image)converted.ConvertFrom(value);

                    BannerImage = new Bitmap(convertedImage);
                }
            }
        }
    }
}
