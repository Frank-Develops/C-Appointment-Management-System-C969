namespace C969_FB
{
    partial class calendar
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
            this.goBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // goBack
            // 
            this.goBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.goBack.Location = new System.Drawing.Point(738, 428);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(191, 90);
            this.goBack.TabIndex = 0;
            this.goBack.Text = "Go Back to Appointment Manager";
            this.goBack.UseVisualStyleBackColor = true;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(989, 553);
            this.Controls.Add(this.goBack);
            this.Name = "calendar";
            this.Text = "calendar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button goBack;
    }
}