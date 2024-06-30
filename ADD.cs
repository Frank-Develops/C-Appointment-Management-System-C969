﻿using MySql.Data.MySqlClient;
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
                int addressIDint = int.Parse(customerIDString);
                addressIDint++;
                string cityIDQuery = "SELECT MAX(cityId) FROM City";
                sqlCommand = new MySqlCommand(cityIDQuery, Connection.conn);
                DataTable dt3 = new DataTable();
                MySqlDataAdapter sda3 = new MySqlDataAdapter(sqlCommand);
                sda.Fill(dt3);
                string cityIDString = dt3.Rows[0][0].ToString();
                int cityIDint = int.Parse(customerIDString);
                cityIDint++;
                string countryIDQuery = "SELECT MAX(countryId) FROM Country";
                sqlCommand = new MySqlCommand(countryIDQuery, Connection.conn);
                DataTable dt4 = new DataTable();
                MySqlDataAdapter sda4 = new MySqlDataAdapter(sqlCommand);
                sda.Fill(dt4);
                string countryIDString = dt4.Rows[0][0].ToString();
                int countryIDint = int.Parse(countryIDString);
                countryIDint++;




                string customerRecord = "INSERT INTO CUSTOMER (customerID, customerName, addressID, active, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES(@customerID, @name, @addressID, 1, '2024-06-29 00:00:00', 'test', '2024-06-29 00:00:00', 'test'); ";
                string addressRecord = "INSERT INTO ADDRESS (addressID, address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate,lastUpdateBy) VALUES(@addressID,@address, 'fake', @cityID, @zipCode, @phone, '2024-06-29 00:00:00', 'test', '2024-06-29 00:00:00', 'test');";
                string cityRecord = "INSERT INTO CITY (cityId, city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES(@cityID, @city, @countryID, '2024-06-29 00:00:00', 'test', '2024-06-29 00:00:00', 'test');";
                string countryRecord = "INSERT INTO COUNTRY (countryId, country, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES(@countryID, @country,'2024-06-29 00:00:00', 'test', '2024-06-29 00:00:00', 'test');";




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
                reader.Close();
            }
        }
    }
}