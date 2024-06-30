using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

                string customerRecord = "INSERT INTO CUSTOMER (customerID, customerName, addressID, active, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES(101, @name, 101, 1, '2024-06-29 00:00:00', 'test', '2024-06-29 00:00:00', 'test'); ";
                string addressRecord = "INSERT INTO ADDRESS (addressID, address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate,lastUpdateBy) VALUES(101,@address, 'fake', 101, @zipCode, @phone, '2024-06-29 00:00:00', 'test', '2024-06-29 00:00:00', 'test');";
                string cityRecord = "INSERT INTO CITY (cityId, city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES(101, @city, 101, '2024-06-29 00:00:00', 'test', '2024-06-29 00:00:00', 'test');";
                string countryRecord = "INSERT INTO COUNTRY (countryId, country, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES(101, @country,'2024-06-29 00:00:00', 'test', '2024-06-29 00:00:00', 'test');";




                string addRecord = countryRecord + cityRecord + addressRecord + customerRecord;

                MessageBox.Show(addRecord);

                sqlCommand = new MySqlCommand(addRecord, Connection.conn);
                sqlCommand.Parameters.AddWithValue("@name", name);
                sqlCommand.Parameters.AddWithValue("@address", address);
                sqlCommand.Parameters.AddWithValue("@city", city);
                sqlCommand.Parameters.AddWithValue("@state", state);
                sqlCommand.Parameters.AddWithValue("@country", country);
                sqlCommand.Parameters.AddWithValue("@phone", phone);
                sqlCommand.Parameters.AddWithValue("@zipCode", zipCode);
                reader = sqlCommand.ExecuteReader();

                if (reader.Read())
                {


                    MessageBox.Show("Record Added");
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                {

                    MessageBox.Show(ex.Message);

                }
            }
        }
    }
}
