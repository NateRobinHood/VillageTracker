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
    public partial class NpcStats : UserControl
    {
        public NpcStats()
        {
            InitializeComponent();

            this.BackColor = ColorManager.NpcCharacterBackgroundColor;
        }

        //Public Methods
        public void SetNpcData(NpcData npcData)
        {
            npcInfoCard.SetNpcData(npcData);
            npcTitleCard.SetNpcData(npcData);
        }
    }
}
