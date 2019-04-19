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
    public partial class AddLocationDilaog : Form
    {
        private LocationData m_NewLocationData = new LocationData();

        public AddLocationDilaog()
        {
            InitializeComponent();
        }

        //Public Properties
        public LocationData NewLocationData
        {
            get
            {
                return m_NewLocationData;
            }
        }

        //Event Handlers
        private void txtLocationName_TextChanged(object sender, EventArgs e)
        {
            m_NewLocationData.LocationName = txtLocationName.Text;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (ProjectData.Locations.Any(c => c.LocationName.ToLower() == m_NewLocationData.LocationName.ToLower()))
            {
                MessageBox.Show(string.Format("Location {0} already exists", m_NewLocationData.LocationName), "Location Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void cmdImportBanner_Click(object sender, EventArgs e)
        {
            using (ImportVillageBannerDialog IVBD = new ImportVillageBannerDialog())
            {
                if (IVBD.ShowDialog() == DialogResult.OK)
                {
                    IVBD.BannerImage.Save(@"C:\Git\VillageTracker\VillageTracker\VillageTracker\Resources\TestCroppedImage.bmp");
                    m_NewLocationData.BannerImage = IVBD.BannerImage;
                }
            }
        }
    }
}
