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

            npcList.OnNpcSelected += NpcList_OnNpcSelected;
        }

        public VillageUserControl(LocationData location)
        {
            InitializeComponent();

            m_Location = location;
            npcList.OnNpcSelected += NpcList_OnNpcSelected;
        }

        //Event Handlers
        private void NpcList_OnNpcSelected(object sender, OnNpcSelectedArgs e)
        {
            npcStats.SetNpcData(e.SelectedNpc);
        }
    }
}
