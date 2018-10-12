using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VillageTracker.Dialogs
{
    public partial class ImportVillageBannerDialog : Form
    {
        public ImportVillageBannerDialog()
        {
            InitializeComponent();
        }

        //Public Properties
        public Image BannerImage
        {
            get
            {
                return croppingBox.CroppedImage;
            }
        }

        //Event Handlers
        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog OFD = new OpenFileDialog())
            {
                OFD.Filter = "Image files(*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png; | All Files (*.*) | *.*;";
                OFD.Multiselect = false;
                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    croppingBox.ImageLocation = OFD.FileName;
                    croppingBox.Invalidate();
                }
            }
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
