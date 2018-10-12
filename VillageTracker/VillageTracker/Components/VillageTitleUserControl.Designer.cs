namespace VillageTracker.Components
{
    partial class VillageTitleUserControl
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
            this.lblVillageTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblVillageTitle
            // 
            this.lblVillageTitle.AutoSize = true;
            this.lblVillageTitle.Font = new System.Drawing.Font("Microsoft Uighur", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVillageTitle.Location = new System.Drawing.Point(12, 14);
            this.lblVillageTitle.Name = "lblVillageTitle";
            this.lblVillageTitle.Size = new System.Drawing.Size(213, 70);
            this.lblVillageTitle.TabIndex = 0;
            this.lblVillageTitle.Text = "Village Title";
            // 
            // VillageTitleUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblVillageTitle);
            this.Name = "VillageTitleUserControl";
            this.Size = new System.Drawing.Size(750, 120);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVillageTitle;
    }
}
