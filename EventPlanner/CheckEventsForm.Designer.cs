namespace WindowsFormsApplication1
{
    /// <summary>
    /// A form allowing users to check the attendees of events created under their username.
    /// </summary>
    partial class CheckEventsForm
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
            this.yourEventsBox = new System.Windows.Forms.ComboBox();
            this.AttendeesLabel = new System.Windows.Forms.Label();
            this.attendeesBox = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // yourEventsBox
            // 
            this.yourEventsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yourEventsBox.FormattingEnabled = true;
            this.yourEventsBox.Location = new System.Drawing.Point(438, 75);
            this.yourEventsBox.Margin = new System.Windows.Forms.Padding(6);
            this.yourEventsBox.Name = "yourEventsBox";
            this.yourEventsBox.Size = new System.Drawing.Size(238, 33);
            this.yourEventsBox.TabIndex = 0;
            this.yourEventsBox.SelectedValueChanged += new System.EventHandler(this.yourEventsBox_SelectedValueChanged);
            // 
            // AttendeesLabel
            // 
            this.AttendeesLabel.AutoSize = true;
            this.AttendeesLabel.Location = new System.Drawing.Point(50, 167);
            this.AttendeesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AttendeesLabel.Name = "AttendeesLabel";
            this.AttendeesLabel.Size = new System.Drawing.Size(109, 25);
            this.AttendeesLabel.TabIndex = 13;
            this.AttendeesLabel.Text = "Attendees";
            // 
            // attendeesBox
            // 
            this.attendeesBox.Location = new System.Drawing.Point(56, 196);
            this.attendeesBox.Margin = new System.Windows.Forms.Padding(4);
            this.attendeesBox.Multiline = true;
            this.attendeesBox.Name = "attendeesBox";
            this.attendeesBox.ReadOnly = true;
            this.attendeesBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.attendeesBox.Size = new System.Drawing.Size(1060, 94);
            this.attendeesBox.TabIndex = 12;
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton.Location = new System.Drawing.Point(836, 40);
            this.BackButton.Margin = new System.Windows.Forms.Padding(6);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(284, 106);
            this.BackButton.TabIndex = 15;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(50, 121);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(192, 25);
            this.dateLabel.TabIndex = 16;
            this.dateLabel.Text = "Event has no date.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tasks";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(61, 342);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1055, 174);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // CheckEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 610);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AttendeesLabel);
            this.Controls.Add(this.attendeesBox);
            this.Controls.Add(this.yourEventsBox);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(1168, 681);
            this.MinimumSize = new System.Drawing.Size(1168, 681);
            this.Name = "CheckEventsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckEventsForm";
            this.Load += new System.EventHandler(this.CheckEventsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox yourEventsBox;
        private System.Windows.Forms.Label AttendeesLabel;
        private System.Windows.Forms.TextBox attendeesBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}