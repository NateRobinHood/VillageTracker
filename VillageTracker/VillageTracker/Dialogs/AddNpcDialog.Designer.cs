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
            this.cbAlignment = new System.Windows.Forms.ComboBox();
            this.lblAlignment = new System.Windows.Forms.Label();
            this.txtRaceOther = new System.Windows.Forms.TextBox();
            this.lblRaceOther = new System.Windows.Forms.Label();
            this.cbRace = new System.Windows.Forms.ComboBox();
            this.lblRace = new System.Windows.Forms.Label();
            this.txtGenderOther = new System.Windows.Forms.TextBox();
            this.lblGenderOther = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.cbCurrentLocation = new System.Windows.Forms.ComboBox();
            this.lblCurrentLocation = new System.Windows.Forms.Label();
            this.pictureBoxNpcImage = new System.Windows.Forms.PictureBox();
            this.rtbAppearance = new System.Windows.Forms.RichTextBox();
            this.groupBoxAppearance = new System.Windows.Forms.GroupBox();
            this.rtbBackground = new System.Windows.Forms.RichTextBox();
            this.groupBoxBackground = new System.Windows.Forms.GroupBox();
            this.groupBoxMotivations = new System.Windows.Forms.GroupBox();
            this.rtbMotivations = new System.Windows.Forms.RichTextBox();
            this.groupBoxProfession = new System.Windows.Forms.GroupBox();
            this.rtbProfession = new System.Windows.Forms.RichTextBox();
            this.groupBoxStrongestSkills = new System.Windows.Forms.GroupBox();
            this.rtbStrongestSkills = new System.Windows.Forms.RichTextBox();
            this.groupBoxWeakestSkills = new System.Windows.Forms.GroupBox();
            this.rtbWeakestSkills = new System.Windows.Forms.RichTextBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.groupBoxDescription = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.groupBoxBasics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNpcImage)).BeginInit();
            this.groupBoxAppearance.SuspendLayout();
            this.groupBoxBackground.SuspendLayout();
            this.groupBoxMotivations.SuspendLayout();
            this.groupBoxProfession.SuspendLayout();
            this.groupBoxStrongestSkills.SuspendLayout();
            this.groupBoxWeakestSkills.SuspendLayout();
            this.groupBoxDescription.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBasics
            // 
            this.groupBoxBasics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBasics.Controls.Add(this.cbAlignment);
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
            this.groupBoxBasics.Size = new System.Drawing.Size(426, 217);
            this.groupBoxBasics.TabIndex = 0;
            this.groupBoxBasics.TabStop = false;
            this.groupBoxBasics.Text = "Basics";
            // 
            // cbAlignment
            // 
            this.cbAlignment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlignment.FormattingEnabled = true;
            this.cbAlignment.Location = new System.Drawing.Point(100, 175);
            this.cbAlignment.Name = "cbAlignment";
            this.cbAlignment.Size = new System.Drawing.Size(320, 21);
            this.cbAlignment.TabIndex = 13;
            this.cbAlignment.SelectedIndexChanged += new System.EventHandler(this.cbAlignment_SelectedIndexChanged);
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
            // txtRaceOther
            // 
            this.txtRaceOther.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRaceOther.Enabled = false;
            this.txtRaceOther.Location = new System.Drawing.Point(100, 149);
            this.txtRaceOther.Name = "txtRaceOther";
            this.txtRaceOther.Size = new System.Drawing.Size(320, 20);
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
            this.cbRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRace.FormattingEnabled = true;
            this.cbRace.Location = new System.Drawing.Point(100, 122);
            this.cbRace.Name = "cbRace";
            this.cbRace.Size = new System.Drawing.Size(320, 21);
            this.cbRace.TabIndex = 9;
            this.cbRace.SelectedIndexChanged += new System.EventHandler(this.cbRace_SelectedIndexChanged);
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
            // txtGenderOther
            // 
            this.txtGenderOther.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGenderOther.Enabled = false;
            this.txtGenderOther.Location = new System.Drawing.Point(100, 96);
            this.txtGenderOther.Name = "txtGenderOther";
            this.txtGenderOther.Size = new System.Drawing.Size(320, 20);
            this.txtGenderOther.TabIndex = 7;
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
            // cbGender
            // 
            this.cbGender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(100, 69);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(320, 21);
            this.cbGender.TabIndex = 5;
            this.cbGender.SelectedIndexChanged += new System.EventHandler(this.cbGender_SelectedIndexChanged);
            this.cbGender.SelectedValueChanged += new System.EventHandler(this.cbGender_SelectedValueChanged);
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
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(100, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(320, 20);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
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
            // cbCurrentLocation
            // 
            this.cbCurrentLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCurrentLocation.FormattingEnabled = true;
            this.cbCurrentLocation.Location = new System.Drawing.Point(100, 16);
            this.cbCurrentLocation.Name = "cbCurrentLocation";
            this.cbCurrentLocation.Size = new System.Drawing.Size(320, 21);
            this.cbCurrentLocation.TabIndex = 1;
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
            // pictureBoxNpcImage
            // 
            this.pictureBoxNpcImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxNpcImage.Cursor = System.Windows.Forms.Cursors.Help;
            this.pictureBoxNpcImage.Image = global::VillageTracker.Properties.Resources.DefaultNpcImage;
            this.pictureBoxNpcImage.Location = new System.Drawing.Point(444, 12);
            this.pictureBoxNpcImage.Name = "pictureBoxNpcImage";
            this.pictureBoxNpcImage.Size = new System.Drawing.Size(217, 217);
            this.pictureBoxNpcImage.TabIndex = 1;
            this.pictureBoxNpcImage.TabStop = false;
            this.pictureBoxNpcImage.Click += new System.EventHandler(this.pictureBoxNpcImage_Click);
            // 
            // rtbAppearance
            // 
            this.rtbAppearance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbAppearance.BackColor = System.Drawing.Color.White;
            this.rtbAppearance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbAppearance.Location = new System.Drawing.Point(6, 19);
            this.rtbAppearance.Name = "rtbAppearance";
            this.rtbAppearance.Size = new System.Drawing.Size(306, 39);
            this.rtbAppearance.TabIndex = 2;
            this.rtbAppearance.Text = "";
            this.rtbAppearance.TextChanged += new System.EventHandler(this.rtbAppearance_TextChanged);
            // 
            // groupBoxAppearance
            // 
            this.groupBoxAppearance.Controls.Add(this.rtbAppearance);
            this.groupBoxAppearance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAppearance.Location = new System.Drawing.Point(3, 3);
            this.groupBoxAppearance.Name = "groupBoxAppearance";
            this.groupBoxAppearance.Size = new System.Drawing.Size(318, 64);
            this.groupBoxAppearance.TabIndex = 3;
            this.groupBoxAppearance.TabStop = false;
            this.groupBoxAppearance.Text = "Appearance";
            // 
            // rtbBackground
            // 
            this.rtbBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbBackground.BackColor = System.Drawing.Color.White;
            this.rtbBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbBackground.Location = new System.Drawing.Point(6, 19);
            this.rtbBackground.Name = "rtbBackground";
            this.rtbBackground.Size = new System.Drawing.Size(307, 39);
            this.rtbBackground.TabIndex = 2;
            this.rtbBackground.Text = "";
            this.rtbBackground.TextChanged += new System.EventHandler(this.rtbBackground_TextChanged);
            // 
            // groupBoxBackground
            // 
            this.groupBoxBackground.Controls.Add(this.rtbBackground);
            this.groupBoxBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBackground.Location = new System.Drawing.Point(327, 3);
            this.groupBoxBackground.Name = "groupBoxBackground";
            this.groupBoxBackground.Size = new System.Drawing.Size(319, 64);
            this.groupBoxBackground.TabIndex = 4;
            this.groupBoxBackground.TabStop = false;
            this.groupBoxBackground.Text = "Background";
            // 
            // groupBoxMotivations
            // 
            this.groupBoxMotivations.Controls.Add(this.rtbMotivations);
            this.groupBoxMotivations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMotivations.Location = new System.Drawing.Point(3, 73);
            this.groupBoxMotivations.Name = "groupBoxMotivations";
            this.groupBoxMotivations.Size = new System.Drawing.Size(318, 64);
            this.groupBoxMotivations.TabIndex = 5;
            this.groupBoxMotivations.TabStop = false;
            this.groupBoxMotivations.Text = "Motivations";
            // 
            // rtbMotivations
            // 
            this.rtbMotivations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbMotivations.BackColor = System.Drawing.Color.White;
            this.rtbMotivations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbMotivations.Location = new System.Drawing.Point(6, 19);
            this.rtbMotivations.Name = "rtbMotivations";
            this.rtbMotivations.Size = new System.Drawing.Size(306, 39);
            this.rtbMotivations.TabIndex = 2;
            this.rtbMotivations.Text = "";
            this.rtbMotivations.TextChanged += new System.EventHandler(this.rtbMotivations_TextChanged);
            // 
            // groupBoxProfession
            // 
            this.groupBoxProfession.Controls.Add(this.rtbProfession);
            this.groupBoxProfession.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxProfession.Location = new System.Drawing.Point(327, 73);
            this.groupBoxProfession.Name = "groupBoxProfession";
            this.groupBoxProfession.Size = new System.Drawing.Size(319, 64);
            this.groupBoxProfession.TabIndex = 6;
            this.groupBoxProfession.TabStop = false;
            this.groupBoxProfession.Text = "Profession";
            // 
            // rtbProfession
            // 
            this.rtbProfession.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbProfession.BackColor = System.Drawing.Color.White;
            this.rtbProfession.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbProfession.Location = new System.Drawing.Point(6, 19);
            this.rtbProfession.Name = "rtbProfession";
            this.rtbProfession.Size = new System.Drawing.Size(307, 39);
            this.rtbProfession.TabIndex = 2;
            this.rtbProfession.Text = "";
            this.rtbProfession.TextChanged += new System.EventHandler(this.rtbProfession_TextChanged);
            // 
            // groupBoxStrongestSkills
            // 
            this.groupBoxStrongestSkills.Controls.Add(this.rtbStrongestSkills);
            this.groupBoxStrongestSkills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxStrongestSkills.Location = new System.Drawing.Point(3, 143);
            this.groupBoxStrongestSkills.Name = "groupBoxStrongestSkills";
            this.groupBoxStrongestSkills.Size = new System.Drawing.Size(318, 64);
            this.groupBoxStrongestSkills.TabIndex = 7;
            this.groupBoxStrongestSkills.TabStop = false;
            this.groupBoxStrongestSkills.Text = "Strongest Skills";
            // 
            // rtbStrongestSkills
            // 
            this.rtbStrongestSkills.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbStrongestSkills.BackColor = System.Drawing.Color.White;
            this.rtbStrongestSkills.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbStrongestSkills.Location = new System.Drawing.Point(6, 19);
            this.rtbStrongestSkills.Name = "rtbStrongestSkills";
            this.rtbStrongestSkills.Size = new System.Drawing.Size(306, 39);
            this.rtbStrongestSkills.TabIndex = 2;
            this.rtbStrongestSkills.Text = "";
            this.rtbStrongestSkills.TextChanged += new System.EventHandler(this.rtbStrongestSkills_TextChanged);
            // 
            // groupBoxWeakestSkills
            // 
            this.groupBoxWeakestSkills.Controls.Add(this.rtbWeakestSkills);
            this.groupBoxWeakestSkills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxWeakestSkills.Location = new System.Drawing.Point(327, 143);
            this.groupBoxWeakestSkills.Name = "groupBoxWeakestSkills";
            this.groupBoxWeakestSkills.Size = new System.Drawing.Size(319, 64);
            this.groupBoxWeakestSkills.TabIndex = 8;
            this.groupBoxWeakestSkills.TabStop = false;
            this.groupBoxWeakestSkills.Text = "Weakest Skills";
            // 
            // rtbWeakestSkills
            // 
            this.rtbWeakestSkills.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbWeakestSkills.BackColor = System.Drawing.Color.White;
            this.rtbWeakestSkills.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbWeakestSkills.Location = new System.Drawing.Point(6, 19);
            this.rtbWeakestSkills.Name = "rtbWeakestSkills";
            this.rtbWeakestSkills.Size = new System.Drawing.Size(307, 39);
            this.rtbWeakestSkills.TabIndex = 2;
            this.rtbWeakestSkills.Text = "";
            this.rtbWeakestSkills.TextChanged += new System.EventHandler(this.rtbWeakestSkills_TextChanged);
            // 
            // rtbDescription
            // 
            this.rtbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDescription.BackColor = System.Drawing.Color.White;
            this.rtbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbDescription.Location = new System.Drawing.Point(6, 19);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(631, 80);
            this.rtbDescription.TabIndex = 2;
            this.rtbDescription.Text = "";
            this.rtbDescription.TextChanged += new System.EventHandler(this.rtbDescription_TextChanged);
            // 
            // groupBoxDescription
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBoxDescription, 2);
            this.groupBoxDescription.Controls.Add(this.rtbDescription);
            this.groupBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDescription.Location = new System.Drawing.Point(3, 213);
            this.groupBoxDescription.Name = "groupBoxDescription";
            this.groupBoxDescription.Size = new System.Drawing.Size(643, 105);
            this.groupBoxDescription.TabIndex = 8;
            this.groupBoxDescription.TabStop = false;
            this.groupBoxDescription.Text = "Description";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBoxAppearance, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxDescription, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxBackground, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxStrongestSkills, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxProfession, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxMotivations, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxWeakestSkills, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 235);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(649, 321);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(586, 562);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 10;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(505, 562);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 11;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // AddNpcDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 595);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBoxNpcImage);
            this.Controls.Add(this.groupBoxBasics);
            this.Name = "AddNpcDialog";
            this.Text = "Add/Edit Npc";
            this.groupBoxBasics.ResumeLayout(false);
            this.groupBoxBasics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNpcImage)).EndInit();
            this.groupBoxAppearance.ResumeLayout(false);
            this.groupBoxBackground.ResumeLayout(false);
            this.groupBoxMotivations.ResumeLayout(false);
            this.groupBoxProfession.ResumeLayout(false);
            this.groupBoxStrongestSkills.ResumeLayout(false);
            this.groupBoxWeakestSkills.ResumeLayout(false);
            this.groupBoxDescription.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox cbAlignment;
        private System.Windows.Forms.Label lblAlignment;
        private System.Windows.Forms.PictureBox pictureBoxNpcImage;
        private System.Windows.Forms.RichTextBox rtbAppearance;
        private System.Windows.Forms.GroupBox groupBoxAppearance;
        private System.Windows.Forms.RichTextBox rtbBackground;
        private System.Windows.Forms.GroupBox groupBoxBackground;
        private System.Windows.Forms.GroupBox groupBoxMotivations;
        private System.Windows.Forms.RichTextBox rtbMotivations;
        private System.Windows.Forms.GroupBox groupBoxProfession;
        private System.Windows.Forms.RichTextBox rtbProfession;
        private System.Windows.Forms.GroupBox groupBoxStrongestSkills;
        private System.Windows.Forms.RichTextBox rtbStrongestSkills;
        private System.Windows.Forms.GroupBox groupBoxWeakestSkills;
        private System.Windows.Forms.RichTextBox rtbWeakestSkills;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.GroupBox groupBoxDescription;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdCancel;
    }
}