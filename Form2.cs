using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969_FB
{
    public partial class Form2 : Form
    {   
        MySqlDataReader reader;
        MySqlCommand sqlCommand;
        public Form2()
        {
            InitializeComponent();
        }




        private void Logon_Click(object sender, EventArgs e)
        {

            string username;
            string password;

            username = textBox1.Text;
            password = textBox2.Text;

            try
            {
                string logoncheck = "Select * FROM user WHERE userName = @username AND password = @password";
                sqlCommand = new MySqlCommand(logoncheck, Connection.conn);
                sqlCommand.Parameters.AddWithValue("@Username", username);
                sqlCommand.Parameters.AddWithValue("@Password", password);
                reader = sqlCommand.ExecuteReader();
               
                if (reader.Read())
                {
                    MessageBox.Show("if calls");
                    MessageBox.Show("username and password are correct");
                }
                else
                {
                    MessageBox.Show("else calls");
                    MessageBox.Show("Incorrect logon information");
                }
            }
            catch
            {
                MessageBox.Show(username + " " + password);
                MessageBox.Show("There was an error");

            }
            finally
            {

            }
        }
    }
}
