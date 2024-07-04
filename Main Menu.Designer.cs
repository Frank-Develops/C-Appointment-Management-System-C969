namespace C969_FB
{
    partial class mainMenu
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
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.manage = new System.Windows.Forms.Button();
            this.appointments = new System.Windows.Forms.Button();
            this.reports = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.exit.Location = new System.Drawing.Point(551, 540);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(86, 65);
            this.exit.TabIndex = 0;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(296, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Main Menu";
            // 
            // manage
            // 
            this.manage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.manage.Location = new System.Drawing.Point(51, 250);
            this.manage.Name = "manage";
            this.manage.Size = new System.Drawing.Size(146, 100);
            this.manage.TabIndex = 2;
            this.manage.Text = "Manage Customer Records";
            this.manage.UseVisualStyleBackColor = true;
            this.manage.Click += new System.EventHandler(this.manage_Click);
            // 
            // appointments
            // 
            this.appointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.appointments.Location = new System.Drawing.Point(282, 250);
            this.appointments.Name = "appointments";
            this.appointments.Size = new System.Drawing.Size(146, 100);
            this.appointments.TabIndex = 3;
            this.appointments.Text = "Manage Appointments";
            this.appointments.UseVisualStyleBackColor = true;
            this.appointments.Click += new System.EventHandler(this.appointments_Click);
            // 
            // reports
            // 
            this.reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.reports.Location = new System.Drawing.Point(491, 250);
            this.reports.Name = "reports";
            this.reports.Size = new System.Drawing.Size(146, 100);
            this.reports.TabIndex = 4;
            this.reports.Text = "Reports";
            this.reports.UseVisualStyleBackColor = true;
            this.reports.Click += new System.EventHandler(this.reports_Click);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(693, 617);
            this.Controls.Add(this.reports);
            this.Controls.Add(this.appointments);
            this.Controls.Add(this.manage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.Name = "mainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button manage;
        private System.Windows.Forms.Button appointments;
        private System.Windows.Forms.Button reports;
    }
}