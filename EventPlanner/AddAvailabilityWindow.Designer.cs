﻿namespace WindowsFormsApplication1
{
    partial class AddAvailabilityWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAvailabilityWindow));
            this.saveAvailabilityButton = new System.Windows.Forms.Button();
            this.timeSlotComboBox = new System.Windows.Forms.ComboBox();
            this.eventComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // saveAvailabilityButton
            // 
            this.saveAvailabilityButton.Location = new System.Drawing.Point(81, 226);
            this.saveAvailabilityButton.Name = "saveAvailabilityButton";
            this.saveAvailabilityButton.Size = new System.Drawing.Size(118, 23);
            this.saveAvailabilityButton.TabIndex = 1;
            this.saveAvailabilityButton.Text = "Save Availability";
            this.saveAvailabilityButton.UseVisualStyleBackColor = true;
            // 
            // timeSlotComboBox
            // 
            this.timeSlotComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeSlotComboBox.FormattingEnabled = true;
            this.timeSlotComboBox.Location = new System.Drawing.Point(25, 86);
            this.timeSlotComboBox.Name = "timeSlotComboBox";
            this.timeSlotComboBox.Size = new System.Drawing.Size(247, 21);
            this.timeSlotComboBox.TabIndex = 0;
            // 
            // eventComboBox
            // 
            this.eventComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eventComboBox.FormattingEnabled = true;
            this.eventComboBox.Location = new System.Drawing.Point(25, 32);
            this.eventComboBox.Name = "eventComboBox";
            this.eventComboBox.Size = new System.Drawing.Size(247, 21);
            this.eventComboBox.TabIndex = 2;
            // 
            // AddAvailabilityWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.eventComboBox);
            this.Controls.Add(this.saveAvailabilityButton);
            this.Controls.Add(this.timeSlotComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.Name = "AddAvailabilityWindow";
            this.Text = "AddAvailabilityWindow";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button saveAvailabilityButton;
        private System.Windows.Forms.ComboBox timeSlotComboBox;
        private System.Windows.Forms.ComboBox eventComboBox;
    }
}