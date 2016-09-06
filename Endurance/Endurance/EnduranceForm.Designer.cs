namespace Endurance
{
    partial class EnduranceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnduranceForm));
            this.timeLeftLbl = new System.Windows.Forms.Label();
            this.startStopBtn = new System.Windows.Forms.Button();
            this.delayTimePicker = new System.Windows.Forms.DateTimePicker();
            this.timedRunBx = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // timeLeftLbl
            // 
            this.timeLeftLbl.AutoEllipsis = true;
            this.timeLeftLbl.AutoSize = true;
            this.timeLeftLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLeftLbl.Location = new System.Drawing.Point(123, 64);
            this.timeLeftLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.timeLeftLbl.Name = "timeLeftLbl";
            this.timeLeftLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.timeLeftLbl.Size = new System.Drawing.Size(127, 31);
            this.timeLeftLbl.TabIndex = 13;
            this.timeLeftLbl.Text = "Time Left";
            this.timeLeftLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startStopBtn
            // 
            this.startStopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startStopBtn.Location = new System.Drawing.Point(26, 66);
            this.startStopBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.startStopBtn.Name = "startStopBtn";
            this.startStopBtn.Size = new System.Drawing.Size(75, 35);
            this.startStopBtn.TabIndex = 12;
            this.startStopBtn.Text = "Start";
            this.startStopBtn.UseVisualStyleBackColor = true;
            this.startStopBtn.Click += new System.EventHandler(this.startStopBtn_Click);
            // 
            // delayTimePicker
            // 
            this.delayTimePicker.CustomFormat = "HH \'H\' mm \'M\' ss \'S\'";
            this.delayTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delayTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.delayTimePicker.Location = new System.Drawing.Point(114, 17);
            this.delayTimePicker.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.delayTimePicker.Name = "delayTimePicker";
            this.delayTimePicker.ShowUpDown = true;
            this.delayTimePicker.Size = new System.Drawing.Size(151, 26);
            this.delayTimePicker.TabIndex = 11;
            this.delayTimePicker.ValueChanged += new System.EventHandler(this.delayTimePicker_ValueChanged);
            // 
            // timedRunBx
            // 
            this.timedRunBx.AutoSize = true;
            this.timedRunBx.Checked = true;
            this.timedRunBx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.timedRunBx.Location = new System.Drawing.Point(26, 23);
            this.timedRunBx.Name = "timedRunBx";
            this.timedRunBx.Size = new System.Drawing.Size(81, 17);
            this.timedRunBx.TabIndex = 14;
            this.timedRunBx.Text = "Timed Run:";
            this.timedRunBx.UseVisualStyleBackColor = true;
            this.timedRunBx.CheckedChanged += new System.EventHandler(this.countDownBx_CheckedChanged);
            // 
            // EnduranceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(304, 120);
            this.Controls.Add(this.timedRunBx);
            this.Controls.Add(this.timeLeftLbl);
            this.Controls.Add(this.startStopBtn);
            this.Controls.Add(this.delayTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnduranceForm";
            this.Text = "Screen Endurance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLeftLbl;
        private System.Windows.Forms.Button startStopBtn;
        private System.Windows.Forms.DateTimePicker delayTimePicker;
        private System.Windows.Forms.CheckBox timedRunBx;
    }
}

