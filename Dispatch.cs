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
    public partial class Dispatch : UserControl
    {
        string selectedClient = null;
        DataRowView selectedRow;
        int globalLastRo;

        public Dispatch()
        {
            InitializeComponent();
        }

        public void Dispatch_Load(object sender, EventArgs e)
        {
            if (GlobalLoginData.userRole != "Admin")
            {
                approveBtn.Enabled = false;
                declineBtn.Enabled = false;
            }
            if (GlobalLoginData.userRole != "Admin" && GlobalLoginData.userRole !="Purchasing")
            {
                dispatchBtn.Enabled = false;
            }
            setReqNum();
            populateDataGrid();
            populateDispatchCombo();
            try
            {
                clientComboBox.SelectedIndex = 0;
            }
            catch (Exception)
            {

            }
            selectComboBoxValue();
            dataViewDesign(dataGridView4);
            dataViewDesign(dataGridView6);

        }

        private void clientComboBox_DropDown(object sender, EventArgs e)
        {
            populateDispatchCombo();
        }

        private void clientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectComboBoxValue();
        }

        private void populateDispatchCombo()
        {
            string selectStatement = "SELECT identifier_code as 'Client Code', hospital as 'Client Name' FROM client";
            DatabaseHandler.populateDispatchCombobox(selectStatement, clientComboBox);
        }

        private void clientComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            selectComboBoxValue();
        }

        private void selectComboBoxValue()
        {
            selectedRow = clientComboBox.SelectedItem as DataRowView;
            if (selectedRow != null)
            {
                selectedClient = selectedRow.Row["Client Code"] as string;
            }
        }

        private void populateDataGrid()
        {
            string selectStatement = "SELECT STORE.item_code as 'Item Code', STORE.item_name as 'Item Name', STORE.description as 'Item Description', STORE.qty as 'Available Quantity', SUPPLIER.supplier_name as 'Supplier' FROM STORE INNER JOIN SUPPLIER ON STORE.supplier_code = SUPPLIER.supplier_code";
            DatabaseHandler.populateGridViewWithBinding(selectStatement, dataGridView5);

            string selectStatement1 = "SELECT requestorder.ro as 'Order #', client.hospital as 'Client Name', requestorder.creation_time as 'Posted Time', requestorder.postedUser as 'User' FROM requestorder inner join client on requestorder.client_code = client.identifier_code WHERE requestorder.approval = 'Pending' AND requestorder.released='No'";
            DatabaseHandler.populateGridViewWithBinding(selectStatement1, dataGridView1);

            string selectStatement2 = "SELECT requestorder.ro as 'Order #', client.hospital as 'Client Name', requestorder.creation_time as 'Posted Time', requestorder.postedUser as 'User' FROM requestorder inner join client on requestorder.client_code = client.identifier_code WHERE requestorder.approval = 'Approved' AND requestorder.released='No'";
            DatabaseHandler.populateGridViewWithBinding(selectStatement2, dataGridView2);

            string selectStatement3 = "SELECT requestorder.ro as 'Order #', client.hospital as 'Client Name', requestorder.creation_time as 'Posted Time', requestorder.postedUser as 'User' FROM requestorder inner join client on requestorder.client_code = client.identifier_code WHERE requestorder.approval = 'Approved' AND requestorder.released='Yes'";
            DatabaseHandler.populateGridViewWithBinding(selectStatement3, dataGridView3);
        }

        private void itemName_TextChanged(object sender, EventArgs e)
        {
            string selectStatement = "SELECT STORE.item_code as 'Item Code', STORE.item_name as 'Item Name', STORE.description as 'Item Description', STORE.qty as 'Available Quantity', SUPPLIER.supplier_name as 'Supplier' FROM STORE INNER JOIN SUPPLIER ON STORE.supplier_code = SUPPLIER.supplier_code WHERE STORE.item_name like '%" + itemNameTxt.Text + "%'";
            DatabaseHandler.populateGridViewWithBinding(selectStatement, dataGridView5);
        }

        private void qtyTxt_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(qtyTxt.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                qtyTxt.Text = qtyTxt.Text.Remove(qtyTxt.Text.Length - 1);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string itemCode;
            string itemQty;
            string itemName;
            try
            {
                itemCode = dataGridView5.SelectedRows[0].Cells["Item Code"].Value.ToString();
            }
            catch (Exception)
            {
                itemCode = null;
            }
           
            if(itemCode == null)
            {
                MessageBox.Show("Invalid Selection!");
            }
            else
            {
                itemQty = qtyTxt.Text;

                List<MySqlParameter> paramlist = new List<MySqlParameter>();
                paramlist.Clear();
                paramlist.Add(new MySqlParameter("@itemCode", itemCode));
                paramlist.Add(new MySqlParameter("@value", itemQty));
                string queryGetQtyCondition = "SELECT IF(qty >= @value,'Yes','No') AS possibility FROM STORE WHERE item_code = @itemCode";
                string possibility = DatabaseHandler.returnOneValue(queryGetQtyCondition, paramlist, "possibility");

                if (string.Compare(possibility, "Yes") == 0)
                {
                   itemName = dataGridView5.SelectedRows[0].Cells["Item Name"].Value.ToString();
                  

                    //Add to dataViewGrid4
                    int index = dataGridView4.DisplayedRowCount(true);
                    dataGridView4.Rows.Add();
                    Console.WriteLine("In Add Btn: Current Index: " + index);
                    dataGridView4.Rows[index - 1].Cells[0].Value = itemCode;
                    dataGridView4.Rows[index - 1].Cells[1].Value = itemName;
                    dataGridView4.Rows[index - 1].Cells[2].Value = itemQty;
                }
                else
                {
                    MessageBox.Show("Stocks aren't available for the quantity required!");
                }
            }
          
        }

        private void dataGridView5_SelectionChanged(object sender, EventArgs e)
        {
           
           
        }

        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                itemNameTxt.Text = dataGridView5.SelectedRows[0].Cells["Item Name"].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void setReqNum()
        {
            string lastRo = DatabaseHandler.returnOneValueWithoutParams("SELECT*FROM requestorder", "ro");
            int lastRoNum;
            if (lastRo == "Null Data!")
            {
                lastRoNum = 0;
            }
            else
            {
                lastRoNum = Int32.Parse(lastRo);
            }

            reqestNum.Text = (lastRoNum + 1).ToString();
            globalLastRo = lastRoNum;
        }

        private void dispatchRequestBtn_Click(object sender, EventArgs e)
        {
            setReqNum();

            try
            {
                string query = "insert into requestorder(client_code, approval,postedUser) values (@clientCode,'Pending',@user)";
                List<MySqlParameter> paramList = new List<MySqlParameter>();
                paramList.Clear();
                paramList.Add(new MySqlParameter("@clientCode", selectedClient));
                paramList.Add(new MySqlParameter("@user", GlobalLoginData.username));

                int rowsAffected = DatabaseHandler.insertOrDeleteRow(query, paramList);

                if (rowsAffected == 1)
                {
                    
                    try
                    {
                        int i = dataGridView4.DisplayedRowCount(true);
                        string itemid;
                        string qty;

                        for (int row = 0; row < i - 1; row++)
                        {
                            string lastRo = DatabaseHandler.returnOneValueWithoutParams("SELECT*FROM requestorder", "ro");
                            Console.WriteLine("lastRo: " + lastRo);
                            itemid = dataGridView4.Rows[row].Cells[0].Value.ToString();
                            qty = dataGridView4.Rows[row].Cells[2].Value.ToString();
                            Console.WriteLine("itemid: " + itemid+" qty: "+qty);
                            string query2 = "INSERT INTO ro_item VALUES (@roNum,@itemCode,@qty)";
                            paramList.Clear();
                            paramList.Add(new MySqlParameter("@roNum", lastRo));
                            paramList.Add(new MySqlParameter("@itemCode", itemid));
                            paramList.Add(new MySqlParameter("@qty", qty));

                            rowsAffected = DatabaseHandler.insertOrDeleteRow(query2, paramList);
                            Console.WriteLine("rows affected: "+rowsAffected);
                            if (rowsAffected == 1)
                            {
                                string updateStore = "UPDATE STORE SET qty = qty - @qty WHERE item_code = @itemCode";
                                paramList.Clear();
                                paramList.Add(new MySqlParameter("@qty", qty));
                                paramList.Add(new MySqlParameter("@itemCode", itemid));
                                DatabaseHandler.insertOrDeleteRow(updateStore, paramList);

                                itemNameTxt.Clear();
                                qtyTxt.Clear();
                                dataGridView4.Rows.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Update Failed! RO Link Broken");
                            }

                        }
                    }
                    catch (Exception)
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Update Failed!");
                }
                MessageBox.Show("Purchase Order : Posted!");
                populateDataGrid();
            }
            catch (Exception)
            {

            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            populateItemGrid(dataGridView1);
        }

        private void populateItemGrid(DataGridView dataGridView)
        {
            try
            {
                string val = dataGridView.SelectedRows[0].Cells["Order #"].Value.ToString();

                string select = "SELECT ro_item.ro as 'Order #', ro_item.item_code as 'Item Code', STORE.item_name as 'Item', ro_item.qty as 'Qty' FROM ro_item INNER JOIN STORE ON ro_item.item_code = STORE.item_code WHERE ro_item.ro = '" + val + "'";
                DatabaseHandler.populateGridViewWithBinding(select, dataGridView6);
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            populateItemGrid(dataGridView2);
        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            populateItemGrid(dataGridView3);
        }

        private void approveBtn_Click(object sender, EventArgs e)
        {
            string val = dataGridView1.SelectedRows[0].Cells["Order #"].Value.ToString();
            string update = "UPDATE requestorder set approval='Approved' where ro=@ronum";
            List<MySqlParameter> paramList = new List<MySqlParameter>();
            paramList.Add(new MySqlParameter("@ronum", val));

            int rowsAffected = DatabaseHandler.insertOrDeleteRow(update, paramList);

            if (rowsAffected != 0)
            {
                MessageBox.Show("Purchase Order Confirmed!");
                populateDataGrid();
            }
            else
            {
                MessageBox.Show("Error Occured! Please check Selection!");
            }

           
        }

        private void declineBtn_Click(object sender, EventArgs e)
        {
            string val = dataGridView1.SelectedRows[0].Cells["Order #"].Value.ToString();
            string update = "UPDATE requestorder set approval='Declined' where ro=@ronum";


            //string putBack = ""
            List<MySqlParameter> paramList = new List<MySqlParameter>();
            paramList.Add(new MySqlParameter("@ronum", val));

            int rowsAffected = DatabaseHandler.insertOrDeleteRow(update, paramList);

            if (rowsAffected != 0)
            {
                string itemCodeTemp;
                string putBack;
               string putBackqty;
                for (int i = 0; i < dataGridView6.RowCount - 1; i++)
              {
                try
              {
                        itemCodeTemp = dataGridView6.SelectedRows[i].Cells["Item Code"].Value.ToString();
                        putBackqty = dataGridView6.SelectedRows[i].Cells["Qty"].Value.ToString();
                        putBack = "UPDATE STORE SET qty = qty + @putbackQty WHERE item_code = @itemCode";

                        Console.WriteLine("GridView Row Count: " + dataGridView6.RowCount);
                        Console.WriteLine("itemCodeTemp: " + itemCodeTemp);
                        Console.WriteLine("putBackqty " + putBackqty);

                        List<MySqlParameter> paramList2 = new List<MySqlParameter>();
                        paramList2.Add(new MySqlParameter("@putbackQty", putBackqty));
                        paramList2.Add(new MySqlParameter("@itemCode", itemCodeTemp));

                        Console.WriteLine("query :" + putBack);
                        DatabaseHandler.insertOrDeleteRow(putBack, paramList2);
                    }catch(Exception err)
                    {
                        Console.WriteLine(err);
                    }
                    
                }
                MessageBox.Show("Purchase Order Declined!");
                populateDataGrid();
            }
            else
            {
                MessageBox.Show("Error Occured! Please check Selection!");
            }
        }

        private void dispatchBtn_Click(object sender, EventArgs e)
        {
            string val = null;
            try
            {
                val = dataGridView2.SelectedRows[0].Cells["Order #"].Value.ToString();
            }catch(Exception)
            {
                MessageBox.Show("Nothing Selected");
            }
            string update = "UPDATE requestorder set released='Yes' where ro=@ronum";
            List<MySqlParameter> paramList = new List<MySqlParameter>();
            paramList.Add(new MySqlParameter("@ronum", val));

            int rowsAffected = DatabaseHandler.insertOrDeleteRow(update, paramList);

            if (rowsAffected != 0)
            {
                MessageBox.Show("Order Dispatched!");
                populateDataGrid();
            }
            else
            {
                MessageBox.Show("Error Occured! Please check Selection!");
            }
        }
        private void dataViewDesign(DataGridView dataGridView)
        {
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.Font =
                new Font(dataGridView.Font, FontStyle.Bold);
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ApprovedDispatchOrdersReportPrint printForm = new ApprovedDispatchOrdersReportPrint();
            printForm.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            FinishedDispatchOrderReportPrint printForm = new FinishedDispatchOrderReportPrint();
            printForm.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            PendingDispatchOrderReportPrint printform = new PendingDispatchOrderReportPrint();
            printform.Show();
        }
    }

}
