﻿
namespace ManagementApp
{
    partial class HoneycombInfo
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblNumberOfCells = new System.Windows.Forms.Label();
            this.lbGuests = new System.Windows.Forms.ListBox();
            this.lbAcceptedBeeTypes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(22, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblNumberOfCells
            // 
            this.lblNumberOfCells.AutoSize = true;
            this.lblNumberOfCells.Location = new System.Drawing.Point(22, 151);
            this.lblNumberOfCells.Name = "lblNumberOfCells";
            this.lblNumberOfCells.Size = new System.Drawing.Size(80, 13);
            this.lblNumberOfCells.TabIndex = 2;
            this.lblNumberOfCells.Text = "Number of cells";
            // 
            // lbGuests
            // 
            this.lbGuests.FormattingEnabled = true;
            this.lbGuests.Location = new System.Drawing.Point(25, 167);
            this.lbGuests.Name = "lbGuests";
            this.lbGuests.Size = new System.Drawing.Size(363, 82);
            this.lbGuests.TabIndex = 3;
            // 
            // lbAcceptedBeeTypes
            // 
            this.lbAcceptedBeeTypes.FormattingEnabled = true;
            this.lbAcceptedBeeTypes.Location = new System.Drawing.Point(22, 51);
            this.lbAcceptedBeeTypes.Name = "lbAcceptedBeeTypes";
            this.lbAcceptedBeeTypes.Size = new System.Drawing.Size(363, 82);
            this.lbAcceptedBeeTypes.TabIndex = 4;
            // 
            // HoneycombInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 287);
            this.Controls.Add(this.lbAcceptedBeeTypes);
            this.Controls.Add(this.lbGuests);
            this.Controls.Add(this.lblNumberOfCells);
            this.Controls.Add(this.lblName);
            this.Name = "HoneycombInfo";
            this.Text = "Honeycomb Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNumberOfCells;
        private System.Windows.Forms.ListBox lbGuests;
        private System.Windows.Forms.ListBox lbAcceptedBeeTypes;
    }
}