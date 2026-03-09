namespace Alarm
{
    partial class Form2
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
            tbInput = new TextBox();
            lbNewTimer = new Label();
            btnSubmit = new Button();
            lbWarning = new Label();
            SuspendLayout();
            // 
            // tbInput
            // 
            tbInput.Location = new Point(12, 73);
            tbInput.Name = "tbInput";
            tbInput.Size = new Size(216, 23);
            tbInput.TabIndex = 0;
            // 
            // lbNewTimer
            // 
            lbNewTimer.AutoSize = true;
            lbNewTimer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbNewTimer.ForeColor = Color.Yellow;
            lbNewTimer.Location = new Point(12, 9);
            lbNewTimer.Name = "lbNewTimer";
            lbNewTimer.Size = new Size(216, 21);
            lbNewTimer.TabIndex = 1;
            lbNewTimer.Text = "Set a new timer (hh:mm:ss)";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(153, 102);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lbWarning
            // 
            lbWarning.AutoSize = true;
            lbWarning.Font = new Font("Segoe UI", 8F);
            lbWarning.ForeColor = Color.Black;
            lbWarning.Location = new Point(12, 30);
            lbWarning.Name = "lbWarning";
            lbWarning.Size = new Size(77, 13);
            lbWarning.TabIndex = 3;
            lbWarning.Text = "Wrong Value!";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(240, 137);
            Controls.Add(lbWarning);
            Controls.Add(btnSubmit);
            Controls.Add(lbNewTimer);
            Controls.Add(tbInput);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbInput;
        private Label lbNewTimer;
        private Button btnSubmit;
        private Label lbWarning;
    }
}