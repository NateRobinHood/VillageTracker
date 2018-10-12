using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageTracker.Data
{
    public static class ProjectData
    {
        //Constants
        public static string AllNpcsTabName = "All Npcs";

        //Public Events
        public static event EventHandler<OnProjectChangedEventArgs> OnProjectDataChanged;

        //Private Variables
        private static NpcList m_Npcs;
        private static LocationList m_Locations;

        //Public Properties
        public static LocationList Locations
        {
            get
            {
                if (m_Locations == null)
                {
                    m_Locations = new LocationList();
                    m_Locations.OnLocationAdded += Locations_OnLocationAdded;
                    m_Locations.OnLocationRemoved += Locations_OnLocationRemoved;
                }

                return m_Locations;
            }
        }

        public static NpcList Npcs
        {
            get
            {
                if (m_Npcs == null)
                {
                    m_Npcs = new NpcList();
                    m_Npcs.OnNpcAdded += Npcs_OnNpcAdded;
                    m_Npcs.OnNpcRemoved += Npcs_OnNpcRemoved;
                }

                return m_Npcs;
            }
        }


        //Public Methods
        public static void SaveProjectData()
        {
            throw new NotImplementedException("To Do - Save Project Data");
        }

        //Event Handlers
        private static void Npcs_OnNpcRemoved(object sender, OnNpcAddedRemovedArgs e)
        {
            OnProjectDataChanged?.Invoke(sender, new OnProjectChangedEventArgs(OnProjectChangedEventArgs.ProjectChangedDataTypes.Npc));
        }

        private static void Npcs_OnNpcAdded(object sender, OnNpcAddedRemovedArgs e)
        {
            OnProjectDataChanged?.Invoke(sender, new OnProjectChangedEventArgs(OnProjectChangedEventArgs.ProjectChangedDataTypes.Npc));
        }

        private static void Locations_OnLocationRemoved(object sender, OnLocationAddedRemovedArgs e)
        {
            OnProjectDataChanged?.Invoke(sender, new OnProjectChangedEventArgs(OnProjectChangedEventArgs.ProjectChangedDataTypes.Location));
        }

        private static void Locations_OnLocationAdded(object sender, OnLocationAddedRemovedArgs e)
        {
            OnProjectDataChanged?.Invoke(sender, new OnProjectChangedEventArgs(OnProjectChangedEventArgs.ProjectChangedDataTypes.Location));
        }
    }
}
