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
    public partial class Purchasing : UserControl
    {
        string selectedSupplier = null;
        DataRowView selectedRow;
        int globalLastPo;


        public Purchasing()
        {
            InitializeComponent();
        }

        public void Purchasing_Load(object sender, EventArgs e)
        {
            if (GlobalLoginData.userRole != "Admin" && GlobalLoginData.userRole != "Purchasing")
            {
                addItemBtn.Enabled = false;
                createPurchaseOrderBtn.Enabled = false;
            }
            if (GlobalLoginData.userRole != "Admin")
            {
                approveBtn.Enabled = false;
                declineBtn.Enabled = false;
            }
            setPoNum();
            populateCombo();
            try
            {
                supplierComboBox.SelectedIndex = 0;
            }
            catch(Exception)
            {

            }
            selectedRow = supplierComboBox.SelectedItem as DataRowView;
            if (selectedRow != null)
            {
                selectedSupplier = selectedRow.Row["Supplier Code"] as string;
            }

            //Populate dataViewGrid1 (Items by that supplier)
            populateGrid();
            dataViewDesign(dataGridView4);

            //Populate Other Grids
            populateNonComboGrids();
        }

        public void populateCombo()
        {
            string selectStatement = "SELECT supplier_code as 'Supplier Code', supplier_name as 'Supplier' FROM SUPPLIER";
            DatabaseHandler.populateCombobox(selectStatement, supplierComboBox);
        }

        private void supplierComboBox_DropDown(object sender, EventArgs e)
        {
            populateCombo();
        }

        private void supplierComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedRow = supplierComboBox.SelectedItem as DataRowView;
            if(selectedRow != null){
                selectedSupplier = selectedRow.Row["Supplier Code"] as string;
            }
            populateGrid();
        }

        private void populateGrid()
        {
            string selectStatement = "SELECT STORE.item_code as 'Item Code', STORE.item_name as 'Item Name', STORE.description as 'Item Description', SUPPLIER.supplier_name as 'Supplier' FROM STORE INNER JOIN SUPPLIER ON STORE.supplier_code = SUPPLIER.supplier_code WHERE SUPPLIER.supplier_code = '"+selectedSupplier+"'";
            DatabaseHandler.populateViewwithNoParameters(selectStatement, dataGridView1);

            populateNonComboGrids();
        }

        private void populateNonComboGrids()
        {
            string approvedSelect = "SELECT purchaseorder.po as 'Order #', supplier.supplier_name as 'Supplier', purchaseorder.creation_time as 'Order Creation Time', purchaseorder.postedUser as 'Posted By' FROM purchaseorder INNER JOIN supplier ON purchaseorder.supplier_code = supplier.supplier_code WHERE purchaseorder.approval = 'Approved'";
            DatabaseHandler.populateGridViewWithBinding(approvedSelect, dataGridView2);

            string pendingSelect = "SELECT purchaseorder.po as 'Order #', supplier.supplier_name as 'Supplier', purchaseorder.creation_time as 'Order Creation Time', purchaseorder.postedUser as 'Posted By' FROM purchaseorder INNER JOIN supplier ON purchaseorder.supplier_code = supplier.supplier_code WHERE purchaseorder.approval = 'Pending'";
            DatabaseHandler.populateGridViewWithBinding(pendingSelect, dataGridView3);

        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            string itemCode = addItemCodeTxt.Text;
            string itemQty = addItemQty.Text;

            List<MySqlParameter> paramList = new List<MySqlParameter>();
            paramList.Add(new MySqlParameter("@itemCode", itemCode));
            int returnedRowCount = DatabaseHandler.returnRowCount("SELECT*FROM STORE WHERE item_code=@itemCode", paramList);

            if(returnedRowCount != 0)
            {
                //Get Item Name from DB
                paramList.Clear();
                paramList.Add(new MySqlParameter("@itemCode", itemCode));
                string itemName = DatabaseHandler.returnOneValue("SELECT item_name as 'Item Name' from STORE where item_code=@itemCode",paramList,"Item Name");


                //Add to dataViewGrid4
                int index = dataGridView4.DisplayedRowCount(true);
                dataGridView4.Rows.Add();
                Console.WriteLine("In Add Btn: Current Index: " + index);
                dataGridView4.Rows[index-1].Cells[0].Value = itemCode;
                dataGridView4.Rows[index-1].Cells[1].Value = itemName;
                dataGridView4.Rows[index-1].Cells[2].Value = itemQty;

                supplierComboBox.Enabled = false;
            }
            else
            {
                MessageBox.Show("Invalid Item Code!");
            }
        }

        private void addItemQty_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(addItemQty.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                addItemQty.Text = addItemQty.Text.Remove(addItemQty.Text.Length - 1);
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

        private void createPurchaseOrderBtn_Click(object sender, EventArgs e)
        {

            setPoNum();
            try
            {
                string query = "insert into purchaseorder(supplier_code, approval,postedUser) values (@supplierCode,'Pending',@user);";
                List<MySqlParameter> paramList = new List<MySqlParameter>();
                paramList.Clear();
                paramList.Add(new MySqlParameter("@supplierCode", selectedSupplier));
                paramList.Add(new MySqlParameter("@user", GlobalLoginData.username));

                int rowsAffected = DatabaseHandler.insertOrDeleteRow(query, paramList);

                if (rowsAffected != 0)
                {
                    MessageBox.Show("Purchase Order Created Successfully!");
                    supplierComboBox.Enabled = true;
                    

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
            int i = dataGridView4.DisplayedRowCount(true);
            Console.WriteLine("Special i Value: " + i);
            string itemid;
            string qty;
            for(int row = 0; row<i-1; row++)
            {
                string lastPo = DatabaseHandler.returnOneValueWithoutParams("SELECT*FROM purchaseorder", "po");

                itemid = dataGridView4.Rows[row].Cells[0].Value.ToString();
                qty = dataGridView4.Rows[row].Cells[2].Value.ToString();
                Console.WriteLine(itemid + "   " + qty);
                try
                {
                    string query = "INSERT INTO po_item VALUES (@poNum,@itemCode,@qty)";
                    List<MySqlParameter> paramList = new List<MySqlParameter>();
                    paramList.Add(new MySqlParameter("@poNum", lastPo));
                    paramList.Add(new MySqlParameter("@itemCode", itemid));
                    paramList.Add(new MySqlParameter("@qty", qty));

                    int rowsAffected = DatabaseHandler.insertOrDeleteRow(query, paramList);

                    if (rowsAffected != 0)
                    {
                        
                        //populateGrid();
                    }
                    else
                    {
                        MessageBox.Show("Error Occured! PO-Item Link Broken!");
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Error Occured! Please check if the Client already exists!");
                }
                finally
                {
                    populateGrid();
                }

                
            }

            setPoNum();
            addItemCodeTxt.Text = "";
            addItemQty.Text = "";
            dataGridView4.Rows.Clear();
            Console.WriteLine("Current Row Count: " + dataGridView4.RowCount);
            Console.WriteLine("Current Displayed Row Count: " + dataGridView4.DisplayedRowCount(true));

        }

        private void setPoNum()
        {
            string lastPo = DatabaseHandler.returnOneValueWithoutParams("SELECT*FROM purchaseorder", "po");
            int lastPoNum;
            if(lastPo == "Null Data!")
            {
                lastPoNum = 0;
            }
            else
            {
                lastPoNum = Int32.Parse(lastPo);
            }
            
            poNumLbl.Text = (lastPoNum+1).ToString();
            globalLastPo = lastPoNum;
        }

        private void dataGridView3_Click(object sender, EventArgs e)
        {
            try
            {
                string val = dataGridView3.SelectedRows[0].Cells["Order #"].Value.ToString();

                string select = "SELECT po_item.po as 'Order #', po_item.item_code as 'Item Code', STORE.item_name as 'Item', po_item.qty as 'Qty' FROM po_item INNER JOIN STORE ON po_item.item_code = STORE.item_code WHERE po_item.po = '" + val + "'";
                DatabaseHandler.populateGridViewWithBinding(select, dataGridView5);
            }catch(Exception err)
            {
                Console.WriteLine(err);
            }
            
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                string val = dataGridView2.SelectedRows[0].Cells["Order #"].Value.ToString();

                string select = "SELECT po_item.po as 'Order #', po_item.item_code as 'Item Code', STORE.item_name as 'Item', po_item.qty as 'Qty' FROM po_item INNER JOIN STORE ON po_item.item_code = STORE.item_code WHERE po_item.po = '" + val + "'";
                DatabaseHandler.populateGridViewWithBinding(select, dataGridView5);
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
             
        }

        private void approveBtn_Click(object sender, EventArgs e)
        {
            string val = dataGridView3.SelectedRows[0].Cells["Order #"].Value.ToString();
            string update = "UPDATE purchaseorder set approval='Approved' where po=@ponum";
            List<MySqlParameter> paramList = new List<MySqlParameter>();
            paramList.Add(new MySqlParameter("@ponum", val));

            int rowsAffected = DatabaseHandler.insertOrDeleteRow(update, paramList);

            if (rowsAffected != 0)
            {
                MessageBox.Show("Purchase Order Confirmed!");
                populateGrid();
            }
            else
            {
                MessageBox.Show("Error Occured! Please check Selection!");
            }

            populateNonComboGrids();
            
        }

        private void declineBtn_Click(object sender, EventArgs e)
        {
            string val = dataGridView3.SelectedRows[0].Cells["Order #"].Value.ToString();
            string update = "UPDATE purchaseorder set approval='Declined' where po=@ponum";
            List<MySqlParameter> paramList = new List<MySqlParameter>();
            paramList.Add(new MySqlParameter("@poNum", val));

            int rowsAffected = DatabaseHandler.insertOrDeleteRow(update, paramList);

            if (rowsAffected != 0)
            {
                MessageBox.Show("Purchase Order Declined!");
                populateGrid();
            }
            else
            {
                MessageBox.Show("Error Occured! Please check Selection!");
            }

            populateNonComboGrids();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            PurchaseOrderPrintReport printForm = new PurchaseOrderPrintReport();
            printForm.Show();
        }

        private void PendingPrint_Click(object sender, EventArgs e)
        {
            PendingPurchaseOrdersReportPrint printForm = new PendingPurchaseOrdersReportPrint();
            printForm.Show();
        }

        private void ItemViewReport_Click(object sender, EventArgs e)
        {
            POItemViewReportPrint printForm = new POItemViewReportPrint();
            printForm.Show();
        }
    }
}
