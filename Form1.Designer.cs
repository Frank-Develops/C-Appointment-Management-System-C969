namespace C969_FB
{
    partial class Form1
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
            this.connectDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connectDB
            // 
            this.connectDB.Location = new System.Drawing.Point(274, 135);
            this.connectDB.Name = "connectDB";
            this.connectDB.Size = new System.Drawing.Size(327, 192);
            this.connectDB.TabIndex = 0;
            this.connectDB.Text = "Connect";
            this.connectDB.UseVisualStyleBackColor = true;
            this.connectDB.Click += new System.EventHandler(this.connectDB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(934, 478);
            this.Controls.Add(this.connectDB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button connectDB;
    }
}

