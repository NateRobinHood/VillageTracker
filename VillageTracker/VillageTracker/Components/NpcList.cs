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
    public partial class NpcList : UserControl
    {
        //Public Events
        public event EventHandler<OnNpcSelectedArgs> OnNpcSelected;

        public NpcList()
        {
            InitializeComponent();

            listViewCharacters.MultiSelect = false;

            ProjectData.OnProjectDataChanged += ProjectData_OnProjectDataChanged;
            ProjectData.OnProjectLoaded += ProjectData_OnProjectLoaded;
        }

        //Private Methods
        private void AddNpc(NpcData npc)
        {
            ListViewItem newNpcItem = new ListViewItem(npc.Name);
            newNpcItem.Tag = npc;
            listViewCharacters.Items.Add(newNpcItem);
        }

        private void ProjectData_OnProjectLoaded(object sender, EventArgs e)
        {
            listViewCharacters.Items.Clear();

            foreach (NpcData npc in ProjectData.Npcs)
            {
                AddNpc(npc);
            }
        }

        private void ProjectData_OnProjectDataChanged(object sender, OnProjectChangedEventArgs e)
        {
            if (e.DataTypeChanged == OnProjectChangedEventArgs.ProjectChangedDataTypes.Npc)
            {
                listViewCharacters.Items.Clear();

                foreach (NpcData npc in ProjectData.Npcs)
                {
                    AddNpc(npc);
                }
            }
        }

        private void listViewCharacters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCharacters.SelectedIndices.Count > 0 &&
                listViewCharacters.SelectedIndices[0] < listViewCharacters.Items.Count)
            {
                ListViewItem selectedItem = listViewCharacters.Items[listViewCharacters.SelectedIndices[0]] as ListViewItem;
                if (selectedItem != null)
                {
                    NpcData selectedNpc = selectedItem.Tag as NpcData;
                    if (selectedNpc != null)
                    {
                        OnNpcSelected?.Invoke(this, new OnNpcSelectedArgs(selectedNpc));
                    }
                }
            }
        }
    }
}
