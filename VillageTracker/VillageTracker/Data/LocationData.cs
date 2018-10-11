using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageTracker.Data
{
    public class LocationData
    {
        private string m_LocationName = string.Empty;

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
                if (m_LocationName == value)
                {
                    m_LocationName = value;
                }
            }
        }
    }
}
