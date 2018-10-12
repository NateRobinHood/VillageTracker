using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VillageTracker.Data;

namespace VillageTracker.Components
{
    public partial class VillageUserControl : UserControl
    {
        //Private Variables
        private LocationData m_Location = null;

        //Constructors
        public VillageUserControl() //For Designer
        {
            InitializeComponent();
        }

        public VillageUserControl(LocationData location)
        {
            InitializeComponent();

            m_Location = location;
        }
    }
}
