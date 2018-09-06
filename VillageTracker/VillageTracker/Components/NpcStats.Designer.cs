namespace VillageTracker.Components
{
    partial class NpcStats
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
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.npcTitleCard = new VillageTracker.Components.NpcTitleCard();
            this.npcStatCard1 = new VillageTracker.Components.NpcStatCard();
            this.tableLayoutPanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.npcTitleCard, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.npcStatCard1, 0, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(406, 560);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // npcTitleCard
            // 
            this.npcTitleCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(241)))), ((int)(((byte)(220)))));
            this.npcTitleCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.npcTitleCard.Location = new System.Drawing.Point(3, 3);
            this.npcTitleCard.Name = "npcTitleCard";
            this.npcTitleCard.NpcInfo = "Medium Humanoid (Human), Lawful Good";
            this.npcTitleCard.NpcName = "Niel Patrick Carter";
            this.npcTitleCard.Size = new System.Drawing.Size(400, 69);
            this.npcTitleCard.TabIndex = 0;
            // 
            // npcStatCard1
            // 
            this.npcStatCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(241)))), ((int)(((byte)(220)))));
            this.npcStatCard1.Location = new System.Drawing.Point(3, 78);
            this.npcStatCard1.Name = "npcStatCard1";
            this.npcStatCard1.Size = new System.Drawing.Size(400, 119);
            this.npcStatCard1.TabIndex = 1;
            // 
            // NpcStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "NpcStats";
            this.Size = new System.Drawing.Size(406, 560);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private NpcTitleCard npcTitleCard;
        private NpcStatCard npcStatCard1;
    }
}
