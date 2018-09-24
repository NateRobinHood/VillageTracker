namespace VillageTracker.Dialogs
{
    partial class AddNpcDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxBasics = new System.Windows.Forms.GroupBox();
            this.lblCurrentLocation = new System.Windows.Forms.Label();
            this.cbCurrentLocation = new System.Windows.Forms.ComboBox();
            this.labelName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.lblGenderOther = new System.Windows.Forms.Label();
            this.txtGenderOther = new System.Windows.Forms.TextBox();
            this.txtRaceOther = new System.Windows.Forms.TextBox();
            this.lblRaceOther = new System.Windows.Forms.Label();
            this.cbRace = new System.Windows.Forms.ComboBox();
            this.lblRace = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblAlignment = new System.Windows.Forms.Label();
            this.pictureBoxNpcImage = new System.Windows.Forms.PictureBox();
            this.groupBoxBasics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNpcImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxBasics
            // 
            this.groupBoxBasics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBasics.Controls.Add(this.comboBox1);
            this.groupBoxBasics.Controls.Add(this.lblAlignment);
            this.groupBoxBasics.Controls.Add(this.txtRaceOther);
            this.groupBoxBasics.Controls.Add(this.lblRaceOther);
            this.groupBoxBasics.Controls.Add(this.cbRace);
            this.groupBoxBasics.Controls.Add(this.lblRace);
            this.groupBoxBasics.Controls.Add(this.txtGenderOther);
            this.groupBoxBasics.Controls.Add(this.lblGenderOther);
            this.groupBoxBasics.Controls.Add(this.cbGender);
            this.groupBoxBasics.Controls.Add(this.lblGender);
            this.groupBoxBasics.Controls.Add(this.txtName);
            this.groupBoxBasics.Controls.Add(this.labelName);
            this.groupBoxBasics.Controls.Add(this.cbCurrentLocation);
            this.groupBoxBasics.Controls.Add(this.lblCurrentLocation);
            this.groupBoxBasics.Location = new System.Drawing.Point(12, 12);
            this.groupBoxBasics.Name = "groupBoxBasics";
            this.groupBoxBasics.Size = new System.Drawing.Size(416, 217);
            this.groupBoxBasics.TabIndex = 0;
            this.groupBoxBasics.TabStop = false;
            this.groupBoxBasics.Text = "Basics";
            // 
            // lblCurrentLocation
            // 
            this.lblCurrentLocation.Location = new System.Drawing.Point(6, 16);
            this.lblCurrentLocation.Name = "lblCurrentLocation";
            this.lblCurrentLocation.Size = new System.Drawing.Size(88, 21);
            this.lblCurrentLocation.TabIndex = 0;
            this.lblCurrentLocation.Text = "Current Location:";
            this.lblCurrentLocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbCurrentLocation
            // 
            this.cbCurrentLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCurrentLocation.FormattingEnabled = true;
            this.cbCurrentLocation.Location = new System.Drawing.Point(100, 16);
            this.cbCurrentLocation.Name = "cbCurrentLocation";
            this.cbCurrentLocation.Size = new System.Drawing.Size(310, 21);
            this.cbCurrentLocation.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(6, 43);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(88, 21);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(100, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(310, 20);
            this.txtName.TabIndex = 3;
            // 
            // lblGender
            // 
            this.lblGender.Location = new System.Drawing.Point(6, 69);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(88, 21);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Gender:";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbGender
            // 
            this.cbGender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(100, 69);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(310, 21);
            this.cbGender.TabIndex = 5;
            // 
            // lblGenderOther
            // 
            this.lblGenderOther.Location = new System.Drawing.Point(6, 96);
            this.lblGenderOther.Name = "lblGenderOther";
            this.lblGenderOther.Size = new System.Drawing.Size(88, 21);
            this.lblGenderOther.TabIndex = 6;
            this.lblGenderOther.Text = "Gender Other:";
            this.lblGenderOther.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGenderOther
            // 
            this.txtGenderOther.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGenderOther.Enabled = false;
            this.txtGenderOther.Location = new System.Drawing.Point(100, 96);
            this.txtGenderOther.Name = "txtGenderOther";
            this.txtGenderOther.Size = new System.Drawing.Size(310, 20);
            this.txtGenderOther.TabIndex = 7;
            // 
            // txtRaceOther
            // 
            this.txtRaceOther.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRaceOther.Enabled = false;
            this.txtRaceOther.Location = new System.Drawing.Point(100, 149);
            this.txtRaceOther.Name = "txtRaceOther";
            this.txtRaceOther.Size = new System.Drawing.Size(310, 20);
            this.txtRaceOther.TabIndex = 11;
            // 
            // lblRaceOther
            // 
            this.lblRaceOther.Location = new System.Drawing.Point(6, 149);
            this.lblRaceOther.Name = "lblRaceOther";
            this.lblRaceOther.Size = new System.Drawing.Size(88, 21);
            this.lblRaceOther.TabIndex = 10;
            this.lblRaceOther.Text = "Race Other:";
            this.lblRaceOther.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbRace
            // 
            this.cbRace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRace.FormattingEnabled = true;
            this.cbRace.Location = new System.Drawing.Point(100, 122);
            this.cbRace.Name = "cbRace";
            this.cbRace.Size = new System.Drawing.Size(310, 21);
            this.cbRace.TabIndex = 9;
            // 
            // lblRace
            // 
            this.lblRace.Location = new System.Drawing.Point(6, 122);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(88, 21);
            this.lblRace.TabIndex = 8;
            this.lblRace.Text = "Race:";
            this.lblRace.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(100, 175);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(310, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // lblAlignment
            // 
            this.lblAlignment.Location = new System.Drawing.Point(6, 175);
            this.lblAlignment.Name = "lblAlignment";
            this.lblAlignment.Size = new System.Drawing.Size(88, 21);
            this.lblAlignment.TabIndex = 12;
            this.lblAlignment.Text = "Alignment:";
            this.lblAlignment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBoxNpcImage
            // 
            this.pictureBoxNpcImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxNpcImage.Cursor = System.Windows.Forms.Cursors.Help;
            this.pictureBoxNpcImage.Location = new System.Drawing.Point(434, 12);
            this.pictureBoxNpcImage.Name = "pictureBoxNpcImage";
            this.pictureBoxNpcImage.Size = new System.Drawing.Size(217, 217);
            this.pictureBoxNpcImage.TabIndex = 1;
            this.pictureBoxNpcImage.TabStop = false;
            // 
            // AddNpcDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 562);
            this.Controls.Add(this.pictureBoxNpcImage);
            this.Controls.Add(this.groupBoxBasics);
            this.Name = "AddNpcDialog";
            this.Text = "Add/Edit Npc";
            this.groupBoxBasics.ResumeLayout(false);
            this.groupBoxBasics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNpcImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBasics;
        private System.Windows.Forms.Label lblCurrentLocation;
        private System.Windows.Forms.ComboBox cbCurrentLocation;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtGenderOther;
        private System.Windows.Forms.Label lblGenderOther;
        private System.Windows.Forms.TextBox txtRaceOther;
        private System.Windows.Forms.Label lblRaceOther;
        private System.Windows.Forms.ComboBox cbRace;
        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblAlignment;
        private System.Windows.Forms.PictureBox pictureBoxNpcImage;
    }
}