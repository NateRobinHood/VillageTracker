namespace VillageTracker.Components
{
    partial class VillageUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.npcList = new VillageTracker.Components.NpcList();
            this.npcStats = new VillageTracker.Components.NpcStats();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.npcList);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.AutoScroll = true;
            this.scMain.Panel2.Controls.Add(this.npcStats);
            this.scMain.Size = new System.Drawing.Size(1009, 577);
            this.scMain.SplitterDistance = 336;
            this.scMain.TabIndex = 0;
            // 
            // npcList
            // 
            this.npcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.npcList.Location = new System.Drawing.Point(0, 0);
            this.npcList.Name = "npcList";
            this.npcList.Size = new System.Drawing.Size(336, 577);
            this.npcList.TabIndex = 0;
            // 
            // npcStats
            // 
            this.npcStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(241)))), ((int)(((byte)(220)))));
            this.npcStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.npcStats.Location = new System.Drawing.Point(0, 0);
            this.npcStats.Name = "npcStats";
            this.npcStats.Size = new System.Drawing.Size(669, 577);
            this.npcStats.TabIndex = 0;
            // 
            // VillageUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scMain);
            this.Name = "VillageUserControl";
            this.Size = new System.Drawing.Size(1009, 577);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMain;
        private NpcList npcList;
        private NpcStats npcStats;
    }
}
