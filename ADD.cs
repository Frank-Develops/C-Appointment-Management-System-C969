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
                string customerIDQuery = "SELECT MAX(customerId) FROM Customer";
                sqlCommand = new MySqlCommand(customerIDQuery, Connection.conn);
                DataTable dt = new DataTable();
                MySqlDataAdapter sda = new MySqlDataAdapter(sqlCommand);
                sda.Fill(dt);
                string customerIDString = dt.Rows[0][0].ToString();
                int customerIDint = int.Parse(customerIDString);
                customerIDint++;
                string addressIDQuery = "SELECT MAX(addressId) FROM Address";
                sqlCommand = new MySqlCommand(addressIDQuery, Connection.conn);
                DataTable dt2 = new DataTable();
                MySqlDataAdapter sda2 = new MySqlDataAdapter(sqlCommand);
                sda.Fill(dt2);
                string addressIDString = dt2.Rows[0][0].ToString();
                int addressIDint = int.Parse(addressIDString);
                addressIDint++;
                string cityIDQuery = "SELECT MAX(cityId) FROM City";
                sqlCommand = new MySqlCommand(cityIDQuery, Connection.conn);
                DataTable dt3 = new DataTable();
                MySqlDataAdapter sda3 = new MySqlDataAdapter(sqlCommand);
                sda.Fill(dt3);
                string cityIDString = dt3.Rows[0][0].ToString();
                int cityIDint = int.Parse(cityIDString);
                cityIDint++;
                string countryIDQuery = "SELECT MAX(countryId) FROM Country";
                sqlCommand = new MySqlCommand(countryIDQuery, Connection.conn);
                DataTable dt4 = new DataTable();
                MySqlDataAdapter sda4 = new MySqlDataAdapter(sqlCommand);
                sda.Fill(dt4);
                string countryIDString = dt4.Rows[0][0].ToString();
                int countryIDint = int.Parse (countryIDString);
                countryIDint++;
                






                string customerRecord = "INSERT INTO CUSTOMER VALUES(@customerID, @name, @addressID, 1, '2024-06-29 00:00:00', 'test', '2024-06-29 00:00:00', 'test');";
                string addressRecord = "INSERT INTO ADDRESS VALUES(@addressID,@address, 'fake', @cityID, @zipCode, @phone, '2024-06-29 00:00:00', 'test', '2024-06-29 00:00:00', 'test');";
                string cityRecord = "INSERT INTO CITY VALUES(@cityID, @city, @countryID, '2024-06-29 00:00:00', 'test', '2024-06-29 00:00:00', 'test');";
                string countryRecord = "INSERT INTO COUNTRY(country, createdate, createdby, lastupdate, lastupdateby) VALUES(@country,'2024-06-29 00:00:00', 'test', '2024-06-29 00:00:00', 'test');";




                string addRecord = countryRecord + cityRecord + addressRecord + customerRecord;
                



                sqlCommand = new MySqlCommand(addRecord, Connection.conn);
                sqlCommand.Parameters.AddWithValue("@name", name);
                sqlCommand.Parameters.AddWithValue("@address", address);
                sqlCommand.Parameters.AddWithValue("@city", city);
                sqlCommand.Parameters.AddWithValue("@state", state);
                sqlCommand.Parameters.AddWithValue("@country", country);
                sqlCommand.Parameters.AddWithValue("@phone", phone);
                sqlCommand.Parameters.AddWithValue("@zipCode", zipCode);
                sqlCommand.Parameters.AddWithValue("@customerID", customerIDint);
                sqlCommand.Parameters.AddWithValue("@addressID", addressIDint);
                sqlCommand.Parameters.AddWithValue("@cityID", cityIDint);
                sqlCommand.Parameters.AddWithValue("@countryID", countryIDint);

                reader = sqlCommand.ExecuteReader();



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


                //string addressIDQuery = "SELECT MAX(addressId) FROM Address";
                //sqlCommand = new MySqlCommand(addressIDQuery, Connection.conn);
                //MySqlDataAdapter sda = new MySqlDataAdapter(sqlCommand);
                //DataTable dt = new DataTable();
                //sda.Fill(dt);
                //string addressIDString = dt.Rows[0][0].ToString();
                //int addressIDint = int.Parse(addressIDString);
                //addressIDint++;
                //string cityIDQuery = "SELECT MAX(cityId) FROM City";
                //sqlCommand = new MySqlCommand(cityIDQuery, Connection.conn);
                //DataTable dt2 = new DataTable();
                //MySqlDataAdapter sda2 = new MySqlDataAdapter(sqlCommand);
                //sda.Fill(dt2);
                //string cityIDString = dt2.Rows[0][0].ToString();
                //int cityIDint = int.Parse(cityIDString);
                //cityIDint++;
                //string countryIDQuery = "SELECT MAX(countryId) FROM Country";
                //sqlCommand = new MySqlCommand(countryIDQuery, Connection.conn);
                //DataTable dt3 = new DataTable();
                //MySqlDataAdapter sda3 = new MySqlDataAdapter(sqlCommand);
                //sda.Fill(dt3);
                //string countryIDString = dt3.Rows[0][0].ToString();
                //int countryIDint = int.Parse(countryIDString);
                //countryIDint++;



                //string updateCustomer = "UPDATE CUSTOMER SET customerName=@name WHERE customerID = @customerID;";
                //string addressRecord = "INSERT INTO ADDRESS VALUES(@addressID,@address, 'fake', @cityID, @zipCode, @phone, '2024-06-29 00:00:00', 'test', '2024-06-29 00:00:00', 'test');";
                //string cityRecord = "INSERT INTO CITY VALUES(@cityID, @city, @countryID, '2024-06-29 00:00:00', 'test', '2024-06-29 00:00:00', 'test');";
                //string countryRecord = "INSERT INTO COUNTRY(country, createdate, createdby, lastupdate, lastupdateby)VALUES (@country,'2024-06-29 00:00:00', 'test', '2024-06-29 00:00:00', 'test');";

                string updateCustomer = "UPDATE CUSTOMER SET customerName=@name WHERE customerID = @customerID;";
                string addressRecord = "INSERT INTO ADDRESS VALUES(@addressID,@address, 'fake', @cityID, @zipCode, @phone, '2024-06-29 00:00:00', 'test', '2024-06-29 00:00:00', 'test');";
                string cityRecord = "INSERT INTO CITY VALUES(@cityID, @city, @countryID, '2024-06-29 00:00:00', 'test', '2024-06-29 00:00:00', 'test');";
                string countryRecord = "INSERT INTO COUNTRY(country, createdate, createdby, lastupdate, lastupdateby)VALUES (@country,'2024-06-29 00:00:00', 'test', '2024-06-29 00:00:00', 'test');";

               
                //string updateCommands = countryRecord + cityRecord + addressRecord + updateCustomer;

                sqlCommand = new MySqlCommand(countryRecord, Connection.conn);
        
                sqlCommand.Parameters.AddWithValue("@name", name);
                sqlCommand.Parameters.AddWithValue("@customerID", customerID);
                sqlCommand.Parameters.AddWithValue("@address", address);
                sqlCommand.Parameters.AddWithValue("@city", city);
                sqlCommand.Parameters.AddWithValue("@state", state);
                sqlCommand.Parameters.AddWithValue("@country", country);
                sqlCommand.Parameters.AddWithValue("@phone", phone);
                sqlCommand.Parameters.AddWithValue("@zipCode", zipCode);
               


                //sqlCommand.Parameters.AddWithValue("@addressID", addressIDint);
                //sqlCommand.Parameters.AddWithValue("@cityID", cityIDint);
                //sqlCommand.Parameters.AddWithValue("@countryID", countryIDint);
                reader = sqlCommand.ExecuteReader();
                reader.Close();
                string countryIDQuery = "SELECT MAX(countryId) FROM Country";
                sqlCommand = new MySqlCommand(countryIDQuery, Connection.conn);
                MySqlDataAdapter sda = new MySqlDataAdapter(sqlCommand);
                DataTable dt3 = new DataTable();
                MySqlDataAdapter sda3 = new MySqlDataAdapter(sqlCommand);
                sda.Fill(dt3);
                string countryIDString = dt3.Rows[0][0].ToString();
                int countryIDint = int.Parse(countryIDString);
                MessageBox.Show(countryIDint.ToString());
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
    }
}
