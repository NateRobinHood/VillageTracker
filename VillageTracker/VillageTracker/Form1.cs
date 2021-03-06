﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VillageTracker.Components;
using VillageTracker.Data;
using VillageTracker.Dialogs;

namespace VillageTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Event Subscriptions
            ProjectData.OnProjectDataChanged += ProjectData_OnProjectDataChanged;
            ProjectData.OnProjectLoaded += ProjectData_OnProjectLoaded;
            tabControlMain.SelectedIndexChanged += TabControlMain_SelectedIndexChanged;

            InitTabPages();
        }

        //Private Methods
        private void InitTabPages()
        {
            tabControlMain.TabPages.Clear();

            TabPage allNpcsTabPage = new TabPage(ProjectData.AllNpcsTabName);
            VillageUserControl allNpcsVilageControl = new VillageUserControl();
            allNpcsVilageControl.Dock = DockStyle.Fill;
            allNpcsTabPage.Controls.Add(allNpcsVilageControl);

            tabControlMain.TabPages.Add(allNpcsTabPage);
        }

        //Event Handlers
        private void ProjectData_OnProjectLoaded(object sender, EventArgs e)
        {
            List<TabPage> tempList = new List<TabPage>(tabControlMain.TabPages.Cast<TabPage>()); //Avoid enumeration exception
            //Removed Tabs that aren't in list
            foreach (TabPage tab in tempList)
            {
                if (!ProjectData.Locations.Any(c => c.LocationName == tab.Text) && tab.Text != ProjectData.AllNpcsTabName)
                {
                    tabControlMain.TabPages.Remove(tab);
                }
            }
            //Add Tabs that aren't in list
            foreach (LocationData location in ProjectData.Locations)
            {
                if (!tabControlMain.TabPages.Cast<TabPage>().Any(c => c.Text == location.LocationName))
                {
                    tabControlMain.TabPages.Add(new LocationTabPage(location));
                }
            }
        }
        private void ProjectData_OnProjectDataChanged(object sender, OnProjectChangedEventArgs e)
        {
            //Check Location Tabs
            if (e.DataTypeChanged == OnProjectChangedEventArgs.ProjectChangedDataTypes.Location)
            {
                List<TabPage> tempList = new List<TabPage>(tabControlMain.TabPages.Cast<TabPage>()); //Avoid enumeration exception
                //Removed Tabs that aren't in list
                foreach (TabPage tab in tempList)
                {
                    if (!ProjectData.Locations.Any(c => c.LocationName == tab.Text) && tab.Text != ProjectData.AllNpcsTabName)
                    {
                        tabControlMain.TabPages.Remove(tab);
                    }
                }
                //Add Tabs that aren't in list
                foreach (LocationData location in ProjectData.Locations)
                {
                    if (!tabControlMain.TabPages.Cast<TabPage>().Any(c => c.Text == location.LocationName))
                    {
                        tabControlMain.TabPages.Add(new LocationTabPage(location));
                    }
                }
            }
        }

        private void addLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AddLocationDilaog ALD = new AddLocationDilaog())
            {
                ALD.StartPosition = FormStartPosition.CenterParent;
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
                AND.StartPosition = FormStartPosition.CenterParent;
                if (AND.ShowDialog() == DialogResult.OK)
                {
                    ProjectData.Npcs.Add(AND.NewNpcData);
                }
            }
        }

        private void TabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocationTabPage selectedTabPage = tabControlMain.SelectedTab as LocationTabPage;
            if (selectedTabPage != null)
            {
                villageTitleUserControl.VillageBanner = selectedTabPage.LocationData.BannerImage;
                villageTitleUserControl.VillageTitle = selectedTabPage.LocationData.LocationName;
            }
            else
            {
                villageTitleUserControl.VillageTitle = string.Empty;
                villageTitleUserControl.VillageBanner = null;
            }
        }

        private void saveProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectData.SaveProjectData();
        }

        private void openProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog OFD = new OpenFileDialog())
            {
                OFD.Filter = "vtp files (*.vtp)|*.vtp";
                OFD.RestoreDirectory = true;
                OFD.Multiselect = false;

                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(OFD.FileName))
                    {
                        ProjectData.OpenProjectData(OFD.FileName);
                    }
                    else
                    {
                        MessageBox.Show(string.Format("Project file {0} not found", OFD.FileName));
                        return;
                    }
                }
            }
        }
    }
}
