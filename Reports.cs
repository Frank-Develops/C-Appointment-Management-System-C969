using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969_FB
{
    public partial class Reports : Form
    {
        MySqlCommand sqlCommand;
        public Reports()
        {
            InitializeComponent();
            try
            {
                appointment.Appointments.Clear();
                string appointmentGetter = "SELECT appointmentID, customerID, userID, title, location, start, end, type FROM appointment";
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
                    string type = dr["type"].ToString();

                    appointment.addAppointment(new appointment(appointmentID, customerID, userID, title, location, start.ToLocalTime(), end.ToLocalTime(), type));
                }
            }
            catch (Exception ex)
            {
                {
                    {

                        MessageBox.Show(ex.Message);

                    }
                }

            }
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            this.Close();
            mainMenu main = new mainMenu();
            main.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void getSchedule_Click(object sender, EventArgs e)
        {
            int userID = int.Parse(userIDBox.Text);

            var userSchedule = appointment.Appointments.Where(x => x.userID == userID).ToList();


            userScheduleGrid.DataSource = userSchedule;

        }

        private void numAppoints_Click(object sender, EventArgs e)
        {
            int customerID = int.Parse(customerIDText.Text);

            var customerAppointments = appointment.Appointments.Count(x => x.customerID == customerID);
            MessageBox.Show("this customer has " + customerAppointments + " appointments");
            

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
          
            
            DateTime selectedDate = monthCalendar1.SelectionRange.Start;
            int month = selectedDate.Month;
            int year = selectedDate.Year;
            string type = typeBox.Text;

            var monthAppointments = appointment.Appointments.Where(x => x.start.Month == month);
            var yearAppointments = monthAppointments.Where(x => x.start.Year == year);
            var typeAppointments = yearAppointments.Count(x => x.type == type);
            
            MessageBox.Show("There are " + typeAppointments + " " + type + " of appointments in the selected month");

        }
    }
}
