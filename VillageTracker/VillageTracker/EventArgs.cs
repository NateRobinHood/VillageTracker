using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageTracker.Data;

namespace VillageTracker
{
    public class OnProjectChangedEventArgs : EventArgs
    {
        private ProjectChangedDataTypes m_DataTypeChanged;

        public OnProjectChangedEventArgs(ProjectChangedDataTypes type)
        {
            m_DataTypeChanged = type;
        }

        public ProjectChangedDataTypes DataTypeChanged
        {
            get
            {
                return m_DataTypeChanged;
            }
        }

        //Internal Enum
        public enum ProjectChangedDataTypes
        {
            Location = 0,
            Npc
        }
    }

    public class OnNpcAddedRemovedArgs : EventArgs
    {
        private NpcData m_Npc;

        public OnNpcAddedRemovedArgs(NpcData npc)
        {
            m_Npc = npc;
        }

        public NpcData Npc
        {
            get
            {
                return m_Npc;
            }
        }
    }

    public class OnLocationAddedRemovedArgs : EventArgs
    {
        private LocationData m_Location;

        public OnLocationAddedRemovedArgs(LocationData location)
        {
            m_Location = location;
        }

        public LocationData Location
        {
            get
            {
                return m_Location;
            }
        }
    }
}
