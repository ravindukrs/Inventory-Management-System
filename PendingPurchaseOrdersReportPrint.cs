using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class PendingPurchaseOrdersReportPrint : Form
    {
        static string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=ims";
        MySqlConnection conn = new MySqlConnection(MySQLConnectionString);
        public PendingPurchaseOrdersReportPrint()
        {
            InitializeComponent();
        }

        private void PendingPurchaseOrdersReportPrint_Load(object sender, EventArgs e)
        {
            conn.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM purchaseorder", conn);
            MySqlDataAdapter sda1 = new MySqlDataAdapter("SELECT * FROM supplier", conn);
            var commandBuilder = new MySqlCommandBuilder(sda);
            var commandBuilder1 = new MySqlCommandBuilder(sda1);
            DataSet dst = new DataSet();
            //DataTable dt = new DataTable();
            Console.WriteLine("In now NEW");
            //Console.WriteLine(dt);
            sda.Fill(dst, "purchaseorder");
            sda1.Fill(dst, "supplier");
            //Console.WriteLine("Data Table is "+ dt);
            pendingPurchaseReport1.SetDataSource(dst);
            //allPurchaseOrdes1.SetParameterValue("pDateTime", DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt"));
            pendingPurchaseReport1.SetParameterValue("pCreatedBy", GlobalLoginData.username);
            crystalReportViewer1.ReportSource = pendingPurchaseReport1;

            conn.Close();
        }

        private void PendingPurchaseReport1_InitReport(object sender, EventArgs e)
        {

        }

        private void PendingPurchaseOrdersReportPrint_Load_1(object sender, EventArgs e)
        {
            conn.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM purchaseorder WHERE approval='Pending'", conn);
            MySqlDataAdapter sda1 = new MySqlDataAdapter("SELECT * FROM supplier", conn);
            var commandBuilder = new MySqlCommandBuilder(sda);
            var commandBuilder1 = new MySqlCommandBuilder(sda1);
            DataSet dst = new DataSet();
            //DataTable dt = new DataTable();
            Console.WriteLine("In now NEW");
            //Console.WriteLine(dt);
            sda.Fill(dst, "purchaseorder");
            sda1.Fill(dst, "supplier");
            //Console.WriteLine("Data Table is "+ dt);
            pendingPurchaseReport1.SetDataSource(dst);
            //allPurchaseOrdes1.SetParameterValue("pDateTime", DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt"));
            pendingPurchaseReport1.SetParameterValue("pCreatedBy", GlobalLoginData.username);
            crystalReportViewer1.ReportSource = pendingPurchaseReport1;

            conn.Close();
        }
    }
}
