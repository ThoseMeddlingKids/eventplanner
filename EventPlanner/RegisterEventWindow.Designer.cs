namespace WindowsFormsApplication1
{
    partial class RegisterEventWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterEventWindow));
            this.saveButton = new System.Windows.Forms.Button();
            this.addSlotButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.removeTimeSlotButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.AddTaskBtn = new System.Windows.Forms.Button();
            this.DeleteTaskBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.removeDay = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.AddDay = new System.Windows.Forms.Button();
            this.briefMessageText = new CueTextBox();
            this.locationText = new CueTextBox();
            this.nameTextBox = new CueTextBox();
            this.capacityText = new CueTextBox();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(967, 138);
            this.saveButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(149, 44);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // addSlotButton
            // 
            this.addSlotButton.Location = new System.Drawing.Point(56, 744);
            this.addSlotButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.addSlotButton.Name = "addSlotButton";
            this.addSlotButton.Size = new System.Drawing.Size(272, 44);
            this.addSlotButton.TabIndex = 9;
            this.addSlotButton.Text = "Add Time Slot";
            this.addSlotButton.UseVisualStyleBackColor = true;
            this.addSlotButton.Click += new System.EventHandler(this.addSlotButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(56, 539);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(548, 192);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // removeTimeSlotButton
            // 
            this.removeTimeSlotButton.Location = new System.Drawing.Point(339, 744);
            this.removeTimeSlotButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.removeTimeSlotButton.Name = "removeTimeSlotButton";
            this.removeTimeSlotButton.Size = new System.Drawing.Size(265, 44);
            this.removeTimeSlotButton.TabIndex = 8;
            this.removeTimeSlotButton.Text = "Remove Time Slot";
            this.removeTimeSlotButton.UseVisualStyleBackColor = true;
            this.removeTimeSlotButton.Click += new System.EventHandler(this.removeTimeSlotButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 508);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Start Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 508);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "End Time";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(28, 18);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(70, 25);
            this.dateLabel.TabIndex = 9;
            this.dateLabel.Text = "label3";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(56, 798);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(149, 44);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(689, 539);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(409, 192);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // AddTaskBtn
            // 
            this.AddTaskBtn.Location = new System.Drawing.Point(689, 749);
            this.AddTaskBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddTaskBtn.Name = "AddTaskBtn";
            this.AddTaskBtn.Size = new System.Drawing.Size(196, 39);
            this.AddTaskBtn.TabIndex = 15;
            this.AddTaskBtn.Text = "Create Task";
            this.AddTaskBtn.UseVisualStyleBackColor = true;
            this.AddTaskBtn.Click += new System.EventHandler(this.AddTaskBtn_Click);
            // 
            // DeleteTaskBtn
            // 
            this.DeleteTaskBtn.Location = new System.Drawing.Point(893, 749);
            this.DeleteTaskBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteTaskBtn.Name = "DeleteTaskBtn";
            this.DeleteTaskBtn.Size = new System.Drawing.Size(224, 39);
            this.DeleteTaskBtn.TabIndex = 16;
            this.DeleteTaskBtn.Text = "Delete Task";
            this.DeleteTaskBtn.UseVisualStyleBackColor = true;
            this.DeleteTaskBtn.Click += new System.EventHandler(this.DeleteTaskBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(684, 510);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Name of Task";
            // 
            // removeDay
            // 
            this.removeDay.Location = new System.Drawing.Point(619, 418);
            this.removeDay.Margin = new System.Windows.Forms.Padding(4);
            this.removeDay.Name = "removeDay";
            this.removeDay.Size = new System.Drawing.Size(499, 44);
            this.removeDay.TabIndex = 25;
            this.removeDay.Text = "Remove Day";
            this.removeDay.UseVisualStyleBackColor = true;
            this.removeDay.Click += new System.EventHandler(this.removeDay_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoScroll = true;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(56, 192);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1061, 205);
            this.flowLayoutPanel3.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 164);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Date(s)";
            // 
            // AddDay
            // 
            this.AddDay.Location = new System.Drawing.Point(56, 418);
            this.AddDay.Margin = new System.Windows.Forms.Padding(4);
            this.AddDay.Name = "AddDay";
            this.AddDay.Size = new System.Drawing.Size(555, 44);
            this.AddDay.TabIndex = 20;
            this.AddDay.Text = "Add Day";
            this.AddDay.UseVisualStyleBackColor = true;
            this.AddDay.Click += new System.EventHandler(this.AddDay_Click);
            // 
            // briefMessageText
            // 
            this.briefMessageText.Cue = "Description";
            this.briefMessageText.Location = new System.Drawing.Point(24, 98);
            this.briefMessageText.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.briefMessageText.Name = "briefMessageText";
            this.briefMessageText.Size = new System.Drawing.Size(1092, 31);
            this.briefMessageText.TabIndex = 4;
            // 
            // locationText
            // 
            this.locationText.Cue = "Location";
            this.locationText.Location = new System.Drawing.Point(451, 48);
            this.locationText.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.locationText.Name = "locationText";
            this.locationText.Size = new System.Drawing.Size(421, 31);
            this.locationText.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Cue = "Event Name";
            this.nameTextBox.Location = new System.Drawing.Point(24, 48);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(415, 31);
            this.nameTextBox.TabIndex = 1;
            // 
            // capacityText
            // 
            this.capacityText.Cue = "Capacity";
            this.capacityText.Location = new System.Drawing.Point(884, 49);
            this.capacityText.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.capacityText.Name = "capacityText";
            this.capacityText.Size = new System.Drawing.Size(232, 31);
            this.capacityText.TabIndex = 3;
            this.capacityText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.capacityText_KeyPress);
            // 
            // RegisterEventWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 839);
            this.Controls.Add(this.removeDay);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AddDay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DeleteTaskBtn);
            this.Controls.Add(this.AddTaskBtn);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.briefMessageText);
            this.Controls.Add(this.locationText);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.capacityText);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeTimeSlotButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.addSlotButton);
            this.Controls.Add(this.saveButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximumSize = new System.Drawing.Size(1200, 910);
            this.MinimumSize = new System.Drawing.Size(1200, 910);
            this.Name = "RegisterEventWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button addSlotButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button removeTimeSlotButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dateLabel;
        private CueTextBox capacityText;
        private CueTextBox nameTextBox;
        private CueTextBox locationText;
        private CueTextBox briefMessageText;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button AddTaskBtn;
        private System.Windows.Forms.Button DeleteTaskBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button removeDay;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddDay;
    }
}