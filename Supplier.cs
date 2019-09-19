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
    public partial class Supplier : UserControl
    {
        public Supplier()
        {
            InitializeComponent();
        }

        public void Supplier_Load(object sender, EventArgs e)
        {
            populateGrid();
            if (GlobalLoginData.userRole == "Admin")
            {

            }else if(GlobalLoginData.userRole == "Purchasing"){
                
            }
            else
            {
                removeItemBtn.Enabled = false;
                masterRemoveBtn.Enabled = false;
                addSupplierBtn.Enabled = false;
                addItemBtn.Enabled = false;
                removeSupplierBtn.Enabled = false;
                removeItemBtn.Enabled = false;
                masterRemoveBtn.Enabled = false;
            }
        }

        private void contactNumTxt_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(contactNumberTxt.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                contactNumberTxt.Text = contactNumberTxt.Text.Remove(contactNumberTxt.Text.Length - 1);
            }
        }

        private void addSupplierBtn_Click(object sender, EventArgs e)
        {
            string supplierName = supplierNameTxt.Text;
            string supplierCode = supplierCodeTxt.Text;
            string contactNumber = contactNumberTxt.Text;
            string contactName = contactNameTxt.Text;
            string email = emailTxt.Text;

            if (!String.IsNullOrEmpty(supplierName) && !String.IsNullOrEmpty(supplierCode) && !String.IsNullOrEmpty(contactNumber) && !String.IsNullOrEmpty(contactName) && !String.IsNullOrEmpty(email))
            {
                try
                {
                    string query = "INSERT INTO SUPPLIER VALUES (@supplierCode,@supplierName,@contactName,@contactNumber,@email)";
                    List<MySqlParameter> paramList = new List<MySqlParameter>();
                    paramList.Add(new MySqlParameter("@supplierCode", supplierCode));
                    paramList.Add(new MySqlParameter("@supplierName", supplierName));
                    paramList.Add(new MySqlParameter("@contactName", contactName));
                    paramList.Add(new MySqlParameter("@contactNumber", contactNumber));
                    paramList.Add(new MySqlParameter("@email", email));

                    int rowsAffected = DatabaseHandler.insertOrDeleteRow(query, paramList);

                    if(rowsAffected != 0)
                    {
                        MessageBox.Show("Supplier Added Successfully!");
                        populateGrid();
                        supplierNameTxt.Text="";
                        supplierCodeTxt.Text="";
                        contactNumberTxt.Text="";
                        contactNameTxt.Text="";
                        emailTxt.Text="";
                    }
                    else
                    {
                        MessageBox.Show("Error Occured! Please check if the Supplier already exists!");
                    }
                   
                }
                catch (Exception)
                {
                    MessageBox.Show("Error Occured! Please check if the Supplier already exists!");
                }
            }
        }

        private void populateGrid()
        {
            string selectStatement = "SELECT supplier_code as 'Supplier Code', supplier_name as 'Supplier' , contact_name as 'Contact Person', contact_number as 'Contact Number', email as 'Email' FROM SUPPLIER";
            DatabaseHandler.populateViewwithNoParameters(selectStatement, dataGridView1);

            string selectStatement4 = "SELECT STORE.item_code as 'Item Code', STORE.item_name as 'Item Name', STORE.description as 'Description', SUPPLIER.supplier_code as 'Supplier Code', SUPPLIER.supplier_name as 'Supplier' FROM SUPPLIER INNER JOIN STORE ON SUPPLIER.supplier_code = STORE.supplier_code WHERE STORE.pending_removal='Yes'"; 
            DatabaseHandler.populateViewwithNoParameters(selectStatement4, dataGridView3);

            if (!String.IsNullOrEmpty(findById.Text))
            {
                string selectStatement2 = "SELECT STORE.item_code as 'Item Code', STORE.item_name as 'Item Name', STORE.description as 'Description', SUPPLIER.supplier_code as 'Supplier Code', SUPPLIER.supplier_name as 'Supplier' FROM SUPPLIER INNER JOIN STORE ON SUPPLIER.supplier_code = STORE.supplier_code WHERE SUPPLIER.supplier_code like '%" + findById.Text + "%'";
                DatabaseHandler.populateViewwithNoParameters(selectStatement2, dataGridView2);
            }
            else if(!String.IsNullOrEmpty(findByName.Text))
            {
                string selectStatement3 = "SELECT STORE.item_code as 'Item Code', STORE.item_name as 'Item Name', STORE.description as 'Description', SUPPLIER.supplier_code as 'Supplier Code', SUPPLIER.supplier_name as 'Supplier' FROM SUPPLIER INNER JOIN STORE ON SUPPLIER.supplier_code = STORE.supplier_code WHERE SUPPLIER.supplier_name like '%" + findByName.Text + "%'";
                DatabaseHandler.populateViewwithNoParameters(selectStatement3, dataGridView2);
            }
            else
            {
                string selectStatement3 = "SELECT STORE.item_code as 'Item Code', STORE.item_name as 'Item Name', STORE.description as 'Description', SUPPLIER.supplier_code as 'Supplier Code', SUPPLIER.supplier_name as 'Supplier' FROM SUPPLIER INNER JOIN STORE ON SUPPLIER.supplier_code = STORE.supplier_code";
                DatabaseHandler.populateViewwithNoParameters(selectStatement3, dataGridView2);
            }
           

           
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            string itemSupplierCode = itemSupplierCodeTxt.Text;
            string itemId = itemIdTxt.Text;
            string itemName = itemNameTxt.Text;
            string description = descriptionTxt.Text;

            if (!String.IsNullOrEmpty(itemSupplierCode) && !String.IsNullOrEmpty(itemId) && !String.IsNullOrEmpty(itemName) && !String.IsNullOrEmpty(description))
            {
                try
                {
                    string query = "INSERT INTO STORE(supplier_code,item_code,item_name,description) VALUES (@itemSupplierCode,@itemId,@itemName,@description)";
                    List<MySqlParameter> paramList = new List<MySqlParameter>();
                    paramList.Add(new MySqlParameter("@itemSupplierCode", itemSupplierCode));
                    paramList.Add(new MySqlParameter("@itemId", itemId));
                    paramList.Add(new MySqlParameter("@itemName", itemName));
                    paramList.Add(new MySqlParameter("@description", description));
                    
                    int rowsAffected = DatabaseHandler.insertOrDeleteRow(query, paramList);

                    if(rowsAffected != 0)
                    {
                        MessageBox.Show("Item Added Successfully!");
                        itemSupplierCodeTxt.Text="";
                        itemIdTxt.Text = "";
                        itemNameTxt.Text = "";
                        descriptionTxt.Text = "";
                        populateGrid();
                    }
                    else
                    {
                        MessageBox.Show("Error Occured! Please check if the Item already exists/Info entered!");

                    }


                }
                catch (Exception)
                {
                    MessageBox.Show("Error Occured! Please check if the Item already exists/Info entered!");
                }
            }
        }

        private void itemSupplierCodeTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string selectStatement = "SELECT supplier_code as 'Supplier Code', supplier_name as 'Supplier' , contact_name as 'Contact Person', contact_number as 'Contact Number', email as 'Email' FROM SUPPLIER WHERE supplier_code like '%" + itemSupplierCodeTxt.Text + "%'";
                DatabaseHandler.populateViewwithNoParameters(selectStatement, dataGridView1);
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
        }

        private void removeSupplierBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM SUPPLIER WHERE supplier_code=@supplierCode";
                List<MySqlParameter> paramList = new List<MySqlParameter>();
                paramList.Clear();
                paramList.Add(new MySqlParameter("@supplierCode", removeSupplierId.Text));
                int rowsAffected = DatabaseHandler.insertOrDeleteRow(query, paramList);

                if (rowsAffected != 0)
                {
                    MessageBox.Show("Supplier Removed Successfully!");
                    populateGrid();
                }
                else
                {
                    MessageBox.Show("Error! The supplier may have unremoved items. Remove items first!");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error! The supplier may have unremoved items. Remove items first!");
            }
        }

        private void removeSupplierId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string selectStatement = "SELECT supplier_code as 'Supplier Code', supplier_name as 'Supplier' , contact_name as 'Contact Person', contact_number as 'Contact Number', email as 'Email' FROM SUPPLIER WHERE supplier_code like '%" + removeSupplierId.Text + "%'";
                DatabaseHandler.populateViewwithNoParameters(selectStatement, dataGridView1);
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
        }

        private void findById_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string selectStatement = "SELECT supplier_code as 'Supplier Code', supplier_name as 'Supplier' , contact_name as 'Contact Person', contact_number as 'Contact Number', email as 'Email' FROM SUPPLIER WHERE supplier_code like '%" + findById.Text + "%'";
                DatabaseHandler.populateViewwithNoParameters(selectStatement, dataGridView1);

                string selectStatement2 = "SELECT STORE.item_code as 'Item Code', STORE.item_name as 'Item Name', STORE.description as 'Description', SUPPLIER.supplier_code as 'Supplier Code', SUPPLIER.supplier_name as 'Supplier' FROM SUPPLIER INNER JOIN STORE ON SUPPLIER.supplier_code = STORE.supplier_code WHERE SUPPLIER.supplier_code like '%" + findById.Text + "%'";
                DatabaseHandler.populateViewwithNoParameters(selectStatement2, dataGridView2);
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
                string selectStatement = "SELECT supplier_code as 'Supplier Code', supplier_name as 'Supplier' , contact_name as 'Contact Person', contact_number as 'Contact Number', email as 'Email' FROM SUPPLIER WHERE supplier_name like '%" + findByName.Text + "%'";
                DatabaseHandler.populateViewwithNoParameters(selectStatement, dataGridView1);

                string selectStatement2 = "SELECT STORE.item_code as 'Item Code', STORE.item_name as 'Item Name', STORE.description as 'Description', SUPPLIER.supplier_code as 'Supplier Code', SUPPLIER.supplier_name as 'Supplier' FROM SUPPLIER INNER JOIN STORE ON SUPPLIER.supplier_code = STORE.supplier_code WHERE SUPPLIER.supplier_name like '%" + findByName.Text + "%'";
                DatabaseHandler.populateViewwithNoParameters(selectStatement2, dataGridView2);
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
        }

        private void removeItemBtn_Click(object sender, EventArgs e)
        {
            removeItem();

        }

        private void requestRemovalBtn_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridView2.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView2.Rows[selectedRowIndex];
            string itemCode = Convert.ToString(selectedRow.Cells["Item Code"].Value);

            try
            {
                string query = "UPDATE STORE SET pending_removal = @state WHERE item_code=@itemCode";
                List<MySqlParameter> paramList = new List<MySqlParameter>();
                paramList.Clear();
                paramList.Add(new MySqlParameter("@state", "Yes"));
                paramList.Add(new MySqlParameter("@itemCode", itemCode));
                int rowsAffected = DatabaseHandler.insertOrDeleteRow(query, paramList);

                if (rowsAffected != 0)
                {
                    MessageBox.Show("Removal Request Added!");
                    populateGrid();
                }
                else
                {
                    MessageBox.Show("Error!");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
            }

            

        }

        private void masterRemoveBtn_Click(object sender, EventArgs e)
        {
            removeItem();
        }

        private void removeItem()
        {
            int selectedRowIndex = dataGridView2.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView2.Rows[selectedRowIndex];
            string itemCode = Convert.ToString(selectedRow.Cells["Item Code"].Value);

            try
            {
                string query = "DELETE FROM STORE WHERE item_code=@itemCode";
                List<MySqlParameter> paramList = new List<MySqlParameter>();
                paramList.Clear();
                paramList.Add(new MySqlParameter("@itemCode", itemCode));
                int rowsAffected = DatabaseHandler.insertOrDeleteRow(query, paramList);

                if (rowsAffected != 0)
                {
                    MessageBox.Show("Item Removed Successfully!");
                    populateGrid();
                }
                else
                {
                    MessageBox.Show("Error!");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
            }
        }
    }
}
