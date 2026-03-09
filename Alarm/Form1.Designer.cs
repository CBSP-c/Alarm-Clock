namespace Alarm
{
    partial class Form1
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
            MainClock = new Label();
            lbTimer = new Label();
            lbAlarm = new Label();
            btnTimers = new Button();
            btnAlarms = new Button();
            TimerValue = new Label();
            NewAlarm = new Label();
            SuspendLayout();
            // 
            // MainClock
            // 
            MainClock.AccessibleName = "";
            MainClock.AutoSize = true;
            MainClock.Font = new Font("Roboto", 84F, FontStyle.Bold);
            MainClock.ForeColor = Color.FromArgb(255, 255, 128);
            MainClock.Location = new Point(12, 9);
            MainClock.Name = "MainClock";
            MainClock.Size = new Size(350, 147);
            MainClock.TabIndex = 0;
            MainClock.Text = "18:48";
            MainClock.Click += label1_Click;
            // 
            // lbTimer
            // 
            lbTimer.AutoSize = true;
            lbTimer.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lbTimer.ForeColor = Color.FromArgb(255, 255, 128);
            lbTimer.Location = new Point(12, 209);
            lbTimer.Name = "lbTimer";
            lbTimer.Size = new Size(243, 45);
            lbTimer.TabIndex = 1;
            lbTimer.Text = "Current Timers";
            // 
            // lbAlarm
            // 
            lbAlarm.AutoSize = true;
            lbAlarm.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lbAlarm.ForeColor = Color.FromArgb(255, 255, 128);
            lbAlarm.Location = new Point(495, 209);
            lbAlarm.Name = "lbAlarm";
            lbAlarm.Size = new Size(247, 45);
            lbAlarm.TabIndex = 2;
            lbAlarm.Text = "Current Alarms";
            // 
            // btnTimers
            // 
            btnTimers.Location = new Point(261, 209);
            btnTimers.Name = "btnTimers";
            btnTimers.Size = new Size(75, 43);
            btnTimers.TabIndex = 3;
            btnTimers.Text = "Add New";
            btnTimers.UseVisualStyleBackColor = true;
            btnTimers.Click += btnTimers_Click;
            // 
            // btnAlarms
            // 
            btnAlarms.Location = new Point(748, 209);
            btnAlarms.Name = "btnAlarms";
            btnAlarms.Size = new Size(75, 43);
            btnAlarms.TabIndex = 4;
            btnAlarms.Text = "Add New";
            btnAlarms.UseVisualStyleBackColor = true;
            btnAlarms.Click += btnAlarms_Click;
            // 
            // TimerValue
            // 
            TimerValue.AutoSize = true;
            TimerValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            TimerValue.ForeColor = Color.FromArgb(255, 255, 128);
            TimerValue.Location = new Point(12, 269);
            TimerValue.Name = "TimerValue";
            TimerValue.Size = new Size(146, 45);
            TimerValue.TabIndex = 5;
            TimerValue.Text = "00:00:00";
            TimerValue.TextChanged += TimerValue_TextChanged;
            // 
            // NewAlarm
            // 
            NewAlarm.AutoSize = true;
            NewAlarm.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            NewAlarm.ForeColor = Color.FromArgb(255, 255, 128);
            NewAlarm.Location = new Point(495, 269);
            NewAlarm.Name = "NewAlarm";
            NewAlarm.Size = new Size(146, 45);
            NewAlarm.TabIndex = 6;
            NewAlarm.Text = "00:00:00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(865, 633);
            Controls.Add(NewAlarm);
            Controls.Add(TimerValue);
            Controls.Add(btnAlarms);
            Controls.Add(btnTimers);
            Controls.Add(lbAlarm);
            Controls.Add(lbTimer);
            Controls.Add(MainClock);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MainClock;
        private Label lbTimer;
        private Label lbAlarm;
        private Button btnTimers;
        private Button btnAlarms;
        private Label TimerValue;
        private Label NewAlarm;
    }
}
