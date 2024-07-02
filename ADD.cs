using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace C969_FB
{
    public partial class ADD : Form
    {
        MySqlDataReader reader;
        MySqlCommand sqlCommand;
        public ADD()
        {
            InitializeComponent();
        }

        private void addCustomer_Click(object sender, EventArgs e)
        {

            string name = nameField.Text;
            string address = addressField.Text;
            string city = cityField.Text;
            string state = stateField.Text;
            string country = countryField.Text;
            int phone = int.Parse(phoneField.Text);
            string zipCode = zipField.Text;



            try
            {
                

                string customerRecord = "INSERT INTO CUSTOMER(customerName, addressId, active, createdate, createdby, lastupdate, lastupdateby)  VALUES(@name, @addressID, 1, '2024-06-29 00:00:00', 'test', '2024-06-29 00:00:00', 'test');";
                string addressRecord = "INSERT INTO ADDRESS(address, address2, cityID, postalcode, phone, createdate, createdby, lastupdate, lastupdateby) VALUES(@address, 'fake', @cityID, @zipCode, @phone, '2024-06-29 00:00:00', 'test', '2024-06-29 00:00:00', 'test');";
                string cityRecord = "INSERT INTO CITY(city, countryid,createdate, createdby, lastupdate, lastupdateby)  VALUES(@city, @countryID, '2024-06-29 00:00:00', 'test', '2024-06-29 00:00:00', 'test');";
                string countryRecord = "INSERT INTO COUNTRY(country, createdate, createdby, lastupdate, lastupdateby) VALUES(@country,'2024-06-29 00:00:00', 'test', '2024-06-29 00:00:00', 'test');";


                sqlCommand = new MySqlCommand(countryRecord, Connection.conn);

                sqlCommand.Parameters.AddWithValue("@country", country);
                reader = sqlCommand.ExecuteReader();
                reader.Close();

                int countryIDint = (int)sqlCommand.LastInsertedId;

                sqlCommand = new MySqlCommand(cityRecord, Connection.conn);
                MySqlDataAdapter sda4 = new MySqlDataAdapter(sqlCommand);
                sqlCommand.Parameters.AddWithValue("@countryID", countryIDint);
                sqlCommand.Parameters.AddWithValue("@city", city);
                reader = sqlCommand.ExecuteReader();
                reader.Close();
                int cityIDint = (int)sqlCommand.LastInsertedId;

                sqlCommand = new MySqlCommand(addressRecord, Connection.conn);
                MySqlDataAdapter sda5 = new MySqlDataAdapter(sqlCommand);

                sqlCommand.Parameters.AddWithValue("@cityID", cityIDint);
                sqlCommand.Parameters.AddWithValue("@address", address);
                sqlCommand.Parameters.AddWithValue("@city", city);
                sqlCommand.Parameters.AddWithValue("@phone", phone);
                sqlCommand.Parameters.AddWithValue("@zipCode", zipCode);
                reader = sqlCommand.ExecuteReader();
                reader.Close();

                int addressIDint = (int)sqlCommand.LastInsertedId;

                sqlCommand = new MySqlCommand(customerRecord, Connection.conn);
                MySqlDataAdapter sda6 = new MySqlDataAdapter(sqlCommand);
                sqlCommand.Parameters.AddWithValue("@name", name);
                sqlCommand.Parameters.AddWithValue("@addressID", addressIDint);
                reader = sqlCommand.ExecuteReader();
                reader.Close();



            }
            catch (Exception ex)
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

        //private void ADD_Load(object sender, EventArgs e)
        //{

        //}

        private void deleteButton_Click(object sender, EventArgs e)
        {

            try
            {


                int delete = int.Parse(deleteField.Text);

                string getInfo = "SELECT addressId FROM Customer WHERE customerID = @deleteID";
                sqlCommand = new MySqlCommand(getInfo, Connection.conn);
                sqlCommand.Parameters.AddWithValue("@deleteID", delete);
                DataTable dt = new DataTable();
                MySqlDataAdapter sda = new MySqlDataAdapter(sqlCommand);
                sda.Fill(dt);
                string addressIDString = dt.Rows[0][0].ToString();
                int addressIDint = int.Parse(addressIDString);




                string deleteAppointments = "DELETE FROM APPOINTMENT WHERE customerID = @deleteID;";
                string deleteCustomer = "DELETE FROM CUSTOMER WHERE customerID = @deleteID;";
                string deleteAddress = "DELETE FROM ADDRESS WHERE addressID = @addressID;";



                sqlCommand = new MySqlCommand(deleteAppointments, Connection.conn);
                sqlCommand.Parameters.AddWithValue("@deleteID", delete);

                sqlCommand = new MySqlCommand(deleteAddress, Connection.conn);
                sqlCommand.Parameters.AddWithValue("@address", addressIDint);

                sqlCommand = new MySqlCommand(deleteCustomer, Connection.conn);
                sqlCommand.Parameters.AddWithValue("@deleteID", delete);
                reader = sqlCommand.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
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

        private void ADD_Load(object sender, EventArgs e)
        {

        }

        private void updateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameUpdateField.Text;
                string address = addressUpdateField.Text;
                string city = cityUpdateField.Text;
                string state = stateUpdateField.Text;
                string country = countryUpdateField.Text;
                string phone = phoneUpdateField.Text;
                string zipCode = zipUpdateField.Text;
                int customerID = int.Parse(customerIDField.Text);






                string updateCustomer = "UPDATE CUSTOMER SET customerName=@name, addressID=@addressID WHERE customerID = @customerID;";
                string addressRecord = "INSERT INTO ADDRESS(address, address2, cityID, postalcode, phone, createdate, createdby, lastupdate, lastupdateby) VALUES(@address, 'fake', @cityID, @zipCode, @phone, '2024-06-29 00:00:00', 'test', '2024-06-29 00:00:00', 'test');";
                string cityRecord = "INSERT INTO CITY(city, countryid,createdate, createdby, lastupdate, lastupdateby)  VALUES(@city, @countryID, '2024-06-29 00:00:00', 'test', '2024-06-29 00:00:00', 'test');";
                string countryRecord = "INSERT INTO COUNTRY(country, createdate, createdby, lastupdate, lastupdateby)VALUES (@country,'2024-06-29 00:00:00', 'test', '2024-06-29 00:00:00', 'test');";



                sqlCommand = new MySqlCommand(countryRecord, Connection.conn);

                sqlCommand.Parameters.AddWithValue("@name", name);
                sqlCommand.Parameters.AddWithValue("@customerID", customerID);
                sqlCommand.Parameters.AddWithValue("@address", address);
                sqlCommand.Parameters.AddWithValue("@city", city);
                sqlCommand.Parameters.AddWithValue("@state", state);
                sqlCommand.Parameters.AddWithValue("@country", country);
                sqlCommand.Parameters.AddWithValue("@phone", phone);
                sqlCommand.Parameters.AddWithValue("@zipCode", zipCode);




                reader = sqlCommand.ExecuteReader();
                reader.Close();

                int countryIDint = (int)sqlCommand.LastInsertedId;

                sqlCommand = new MySqlCommand(cityRecord, Connection.conn);
                MySqlDataAdapter sda4 = new MySqlDataAdapter(sqlCommand);
                sqlCommand.Parameters.AddWithValue("@countryID", countryIDint);
                sqlCommand.Parameters.AddWithValue("@city", city);
                reader = sqlCommand.ExecuteReader();
                reader.Close();
                int cityIDint = (int)sqlCommand.LastInsertedId;


                sqlCommand = new MySqlCommand(addressRecord, Connection.conn);
                MySqlDataAdapter sda5 = new MySqlDataAdapter(sqlCommand);

                sqlCommand.Parameters.AddWithValue("@cityID", cityIDint);
                sqlCommand.Parameters.AddWithValue("@address", address);
                sqlCommand.Parameters.AddWithValue("@city", city);
                sqlCommand.Parameters.AddWithValue("@phone", phone);
                sqlCommand.Parameters.AddWithValue("@zipCode", zipCode);
                reader = sqlCommand.ExecuteReader();
                reader.Close();

                int addressIDint = (int)sqlCommand.LastInsertedId;

                MessageBox.Show(addressIDint.ToString());
                MessageBox.Show(name);

                sqlCommand = new MySqlCommand(updateCustomer, Connection.conn);
                MySqlDataAdapter sda6 = new MySqlDataAdapter(sqlCommand);
                sqlCommand.Parameters.AddWithValue("@name", name);
                sqlCommand.Parameters.AddWithValue("@addressID", addressIDint);
                sqlCommand.Parameters.AddWithValue("@customerID", customerID);
                //sqlCommand.ExecuteNonQuery();
                reader = sqlCommand.ExecuteReader();
                reader.Close();

            }
            catch (Exception ex)
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

        private void close_Click(object sender, EventArgs e)
        {
            mainMenu mainMenu = new mainMenu();
            mainMenu.Show();
            this.Close();
        }
    }
}
