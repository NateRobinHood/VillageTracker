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
    public partial class NpcInfoCard : UserControl
    {
        //Private Variables
        private string m_AppearanceText = string.Empty;
        private string m_BackgroundText = string.Empty;
        private string m_MotivationsText = string.Empty;
        private string m_AlignmentText = string.Empty;
        private string m_ProfessionText = string.Empty;
        private string m_StrongestSkillsText = string.Empty;
        private string m_WeakestSkillsText = string.Empty;
        private string m_DescriptionText = string.Empty;

        public NpcInfoCard()
        {
            InitializeComponent();

            this.BackColor = ColorManager.NpcCharacterBackgroundColor;
            rtbAppearance.BackColor = ColorManager.NpcCharacterBackgroundColor;
            rtbBackground.BackColor = ColorManager.NpcCharacterBackgroundColor;
            rtbMotivations.BackColor = ColorManager.NpcCharacterBackgroundColor;
            rtbAlignment.BackColor = ColorManager.NpcCharacterBackgroundColor;
            rtbProfession.BackColor = ColorManager.NpcCharacterBackgroundColor;
            rtbStrongestSkills.BackColor = ColorManager.NpcCharacterBackgroundColor;
            rtbWeakestSkills.BackColor = ColorManager.NpcCharacterBackgroundColor;
            rtbDescription.BackColor = ColorManager.NpcCharacterBackgroundColor;

            //test values
            AppearanceText = "Black hair and stern face";
            BackgroundText = "The son of a npc";
            MotivationsText = "To matter to the party so he exists, To matter to the party so he exists, ,To matter to the party so he exists, To matter to the party so he exists, To matter to the party so he exists, To matter to the party so he exists,To matter to the party so he exists";
            AlignmentText = "Lawful Good";
            ProfessionText = "Whatever is needed at the moment";
            StrongestSkillsText = "Strenght";
            WeakestSkillsText = "Constitution";
            DescriptionText = "A wondering man that fills the role that is currently needed by the campaign, A wondering man that fills the role that is currently needed by the campaign, A wondering man that fills the role that is currently needed by the campaign, A wondering man that fills the role that is currently needed by the campaign";
        }

        //Private Methods
        private string GetHeaderText(RichTextBox thisTextBox)
        {
            if (thisTextBox == rtbAppearance)
                return "Appearance";
            if (thisTextBox == rtbBackground)
                return "Background";
            if (thisTextBox == rtbMotivations)
                return "Motivations";
            if (thisTextBox == rtbAlignment)
                return "Alignment";
            if (thisTextBox == rtbProfession)
                return "Profession";
            if (thisTextBox == rtbStrongestSkills)
                return "Strongest Skills";
            if (thisTextBox == rtbWeakestSkills)
                return "Weakest Skills";
            if (thisTextBox == rtbDescription)
                return "Description";

            return "";
        }

        private void SetText(RichTextBox thisTextBox, string text)
        {
            string header = GetHeaderText(thisTextBox);

            thisTextBox.Clear();

            thisTextBox.SelectionStart = thisTextBox.TextLength;
            thisTextBox.SelectionLength = 0;

            thisTextBox.SelectionColor = ColorManager.NpcCharacterTextColor;
            thisTextBox.SelectionFont = ThemeManager.NpcCharacterStatTitleFont(10);
            thisTextBox.AppendText(header);

            thisTextBox.SelectionStart = thisTextBox.TextLength;
            thisTextBox.SelectionLength = 0;

            thisTextBox.SelectionColor = ColorManager.NpcCharacterAltTextColor;
            thisTextBox.SelectionFont = ThemeManager.NpcCharacterTextFont(10);
            thisTextBox.AppendText(string.Format(" : {0}", text));

            thisTextBox.SelectionColor = thisTextBox.ForeColor;
            thisTextBox.SelectionFont = thisTextBox.Font;

            thisTextBox.DeselectAll();

            //Determine rich text box height from line count
            int lineCount = thisTextBox.GetLineFromCharIndex(thisTextBox.TextLength) + 1;
            thisTextBox.Height = lineCount * 25;
        }

        //Public Properties
        public string AppearanceText
        {
            get
            {
                return m_AppearanceText;
            }
            set
            {
                m_AppearanceText = value;
                SetText(rtbAppearance, value);
            }
        }

        public string BackgroundText
        {
            get
            {
                return m_BackgroundText;
            }
            set
            {
                m_BackgroundText = value;
                SetText(rtbBackground, value);
            }
        }

        public string MotivationsText
        {
            get
            {
                return m_MotivationsText;
            }
            set
            {
                m_MotivationsText = value;
                SetText(rtbMotivations, value);
            }
        }

        public string AlignmentText
        {
            get
            {
                return m_AlignmentText;
            }
            set
            {
                m_AlignmentText = value;
                SetText(rtbAlignment, value);
            }
        }

        public string ProfessionText
        {
            get
            {
                return m_ProfessionText;
            }
            set
            {
                m_ProfessionText = value;
                SetText(rtbProfession, value);
            }
        }

        public string StrongestSkillsText
        {
            get
            {
                return m_StrongestSkillsText;
            }
            set
            {
                m_StrongestSkillsText = value;
                SetText(rtbStrongestSkills, value);
            }
        }

        public string WeakestSkillsText
        {
            get
            {
                return m_WeakestSkillsText;
            }
            set
            {
                m_WeakestSkillsText = value;
                SetText(rtbWeakestSkills, value);
            }
        }

        public string DescriptionText
        {
            get
            {
                return m_DescriptionText;
            }
            set
            {
                m_DescriptionText = value;
                SetText(rtbDescription, value);
            }
        }
    }
}
