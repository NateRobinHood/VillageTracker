using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace VillageTracker.Data
{
    public static class ProjectData
    {
        //Constants
        public static string AllNpcsTabName = "All Npcs";
        private static string XML_ROOT = "village_tracker_project_data";
        private static string XML_NPC_ELEMENT = "npc_data";
        private static string XML_LOCATION_ELEMENT = "location_data";

        //Public Events
        public static event EventHandler<OnProjectChangedEventArgs> OnProjectDataChanged;
        public static event EventHandler OnProjectLoaded;

        //Private Variables
        private static string m_ProjectPath = string.Empty;
        private static bool m_LoadingProject = false;
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
        public static void SaveProjectData(string path = "")
        {
            string saveProjectFilePath = path;
            if (saveProjectFilePath == string.Empty && m_ProjectPath != string.Empty)
            {
                saveProjectFilePath = m_ProjectPath;
            }
            else if(path == string.Empty && m_ProjectPath == string.Empty)
            {
                using (SaveFileDialog SFD = new SaveFileDialog())
                {
                    SFD.Filter = "vtp files (*.vtp) | *.vtp";
                    SFD.RestoreDirectory = true;

                    if (SFD.ShowDialog() == DialogResult.OK)
                    {
                        saveProjectFilePath = SFD.FileName;
                    }
                }
            }

            XElement rootElement = new XElement(XML_ROOT);
            XElement npcData = new XElement(XML_NPC_ELEMENT);
            XElement locationData = new XElement(XML_LOCATION_ELEMENT);

            //Serialize Npc Data
            XmlSerializer npcSerializer = new XmlSerializer(typeof(NpcList));
            using (StringWriter sw = new StringWriter())
            {
                using (XmlWriter xw = XmlWriter.Create(sw))
                {
                    npcSerializer.Serialize(xw, m_Npcs);
                    npcData.Add(XDocument.Parse(sw.ToString()).Root);
                }
            }

            //Serialize Location Data
            XmlSerializer locationSerializer = new XmlSerializer(typeof(LocationList));
            using (StringWriter sw = new StringWriter())
            {
                using (XmlWriter xw = XmlWriter.Create(sw))
                {
                    locationSerializer.Serialize(xw, m_Locations);
                    locationData.Add(XDocument.Parse(sw.ToString()).Root);
                }
            }

            rootElement.Add(npcData);
            rootElement.Add(locationData);
            rootElement.Save(saveProjectFilePath);
        }

        public static void OpenProjectData(string path)
        {
            m_LoadingProject = true;
            m_ProjectPath = path;

            //Open Document
            XDocument projectDataXml = XDocument.Load(path);

            XElement rootElement = projectDataXml.Root;
            if (rootElement == null || rootElement.Name.LocalName != XML_ROOT)
            {
                MessageBox.Show($"The file {path} is an invalid project file", "Invalid Project File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                m_LoadingProject = false;
                return;
            }

            XElement npcData = rootElement.Element(XML_NPC_ELEMENT);
            if (npcData == null)
            {
                MessageBox.Show($"The file {path} is an invalid project file", "Invalid Project File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                m_LoadingProject = false;
                return;
            }

            XElement locationData = rootElement.Element(XML_LOCATION_ELEMENT);
            if (npcData == null)
            {
                MessageBox.Show($"The file {path} is an invalid project file", "Invalid Project File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                m_LoadingProject = false;
                return;
            }

            //Deserialize Npc Data
            XmlSerializer npcDataSerializer = new XmlSerializer(typeof(NpcList));
            using (TextReader reader = new StringReader(npcData.Element("ArrayOfNpcData").ToString()))
            {
                try
                {
                    m_Npcs = (NpcList)npcDataSerializer.Deserialize(reader);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"The file {path} is an invalid project file\n{ex.ToString()}", "Invalid Project File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    m_LoadingProject = false;
                    return;
                }
            }

            //Deserialize Location Data
            XmlSerializer locationDataSerializer = new XmlSerializer(typeof(LocationList));
            using (TextReader reader = new StringReader(locationData.Element("ArrayOfLocationData").ToString()))
            {
                try
                { 
                    m_Locations = (LocationList)locationDataSerializer.Deserialize(reader);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"The file {path} is an invalid project file\n{ex.ToString()}", "Invalid Project File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    m_LoadingProject = false;
                    return;
                }
        }

            m_LoadingProject = false;
            OnProjectLoaded?.Invoke(null, new EventArgs());
        }

        //Event Handlers
        private static void Npcs_OnNpcRemoved(object sender, OnNpcAddedRemovedArgs e)
        {
            if (!m_LoadingProject)
                OnProjectDataChanged?.Invoke(sender, new OnProjectChangedEventArgs(OnProjectChangedEventArgs.ProjectChangedDataTypes.Npc));
        }

        private static void Npcs_OnNpcAdded(object sender, OnNpcAddedRemovedArgs e)
        {
            if(!m_LoadingProject)
                OnProjectDataChanged?.Invoke(sender, new OnProjectChangedEventArgs(OnProjectChangedEventArgs.ProjectChangedDataTypes.Npc));
        }

        private static void Locations_OnLocationRemoved(object sender, OnLocationAddedRemovedArgs e)
        {
            if (!m_LoadingProject)
                OnProjectDataChanged?.Invoke(sender, new OnProjectChangedEventArgs(OnProjectChangedEventArgs.ProjectChangedDataTypes.Location));
        }

        private static void Locations_OnLocationAdded(object sender, OnLocationAddedRemovedArgs e)
        {
            if (!m_LoadingProject)
                OnProjectDataChanged?.Invoke(sender, new OnProjectChangedEventArgs(OnProjectChangedEventArgs.ProjectChangedDataTypes.Location));
        }
    }
}
