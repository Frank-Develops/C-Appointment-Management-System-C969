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
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void manage_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADD addForm = new ADD();
            addForm.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();

        }

        private void appointments_Click(object sender, EventArgs e)
        {
            Appointments appoint = new Appointments();
            appoint.Show();
            this.Hide();
        }

        private void reports_Click(object sender, EventArgs e)
        {
            this.Close();
            Reports reports = new Reports();
            reports.Show();
        }
    }
}
