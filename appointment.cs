using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969_FB
{
    internal class appointment
    {
        public static BindingList<appointment> Appointments = new BindingList<appointment>();
        //private BindingList<appointment> SelectedAppointments = new BindingList<appointment>();

        public int appointmentID { get; set; }
        public int customerID { get; set; }
        public int userID { get; set; }
        public string title { get; set; }
        public string location { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }

        public appointment() { }

        public appointment(int appointmentID, int customerID, int userID, string title, string location, DateTime start, DateTime end)
        {
            this.appointmentID = appointmentID;
            this.customerID = customerID;
            this.userID = userID;
            this.title = title;
            this.location = location;
            this.start = start;
            this.end = end;
        }

        public static void addAppointment(appointment a)
        {
            Appointments.Add(a);
        }
    }
}
