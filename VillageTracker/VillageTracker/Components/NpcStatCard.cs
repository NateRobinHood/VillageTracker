using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VillageTracker.Components
{
    public partial class NpcStatCard : UserControl
    {
        public NpcStatCard()
        {
            InitializeComponent();

            this.BackColor = ColorManager.NpcCharacterBackgroundColor;

            lblArmorClassTitle.ForeColor = ColorManager.NpcCharacterTextColor;
            lblArmorClassTitle.Font = ThemeManager.NpcCharacterStatTitleFont(10);
            lblArmorClass.ForeColor = ColorManager.NpcCharacterTextColor;
            lblArmorClass.Font = ThemeManager.NpcCharacterTextFont(10);

            lblHitPointsTitle.ForeColor = ColorManager.NpcCharacterTextColor;
            lblHitPointsTitle.Font = ThemeManager.NpcCharacterStatTitleFont(10);
            lblHitPoints.ForeColor = ColorManager.NpcCharacterTextColor;
            lblHitPoints.Font = ThemeManager.NpcCharacterTextFont(10);

            lblSpeedTitle.ForeColor = ColorManager.NpcCharacterTextColor;
            lblSpeedTitle.Font = ThemeManager.NpcCharacterStatTitleFont(10);
            lblSpeed.ForeColor = ColorManager.NpcCharacterTextColor;
            lblSpeed.Font = ThemeManager.NpcCharacterTextFont(10);

            lblStrTitle.ForeColor = ColorManager.NpcCharacterTextColor;
            lblStrTitle.Font = ThemeManager.NpcCharacterStatTitleFont(10);
            lblDexTitle.ForeColor = ColorManager.NpcCharacterTextColor;
            lblDexTitle.Font = ThemeManager.NpcCharacterStatTitleFont(10);
            lblConTitle.ForeColor = ColorManager.NpcCharacterTextColor;
            lblConTitle.Font = ThemeManager.NpcCharacterStatTitleFont(10);
            lblIntTitle.ForeColor = ColorManager.NpcCharacterTextColor;
            lblIntTitle.Font = ThemeManager.NpcCharacterStatTitleFont(10);
            lblWisTitle.ForeColor = ColorManager.NpcCharacterTextColor;
            lblWisTitle.Font = ThemeManager.NpcCharacterStatTitleFont(10);
            lblChaTitle.ForeColor = ColorManager.NpcCharacterTextColor;
            lblChaTitle.Font = ThemeManager.NpcCharacterStatTitleFont(10);

            lblStr.ForeColor = ColorManager.NpcCharacterTextColor;
            lblStr.Font = ThemeManager.NpcCharacterTextFont(10);
            lblDex.ForeColor = ColorManager.NpcCharacterTextColor;
            lblDex.Font = ThemeManager.NpcCharacterTextFont(10);
            lblCon.ForeColor = ColorManager.NpcCharacterTextColor;
            lblCon.Font = ThemeManager.NpcCharacterTextFont(10);
            lblInt.ForeColor = ColorManager.NpcCharacterTextColor;
            lblInt.Font = ThemeManager.NpcCharacterTextFont(10);
            lblWis.ForeColor = ColorManager.NpcCharacterTextColor;
            lblWis.Font = ThemeManager.NpcCharacterTextFont(10);
            lblCha.ForeColor = ColorManager.NpcCharacterTextColor;
            lblCha.Font = ThemeManager.NpcCharacterTextFont(10);
        }

        //Public Properties
        public string ArmorClass
        {
            get
            {
                return lblArmorClass.Text;
            }
            set
            {
                lblArmorClass.Text = value;
            }
        }

        public string HitPoints
        {
            get
            {
                return lblHitPoints.Text;
            }
            set
            {
                lblHitPoints.Text = value;
            }
        }

        public string Speed
        {
            get
            {
                return lblSpeed.Text;
            }
            set
            {
                lblSpeed.Text = value;
            }
        }

        public string Str
        {
            get
            {
                return lblStr.Text;
            }
            set
            {
                lblStr.Text = value;
            }
        }

        public string Dex
        {
            get
            {
                return lblDex.Text;
            }
            set
            {
                lblDex.Text = value;
            }
        }

        public string Con
        {
            get
            {
                return lblCon.Text;
            }
            set
            {
                lblCon.Text = value;
            }
        }

        public string Int
        {
            get
            {
                return lblInt.Text;
            }
            set
            {
                lblInt.Text = value;
            }
        }

        public string Wis
        {
            get
            {
                return lblWis.Text;
            }
            set
            {
                lblWis.Text = value;
            }
        }

        public string Cha
        {
            get
            {
                return lblCha.Text;
            }
            set
            {
                lblCha.Text = value;
            }
        }
    }
}
