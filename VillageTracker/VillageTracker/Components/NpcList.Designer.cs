namespace VillageTracker.Components
{
    partial class NpcList
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmdClearSearch = new System.Windows.Forms.Button();
            this.listViewCharacters = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 20);
            this.textBox1.TabIndex = 0;
            // 
            // cmdClearSearch
            // 
            this.cmdClearSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdClearSearch.Location = new System.Drawing.Point(239, 0);
            this.cmdClearSearch.Name = "cmdClearSearch";
            this.cmdClearSearch.Size = new System.Drawing.Size(21, 20);
            this.cmdClearSearch.TabIndex = 1;
            this.cmdClearSearch.Text = "X";
            this.cmdClearSearch.UseVisualStyleBackColor = true;
            // 
            // listViewCharacters
            // 
            this.listViewCharacters.Location = new System.Drawing.Point(0, 20);
            this.listViewCharacters.Name = "listViewCharacters";
            this.listViewCharacters.Size = new System.Drawing.Size(260, 410);
            this.listViewCharacters.TabIndex = 2;
            this.listViewCharacters.UseCompatibleStateImageBehavior = false;
            // 
            // NpcList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewCharacters);
            this.Controls.Add(this.cmdClearSearch);
            this.Controls.Add(this.textBox1);
            this.Name = "NpcList";
            this.Size = new System.Drawing.Size(260, 430);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cmdClearSearch;
        private System.Windows.Forms.ListView listViewCharacters;
    }
}
