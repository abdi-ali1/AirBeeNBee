namespace ManagementApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlTopLeft = new System.Windows.Forms.GroupBox();
            this.btnCreateBooking = new System.Windows.Forms.Button();
            this.lbBeeGroups = new System.Windows.Forms.ListBox();
            this.pnlTopRight = new System.Windows.Forms.GroupBox();
            this.btnViewHoneycomb = new System.Windows.Forms.Button();
            this.tbNumberOfCells = new System.Windows.Forms.TextBox();
            this.cbBeeTypes = new System.Windows.Forms.ComboBox();
            this.lbHoneycombs = new System.Windows.Forms.ListBox();
            this.btnAddHoneycomb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlTopLeft.SuspendLayout();
            this.pnlTopRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::ManagementApp.Properties.Resources.Honeycomb;
            this.pbLogo.Location = new System.Drawing.Point(10, 286);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(255, 120);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // pnlTopLeft
            // 
            this.pnlTopLeft.Controls.Add(this.btnCreateBooking);
            this.pnlTopLeft.Controls.Add(this.lbBeeGroups);
            this.pnlTopLeft.Location = new System.Drawing.Point(10, 10);
            this.pnlTopLeft.Name = "pnlTopLeft";
            this.pnlTopLeft.Size = new System.Drawing.Size(311, 270);
            this.pnlTopLeft.TabIndex = 2;
            this.pnlTopLeft.TabStop = false;
            this.pnlTopLeft.Text = "Bee groups";
            // 
            // btnCreateBooking
            // 
            this.btnCreateBooking.Enabled = false;
            this.btnCreateBooking.Location = new System.Drawing.Point(19, 224);
            this.btnCreateBooking.Name = "btnCreateBooking";
            this.btnCreateBooking.Size = new System.Drawing.Size(144, 38);
            this.btnCreateBooking.TabIndex = 15;
            this.btnCreateBooking.Text = "Create booking";
            this.btnCreateBooking.UseVisualStyleBackColor = true;
            // 
            // lbBeeGroups
            // 
            this.lbBeeGroups.FormattingEnabled = true;
            this.lbBeeGroups.Location = new System.Drawing.Point(19, 19);
            this.lbBeeGroups.Name = "lbBeeGroups";
            this.lbBeeGroups.Size = new System.Drawing.Size(284, 199);
            this.lbBeeGroups.TabIndex = 1;
            this.lbBeeGroups.SelectedIndexChanged += new System.EventHandler(this.lbBeeGroups_SelectedIndexChanged);
            // 
            // pnlTopRight
            // 
            this.pnlTopRight.Controls.Add(this.btnViewHoneycomb);
            this.pnlTopRight.Controls.Add(this.tbNumberOfCells);
            this.pnlTopRight.Controls.Add(this.cbBeeTypes);
            this.pnlTopRight.Controls.Add(this.lbHoneycombs);
            this.pnlTopRight.Controls.Add(this.btnAddHoneycomb);
            this.pnlTopRight.Location = new System.Drawing.Point(342, 12);
            this.pnlTopRight.Name = "pnlTopRight";
            this.pnlTopRight.Size = new System.Drawing.Size(514, 371);
            this.pnlTopRight.TabIndex = 3;
            this.pnlTopRight.TabStop = false;
            this.pnlTopRight.Text = "Honeycombs";
            // 
            // btnViewHoneycomb
            // 
            this.btnViewHoneycomb.Enabled = false;
            this.btnViewHoneycomb.Location = new System.Drawing.Point(376, 220);
            this.btnViewHoneycomb.Name = "btnViewHoneycomb";
            this.btnViewHoneycomb.Size = new System.Drawing.Size(126, 40);
            this.btnViewHoneycomb.TabIndex = 2;
            this.btnViewHoneycomb.Text = "View info";
            this.btnViewHoneycomb.UseVisualStyleBackColor = true;
            // 
            // tbNumberOfCells
            // 
            this.tbNumberOfCells.Location = new System.Drawing.Point(12, 313);
            this.tbNumberOfCells.Name = "tbNumberOfCells";
            this.tbNumberOfCells.Size = new System.Drawing.Size(259, 20);
            this.tbNumberOfCells.TabIndex = 14;
            this.tbNumberOfCells.Text = "250";
            // 
            // cbBeeTypes
            // 
            this.cbBeeTypes.FormattingEnabled = true;
            this.cbBeeTypes.Location = new System.Drawing.Point(12, 275);
            this.cbBeeTypes.Name = "cbBeeTypes";
            this.cbBeeTypes.Size = new System.Drawing.Size(259, 21);
            this.cbBeeTypes.TabIndex = 13;
            this.cbBeeTypes.Text = "Bee types";
            this.cbBeeTypes.SelectedIndexChanged += new System.EventHandler(this.cbBeeTypes_SelectedIndexChanged);
            // 
            // lbHoneycombs
            // 
            this.lbHoneycombs.FormattingEnabled = true;
            this.lbHoneycombs.Location = new System.Drawing.Point(12, 17);
            this.lbHoneycombs.Name = "lbHoneycombs";
            this.lbHoneycombs.Size = new System.Drawing.Size(490, 186);
            this.lbHoneycombs.TabIndex = 2;
            // 
            // btnAddHoneycomb
            // 
            this.btnAddHoneycomb.Location = new System.Drawing.Point(12, 220);
            this.btnAddHoneycomb.Name = "btnAddHoneycomb";
            this.btnAddHoneycomb.Size = new System.Drawing.Size(135, 40);
            this.btnAddHoneycomb.TabIndex = 1;
            this.btnAddHoneycomb.Text = "Add honeycomb";
            this.btnAddHoneycomb.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 420);
            this.Controls.Add(this.pnlTopRight);
            this.Controls.Add(this.pnlTopLeft);
            this.Controls.Add(this.pbLogo);
            this.Name = "MainForm";
            this.Text = "AirBeeNBee Management";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlTopLeft.ResumeLayout(false);
            this.pnlTopRight.ResumeLayout(false);
            this.pnlTopRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.GroupBox pnlTopLeft;
        private System.Windows.Forms.ListBox lbBeeGroups;
        private System.Windows.Forms.GroupBox pnlTopRight;
        private System.Windows.Forms.ListBox lbHoneycombs;
        private System.Windows.Forms.Button btnAddHoneycomb;
        private System.Windows.Forms.Button btnCreateBooking;
        private System.Windows.Forms.TextBox tbNumberOfCells;
        private System.Windows.Forms.ComboBox cbBeeTypes;
        private System.Windows.Forms.Button btnViewHoneycomb;
    }
}
