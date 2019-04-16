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
    public partial class NpcTitleCard : UserControl
    {
        public NpcTitleCard()
        {
            InitializeComponent();

            this.BackColor = ColorManager.NpcCharacterBackgroundColor;

            lblName.ForeColor = ColorManager.NpcCharacterTextColor;
            lblName.Font = ThemeManager.NpcCharacterNameFont(20);

            lblInfo.ForeColor = ColorManager.NpcCharacterAltTextColor;
            lblInfo.Font = ThemeManager.NpcCharacterInfoFont(10);

            //Testing Values
            lblName.Text = "Niel Patrick Carter";
            lblInfo.Text = "Medium Humanoid (Human), Lawful Good";
        }

        //Public Properties
        public string NpcName
        {
            get
            {
                return lblName.Text;
            }
            set
            {
                lblName.Text = value;
            }
        }

        public string NpcInfo
        {
            get
            {
                return lblInfo.Text;
            }
            set
            {
                lblInfo.Text = value;
            }
        }

        //Public Methods
        public void SetNpcData(NpcData npcData)
        {
            NpcName = npcData.Name;
            NpcInfo = npcData.NpcInfo;
        }
    }
}
