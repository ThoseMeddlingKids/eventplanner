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
            this.startTimeBox = new System.Windows.Forms.ComboBox();
            this.endTimeBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.addSlotButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.removeTimeSlotButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.capacityText = new System.Windows.Forms.TextBox();
            this.capLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.newTask = new System.Windows.Forms.TextBox();
            this.AddTasks = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.briefMessageText = new CueTextBox();
            this.locationText = new CueTextBox();
            this.nameTextBox = new CueTextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // startTimeBox
            // 
            this.startTimeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startTimeBox.FormattingEnabled = true;
            this.startTimeBox.Location = new System.Drawing.Point(6, 6);
            this.startTimeBox.Margin = new System.Windows.Forms.Padding(6);
            this.startTimeBox.Name = "startTimeBox";
            this.startTimeBox.Size = new System.Drawing.Size(238, 33);
            this.startTimeBox.TabIndex = 5;
            // 
            // endTimeBox
            // 
            this.endTimeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.endTimeBox.FormattingEnabled = true;
            this.endTimeBox.Location = new System.Drawing.Point(256, 6);
            this.endTimeBox.Margin = new System.Windows.Forms.Padding(6);
            this.endTimeBox.Name = "endTimeBox";
            this.endTimeBox.Size = new System.Drawing.Size(238, 33);
            this.endTimeBox.TabIndex = 6;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(33, 377);
            this.saveButton.Margin = new System.Windows.Forms.Padding(6);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(150, 44);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // addSlotButton
            // 
            this.addSlotButton.Location = new System.Drawing.Point(554, 377);
            this.addSlotButton.Margin = new System.Windows.Forms.Padding(6);
            this.addSlotButton.Name = "addSlotButton";
            this.addSlotButton.Size = new System.Drawing.Size(238, 44);
            this.addSlotButton.TabIndex = 9;
            this.addSlotButton.Text = "Add Time Slot";
            this.addSlotButton.UseVisualStyleBackColor = true;
            this.addSlotButton.Click += new System.EventHandler(this.addSlotButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.startTimeBox);
            this.flowLayoutPanel1.Controls.Add(this.endTimeBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(528, 173);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(567, 192);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // removeTimeSlotButton
            // 
            this.removeTimeSlotButton.Location = new System.Drawing.Point(804, 377);
            this.removeTimeSlotButton.Margin = new System.Windows.Forms.Padding(6);
            this.removeTimeSlotButton.Name = "removeTimeSlotButton";
            this.removeTimeSlotButton.Size = new System.Drawing.Size(238, 44);
            this.removeTimeSlotButton.TabIndex = 8;
            this.removeTimeSlotButton.Text = "Remove Time Slot";
            this.removeTimeSlotButton.UseVisualStyleBackColor = true;
            this.removeTimeSlotButton.Click += new System.EventHandler(this.removeTimeSlotButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(529, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Start Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(779, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "End Time";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(28, 17);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(70, 25);
            this.dateLabel.TabIndex = 9;
            this.dateLabel.Text = "label3";
            // 
            // capacityText
            // 
            this.capacityText.Location = new System.Drawing.Point(448, 48);
            this.capacityText.Margin = new System.Windows.Forms.Padding(6);
            this.capacityText.Name = "capacityText";
            this.capacityText.Size = new System.Drawing.Size(78, 31);
            this.capacityText.TabIndex = 3;
            this.capacityText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.capacityText_KeyPress);
            // 
            // capLabel
            // 
            this.capLabel.AutoSize = true;
            this.capLabel.Location = new System.Drawing.Point(442, 17);
            this.capLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.capLabel.Name = "capLabel";
            this.capLabel.Size = new System.Drawing.Size(96, 25);
            this.capLabel.TabIndex = 13;
            this.capLabel.Text = "Capacity";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(214, 377);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(150, 44);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // newTask
            // 
            this.newTask.Location = new System.Drawing.Point(3, 3);
            this.newTask.Name = "newTask";
            this.newTask.Size = new System.Drawing.Size(259, 31);
            this.newTask.TabIndex = 14;
            // 
            // AddTasks
            // 
            this.AddTasks.Location = new System.Drawing.Point(24, 147);
            this.AddTasks.Name = "AddTasks";
            this.AddTasks.Size = new System.Drawing.Size(196, 46);
            this.AddTasks.TabIndex = 15;
            this.AddTasks.Text = "Add Task";
            this.AddTasks.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.newTask);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(24, 207);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(340, 132);
            this.flowLayoutPanel2.TabIndex = 16;
            // 
            // briefMessageText
            // 
            this.briefMessageText.Cue = "Description";
            this.briefMessageText.Location = new System.Drawing.Point(24, 98);
            this.briefMessageText.Margin = new System.Windows.Forms.Padding(6);
            this.briefMessageText.Name = "briefMessageText";
            this.briefMessageText.Size = new System.Drawing.Size(502, 31);
            this.briefMessageText.TabIndex = 4;
            // 
            // locationText
            // 
            this.locationText.Cue = "Location";
            this.locationText.Location = new System.Drawing.Point(230, 48);
            this.locationText.Margin = new System.Windows.Forms.Padding(6);
            this.locationText.Name = "locationText";
            this.locationText.Size = new System.Drawing.Size(196, 31);
            this.locationText.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Cue = "Event Name";
            this.nameTextBox.Location = new System.Drawing.Point(24, 48);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(196, 31);
            this.nameTextBox.TabIndex = 1;
            // 
            // RegisterEventWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 794);
            this.Controls.Add(this.AddTasks);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.briefMessageText);
            this.Controls.Add(this.locationText);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.capLabel);
            this.Controls.Add(this.capacityText);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeTimeSlotButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.addSlotButton);
            this.Controls.Add(this.saveButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "RegisterEventWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Event";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox startTimeBox;
        private System.Windows.Forms.ComboBox endTimeBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button addSlotButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button removeTimeSlotButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox capacityText;
        private System.Windows.Forms.Label capLabel;
        private CueTextBox nameTextBox;
        private CueTextBox locationText;
        private CueTextBox briefMessageText;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox newTask;
        private System.Windows.Forms.Button AddTasks;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}