using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                int customerID = int.Parse(customerIDBox.Text);
                int userID = int.Parse(userIDBox.Text);
                string title = titleBox.Text;   
                string description = descriptionBox.Text;  
                string location = locationBox.Text;
                string contact = contactBox.Text;
                string type = typeBox.Text;
                string start = startBox.Text;
                string end = endBox.Text;

                // YYYY-MM-DD hh:mm:ss.
                //2024-12-10 06:05:00
                //2024-12-10 07:05:00

                //string overlapCheck = 
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
            } catch (Exception ex)
            {
                {

                    MessageBox.Show(ex.Message);

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

        private void customerID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
