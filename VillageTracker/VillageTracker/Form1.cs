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
using VillageTracker.Dialogs;

namespace VillageTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AddLocationDilaog ALD = new AddLocationDilaog())
            {
                if (ALD.ShowDialog() == DialogResult.OK)
                {
                    ProjectData.Locations.Add(ALD.NewLocationData);
                }
            }
        }

        private void addNPCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AddNpcDialog AND = new AddNpcDialog())
            {
                if (AND.ShowDialog() == DialogResult.OK)
                {
                    ProjectData.Npcs.Add(AND.NewNpcData);
                }
            }
        }
    }
}
