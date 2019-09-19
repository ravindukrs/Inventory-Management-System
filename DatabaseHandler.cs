using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Data;

namespace InventoryManagementSystem
{
    class DatabaseHandler
    {
        static string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=ims";

        //Get 1 value as result from query
        public static string returnOneValue(string query, List<MySqlParameter> paramsCollection, string column)
        {
            string data = null;
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.Parameters.Clear();
            commandDatabase.Parameters.AddRange(paramsCollection.ToArray<MySqlParameter>());
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                Console.WriteLine("Connection Made");
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                Console.WriteLine("Reader got data");

                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        data = myReader.GetString(column);
                    }
                }
                else
                {
                    data = "Null Data!";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                databaseConnection.Close();
            }

            return data;
        }

        //Get 1 value as result from query
        public static string returnOneValueWithoutParams(string query, string column)
        {
            string data = null;
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            
            try
            {
                databaseConnection.Open();
                Console.WriteLine("Connection Made");
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                Console.WriteLine("Reader got data");

                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        data = myReader.GetString(column);
                    }
                }
                else
                {
                    data = "Null Data!";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                databaseConnection.Close();
            }

            return data;
        }

        //Get result row count
        public static int returnRowCount(string query, List<MySqlParameter> paramsCollection)
        {
            int count = 0;
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.Parameters.Clear();
            commandDatabase.Parameters.AddRange(paramsCollection.ToArray<MySqlParameter>());
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                Console.WriteLine("Connection Made");
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        count++;
                    }
                }
                else
                {
                    count = 0;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                databaseConnection.Close();
            }

            return count;
        }

        //Get Row Count without parameters
        public static int returnRowCountWithoutParams(string query)
        {
            int count = 0;
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
           

            try
            {
                databaseConnection.Open();
                Console.WriteLine("Connection Made");
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        count++;
                    }
                }
                else
                {
                    count = 0;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                databaseConnection.Close();
            }

            return count;
        }




        //Insert data 
        public static int insertOrDeleteRow(string query, List<MySqlParameter> paramsCollection)
        {
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.Parameters.Clear();
            commandDatabase.Parameters.AddRange(paramsCollection.ToArray<MySqlParameter>());
            commandDatabase.CommandTimeout = 60;
            int rowsAffected = 0;
            try
            {
                databaseConnection.Open();
                Console.WriteLine("Connection Made");
                rowsAffected = commandDatabase.ExecuteNonQuery();
                Console.WriteLine("Rows Affected: " + rowsAffected);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                databaseConnection.Close();
                
            }
            return rowsAffected;
        }

        //Populate DataViews
        public static void populateViewwithNoParameters(string query, DataGridView dataGridView)
        {
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.Font =
                new Font(dataGridView.Font, FontStyle.Bold);
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            var dataAdapter = new MySqlDataAdapter(query, MySQLConnectionString);
            var commandBuilder = new MySqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView.ReadOnly = true;
            dataGridView.DataSource = ds.Tables[0];

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        public static void populateViewwithParameters(string query, List<MySqlParameter> paramsCollection, DataGridView dataGridView)
        {
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.Font =
                new Font(dataGridView.Font, FontStyle.Bold);
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            var dataAdapter = new MySqlDataAdapter(query, MySQLConnectionString);
            var commandBuilder = new MySqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView.ReadOnly = true;
            dataGridView.DataSource = ds.Tables[0];

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        //Populate ComboBox
        /* public static void populateCombobox(string query, ComboBox comboBox)
         {
             comboBox.Items.Clear();
             var dataAdapter = new MySqlDataAdapter(query, MySQLConnectionString);
             var commandBuilder = new MySqlCommandBuilder(dataAdapter);
             var dt = new DataTable();
             dataAdapter.Fill(dt);

             foreach (DataRow dr in dt.Rows)
             {
                 comboBox.Items.Add(dr["Supplier Code"].ToString()+"         "+dr["Supplier"].ToString());
             }


         }*/

        //Populate ComboBox
        public static void populateCombobox(string query, ComboBox comboBox)
        {
            
            var dataAdapter = new MySqlDataAdapter(query, MySQLConnectionString);
            var commandBuilder = new MySqlCommandBuilder(dataAdapter);
            var dt = new DataTable();
            dt.Columns.Add("Supplier Code");
            dt.Columns.Add("Supplier");
            dataAdapter.Fill(dt);

            comboBox.DataSource = dt;
            comboBox.DisplayMember = "Supplier";
            comboBox.ValueMember = "Supplier Code";

        }

        //Populate ComboBox
        public static void populateDispatchCombobox(string query, ComboBox comboBox)
        {
            Console.WriteLine("Inside DH");
            Console.WriteLine(query);
            Console.WriteLine(comboBox);
            var dataAdapter = new MySqlDataAdapter(query, MySQLConnectionString);
            var commandBuilder = new MySqlCommandBuilder(dataAdapter);
            var dt = new DataTable();
            dt.Columns.Add("Client Code");
            dt.Columns.Add("Client Name");
            dataAdapter.Fill(dt);

            comboBox.DataSource = dt;
            comboBox.DisplayMember = "Client Name";
            comboBox.ValueMember = "Client Code";

        }

        //Populate GridView with binding
        public static void populateGridViewWithBinding(string query, DataGridView dataGridView)
        {
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.Font =
                new Font(dataGridView.Font, FontStyle.Bold);
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            var dataAdapter = new MySqlDataAdapter(query, MySQLConnectionString);
            var commandBuilder = new MySqlCommandBuilder(dataAdapter);
            var dt = new DataTable();
            try { dataAdapter.Fill(dt); }catch(Exception err)
            {
                MessageBox.Show(err.ToString());
                MessageBox.Show(query);
            }

            dataGridView.DataSource = dt;

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }


    }
}
