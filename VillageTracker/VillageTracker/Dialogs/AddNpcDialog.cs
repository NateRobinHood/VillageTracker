using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VillageTracker.Data;

namespace VillageTracker.Dialogs
{
    public partial class AddNpcDialog : Form
    {
        //Private Variables
        private NpcData m_NewNpcData = new NpcData();

        //Constructors
        public AddNpcDialog()
        {
            InitializeComponent();

            InitComboBoxes();
        }

        //Private Methods
        private void InitComboBoxes()
        {
            cbGender.DisplayMember = "GenderDescription";
            cbGender.ValueMember = "Gender";
            cbGender.Items.AddRange(Enum.GetValues(typeof(NpcGenders)).Cast<Enum>().Select(c =>
            {
                NpcGenderItem ret = new NpcGenderItem();
                ret.Gender = (NpcGenders)c;
                ret.GenderDescription = c.GetEnumDescription();
                return ret;
            }).ToArray());
            cbRace.DisplayMember = "RaceDescription";
            cbRace.ValueMember = "Race";
            cbRace.Items.AddRange(Enum.GetValues(typeof(NpcRaces)).Cast<Enum>().Select(c =>
            {
                NpcRaceItem ret = new NpcRaceItem();
                ret.Race = (NpcRaces)c;
                ret.RaceDescription = c.GetEnumDescription();
                return ret;
            }).ToArray());
            cbAlignment.DisplayMember = "AlignmentDescription";
            cbAlignment.ValueMember = "Alignment";
            cbAlignment.Items.AddRange(Enum.GetValues(typeof(NpcAlignments)).Cast<Enum>().Select(c =>
            {
                NpcAlignmentItem ret = new NpcAlignmentItem();
                ret.Alignment = (NpcAlignments)c;
                ret.AlignmentDescription = c.GetEnumDescription();
                return ret;
            }).ToArray());
        }

        public NpcData NewNpcData
        {
            get
            {
                return m_NewNpcData;
            }
        }

        //Event Handlers
        private void pictureBoxNpcImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog OFD = new OpenFileDialog())
            {
                OFD.Filter = "Image Files|*.png;*.jpg|All Files|*.*";
                OFD.Multiselect = false;
                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    m_NewNpcData.SetNpcImage(OFD.FileName);
                    if (m_NewNpcData.HasNpcImage)
                    {
                        pictureBoxNpcImage.Image = m_NewNpcData.NpcImage;
                    }
                }
            }
        }

        private void rtbAppearance_TextChanged(object sender, EventArgs e)
        {
            m_NewNpcData.Appearance = rtbAppearance.Text;
        }

        private void rtbBackground_TextChanged(object sender, EventArgs e)
        {
            m_NewNpcData.Background = rtbBackground.Text;
        }

        private void rtbMotivations_TextChanged(object sender, EventArgs e)
        {
            m_NewNpcData.Mostivations = rtbMotivations.Text;
        }

        private void rtbProfession_TextChanged(object sender, EventArgs e)
        {
            m_NewNpcData.Profession = rtbProfession.Text;
        }

        private void rtbStrongestSkills_TextChanged(object sender, EventArgs e)
        {
            m_NewNpcData.StrongestSkills = rtbStrongestSkills.Text;
        }

        private void rtbWeakestSkills_TextChanged(object sender, EventArgs e)
        {
            m_NewNpcData.WeakestSkills = rtbWeakestSkills.Text;
        }

        private void rtbDescription_TextChanged(object sender, EventArgs e)
        {
            m_NewNpcData.Description = rtbDescription.Text;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            m_NewNpcData.Name = txtName.Text;
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            //m_NewNpcData.Gender = (NpcGenders)cbGender.SelectedValue;

            //if (m_NewNpcData.Gender == NpcGenders.Other)
            //{
            //    txtGenderOther.Enabled = true;
            //}
            //else
            //{
            //    txtGenderOther.Enabled = false;
            //}
        }

        private void cbGender_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbGender.SelectedItem != null && cbGender.SelectedItem is NpcGenderItem)
            {
                m_NewNpcData.Gender = ((NpcGenderItem)cbGender.SelectedItem).Gender;

                if (m_NewNpcData.Gender == NpcGenders.Other)
                {
                    txtGenderOther.Enabled = true;
                }
                else
                {
                    txtGenderOther.Enabled = false;
                }
            }
        }

        private void cbRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRace.SelectedItem != null && cbRace.SelectedItem is NpcRaceItem)
            {
                m_NewNpcData.Race = ((NpcRaceItem)cbRace.SelectedItem).Race;

                if (m_NewNpcData.Race == NpcRaces.Other)
                {
                    txtRaceOther.Enabled = true;
                }
                else
                {
                    txtRaceOther.Enabled = false;
                }
            }
        }

        private void cbAlignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAlignment.SelectedItem != null && cbAlignment.SelectedItem is NpcAlignmentItem)
                m_NewNpcData.Alignemnt = ((NpcAlignmentItem)cbAlignment.SelectedItem).Alignment;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        //Internal Classes
        private class NpcGenderItem
        {
            public NpcGenders Gender { get; set; }
            public string GenderDescription { get; set; }
        }

        private class NpcRaceItem
        {
            public NpcRaces Race { get; set; }
            public string RaceDescription { get; set; }
        }

        private class NpcAlignmentItem
        {
            public NpcAlignments Alignment { get; set; }
            public string AlignmentDescription { get; set; }
        }
    }
}
