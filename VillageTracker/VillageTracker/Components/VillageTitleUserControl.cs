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
    public partial class VillageTitleUserControl : UserControl
    {
        public VillageTitleUserControl()
        {
            InitializeComponent();
        }

        //Public Properties
        public string VillageTitle
        {
            get
            {
                return lblVillageTitle.Text;
            }
            set
            {
                lblVillageTitle.Text = value;
            }
        }

        public Image VillageBanner
        {
            get
            {
                return this.BackgroundImage;
            }
            set
            {
                this.BackgroundImage = value;
            }
        }
    }
}
