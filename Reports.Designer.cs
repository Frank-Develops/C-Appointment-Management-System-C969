namespace C969_FB
{
    partial class Reports
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userScheduleGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.getSchedule = new System.Windows.Forms.Button();
            this.numAppoints = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.customerIDText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label10 = new System.Windows.Forms.Label();
            this.userIDBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.userScheduleGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // goBack
            // 
            this.goBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.goBack.Location = new System.Drawing.Point(1138, 565);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(153, 63);
            this.goBack.TabIndex = 0;
            this.goBack.Text = "Go Back";
            this.goBack.UseVisualStyleBackColor = true;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(42, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Appointment Types Per Month";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(577, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Schedules";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(858, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number of Appointments Per Customer";
            // 
            // userScheduleGrid
            // 
            this.userScheduleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userScheduleGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.userScheduleGrid.Location = new System.Drawing.Point(520, 175);
            this.userScheduleGrid.Name = "userScheduleGrid";
            this.userScheduleGrid.Size = new System.Drawing.Size(240, 443);
            this.userScheduleGrid.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Start";
            this.dataGridViewTextBoxColumn1.HeaderText = "Start";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "End";
            this.dataGridViewTextBoxColumn2.HeaderText = "End";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // typeBox
            // 
            this.typeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.typeBox.Location = new System.Drawing.Point(73, 256);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(192, 26);
            this.typeBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(516, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enter User ID";
            // 
            // getSchedule
            // 
            this.getSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.getSchedule.Location = new System.Drawing.Point(520, 124);
            this.getSchedule.Name = "getSchedule";
            this.getSchedule.Size = new System.Drawing.Size(240, 45);
            this.getSchedule.TabIndex = 9;
            this.getSchedule.Text = "Get Schedule";
            this.getSchedule.UseVisualStyleBackColor = true;
            this.getSchedule.Click += new System.EventHandler(this.getSchedule_Click);
            // 
            // numAppoints
            // 
            this.numAppoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numAppoints.Location = new System.Drawing.Point(872, 126);
            this.numAppoints.Name = "numAppoints";
            this.numAppoints.Size = new System.Drawing.Size(240, 45);
            this.numAppoints.TabIndex = 10;
            this.numAppoints.Text = "Generate Report";
            this.numAppoints.UseVisualStyleBackColor = true;
            this.numAppoints.Click += new System.EventHandler(this.numAppoints_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(69, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Enter appointment type then";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(69, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "to get report in Message Box";
            // 
            // customerIDText
            // 
            this.customerIDText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.customerIDText.Location = new System.Drawing.Point(1045, 82);
            this.customerIDText.Name = "customerIDText";
            this.customerIDText.Size = new System.Drawing.Size(100, 26);
            this.customerIDText.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(858, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Enter Customer ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(868, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(281, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "The results will show in a Message Box";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(69, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(251, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "choose a month from the calendar";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(73, 318);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 11;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(69, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Enter Appointment Type";
            // 
            // userIDBox
            // 
            this.userIDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.userIDBox.Location = new System.Drawing.Point(647, 82);
            this.userIDBox.Name = "userIDBox";
            this.userIDBox.Size = new System.Drawing.Size(100, 26);
            this.userIDBox.TabIndex = 19;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1303, 630);
            this.Controls.Add(this.userIDBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.customerIDText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.numAppoints);
            this.Controls.Add(this.getSchedule);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.userScheduleGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goBack);
            this.Name = "Reports";
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.userScheduleGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView userScheduleGrid;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button getSchedule;
        private System.Windows.Forms.Button numAppoints;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox customerIDText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox userIDBox;
    }
}