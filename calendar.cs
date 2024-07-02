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
    public partial class calendar : Form
    {
        public calendar()
        {
            InitializeComponent();
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Appointments appointments = new Appointments();
            appointments.Show();
        }
    }
}
