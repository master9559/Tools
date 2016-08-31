namespace PowerScheduler
{
    partial class PowerSchedulerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PowerSchedulerForm));
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.delayTimePicker = new System.Windows.Forms.DateTimePicker();
            this.powerOptionCB = new System.Windows.Forms.ComboBox();
            this.powerLabel = new System.Windows.Forms.Label();
            this.timeLbl = new System.Windows.Forms.Label();
            this.scheduleLbl = new System.Windows.Forms.Label();
            this.timeOptionsCB = new System.Windows.Forms.ComboBox();
            this.startStopBtn = new System.Windows.Forms.Button();
            this.timeLeftLbl = new System.Windows.Forms.Label();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.CustomFormat = "MM/dd/yyyy      hh:mm:ss tt";
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(323, 192);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(488, 44);
            this.dateTimePicker.TabIndex = 1;
            // 
            // delayTimePicker
            // 
            this.delayTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delayTimePicker.CustomFormat = "HH \'H\' mm \'M\' ss \'S\'";
            this.delayTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delayTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.delayTimePicker.Location = new System.Drawing.Point(513, 192);
            this.delayTimePicker.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.delayTimePicker.Name = "delayTimePicker";
            this.delayTimePicker.ShowUpDown = true;
            this.delayTimePicker.Size = new System.Drawing.Size(298, 44);
            this.delayTimePicker.TabIndex = 2;
            // 
            // powerOptionCB
            // 
            this.powerOptionCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.powerOptionCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.powerOptionCB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.powerOptionCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerOptionCB.FormattingEnabled = true;
            this.powerOptionCB.Items.AddRange(new object[] {
            "Sleep",
            "Shutdown",
            "Restart"});
            this.powerOptionCB.Location = new System.Drawing.Point(461, 35);
            this.powerOptionCB.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.powerOptionCB.Name = "powerOptionCB";
            this.powerOptionCB.Size = new System.Drawing.Size(350, 45);
            this.powerOptionCB.TabIndex = 3;
            this.powerOptionCB.SelectedIndexChanged += new System.EventHandler(this.powerOptionCB_SelectedIndexChanged);
            // 
            // powerLabel
            // 
            this.powerLabel.AutoSize = true;
            this.powerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerLabel.Location = new System.Drawing.Point(59, 43);
            this.powerLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.powerLabel.Name = "powerLabel";
            this.powerLabel.Size = new System.Drawing.Size(236, 37);
            this.powerLabel.TabIndex = 5;
            this.powerLabel.Text = "Power Options:";
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.Location = new System.Drawing.Point(59, 115);
            this.timeLbl.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(217, 37);
            this.timeLbl.TabIndex = 6;
            this.timeLbl.Text = "Time Options:";
            // 
            // scheduleLbl
            // 
            this.scheduleLbl.AutoSize = true;
            this.scheduleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleLbl.Location = new System.Drawing.Point(57, 192);
            this.scheduleLbl.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.scheduleLbl.Name = "scheduleLbl";
            this.scheduleLbl.Size = new System.Drawing.Size(238, 37);
            this.scheduleLbl.TabIndex = 7;
            this.scheduleLbl.Text = "Schedule Time:";
            // 
            // timeOptionsCB
            // 
            this.timeOptionsCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeOptionsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeOptionsCB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.timeOptionsCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeOptionsCB.FormattingEnabled = true;
            this.timeOptionsCB.Items.AddRange(new object[] {
            "Now",
            "Delayed",
            "Specific Time"});
            this.timeOptionsCB.Location = new System.Drawing.Point(461, 107);
            this.timeOptionsCB.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.timeOptionsCB.Name = "timeOptionsCB";
            this.timeOptionsCB.Size = new System.Drawing.Size(350, 45);
            this.timeOptionsCB.TabIndex = 8;
            this.timeOptionsCB.SelectedIndexChanged += new System.EventHandler(this.timeOptionsCB_SelectedIndexChanged);
            // 
            // startStopBtn
            // 
            this.startStopBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startStopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startStopBtn.Location = new System.Drawing.Point(46, 288);
            this.startStopBtn.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.startStopBtn.Name = "startStopBtn";
            this.startStopBtn.Size = new System.Drawing.Size(230, 92);
            this.startStopBtn.TabIndex = 9;
            this.startStopBtn.Text = "Start";
            this.startStopBtn.UseVisualStyleBackColor = true;
            this.startStopBtn.Click += new System.EventHandler(this.startStopBtn_Click);
            // 
            // timeLeftLbl
            // 
            this.timeLeftLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.timeLeftLbl.AutoEllipsis = true;
            this.timeLeftLbl.AutoSize = true;
            this.timeLeftLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLeftLbl.Location = new System.Drawing.Point(335, 288);
            this.timeLeftLbl.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.timeLeftLbl.Name = "timeLeftLbl";
            this.timeLeftLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.timeLeftLbl.Size = new System.Drawing.Size(247, 61);
            this.timeLeftLbl.TabIndex = 10;
            this.timeLeftLbl.Text = "Time Left";
            this.timeLeftLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(PowerScheduler.Program);
            // 
            // PowerSchedulerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(869, 407);
            this.Controls.Add(this.timeLeftLbl);
            this.Controls.Add(this.startStopBtn);
            this.Controls.Add(this.timeOptionsCB);
            this.Controls.Add(this.scheduleLbl);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.powerLabel);
            this.Controls.Add(this.powerOptionCB);
            this.Controls.Add(this.delayTimePicker);
            this.Controls.Add(this.dateTimePicker);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(895, 478);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(748, 398);
            this.Name = "PowerSchedulerForm";
            this.Text = "Power Scheduler";
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DateTimePicker delayTimePicker;
        private System.Windows.Forms.ComboBox powerOptionCB;
        private System.Windows.Forms.Label powerLabel;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Label scheduleLbl;
        private System.Windows.Forms.ComboBox timeOptionsCB;
        private System.Windows.Forms.Button startStopBtn;
        private System.Windows.Forms.Label timeLeftLbl;
        private System.Windows.Forms.BindingSource programBindingSource;
    }
}

