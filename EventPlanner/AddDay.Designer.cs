namespace WindowsFormsApplication1
{
    partial class AddDay
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
            this.mainCalendar = new System.Windows.Forms.MonthCalendar();
            this.addDayButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainCalendar
            // 
            this.mainCalendar.Location = new System.Drawing.Point(83, 71);
            this.mainCalendar.Margin = new System.Windows.Forms.Padding(14);
            this.mainCalendar.MaxSelectionCount = 1;
            this.mainCalendar.Name = "mainCalendar";
            this.mainCalendar.TabIndex = 5;
            // 
            // addDayButton
            // 
            this.addDayButton.Location = new System.Drawing.Point(292, 356);
            this.addDayButton.Name = "addDayButton";
            this.addDayButton.Size = new System.Drawing.Size(127, 45);
            this.addDayButton.TabIndex = 6;
            this.addDayButton.Text = "Submit";
            this.addDayButton.UseVisualStyleBackColor = true;
            this.addDayButton.Click += new System.EventHandler(this.AddDayButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(67, 356);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(119, 45);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 426);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addDayButton);
            this.Controls.Add(this.mainCalendar);
            this.Name = "AddDay";
            this.Text = "AddDay";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mainCalendar;
        private System.Windows.Forms.Button addDayButton;
        private System.Windows.Forms.Button cancelButton;
    }
}