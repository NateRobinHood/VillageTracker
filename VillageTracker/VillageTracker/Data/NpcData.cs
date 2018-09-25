using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace VillageTracker.Data
{
    public class NpcData: INotifyPropertyChanged
    {
        //Private Variables
        private string m_CurrentVillage = string.Empty;
        private string m_Name = string.Empty;
        private NpcGenders m_Gender = NpcGenders.Male;
        private string m_GenderOther = string.Empty;
        private NpcRaces m_Race = NpcRaces.HumanStandard;
        private string m_RaceOther = string.Empty;
        private string m_Appearance = string.Empty;
        private string m_Background = string.Empty;
        private string m_Mostivations = string.Empty;
        private NpcAlignments m_Alignemnt = NpcAlignments.LawfulGood;
        private string m_Profession = string.Empty;
        private string m_StrongestSkills = string.Empty;
        private string m_WeakestSkills = string.Empty;
        private string m_Description = string.Empty;
        private string m_NpcImagePath = string.Empty;
        private Image m_NpcImage = null;

        //Public Events
        public event PropertyChangedEventHandler PropertyChanged;

        //Constructors
        public NpcData()
        {

        }

        //Public Properties
        public string CurrentVillage
        {
            get
            {
                return m_CurrentVillage;
            }
            set
            {
                if (m_CurrentVillage != value)
                {
                    m_CurrentVillage = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Name
        {
            get
            {
                return m_Name;
            }
            set
            {
                if (m_Name != value)
                {
                    m_Name = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public NpcGenders Gender
        {
            get
            {
                return m_Gender;
            }
            set
            {
                if (m_Gender != value)
                {
                    m_Gender = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string GenderOther
        {
            get
            {
                return m_GenderOther;
            }
            set
            {
                if (m_GenderOther != value)
                {
                    m_GenderOther = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public NpcRaces Race
        {
            get
            {
                return m_Race;
            }
            set
            {
                if (m_Race != value)
                {
                    m_Race = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string RaceOther
        {
            get
            {
                return m_RaceOther;
            }
            set
            {
                if (m_RaceOther != value)
                {
                    m_RaceOther = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Appearance
        {
            get
            {
                return m_Appearance;
            }
            set
            {
                if (m_Appearance != value)
                {
                    m_Appearance = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Background
        {
            get
            {
                return m_Background;
            }
            set
            {
                if (m_Background != value)
                {
                    m_Background = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Mostivations
        {
            get
            {
                return m_Mostivations;
            }
            set
            {
                if (m_Mostivations != value)
                {
                    m_Mostivations = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public NpcAlignments Alignemnt
        {
            get
            {
                return m_Alignemnt;
            }
            set
            {
                if (m_Alignemnt != value)
                {
                    m_Alignemnt = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Profession
        {
            get
            {
                return m_Profession;
            }
            set
            {
                if (m_Profession != value)
                {
                    m_Profession = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string StrongestSkills
        {
            get
            {
                return m_StrongestSkills;
            }
            set
            {
                if (m_StrongestSkills != value)
                {
                    m_StrongestSkills = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string WeakestSkills
        {
            get
            {
                return m_WeakestSkills;
            }
            set
            {
                if (m_WeakestSkills != value)
                {
                    m_WeakestSkills = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Description
        {
            get
            {
                return m_Description;
            }
            set
            {
                if (m_Description != value)
                {
                    m_Description = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string NpcImagePath
        {
            get
            {
                return m_NpcImagePath;
            }
            set
            {
                if (m_NpcImagePath != value)
                {
                    m_NpcImagePath = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool HasNpcImage
        {
            get
            {
                return File.Exists(m_NpcImagePath);
            }
        }

        public Image NpcImage
        {
            get
            {
                if (HasNpcImage)
                {
                    if (m_NpcImage == null)
                    {
                        m_NpcImage = Image.FromFile(m_NpcImagePath);
                    }

                    return m_NpcImage;
                }
                return null;
            }
        }

        //Private Methods
        // This method is called by the Set accessor of each property.
        // The CallerMemberName attribute that is applied to the optional propertyName
        // parameter causes the property name of the caller to be substituted as an argument.
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
