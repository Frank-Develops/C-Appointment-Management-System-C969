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
        //private BindingList<appointment> AppointmentsReport = new BindingList<appointment>();
        public Reports()
        {
            InitializeComponent();
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

                    appointment.addAppointment(new appointment(appointmentID, customerID, userID, title, location, start.ToLocalTime(), end.ToLocalTime()));
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
            int userID = int.Parse(userIDText.Text);

            var userSchedule = appointment.Appointments.Where(x => x.userID == userID).ToList();
            MessageBox.Show(userSchedule.ToString());

            userScheduleGrid.DataSource = userSchedule;
       
        }
    }
}
