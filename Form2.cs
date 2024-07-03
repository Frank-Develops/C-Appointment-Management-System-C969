using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
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
        string country = System.Globalization.CultureInfo.CurrentCulture.Name.ToString();

        public Form2()
        {
            InitializeComponent();
            if (country == "es-MX")
            {
                label1.Text = "Iniciar sesión";
                label2.Text = "Nombre de usuario";
                label3.Text = "contraseña";
                Logon.Text = "Iniciar sesión";
            }
            label4.Text = "User Region " + CultureInfo.CurrentCulture.Name;

        }




        private void Logon_Click(object sender, EventArgs e)
        {

            string username;
            string password;
            DateTime currentTime = DateTime.Now;

            username = textBox1.Text;
            password = textBox2.Text;

            try
            {
                MessageBox.Show(currentTime.ToString());
                string logoncheck = "Select * FROM user WHERE userName = @username AND password = @password";
                string getUserID = "Select userID FROM user WHERE username = @username";
                string alertCheck = "SELECT START FROM Appointment WHERE userID=@userID";
                sqlCommand = new MySqlCommand(logoncheck, Connection.conn);
                sqlCommand.Parameters.AddWithValue("@Username", username);
                sqlCommand.Parameters.AddWithValue("@Password", password);
                reader = sqlCommand.ExecuteReader();






                if (reader.Read())
                {
                    if (country == "es-MX")
                    {
                        MessageBox.Show("nombre de usuario y contraseña son correctos");
                        return;
                    }
                    MessageBox.Show("username and password are correct");
                    this.Hide();
                    mainMenu mainMenu = new mainMenu();
                    mainMenu.Show();
                    reader.Close();

                    sqlCommand = new MySqlCommand(getUserID, Connection.conn);

                    sqlCommand.Parameters.AddWithValue("@username", username);

                    DataTable dt2 = new DataTable();
                    MySqlDataAdapter sda2 = new MySqlDataAdapter(sqlCommand);
                    sda2.Fill(dt2);
                    string userID = "";

                    foreach (DataRow row in dt2.Rows)
                    {
                        MessageBox.Show("this calls");
                        userID = row["userID"].ToString();
                        MessageBox.Show(userID);
                    }
                   
                    int userIDint = int.Parse(userID);

                    sqlCommand = new MySqlCommand(alertCheck, Connection.conn);
                    sqlCommand.Parameters.AddWithValue("@userID",userIDint);
                    sqlCommand.Parameters.AddWithValue("@start", currentTime);
                    DataTable dt = new DataTable();
                    MySqlDataAdapter sda = new MySqlDataAdapter(sqlCommand);
                    sda.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {


                        string appointmentTimes = dr["start"].ToString();
                        DateTime appointments = DateTime.Parse(appointmentTimes);
                        if (appointments >= currentTime && appointments <= currentTime.AddMinutes(15))
                        {
                            MessageBox.Show("you have an appointment in 15 minutes");
                        };
                    }

                    string writeUser = "test";
                    string writeTime = currentTime.ToString();
                    string documentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(documentPath, "Login_History.txt"), true))
                    {
                        outputFile.WriteLine("Username: " + writeUser + " logon time: " + writeTime);

                    }


                    reader = sqlCommand.ExecuteReader();
                    reader.Close();

                }
                else
                {
                    if (CultureInfo.CurrentCulture.Name == "es-MX")
                    {
                        MessageBox.Show("Información de inicio de sesión incorrecta");
                        return;
                    }
                    MessageBox.Show("Incorrect logon information");
                }
            }
            catch (Exception ex)
            {
                {
                    if (CultureInfo.CurrentCulture.Name == "es-MX")
                    {
                        MessageBox.Show("Hubo un error");
                        return;
                    }
                    MessageBox.Show(ex.ToString());

                }
                //finally
                //{
                //maybe add something hear and clear text from username and password fields to allow it to do retries 
                //}
            }
        }
    }
}
