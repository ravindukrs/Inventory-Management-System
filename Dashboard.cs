using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            SidePanel.Height = homeBtn.Height;
            SidePanel.Top = homeBtn.Top;
            home1.BringToFront();

        }

        private void HomeBtn(object sender, EventArgs e)
        {
            sidePanelLocation(homeBtn);
            home1.BringToFront();
            home1.Home_Load(sender, e);
        }

        private void storeBtn_Click(object sender, EventArgs e)
        {
            sidePanelLocation(storeBtn);
            stores1.BringToFront();
            stores1.Stores_Load(sender, e);
        }

        private void recievingBtn_Click(object sender, EventArgs e)
        {
            sidePanelLocation(recievingBtn);
            recieving1.BringToFront();
            recieving1.Recieving_Load(sender,e);
        }

        private void purchasingBtn_Click(object sender, EventArgs e)
        {
            sidePanelLocation(purchasingBtn);
            purchasing1.BringToFront();
            purchasing1.Purchasing_Load(sender, e);
        }

        private void dispatchBtn_Click(object sender, EventArgs e)
        {
            sidePanelLocation(dispatchBtn);
            dispatch1.BringToFront();
            dispatch1.Dispatch_Load(sender,e);
        }

        private void clientsBtn_Click(object sender, EventArgs e)
        {
            sidePanelLocation(clientsBtn);
            client1.BringToFront();
            client1.Client_Load(sender, e);
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            sidePanelLocation(userBtn);
            users1.BringToFront();
            users1.Users_Load(sender, e);
           
        }

        private void sidePanelLocation(Button btn)
        {
            SidePanel.Height = btn.Height;
            SidePanel.Top = btn.Top;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Login()).Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void suppliersBtn_Click(object sender, EventArgs e)
        {
            sidePanelLocation(suppliersBtn);
            supplier1.BringToFront();
            supplier1.Supplier_Load(sender, e);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            if (GlobalLoginData.userRole != "Store Keeper" && GlobalLoginData.userRole != "Admin")
            {
                dispatchBtn.Enabled = false;
            }
            if (GlobalLoginData.userRole != "Purchasing" && GlobalLoginData.userRole != "Admin")
            {
                purchasingBtn.Enabled = false;
            }
            if (GlobalLoginData.userRole != "Recieving" && GlobalLoginData.userRole != "Admin")
            {
                recievingBtn.Enabled = false;
            }
            if (GlobalLoginData.userRole != "Admin")
            {
                userBtn.Enabled = false;
            }
        }
    }
}
