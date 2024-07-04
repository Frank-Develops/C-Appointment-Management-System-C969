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
        public Reports()
        {
            InitializeComponent();
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
    }
}
