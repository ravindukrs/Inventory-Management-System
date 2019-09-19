using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        public void Home_Load(object sender, EventArgs e)
        {
            //Low Quantity Store items
            string query = "SELECT * FROM store WHERE qty < 100";
            int lowQyItemCount = DatabaseHandler.returnRowCountWithoutParams(query);
            storeLowQty.Text = lowQyItemCount.ToString();

            //Unapproved Purchase Orders
            string query1 = "SELECT * FROM purchaseorder WHERE approval='Pending'";
            int pendingPOCount = DatabaseHandler.returnRowCountWithoutParams(query1);
            unapprovedPurchaseOrders.Text = pendingPOCount.ToString();

            //uncommited recieving Orders
            string query2 = "SELECT * FROM purchaseorder WHERE approval='Approved' AND recieved='No'";
            int pendingrecievingsCount = DatabaseHandler.returnRowCountWithoutParams(query2);
            uncommitedRecieving.Text = pendingrecievingsCount.ToString();

            //Unapproved Dispatch Orders
            string query3 = "SELECT * FROM requestorder WHERE approval='Pending'";
            int unapprovedDispatchOrdersCount = DatabaseHandler.returnRowCountWithoutParams(query3);
            unapprovedDispatchOrders.Text = unapprovedDispatchOrdersCount.ToString();

            //undreleased Dispatch Orders
            string query4 = "SELECT * FROM requestorder WHERE approval='Approved' AND released='No'";
            int undispatchedDispatchOrdersCount = DatabaseHandler.returnRowCountWithoutParams(query4);
            undispatchedOrders.Text = undispatchedDispatchOrdersCount.ToString();
        }
    }
}
