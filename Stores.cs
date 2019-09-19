using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class Stores : UserControl
    {
        public Stores()
        {
            InitializeComponent();
        }


        public void Stores_Load(object sender, EventArgs e)
        {
            populateGrid();
            if (GlobalLoginData.userRole != "Admin")
            {
                manualAddBtn.Enabled = false;
                manualSubstractBtn.Enabled = false;
            }
            if (GlobalLoginData.userRole != "Admin"&& GlobalLoginData.userRole != "Store Keeper")
            {
                postRequest.Enabled = false;
            }
        }

        
        private void populateGrid()
        {
            string query = "SELECT item_code as 'Item Code', item_name as 'Item Name', qty as 'Available Quantity', description as 'Description'FROM STORE";
            DatabaseHandler.populateGridViewWithBinding(query, dataGridView1);
        }

        private void findProductName_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT item_code as 'Item Code', item_name as 'Item Name', qty as 'Available Quantity', description as 'Description' FROM STORE WHERE item_name like '%" + findProductName.Text + "%'";
            DatabaseHandler.populateGridViewWithBinding(query, dataGridView1);
        }

        private void findProductId_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT item_code as 'Item Code', item_name as 'Item Name', qty as 'Available Quantity', description as 'Description' FROM STORE WHERE item_code like '%" + findProductId.Text + "%'";
            DatabaseHandler.populateGridViewWithBinding(query, dataGridView1);
        }

        private void manualProductId_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT item_code as 'Item Code', item_name as 'Item Name', qty as 'Available Quantity', description as 'Description' FROM STORE WHERE item_code like '%" + findProductId.Text + "%'";
            DatabaseHandler.populateGridViewWithBinding(query, dataGridView1);
        }

        private void manualQty_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(manualQty.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter numbers only..");
                manualQty.Text = manualQty.Text.Remove(manualQty.Text.Length - 1);
            }
        }

        private void manualAddBtn_Click(object sender, EventArgs e)
        {

            List<MySqlParameter> paramList = new List<MySqlParameter>();
            paramList.Clear();
            paramList.Add(new MySqlParameter("@itemCode", manualProductId.Text));
            int returnedRowCount = DatabaseHandler.returnRowCount("SELECT * FROM STORE WHERE item_code = @itemCode", paramList);

            if (returnedRowCount == 1)
            {
                try
                {
                    List<MySqlParameter> paramList2 = new List<MySqlParameter>();
                    paramList2.Clear();
                    paramList2.Add(new MySqlParameter("@itemQty", manualQty.Text));
                    paramList2.Add(new MySqlParameter("@itemCode", manualProductId.Text));
                    int responseChange = DatabaseHandler.insertOrDeleteRow("UPDATE STORE SET qty = qty + @itemQty WHERE item_code = @itemCode", paramList2);
                    if (responseChange == 1)
                    {
                        MessageBox.Show("Update Successful");
                    }
                    else
                    {
                        MessageBox.Show("Error Occured!");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error Occured!");
                }
            }
            else
            {
                MessageBox.Show("Sorry, Invalid Item Code");
            }
            populateGrid();

        }

        private void manualSubstractBtn_Click(object sender, EventArgs e)
        {
            List<MySqlParameter> paramList = new List<MySqlParameter>();
            paramList.Clear();
            paramList.Add(new MySqlParameter("@itemCode", manualProductId.Text));
            int returnedRowCount = DatabaseHandler.returnRowCount("SELECT * FROM STORE WHERE item_code = @itemCode", paramList);

            if (returnedRowCount == 1)
            {
                
                try
                {
                    List<MySqlParameter> paramList3 = new List<MySqlParameter>();
                    paramList3.Clear();
                    paramList3.Add(new MySqlParameter("@itemCode", manualProductId.Text));
                    paramList3.Add(new MySqlParameter("@value", manualQty.Text));
                    string queryGetQtyCondition = "SELECT IF(qty >= @value,'Yes','No') AS possibility FROM STORE WHERE item_code = @itemCode";
                    string possibility = DatabaseHandler.returnOneValue(queryGetQtyCondition, paramList3,"possibility");
                    Console.WriteLine("String Possobility "+possibility);
                    if (string.Compare(possibility, "Yes") == 0)
                    {
                        Console.WriteLine("String Possobility Inside If " );
                        try
                        {
                            List<MySqlParameter> paramList2 = new List<MySqlParameter>();
                            paramList2.Clear();
                            paramList2.Add(new MySqlParameter("@itemQty", manualQty.Text));
                            paramList2.Add(new MySqlParameter("@itemCode", manualProductId.Text));
                            int responseChange = DatabaseHandler.insertOrDeleteRow("UPDATE STORE SET qty = qty - @itemQty WHERE item_code = @itemCode", paramList2);
                            if (responseChange == 1)
                            {
                                MessageBox.Show("Update Successful");
                            }
                            else
                            {
                                MessageBox.Show("Error Occured!");
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error Occured!");
                        }
                    }
                }
                catch(Exception err)
                {
                    MessageBox.Show("Sorry, Invalid Item Code");
                }
               
            }
            else
            {
                MessageBox.Show("Sorry, Invalid Item Code");
            }
            populateGrid();
        }

        private void postRequest_Click(object sender, EventArgs e)
        {
            try
            {
                
                string getSupplierCodeQuery = "SELECT supplier_code from STORE WHERE item_code='" + reqProdId.Text + "'";
                int rowCountSuppliers = DatabaseHandler.returnRowCountWithoutParams(getSupplierCodeQuery);
                Console.WriteLine("getSupplierCodeQuery: " + getSupplierCodeQuery + " rowCountSuppliers: " + rowCountSuppliers);

                if (rowCountSuppliers == 1)
                {
                    string supplierCode = DatabaseHandler.returnOneValueWithoutParams(getSupplierCodeQuery, "supplier_code");
                    Console.WriteLine("supplierCode: " + supplierCode);

                    try
                    {
                        string query = "insert into purchaseorder(supplier_code, approval,postedUser) values (@supplierCode,'Pending',@user);";
                        List<MySqlParameter> paramList = new List<MySqlParameter>();
                        paramList.Clear();
                        paramList.Add(new MySqlParameter("@supplierCode", supplierCode));
                        paramList.Add(new MySqlParameter("@user", GlobalLoginData.username));

                        int rowsAffected = DatabaseHandler.insertOrDeleteRow(query, paramList);
                        Console.WriteLine("rowsAffected: " + rowsAffected);
                        if (rowsAffected != 0)
                        {

                            string lastPo = DatabaseHandler.returnOneValueWithoutParams("SELECT*FROM purchaseorder", "po");
                            int lastPoNum;
                            if (lastPo == "Null Data!")
                            {
                                lastPoNum = 0;
                            }
                            else
                            {
                                lastPoNum = Int32.Parse(lastPo);
                            }
                            Console.WriteLine("lastPoNum: " + lastPoNum);
                           

                            string insertQuery = "INSERT INTO po_item VALUES (@poNum,@itemCode,@qty)";
                            List<MySqlParameter> paramList2 = new List<MySqlParameter>();
                            paramList2.Add(new MySqlParameter("@poNum", lastPoNum));
                            paramList2.Add(new MySqlParameter("@itemCode", reqProdId.Text));
                            paramList2.Add(new MySqlParameter("@qty", reqQty.Text));

                            int rowsAffected2 = DatabaseHandler.insertOrDeleteRow(insertQuery, paramList2);
                            Console.WriteLine("rowsAffected2: " + rowsAffected2);
                            if (rowsAffected2 != 0)
                            {
                                MessageBox.Show("Purchase Request Created Successfully!");
                                populateGrid();
                            }
                            else
                            {
                                MessageBox.Show("Error Occured! PO-Item Link Broken!");
                            }

                            
                          
                            populateGrid();
                        }
                        else
                        {
                            MessageBox.Show("Error Occured! Please check input details!");
                        }

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error Occured! Please check input details!");
                    }
                }
            }
            catch (Exception)
            {

            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
