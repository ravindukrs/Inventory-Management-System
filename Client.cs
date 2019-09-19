using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InventoryManagementSystem
{
    public partial class Client : UserControl
    {
        public Client()
        {
            InitializeComponent();
        }

        public void Client_Load(object sender, EventArgs e)
        {
            populateGrid();
            if (GlobalLoginData.userRole == "Admin")
            {

            }
            else
            {
                addBtnTxt.Enabled = false;
            }
        }
        private void addBtnTxt_Click(object sender, EventArgs e)
        {
            string hospital = hospitalTxt.Text;
            string identifier = identifierTxt.Text;
            string area = areaTxt.Text;
            string contactName = contactNameTxt.Text;
            string contactNum = contactNumTxt.Text;
            string email = emailTxt.Text;

            if (!String.IsNullOrEmpty(hospital) && !String.IsNullOrEmpty(identifier) && !String.IsNullOrEmpty(area) && !String.IsNullOrEmpty(contactNum) && !String.IsNullOrEmpty(contactName) && !String.IsNullOrEmpty(email))
            {
                try
                {
                    string query = "INSERT INTO CLIENT VALUES (@hospital,@identifier,@area,@contactName,@contactNum,@email)";
                    List<MySqlParameter> paramList = new List<MySqlParameter>();
                    paramList.Add(new MySqlParameter("@hospital", hospital));
                    paramList.Add(new MySqlParameter("@identifier", identifier));
                    paramList.Add(new MySqlParameter("@area", area));
                    paramList.Add(new MySqlParameter("@contactName", contactName));
                    paramList.Add(new MySqlParameter("@contactNum", contactNum));
                    paramList.Add(new MySqlParameter("@email", email));

                    int rowsAffected = DatabaseHandler.insertOrDeleteRow(query, paramList);

                    if (rowsAffected != 0)
                    {
                        MessageBox.Show("Supplier Added Successfully!");
                        hospitalTxt.Text="";
                        identifierTxt.Text="";
                        areaTxt.Text="";
                        contactNameTxt.Text="";
                        contactNumTxt.Text="";
                        emailTxt.Text="";
                        populateGrid();
                    }
                    else
                    {
                        MessageBox.Show("Error Occured! Please check if the Client already exists!");
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Error Occured! Please check if the Client already exists!");
                }
            }
        }

        private void populateGrid()
        {
            string selectStatement = "SELECT hospital as 'Hospital', identifier_code as 'Identifier Code' , area as 'Area', contact_name as 'Contact Name',contact_number as 'Contact Number', email as 'Email' FROM CLIENT";
            DatabaseHandler.populateViewwithNoParameters(selectStatement, dataGridView1);
        }

        private void findById_TextChanged(object sender, EventArgs e)
        {

            try
            {
                string selectStatement = "SELECT hospital as 'Hospital', identifier_code as 'Identifier Code' , area as 'Area', contact_name as 'Contact Name',contact_number as 'Contact Number', email as 'Email' FROM CLIENT WHERE identifier_code like '%" + findById.Text + "%'";
                DatabaseHandler.populateViewwithNoParameters(selectStatement, dataGridView1);
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
        }

        private void findByName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string selectStatement = "SELECT hospital as 'Hospital', identifier_code as 'Identifier Code' , area as 'Area', contact_name as 'Contact Name',contact_number as 'Contact Number', email as 'Email' FROM CLIENT WHERE hospital like '%" + findByName.Text + "%'";
                DatabaseHandler.populateViewwithNoParameters(selectStatement, dataGridView1);
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
        }

        private void contactNumTxt_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(contactNumTxt.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                contactNumTxt.Text = contactNumTxt.Text.Remove(contactNumTxt.Text.Length - 1);
            }
        }
    }
}
