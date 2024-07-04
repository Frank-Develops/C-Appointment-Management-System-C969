﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace C969_FB
{
    public partial class calendar : Form
    {
        MySqlCommand sqlCommand;
        public calendar()
        {
            InitializeComponent();
            appointmentCalGrid.DataSource = appointment.Appointments;
            try
            {
                string appointmentGetter = "SELECT appointmentID, customerID, userID, title, location, start, end FROM appointment";
                sqlCommand = new MySqlCommand(appointmentGetter, Connection.conn);

                DataTable dt = new DataTable();
                MySqlDataAdapter sda = new MySqlDataAdapter(sqlCommand);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    int appointmentID = int.Parse(dr["appointmentID"].ToString());
                    int customerID = int.Parse(dr["customerID"].ToString());
                    int userID = int.Parse(dr["userID"].ToString());
                    string title = dr["Title"].ToString();
                    string location = dr["location"].ToString();
                    DateTime start = DateTime.Parse(dr["start"].ToString());
                    DateTime end = DateTime.Parse(dr["end"].ToString());

                    appointment.addAppointment(new appointment(appointmentID, customerID, userID, title, location, start, end));
                }
            }
            catch (Exception ex)
            {
                {
                    {

                        MessageBox.Show(ex.Message);

                    }
                }
                //finally
                //{
                //    if
                //}
            }
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Appointments appointments = new Appointments();
            appointments.Show();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //build function to get all appointments
            //generate appointments in DataGridView based off what is selected
        }
    }
}
