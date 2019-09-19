using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace InventoryManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

    
    private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            List<MySqlParameter> paramList = new List<MySqlParameter>();
            paramList.Add(new MySqlParameter("@username", usernameTxt.Text));
            paramList.Add(new MySqlParameter("@password", passwordTxt.Text));
            int returnedRowCount = DatabaseHandler.returnRowCount("SELECT*FROM USER WHERE username=@username and password=@password",paramList);

            if (returnedRowCount == 1)
            {
                GlobalLoginData.username = usernameTxt.Text;
                paramList.Clear();
                paramList.Add(new MySqlParameter("@username", usernameTxt.Text));
                GlobalLoginData.userRole = DatabaseHandler.returnOneValue("SELECT role FROM USER WHERE username = @username",paramList,"role");

                this.Hide();
                Dashboard dash = new Dashboard();
                dash.Show();
            }
            else
            {
                MessageBox.Show("Invalid Credentials, Please Try Again!");
            }

        }

        private void loginBtn_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
