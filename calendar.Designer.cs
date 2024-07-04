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
            this.appointmentCalandar = new System.Windows.Forms.MonthCalendar();
            this.appointmentCalGrid = new System.Windows.Forms.DataGridView();
            this.appointmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.End = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localTime = new System.Windows.Forms.RadioButton();
            this.utcTime = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentCalGrid)).BeginInit();
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
            // appointmentCalandar
            // 
            this.appointmentCalandar.Location = new System.Drawing.Point(37, 114);
            this.appointmentCalandar.Name = "appointmentCalandar";
            this.appointmentCalandar.TabIndex = 1;
            this.appointmentCalandar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // appointmentCalGrid
            // 
            this.appointmentCalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentCalGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appointmentID,
            this.CustomerID,
            this.UserID,
            this.Title,
            this.Location,
            this.Start,
            this.End});
            this.appointmentCalGrid.Location = new System.Drawing.Point(341, 47);
            this.appointmentCalGrid.Name = "appointmentCalGrid";
            this.appointmentCalGrid.Size = new System.Drawing.Size(740, 348);
            this.appointmentCalGrid.TabIndex = 2;
            // 
            // appointmentID
            // 
            this.appointmentID.DataPropertyName = "appointmentID";
            this.appointmentID.HeaderText = "Appointment ID";
            this.appointmentID.MinimumWidth = 20;
            this.appointmentID.Name = "appointmentID";
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "customerID";
            this.CustomerID.HeaderText = "Customer ID";
            this.CustomerID.Name = "CustomerID";
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "userID";
            this.UserID.HeaderText = "UserID";
            this.UserID.Name = "UserID";
            // 
            // Title
            // 
            this.Title.DataPropertyName = "title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // Location
            // 
            this.Location.DataPropertyName = "location";
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            // 
            // Start
            // 
            this.Start.DataPropertyName = "start";
            this.Start.HeaderText = "Start";
            this.Start.Name = "Start";
            // 
            // End
            // 
            this.End.DataPropertyName = "end";
            this.End.HeaderText = "End";
            this.End.Name = "End";
            // 
            // localTime
            // 
            this.localTime.AutoSize = true;
            this.localTime.Checked = true;
            this.localTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.localTime.Location = new System.Drawing.Point(341, 448);
            this.localTime.Name = "localTime";
            this.localTime.Size = new System.Drawing.Size(103, 24);
            this.localTime.TabIndex = 3;
            this.localTime.TabStop = true;
            this.localTime.Text = "Local Time";
            this.localTime.UseVisualStyleBackColor = true;
            // 
            // utcTime
            // 
            this.utcTime.AutoSize = true;
            this.utcTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.utcTime.Location = new System.Drawing.Point(498, 448);
            this.utcTime.Name = "utcTime";
            this.utcTime.Size = new System.Drawing.Size(97, 24);
            this.utcTime.TabIndex = 4;
            this.utcTime.Text = "UTC Time";
            this.utcTime.UseVisualStyleBackColor = true;
            // 
            // calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1204, 553);
            this.Controls.Add(this.utcTime);
            this.Controls.Add(this.localTime);
            this.Controls.Add(this.appointmentCalGrid);
            this.Controls.Add(this.appointmentCalandar);
            this.Controls.Add(this.goBack);
            this.Name = "calendar";
            this.Text = "calendar";
            ((System.ComponentModel.ISupportInitialize)(this.appointmentCalGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.MonthCalendar appointmentCalandar;
        private System.Windows.Forms.DataGridView appointmentCalGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn End;
        private System.Windows.Forms.RadioButton localTime;
        private System.Windows.Forms.RadioButton utcTime;
    }
}