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
    public partial class Recieving : UserControl
    {
        public Recieving()
        {
            InitializeComponent();
        }

        private void poNumTxt_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(poNumTxt.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                poNumTxt.Text = poNumTxt.Text.Remove(poNumTxt.Text.Length - 1);
            }
            if (poNumTxt.Text == "")
            {
                string selectedPo = "SELECT purchaseorder.po as 'Order #', supplier.supplier_name as 'Supplier', purchaseorder.creation_time as 'Order Creation Time', purchaseorder.postedUser as 'Posted By' FROM purchaseorder INNER JOIN supplier ON purchaseorder.supplier_code = supplier.supplier_code WHERE purchaseorder.approval = 'Approved' AND purchaseorder.recieved='No'";
                DatabaseHandler.populateGridViewWithBinding(selectedPo, dataGridView1);
            }
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            

            string poNum = poNumTxt.Text;
            List<MySqlParameter> paramList = new List<MySqlParameter>();
            paramList.Add(new MySqlParameter("@poNum", poNum));
            paramList.Add(new MySqlParameter("@recieved", "No"));
            paramList.Add(new MySqlParameter("@approval", "Approved"));

            int returnedRowCount = DatabaseHandler.returnRowCount("SELECT*FROM purchaseorder WHERE po = @poNum AND recieved=@recieved AND approval=@approval", paramList);

            if (returnedRowCount == 1)
            {
                poNumTxt.Enabled = false;
                string select = "select supplier.supplier_name from purchaseorder inner join supplier on purchaseorder.supplier_code = supplier.supplier_code where purchaseorder.po ='"+poNum+"'";
                string returnedSupplierName = DatabaseHandler.returnOneValueWithoutParams(select, "supplier_name");
                supplierNameLbl.Text = returnedSupplierName;

                string query = "SELECT po_item.item_code as 'Item Code', STORE.item_name as 'Item', po_item.qty as 'Qty' FROM po_item INNER JOIN STORE ON po_item.item_code = STORE.item_code WHERE po_item.po = '" + poNum + "'";
                DatabaseHandler.populateGridViewWithBinding(query, dataGridView3);

                string selectedPo = "SELECT purchaseorder.po as 'Order #', supplier.supplier_name as 'Supplier', purchaseorder.creation_time as 'Order Creation Time', purchaseorder.postedUser as 'Posted By' FROM purchaseorder INNER JOIN supplier ON purchaseorder.supplier_code = supplier.supplier_code WHERE purchaseorder.approval = 'Approved' AND purchaseorder.po='" + poNum + "'";
                DatabaseHandler.populateGridViewWithBinding(selectedPo, dataGridView1);

                commitBtn.Enabled = true;
            }
            else
            {
                poNumTxt.Enabled = true;
                MessageBox.Show("No such uncommited Purchase Order or the Order may not be approved. Please Try again..");
                poNumTxt.Clear();
                dataGridView3.DataSource = null;
                dataGridView3.Refresh();

                supplierNameLbl.Text = "";
            }
        }

        public void Recieving_Load(object sender, EventArgs e)
        {
            populateGrids();
            commitBtn.Enabled = false;
        }

        private void populateGrids()
        {
            string approvedSelect = "SELECT purchaseorder.po as 'Order #', supplier.supplier_name as 'Supplier', purchaseorder.creation_time as 'Order Creation Time', purchaseorder.postedUser as 'Posted By' FROM purchaseorder INNER JOIN supplier ON purchaseorder.supplier_code = supplier.supplier_code WHERE purchaseorder.approval = 'Approved' AND purchaseorder.recieved = 'No'";
            DatabaseHandler.populateGridViewWithBinding(approvedSelect, dataGridView1);

            string finishedSelect = "SELECT purchaseorder.po as 'Order #', supplier.supplier_name as 'Supplier', purchaseorder.creation_time as 'Order Creation Time', purchaseorder.postedUser as 'Posted By' FROM purchaseorder INNER JOIN supplier ON purchaseorder.supplier_code = supplier.supplier_code WHERE purchaseorder.approval = 'Approved' AND purchaseorder.recieved = 'Yes'";
            DatabaseHandler.populateGridViewWithBinding(finishedSelect, dataGridView2);
        }

        private void commitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string updateQuery = "update purchaseorder set recieved = 'Yes' where po=@poNum";
                List<MySqlParameter> paramList = new List<MySqlParameter>();
                paramList.Clear();
                paramList.Add(new MySqlParameter("@poNum",poNumTxt.Text));

                int rowsAffected = DatabaseHandler.insertOrDeleteRow(updateQuery, paramList);

                int rows = dataGridView3.RowCount;
                string itemid = null;
                string qty = null;
                for (int i = 0; i < rows - 1; i++)
                {
                    itemid = dataGridView3.Rows[i].Cells[0].Value.ToString();
                    qty = dataGridView3.Rows[i].Cells[2].Value.ToString();
                    Console.WriteLine(itemid + "   " + qty);
                    try
                    {
                        string query = "UPDATE STORE SET qty= qty + @qty WHERE item_code=@itemid";
                        List<MySqlParameter> paramList2 = new List<MySqlParameter>();
                        paramList2.Add(new MySqlParameter("@qty", qty));
                        paramList2.Add(new MySqlParameter("@itemid", itemid));


                        int rowsAffected2 = DatabaseHandler.insertOrDeleteRow(query, paramList2);

                        if (rowsAffected2 != 0)
                        {

                            //populateGrids();
                        }
                        else
                        {
                            MessageBox.Show("Error Occured! PO-Item Link Broken!");
                        }

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error Occured!");
                    }
                }

                if (rowsAffected != 0)
                {
                    MessageBox.Show("Commited!");
                    populateGrids();
                }
                else
                {
                    MessageBox.Show("Error!");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Error occured!");
            }

            poNumTxt.Enabled = true;
            poNumTxt.Clear();
            dataGridView3.DataSource = null;
            dataGridView3.Refresh();

            supplierNameLbl.Text = "";
            commitBtn.Enabled = false;

           
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            poNumTxt.Enabled = true;
            poNumTxt.Clear();
            dataGridView3.DataSource = null;
            dataGridView3.Refresh();

            supplierNameLbl.Text = "";
            commitBtn.Enabled = false;
        }

        private void Recieving_Enter(object sender, EventArgs e)
        {
            Recieving_Load(sender, e);
        }
    }
}
