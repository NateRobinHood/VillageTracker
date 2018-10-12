using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VillageTracker.Data;

namespace VillageTracker.Components
{
    public class LocationTabPage : TabPage
    {
        //Private Variables
        private LocationData m_Location;
        private VillageUserControl m_VillageUserControl;

        //Constructors
        public LocationTabPage(LocationData location) : base(location.LocationName)
        {
            m_Location = location;
            m_VillageUserControl = new VillageUserControl(location);
            this.Controls.Add(VillageUserControl);
        }

        //Public Properties
        public LocationData LocationData
        {
            get
            {
                return m_Location;
            }
        }

        public VillageUserControl VillageUserControl
        {
            get
            {
                return m_VillageUserControl;
            }
        }
    }
}
