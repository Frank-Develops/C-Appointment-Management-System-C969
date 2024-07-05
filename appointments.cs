using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C969_FB
{
    public partial class Appointments : Form
    {
        MySqlDataReader reader;
        MySqlCommand sqlCommand;
        public Appointments()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            mainMenu mainMenu = new mainMenu();
            mainMenu.Show();
            this.Close();
        }

        private void addAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(customerIDBox.Text) || String.IsNullOrEmpty(userIDBox.Text) || String.IsNullOrEmpty(titleBox.Text) || String.IsNullOrEmpty(descriptionBox.Text) || String.IsNullOrEmpty(locationBox.Text) || String.IsNullOrEmpty(contactBox.Text) || String.IsNullOrEmpty(typeBox.Text) || String.IsNullOrEmpty(startBox.Text) || String.IsNullOrEmpty(endBox.Text))
                {

                    MessageBox.Show("please fill out all fields");
                    return;
                }
              


                int customerID = int.Parse(customerIDBox.Text);
                int userID = int.Parse(userIDBox.Text);
                string title = titleBox.Text;
                string description = descriptionBox.Text;
                string location = locationBox.Text;
                string contact = contactBox.Text;
                string type = typeBox.Text;
                string start = startBox.Text;
                string end = endBox.Text;
                string open = "2024-12-10 08:00:00";
                string close = "2024-12-10 17:00:00";



                try
                {
                    DateTime.Parse(start);
                    DateTime.Parse(end);
                } catch {

                    MessageBox.Show("Please enter Start and End times in YYYY-MM-DD hh:mm:ss format");
                    return;
                }

           

                string overlapCheck = "SELECT START FROM APPOINTMENT WHERE START <= @end AND END >= @start";

                sqlCommand = new MySqlCommand(overlapCheck, Connection.conn);
                sqlCommand.Parameters.AddWithValue("@start", DateTime.Parse(start));
                sqlCommand.Parameters.AddWithValue("@end", DateTime.Parse(end));
                DataTable dt = new DataTable();
                MySqlDataAdapter sda = new MySqlDataAdapter(sqlCommand);
                sda.Fill(dt);
                int rowCounter = 0;
                foreach (DataRow row in dt.Rows)
                {
                    rowCounter++;
                }

                if (DateTime.Parse(start).TimeOfDay >= DateTime.Parse(open).TimeOfDay && DateTime.Parse(end).TimeOfDay <= DateTime.Parse(close).TimeOfDay)
                {
                    MessageBox.Show("within business hours");
                }
                else
                {
                    MessageBox.Show("it is outside business hours");
                    return;
                }




                if (rowCounter == 0)
                {
                    MessageBox.Show("no overlap");


                    string insertAppointment = "INSERT INTO APPOINTMENT(customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES(@customerID, @userID, @title, @description, @location, @contact, @type, 'fake', @start, @end, '2024-06-29 00:00:00', 'test', '2024-06-29 00:00:00', 'test');";
                    sqlCommand = new MySqlCommand(insertAppointment, Connection.conn);

                    sqlCommand.Parameters.AddWithValue("@customerID", customerID);
                    sqlCommand.Parameters.AddWithValue("@userID", userID);
                    sqlCommand.Parameters.AddWithValue("@title", title);
                    sqlCommand.Parameters.AddWithValue("@description", description);
                    sqlCommand.Parameters.AddWithValue("@location", location);
                    sqlCommand.Parameters.AddWithValue("@contact", contact);
                    sqlCommand.Parameters.AddWithValue("@type", type);
                    sqlCommand.Parameters.AddWithValue("@start", start);
                    sqlCommand.Parameters.AddWithValue("@end", end);
                    reader = sqlCommand.ExecuteReader();
                    reader.Close();
                    MessageBox.Show("Appointment has been added");

                }
                else
                {
                    MessageBox.Show("there is already an appointment at this time");
                }
            }
            catch (Exception ex)
            {
                {

                    MessageBox.Show("There was an error with adding the appointment");

                }

            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

     

        private void updateAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(customerIDUpdate.Text) || String.IsNullOrEmpty(userIDUpdate.Text) || String.IsNullOrEmpty(titleUpdate.Text) || String.IsNullOrEmpty(descriptionUpdate.Text) || String.IsNullOrEmpty(locationUpdate.Text) || String.IsNullOrEmpty(contactUpdate.Text) || String.IsNullOrEmpty(typeUpdate.Text) || String.IsNullOrEmpty(startUpdate.Text) || String.IsNullOrEmpty(endUpdate.Text) || String.IsNullOrEmpty(appointmentIDUpdate.Text))
                {

                    MessageBox.Show("please fill out all fields");
                    return;
                }
                int customerID = int.Parse(customerIDUpdate.Text);
                int userID = int.Parse(userIDUpdate.Text);
                string title = titleUpdate.Text;
                string description = descriptionUpdate.Text;
                string location = locationUpdate.Text;
                string contact = contactUpdate.Text;
                string type = typeUpdate.Text;
                string start = startUpdate.Text;
                string end = endUpdate.Text;
                int appointmentID = int.Parse(appointmentIDUpdate.Text);
                string open = "2024-12-10 08:00:00";
                string close = "2024-12-10 17:00:00";

                try
                {
                    DateTime.Parse(start);
                    DateTime.Parse(end);
                }
                catch
                {

                    MessageBox.Show("Please enter Start and End times in YYYY-MM-DD hh:mm:ss format");
                    return;
                }


                

                string overlapCheck = "SELECT START FROM APPOINTMENT WHERE START <= @end AND END >= @start";

                sqlCommand = new MySqlCommand(overlapCheck, Connection.conn);
                sqlCommand.Parameters.AddWithValue("@start", DateTime.Parse(start));
                sqlCommand.Parameters.AddWithValue("@end", DateTime.Parse(end));
                DataTable dt = new DataTable();
                MySqlDataAdapter sda = new MySqlDataAdapter(sqlCommand);
                sda.Fill(dt);
                int rowCounter = 0;
                foreach (DataRow row in dt.Rows)
                {
                    rowCounter++;
                }

                if (DateTime.Parse(start).TimeOfDay >= DateTime.Parse(open).TimeOfDay && DateTime.Parse(end).TimeOfDay <= DateTime.Parse(close).TimeOfDay)
                {
                    MessageBox.Show("within business hours");
                }
                else
                {
                    MessageBox.Show("it is outside business hours");
                    return;
                }

                if (rowCounter == 0)
                {
                    MessageBox.Show("no overlap");


                    string updateAppointment = "UPDATE APPOINTMENT SET customerID = @customerID, userID = @userID, title=@title, description = @description, location = @location, contact = @contact, type=@type, start=@start, end=@end WHERE appointmentID = @appointmentID;";
                    sqlCommand = new MySqlCommand(updateAppointment, Connection.conn);

                    sqlCommand.Parameters.AddWithValue("@customerID", customerID);
                    sqlCommand.Parameters.AddWithValue("@userID", userID);
                    sqlCommand.Parameters.AddWithValue("@title", title);
                    sqlCommand.Parameters.AddWithValue("@description", description);
                    sqlCommand.Parameters.AddWithValue("@location", location);
                    sqlCommand.Parameters.AddWithValue("@contact", contact);
                    sqlCommand.Parameters.AddWithValue("@type", type);
                    sqlCommand.Parameters.AddWithValue("@start", start);
                    sqlCommand.Parameters.AddWithValue("@end", end);
                    sqlCommand.Parameters.AddWithValue("@appointmentID", appointmentID);
                    reader = sqlCommand.ExecuteReader();
                    reader.Close();
                    MessageBox.Show("Appointment has been updated");
                    

                }
                else
                {
                    MessageBox.Show("there is already an appointment at this time");
                }
            }
            catch (Exception ex)
            {
                {

                    MessageBox.Show("There was an error with updating the appointment, please make sure all information is correct ");


                }

            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        private void deleteAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                int appointmentID = int.Parse(deleteID.Text);

                string deleteAppointment = "DELETE FROM APPOINTMENT WHERE appointmentID = @appointmentID";
                sqlCommand = new MySqlCommand(deleteAppointment, Connection.conn);
                sqlCommand.Parameters.AddWithValue("@appointmentID", appointmentID);
                reader = sqlCommand.ExecuteReader();
                reader.Close();
                MessageBox.Show("Appointment has been deleted");


            }
            catch (Exception ex)
            
            {

                MessageBox.Show("There is no appointment with that ID");

            }


            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        private void openCalendar_Click(object sender, EventArgs e)
        {
            calendar cal = new calendar();
            this.Close();
            cal.Show();
        }
    }
}
