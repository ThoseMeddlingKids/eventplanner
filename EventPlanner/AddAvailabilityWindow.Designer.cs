namespace WindowsFormsApplication1
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
            this.eventComboBox = new System.Windows.Forms.ComboBox();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.briefBox = new System.Windows.Forms.TextBox();
            this.locationBox = new System.Windows.Forms.TextBox();
            this.hostBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.attendeesBox = new System.Windows.Forms.TextBox();
            this.AttendeesLabel = new System.Windows.Forms.Label();
            this.capacityLabel = new System.Windows.Forms.Label();
            this.capacityBox = new System.Windows.Forms.TextBox();
            this.capacityWarning = new System.Windows.Forms.Label();
            this.selectAllButton = new System.Windows.Forms.Button();
            this.taskPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveAvailabilityButton
            // 
            this.saveAvailabilityButton.Location = new System.Drawing.Point(42, 834);
            this.saveAvailabilityButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveAvailabilityButton.Name = "saveAvailabilityButton";
            this.saveAvailabilityButton.Size = new System.Drawing.Size(236, 44);
            this.saveAvailabilityButton.TabIndex = 1;
            this.saveAvailabilityButton.Text = "Save";
            this.saveAvailabilityButton.UseVisualStyleBackColor = true;
            this.saveAvailabilityButton.Click += new System.EventHandler(this.saveAvailabilityButton_Click);
            // 
            // eventComboBox
            // 
            this.eventComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eventComboBox.FormattingEnabled = true;
            this.eventComboBox.Location = new System.Drawing.Point(46, 58);
            this.eventComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.eventComboBox.Name = "eventComboBox";
            this.eventComboBox.Size = new System.Drawing.Size(490, 33);
            this.eventComboBox.TabIndex = 2;
            this.eventComboBox.SelectedIndexChanged += new System.EventHandler(this.eventComboBox_SelectedIndexChanged);
            // 
            // flowPanel
            // 
            this.flowPanel.AutoScroll = true;
            this.flowPanel.Location = new System.Drawing.Point(42, 254);
            this.flowPanel.Margin = new System.Windows.Forms.Padding(4);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(494, 479);
            this.flowPanel.TabIndex = 3;
            // 
            // briefBox
            // 
            this.briefBox.Location = new System.Drawing.Point(50, 177);
            this.briefBox.Margin = new System.Windows.Forms.Padding(4);
            this.briefBox.Name = "briefBox";
            this.briefBox.ReadOnly = true;
            this.briefBox.Size = new System.Drawing.Size(486, 31);
            this.briefBox.TabIndex = 4;
            // 
            // locationBox
            // 
            this.locationBox.Location = new System.Drawing.Point(266, 117);
            this.locationBox.Margin = new System.Windows.Forms.Padding(4);
            this.locationBox.Name = "locationBox";
            this.locationBox.ReadOnly = true;
            this.locationBox.Size = new System.Drawing.Size(144, 31);
            this.locationBox.TabIndex = 5;
            // 
            // hostBox
            // 
            this.hostBox.Location = new System.Drawing.Point(50, 117);
            this.hostBox.Margin = new System.Windows.Forms.Padding(4);
            this.hostBox.Name = "hostBox";
            this.hostBox.ReadOnly = true;
            this.hostBox.Size = new System.Drawing.Size(204, 31);
            this.hostBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Host";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Description";
            // 
            // attendeesBox
            // 
            this.attendeesBox.Location = new System.Drawing.Point(613, 80);
            this.attendeesBox.Margin = new System.Windows.Forms.Padding(4);
            this.attendeesBox.Multiline = true;
            this.attendeesBox.Name = "attendeesBox";
            this.attendeesBox.ReadOnly = true;
            this.attendeesBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.attendeesBox.Size = new System.Drawing.Size(490, 162);
            this.attendeesBox.TabIndex = 10;
            // 
            // AttendeesLabel
            // 
            this.AttendeesLabel.AutoSize = true;
            this.AttendeesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendeesLabel.Location = new System.Drawing.Point(610, 58);
            this.AttendeesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AttendeesLabel.Name = "AttendeesLabel";
            this.AttendeesLabel.Size = new System.Drawing.Size(72, 17);
            this.AttendeesLabel.TabIndex = 11;
            this.AttendeesLabel.Text = "Attendees";
            // 
            // capacityLabel
            // 
            this.capacityLabel.AutoSize = true;
            this.capacityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacityLabel.Location = new System.Drawing.Point(420, 102);
            this.capacityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.capacityLabel.Name = "capacityLabel";
            this.capacityLabel.Size = new System.Drawing.Size(62, 17);
            this.capacityLabel.TabIndex = 13;
            this.capacityLabel.Text = "Capacity";
            // 
            // capacityBox
            // 
            this.capacityBox.Location = new System.Drawing.Point(422, 117);
            this.capacityBox.Margin = new System.Windows.Forms.Padding(4);
            this.capacityBox.Name = "capacityBox";
            this.capacityBox.ReadOnly = true;
            this.capacityBox.Size = new System.Drawing.Size(114, 31);
            this.capacityBox.TabIndex = 12;
            // 
            // capacityWarning
            // 
            this.capacityWarning.AutoSize = true;
            this.capacityWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacityWarning.ForeColor = System.Drawing.Color.DarkGray;
            this.capacityWarning.Location = new System.Drawing.Point(24, 17);
            this.capacityWarning.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.capacityWarning.Name = "capacityWarning";
            this.capacityWarning.Size = new System.Drawing.Size(327, 24);
            this.capacityWarning.TabIndex = 14;
            this.capacityWarning.Text = "Join Events That Meet Your Schedule";
            // 
            // selectAllButton
            // 
            this.selectAllButton.Location = new System.Drawing.Point(42, 759);
            this.selectAllButton.Margin = new System.Windows.Forms.Padding(6);
            this.selectAllButton.Name = "selectAllButton";
            this.selectAllButton.Size = new System.Drawing.Size(150, 44);
            this.selectAllButton.TabIndex = 15;
            this.selectAllButton.Text = "Select All";
            this.selectAllButton.UseVisualStyleBackColor = true;
            this.selectAllButton.Click += new System.EventHandler(this.selectAllButton_Click);
            // 
            // taskPanel
            // 
            this.taskPanel.Location = new System.Drawing.Point(613, 321);
            this.taskPanel.Name = "taskPanel";
            this.taskPanel.Size = new System.Drawing.Size(490, 412);
            this.taskPanel.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(613, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tasks";
            // 
            // AddAvailabilityWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 1071);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.taskPanel);
            this.Controls.Add(this.selectAllButton);
            this.Controls.Add(this.capacityWarning);
            this.Controls.Add(this.capacityLabel);
            this.Controls.Add(this.capacityBox);
            this.Controls.Add(this.AttendeesLabel);
            this.Controls.Add(this.attendeesBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hostBox);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.briefBox);
            this.Controls.Add(this.flowPanel);
            this.Controls.Add(this.eventComboBox);
            this.Controls.Add(this.saveAvailabilityButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddAvailabilityWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Availability";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button saveAvailabilityButton;
        private System.Windows.Forms.ComboBox eventComboBox;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.TextBox briefBox;
        private System.Windows.Forms.TextBox locationBox;
        private System.Windows.Forms.TextBox hostBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox attendeesBox;
        private System.Windows.Forms.Label AttendeesLabel;
        private System.Windows.Forms.Label capacityLabel;
        private System.Windows.Forms.TextBox capacityBox;
        private System.Windows.Forms.Label capacityWarning;
        private System.Windows.Forms.Button selectAllButton;
        private System.Windows.Forms.FlowLayoutPanel taskPanel;
        private System.Windows.Forms.Label label4;
    }
}